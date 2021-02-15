using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace randomlist
{


    /// A RandomList is a collection that lets client code 'pick' a member item that is returned at
    /// random.
    /// 
    /// 
    /// 
    /// 
    /**
	 * A RandomList is a collection of arbitrary objects to be retrieved at random. 
     * A RandomList is ideal to use for something such as an encounter table, treasure table, npc creator and many other things
     * 
	 * By default, each object added has an equal chance of being retrieved. However, different weights can be specified for each object
	 * to allow for uneven chances of being selected randomly.
	 * 
	 * By default, items added to the list stay on the list, however an integer representing the
	 * 'lifetime' of an item can be specified for things that are meant to expire. 
	 * 
	 * Items are maintained in the order added to the table to allow for lists that assign
	 * some kind of meaning to the order, such as lower # items are bad and higher are good (old-school treasure tables, etc).
	 * 
	 * Pick()
     * 
	 * 
	 * 
	 * ??? have a randomRemove func?  addAt()?  insertBefore( id )
	 * should track the useCount - how many times item has been used - to prevent overuse
	 * 
	 * // REV history
	 * + collapsing all into base class - removing tag stuff
	 * + added clone() -to support use of master lists and modified lists
     * + removing add modifier # feature - too much and not intuitive. move to simpler class like SimpleRandomList
	 */
    public class RandomList : IEnumerable<RandomListItem>
    {

        #region members
        public event RandomListEventHandler RandomListEvent;
		
		/// by default drops 5% for a standard 100 weight
  		const int DEFAULT_WEIGHT_DROP_FACTOR = 5;

        private int _attemptCount;

        // the list of RandomListItems
        private List<RandomListItem> _list = new List<RandomListItem>();

  		// the most recent item picked on the list
  	    public RandomListItem mostRecentItem;
		
		  /**
		   * If the chooser can't find something suitable within this
		   * number of tries, it gives up and returns a null item.
		   */
		public int pickAttemptLimit = 20;
		
		public String id = "";

  		/// the last list item that used up its lifetime and was removed
  		public RandomListItem lastExpired;
		
		private PickObjectHandler _pickHandler;  // mandatory on each pick call
		
		//private RandomListFilter _curFilter;
		
		/**
		  * how many items in list
		  */
		public int Count  {
			get { return _list.Count; }
		}

        private System.Random random = new System.Random();

        public int totalWeight;

        #endregion

        //--------------------------------------------------------------------------------------
        /* constructor
   		/* Every list has an id so that it can be targeted if it is a child. */
        /// </summary>
        public RandomList(String id = "Anonymous_List")
		{
			this.id = id;
		}
		//--------------------------------------------------------------------------------------
		
	  ///
	  /// Add a new object onto the list. wraps it in a RandomListItem
	  ///
	  /// By default every item has the same chance (weight) of selection (100) and an infinite lifetime.
	  ///
	  /// @param id item id
	  /// @param payload the inner object to wrap in a RandomListItem
	  /// @param weight  default is 100   -- this can be overriden if a weightObject is specified
	  /// @param weightDrop default is 0  The amount that the item weight should be lowered every time it is picked. -1 (don't drop) by default -- weight drop is not compatible if a weightObject is specified
	  /// @param weightIncrease every time something is picked from the list and it is not this item,
	  ///      the weight of this item will rise by this amount not compatible with weight object.
	  /// @param userData condition string - an arbitrary string that can be used by a filter to filter the item before a pick.
	  /// *
	  /// * wt drop / increase could have been a single # that is interpreted whether positive or negative.
	  /// if wrapped payload is null it takes the string ID
	  /// *
	  /// * @returns The RandomListItem created
	  public RandomListItem Add( String _id, System.Object payload = null, uint wt = 100, int lifetime = -1, int weightDrop =0, int weightIncrease =0, System.Object userData =null ) {

	    //trace("list add() id, payload, wt, life, wtdrop", _id, payload, wt, lifetime, weightDrop );

	    RandomListItem item = new RandomListItem( _id, payload, this, wt, weightDrop, weightIncrease, userData );
	
	    item.lifetime = lifetime;
	
	    _list.Add( item );
	
	    return item;
	  }	
		
	  /// * add a pre existing RandomListItem to list
	  /// NOTE: * only used for cloning and reconstituting from XML
	  ///
	  public void AddItem( RandomListItem item ) {
	    item.parentList = this;
	    _list.Add( item );
	  }
			
	  	/**
		 * Add an item to a named sub list - will wrap it in a RandomListItem
		 * return null on failure
		 * @param objectId how to refer to this object
		 * @param object - they payload
		 * @listId
		 * @return
		 */ 
		public RandomListItem AddToList( String listId, String objectId, System.Object payload, uint wt = 100, int lifetime = -1, int weightDrop = 0, int weightIncrease = 0, System.Object userData = null ) {			
			
			RandomListItem ret = null;

            // find the list
            RandomList list = GetChildListById(listId);

            if( list == null )
            {
                throw new Exception("List not found: " + listId);
            }

            list.Add(objectId, payload, wt, lifetime, weightDrop, weightIncrease, userData);
       
 			return ret;
		}

        public RandomListItem AddItemToList( String listId, RandomListItem item )
        {
            // find the list
            RandomList list = GetChildListById(listId);

            if (list == null)
            {
                throw new Exception("List not found: " + listId);
            }

            list.AddItem(item);


            return item;
        }

		/**
		 * 
		 * called BEFORE ItemHasBeenPicked()
		 * if expired, dispatches EXPIRED event with item as data
		 * @returns whether it expired or not
		 */ 
		protected bool AdjustLifetime(RandomListItem item ) {
			M3.Out("adjusting lifetime " + item.id + " "+ item.lifetime);
			
			if( item.lifetime == -1 ) {				
				//trace("...ignoring, infinite life");
				return false;  // it has infinite life
			}			
			
			// decrement life
			item.lifetime--; 
			
			
			if( item.lifetime == 0 ) {							
				
				RandomList rlist = item.parentList;
				
				if( rlist != null ) {
					rlist.RemoveItem( item );
				} else {
					Console.Out.WriteLine("WARNING: null parent list for " + item.id);
				}

                UnityEngine.Debug.Log("expiring: " + item.payload);
				
				RandomListEventArgs args = new RandomListEventArgs( RandomListEventType.EXPIRED, this, item);
				
				// expire, this is the last usage of the item
				
				lastExpired = item;
				
				RandomListEvent?.Invoke( this, args);  // fires the event
				
				return true;							
			} else return false;
		} //adj life time
		     

        /// <summary>
        /// choose and filter candidate items until a suitable one is found
        /// internally calls SelectCandidateItem
        /// </summary>
        private void AttemptPick(RandomListFilter filter)
        {
            //UnityEngine.Debug.Log("AttemptPick()");
            _attemptCount++;

            RandomListItem item = SelectCandidateItem(filter);

            item = FilterItem(item, filter);
            mostRecentItem = item;

            if ( item == null )
            {
                // out of tries
                if (_attemptCount > pickAttemptLimit)
                {
                    // TODO ??? is this valid ???
                    UnityEngine.Debug.Log("**** exhausted search attempt, returning null");
                    FinalizePick(item);
                } else
                {
                    AttemptPick(filter);  // try again
                }
            } else
            {
                FinalizePick(item);
            }
        }
        
        private RandomListItem FilterItem( RandomListItem item, RandomListFilter filter)
        {
            
            if (filter == null) return item; // pass through if no filter

            //UnityEngine.Debug.Log("FilterItem()");
            if ( filter(this, item, pickAttemptLimit - _attemptCount) ) {
                return item; // passed the test
            } else
            {
                // failed
                return null;
            }
        }
		
		
		/**
		 * @returns whether it actually changed
		 */ 
		public Boolean ChangeWeight( String id, int newWeight ) {
			
			RandomListItem item = (RandomListItem) GetListItemById( id );
			
			if( item != null ) {
				item.weight = newWeight;
				return true;
			}
			
			return false;			
		}
		
		/**
		 * remove all items
		 */ 
		public void Clear() {
			_list.Clear();
		}
		
		public RandomList Clone(String newId) {
			RandomList newList = new RandomList( newId );			
			
			foreach(RandomListItem item in _list ) {
				RandomListItem newItem = item.Clone();											
				newList.AddItem( newItem );
			}
			return newList;
		}

        private void DoForcedPick(String forceId)
        {
            Trace.TraceInformation("DoForcedPick()");
            try
            {
                // does the item exist?
                FinalizePick(GetListItemById(forceId));  // okay if it's null
            }
            catch (Exception err)
            {
                Console.WriteLine("RandomList.pick() error during forced pick\n" + err);
            }
        }

        private void DoNormalPick(PickObjectHandler pickHandler, RandomListFilter filter)
        {
            //UnityEngine.Debug.Log("DoNormalPick()");

            this._pickHandler = pickHandler;

            WeightManager.RecalcWeights(this);

            //Console.WriteLine("...creating args");
            RandomListEventArgs args = new RandomListEventArgs(RandomListEventType.PICKING, this, null);

            //Console.WriteLine("...firing PICKING event");

            // fire event if there are listeners
            RandomListEvent?.Invoke(this, args);  // fires the event

            AttemptPick(filter);  // will recurse until success or limit hit
        }


        /**
		 * Currently if weight drop below zero it wraps around to maxWeight 
		 */
        private void DoWeightDecrease( RandomListItem item ) {

            if ((item == null) || (!item.weightDrops)) return;


            int wt = item.GetWeight(  );
				
            int newWeight = wt - item.weightDropAmount;

            Console.WriteLine("\n]] dropping weight for " + item.id + " to " + newWeight);

            if (newWeight <= 0)
            {
                if (item.removeOnZero)
                {
                    RemoveListItemById(item.id);
                } else {
                    newWeight = item.maxWeight;  // ??  wrap around ??
                    ChangeWeight(item.id, newWeight);
                }
            } else {
                // positive wt
                //Console.WriteLine("...changing weight");
                ChangeWeight(item.id, newWeight);
            }
        }
		
		
		private void DoWeightIncrease(RandomListItem itemPicked ) {
			// go through list looking for items that are not this item and that have
			// a weightIncrease greater than 0
			
			foreach(RandomListItem i in _list) {
				int inc = i.weightIncreaseAmount;
				
				if( itemPicked == i ) {
					//trace("skipping the picked item");
					continue;
				}
				
				if( inc > 0 ) {
					Console.WriteLine("increasing wt of " + i.id + " by " + inc);
					i.AddWeight( inc );
					WeightManager.RecalcWeights( this );
				}
			}
		}
		
        /// <summary>
        /// Calls pickHandler with the item object
        /// 
        /// </summary>
        /// <param name="item">Can be a NULL value</param>
		private void FinalizePick( RandomListItem item ) {
			
			
			RandomListEventArgs args;
			
			Console.WriteLine("FinalizePick() ");
			
			if( item != null ) {
				//Console.WriteLine("picked " + item.Id);
				
				AdjustLifetime( item );

                DoWeightDecrease(item);

                DoWeightIncrease(item);
				
				mostRecentItem = item;
				
				args = new RandomListEventArgs( RandomListEventType.PICKED, this, item);				
							
			} else {
				// the item == null
				args = new RandomListEventArgs( RandomListEventType.FAILED, this, item);
			}
			
			RandomListEvent?.Invoke( this, args);  // fires the event

            // NOTE: this is an alert mechanism - it is NOT meant to modify pick
            if (_pickHandler != null && item != null)
            {
                _pickHandler( item.GetResolvedValue() );
            } 
		}
		
		
		
		/**
		 * @returns an array of ALL RandomListItems contained by this list and its children.
		 */ 
		public ArrayList GetAllListItems( ) {
			ArrayList arr = new ArrayList();
			
			foreach(RandomListItem item in _list ) {											
				if( item.IsRandomList() ) {
					RandomList list = ( RandomList ) item.payload;
					arr.AddRange( list.GetAllListItems() );					
				} else {
					arr.Add( item );
				}
			}
						
			return arr;			
		}
		
		/**
		 * Get all the wrapped objects from this table and its children.
		 */ 
		public ArrayList GetAllPayloads( ) {
			ArrayList arr = new ArrayList();
			
			foreach(RandomListItem item in _list ) {
												
				if( item.IsRandomList() ) {
					RandomList rlist = (RandomList) item.payload;
					arr.AddRange( rlist.GetAllPayloads() );
				} else {
					arr.Add( item.payload );
				}
			}
						
			return arr;			
		}

        // recurse child lists
        public RandomList GetChildListById(String listId)
        {
            RandomList ret = null;

            ArrayList payloads = GetAllPayloads();

            foreach (object payload in payloads)
            {
                if (payload.GetType() == typeof(RandomList))
                {
                    RandomList list = (RandomList)payload;
                    if (list.id == listId) return list; // found it
                    else
                    { // recurse into the list
                        ret = list.GetChildListById(listId);
                    }
                }
                else
                {
                    // ignore non-lists
                }
            }

            return ret;
        }

        /**
		 * get the current lifetime of the item specified
		 */
        public int GetItemLifetime( String itemId ) {
			return GetListItemById( itemId ).lifetime;
		}
		
		/**
		 * Get a random list item by its ID
         * will recurse into child lists
		 */ 
		public RandomListItem GetListItemById( String id ) {
			try {
				// find the item
				foreach(RandomListItem item in _list ) {
					if( item.id == id ) {
						//trace("found item : " + item.id);
						return item ;
					} else if( item.payload.GetType() == typeof(RandomList) ) {					
						RandomList sublist = (RandomList) item.payload;
						System.Object result = sublist.GetListItemById( id );
						if( result != null ) return (RandomListItem) result;
					}
				}
			} catch(Exception err) {
                Trace.TraceError(err.ToString());

            }
			return null;
		}
		
		/**
		 * Find the parent list for the given item ID.
		 * 
		 */ 
		public RandomList GetListForItem( String objId ) {
			// find the item
			foreach(RandomListItem item in _list ) {
				//trace("searching list ", objId );
				if( item.id == objId ) {					
					return item.parentList;
				} else if( item.IsRandomList() ) {					
					//trace("searching sublist");
                    // TODO could make item.ToRandomList()
				 	RandomList sublist = (RandomList) item.payload;
					RandomList result = sublist.GetListForItem( objId );
					if( result != null ) return result; // found it
				}
			}
			return null; // not found
		}
		
		/**
		 * Get the list object stored under this ID.
		 * Leaves it on list.
		 */ 
		public System.Object GetPayloadById(String objId ) {
			//trace("get payload by id");
			
			// find the item
			foreach(RandomListItem item in _list ) {
				if( item.id == objId ) {
					//trace("found item : " + item.id);
					//trace("  payload: " + item.object );
					return item.payload;
				} else if( item.IsRandomList() ) {					
					//trace("searching sublist");
					RandomList sublist = (RandomList) item.payload;
					System.Object result = sublist.GetPayloadById( objId );
					if( result != null ) return result;
				}
			}
			
			return null; // not found
		}

        private object GetPickReturnValue()
        {
            if (mostRecentItem == null)
            {
                return null;
            }
            else
            {
                return mostRecentItem.GetResolvedValue();
               
            }
        }

        /**
		 * Randomly return a payload OBJECT contained in the list somewhere, NOT the ITEM
         * To get the item, use list.mostRecentItem
		 * 
		 * If the item is itself a randomList, recursively Pick() from that one.
		 * 
		 * first thing this does is to recalc the wts of the items -- to allow for dynamic weights
		 * - based on runtime factors like vars 
		 * 
		 * decrements the lifetime and removes if necessary
		 * 
		 * If item weight drops below zero it is reset to maximum weight.
		 * The callback will get the returned object value as an arg. 
		 * 
		 * @param filter allows a filter object to be passed into to screen the pickedItems against before allowing a good choice.
         * Filters can be created with lamba funcs such as:  RandomListFilter filter = (list, item, attemptsRemaining) => {
            return (item.id == "CHICKEN");
        };
		 * @param forceId  force the item with the specified Id to be returned from the list -- ignore filters 
		 */
        public object Pick(PickObjectHandler pickHandler=null, RandomListFilter filter=null, String forceId = null)  {
			//UnityEngine.Debug.Log("Pick()");
					
			_attemptCount = 0;  // reset

            if (forceId != null) DoForcedPick(forceId);
            else DoNormalPick(pickHandler, filter);
			
            return GetPickReturnValue();
        } // pick

		private RandomListItem  RemoveItem( RandomListItem item ) {
			_list.Remove( item );
			
			item.parentList = null;
			
			return item;
		}
		
		/**
		 * remove from the list and fire an event
		 */ 
		public RandomListItem RemoveListItemById( String id ) {
			// find the item
			foreach(RandomListItem item in _list ) {
				if( item.id == id ) {
					//trace("found item to remove: " + item.id);
					return RemoveItem( item );
				} else if( item.IsRandomList() ) {
					//trace("searching sub list");
					RandomList sublist = (RandomList) item.payload;
					RandomListItem result = sublist.RemoveListItemById( id );
					if( result != null ) return result;
				}
			}
			//trace("couldn't find item id: " + id, " in list: ", id);
			return null;
		}

        /**
         * Called by AttemptPick()
		 * Selects an item without altering it (e.g., decrease lifetime).
		 * 
		 * The point of allowing a 'preview' of what will be picked is to allow filtering
		 * of the items based on arbitrary game constraints. E.g., only a certain class can get certain events, etc.
		 * .
		 * 
		 * should be protected - but is public for unit testing purposes. 
		 *
		 *  gets fired before a result is returned from pick() to allow for filtering of list items,
		 * i.e., to prevent some things from being returned by pick() based on arbitrary game logic.
         * 
         * guaranteed to return a non-null b/c result hasn't been filtered yet
         * 

		 */
        public RandomListItem SelectCandidateItem(RandomListFilter filter)
        {
            //UnityEngine.Debug.Log("SelectCandidateItem()");

            double roll =  random.NextDouble();  // a # betw 0 and .99

            // keep within limits, clamp
            if (roll > .999999999999f) roll = .99999999999f;
            else if (roll < 0) roll = 0;

            //Console.WriteLine("BASE/MOD ROLL " + LastBaseRoll + "/" + LastModifiedRoll);	

            RandomListItem candidate = null;

            foreach (RandomListItem item in _list)
            {
                //UnityEngine.Debug.Log("  testing against item.threshold: " + item.threshold);
                if (roll < item.threshold)
                {  // pick an entry
                    candidate = item;

                    if (candidate.IsRandomList())
                    {
                        // attempt pick from child list
                        RandomList asList = (RandomList)candidate.payload;
                        candidate = asList.SelectCandidateItem(filter); // mod and roll do NOT get passed to children
                    }

                    break;
                }
            }

            return candidate;
        }

        /**
		 * Set the lifetime of the item specified to an arbitrary number. 
		 */
        public void SetItemLifetime( String itemId, int lifetime ) {
			RandomListItem item = GetListItemById( itemId );
			item.lifetime = lifetime;			
		}

        // for literal ctor
        public IEnumerator<RandomListItem> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }	// RandomList class
	
		
		
} // RandomList pkg
	

	
	
