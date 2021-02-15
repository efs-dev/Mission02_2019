using System;
using System.Collections;

namespace randomlist
{

    /**
* An item that can be randomly served up by a RandomList.
* Very often the item serves as a 'wrapper' around an arbitrary payload object
* of another type, e.g. a game entity, etc.
* One nifty feature is that RandomLists themselves can be list items, allowing you
* to nest them to an arbitrary depth. So for example if you were creating a treasure table,
* you might create a nested list such as:
* MASTER_LIST
*    COMMON_ITEMS
*    MAGIC_ITEMS
///         WEAPONS
///             SWORDS
*/
    public class RandomListItem {

        //public const RandomListItem NULL_LIST_ITEM = new RandomListItem("", null, null);


        #region members   
        private String _id = "DEFAULT";
		public String id {
		    get { return _id; }
			set { _id = value; }
		}
		
				
		private int _lifetime = -1;
  		/// how many times item can be selected from list before being removed.
  		/// default is -1, meaning infinite re-use
  		public int lifetime {
  			set { _lifetime = value; }
   		    get { return _lifetime; }
		}
		
		/// if the item weight drops when picked, might want to reset weight to this value
  		/// if drop below zero
  		public int maxWeight;
		
		/// The list containing this item
  		public RandomList parentList;
		
		public double percent; // for internal calculations
		
		/// Whether to remove item from list if its weight goes to zero or below.
        public bool removeOnZero = false;
		
		public double threshold; // for internal calculations
		
		private Hashtable _tagList = new Hashtable();
		
		/// How many times this item has been picked as a list result.
        public int useCount;
		
		/// Arbitrary data a system might want to store about an item. One
        /// use case would be to put a timestamp in here if that was important
        /// or script conditions
        public Object userData;
		
		/**
		 * the weight used for BASIC weight calculations
		 */ 
		private int _weight;
		
		/**
		 * An object that is used somehow to calculate the wt of the item.
		 */ 
		// An optional arbitrary parm to be passed to the wt calc function
		public Object weightData = null;
		
		private int _weightDropAmount = 0;
		/// not allowed below zero
        /// if greater than zero, weightDrops flag set to true, false otherwise
  		public int weightDropAmount {
			get { return _weightDropAmount; }
		    set {
    			_weightDropAmount = (value > -1) ? value : 0;
                weightDrops = (value > 0);
            }
		}
		
		
		/// Whether the weight of the item drops when it is chosen by a list. Default: false
        public bool weightDrops = false;
		
		
		private WeightCalcDelegate _weightCalcFunction;
		
		public WeightCalcDelegate weightCalcFunction {
			get { return _weightCalcFunction; }
			set { 
				if( weightType != WeightType.DEFAULT ) {
					throw new Exception("Item " + id + " has a weightType conflict: trying to set a dynamic weight function when a drop or increase has already been set.");
				}
				weightType = WeightType.DYNAMIC;
				_weightCalcFunction = value;
			}
		}
		
		/// Every time item is NOT picked -- wt goes up by this amount.
  		public int weightIncreaseAmount;
		
		public WeightType weightType;
		
		/// The contained target (wrapped) object.
  		/// This object can be optional if the randomlist just wants to use the ID of the item
  		public Object payload;

        #endregion

        public object GetResolvedValue()
        {
            // if payload empty return the id
            if (payload == null) return id;  // the id is the string value
            else return payload;

        }

		  /// set an optional descriptive tag, with an option strength (value)
  		public void SetTag(String t, int value = 100) {
    		_tagList[ t ] = value;
  		}

  		public void RemoveTag(String t) {
   		 _tagList.Remove(t);
 		 }

 		public  bool HasTag(String t) {
  		  return _tagList.ContainsKey(t);
 		}

        //----------------------------------------------------------------
        /////////////////////////////////////////////////////////////////////
        /// constructor
        /// Default to infinite lifetime.
        /// @param id   auto-uppercased
        /// @param payload  the payload of this item, if any.  Could be a function handler or entity, etc. optional. default to null
        ///
        /// maxWeight will be set to the initial weight by default.

        /// @param weightDrops indicates whether the weight drops every time it is picked. Default false
        public RandomListItem(String __id, Object payload = null, RandomList parentList = null, uint weight = 100,
		      int weightDrop = 0, int weightIncrease = 0, Object userData = null )   {

		    _id = __id.ToUpper();
			
			if( payload == null ) this.payload = _id;
		    else this.payload = payload;
		    
			this.parentList = parentList;
		    _weight = (int)weight;
		    maxWeight = (int)weight;
		    weightType = WeightType.DEFAULT;
		
		    weightDropAmount = weightDrop;
		    if( weightDrop > 0 ) weightType = WeightType.DROPS;
		
		    if( weightIncrease > 0 ) {
		      if( weightType == WeightType.DROPS )
		        weightType  = WeightType.DROP_AND_INCREASE; // both types
		      else {
		        this.weightIncreaseAmount = weightIncrease;
		        weightType = WeightType.INCREASES;
		      }
		    }
		
		    this.userData = userData;
		  }
		
		  /// add to the basic weight
		  /// delta can be negative
		  public void AddWeight( int delta ) {
		    if( weightCalcFunction != null ) {  // dynamic
		      throw new Exception("Can't change the weight of an item with a weight function" + id);
		    }
		
		    _weight += delta;
		  }
		
		

		
		  /// deep copy this item and any children
		  public RandomListItem Clone() {
			    Object newObj; // new wrapped object
			    if( payload.GetType() == typeof(RandomList) ) {
				  RandomList existingList = (RandomList) payload;
			      newObj = existingList.Clone( id );
			    } else {
			      newObj = payload;
			    }
			    RandomListItem item = new RandomListItem(id, newObj, parentList );
			    item.lifetime = lifetime;
			    item.weight = _weight;
			    item.threshold = threshold;
			    item.percent = percent;
			    item.weightDropAmount = weightDropAmount;
			    item.weightIncreaseAmount = weightIncreaseAmount;
			    item.weightData = weightData;
			    item.weightCalcFunction = _weightCalcFunction;
			    return item;
		  }
		  
		
		  /// For use with toXML
  		  public int weight {
    		get { return _weight; }
            set {
    			if( weightCalcFunction != null ) {
      				throw new Exception("Can't change the weight of an item with a weight function" + id);
    			}
				_weight = value;
            }
		  }
		
		
		/**
		 * 
		 */ 
		public int GetWeight( ) {
            //trace("item.getWeightAsync");

            int wt = _weight;  // take default
            
			if( weightCalcFunction != null ) {
				//trace("...calling weightFunction");
				wt = weightCalcFunction( this, weightData ); 	
			}


            return wt;
        }
		
		public bool IsRandomList()
        {
            if (payload == null) return false;

            return (payload.GetType() == typeof(RandomList));
        }
		

		
	} // RandomListItem
	
} // randomlist namespace
		


