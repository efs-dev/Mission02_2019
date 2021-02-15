using System.Collections;
using System.Collections.Generic;
using System;
//using UnityEngine;

namespace randomlist
{
    public class RandomListEventArgs : EventArgs
    {
        public RandomListEventType type;

        public RandomList relatedList;
        public RandomListItem relatedItem;

        public RandomListEventArgs(RandomListEventType type, RandomList relatedList, RandomListItem relatedItem)
        {
            this.type = type;
            this.relatedList = relatedList;
            this.relatedItem = relatedItem;
        }
    } // RandomListEventArgs

    // event types
    public enum RandomListEventType { ADDED, REMOVED, EXPIRED, PICKED, PICKING, FAILED };

    public delegate void RandomListEventHandler(object source, RandomListEventArgs args);

    /// <summary>
    /// A delegate that may choose to react in some way to an item being picked
    /// </summary>
    /// <param name="pickedObject"></param>
	public delegate void PickObjectHandler(object pickedObject);

    /**
		 * 
		 * function to determine whether an item is a candidate to be returned from a random call
		 * 
		 * @param the item to potentially filter.
		 * @param attemptsRemaining is there to try to mitigate too tough constraints - 
		 * so calling function can see if list is having hard time coming up with something that passes the filter.
		 * 
		 * call allowItem  item, t/f to be called on parent
		 * @return bool of whether to allow the item to be picked or not.
		 */
    public delegate bool RandomListFilter(RandomList list, RandomListItem item, int attemptsRemaining);

    public enum WeightType
    {
        DEFAULT, // weight does not change (i.e., drop or increase
        DROPS,
        INCREASES,
        DROP_AND_INCREASE, // both drops and increases                      
        DYNAMIC // uses function to calculate
    };


    /**
	 * a function to dynamically calculate the weight of an item
     * weightData is an arbitrary value
	 */
    public delegate int WeightCalcDelegate(RandomListItem item, Object weightData);


}


/*
 * Console.Out.WriteLine("expiring: " + item.WrappedObject);
				
				RandomListEventArgs args = new RandomListEventArgs( RandomListEventType.EXPIRED, this, item);
				
				// expire, this is the last usage of the item
				
				LastExpired = item;
				
				RandomListEvent( this, args);  // fires the event
*/
