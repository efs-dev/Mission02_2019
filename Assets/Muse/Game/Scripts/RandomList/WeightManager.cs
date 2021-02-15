using System;
using System.Collections;
using UnityEngine;

namespace randomlist
{
		
	/***
	 * 
	 * First calculate all weights of items, then figure out
	 * their new percentages and threshholds for list picking.
	 */ 
	public class WeightManager
	{

		
		private static int totalWeight;
        private static double threshCount = 0;

        // recalc wt for each item, then recalc threshhold for each item
        // empty callback function to signal done
        public static void RecalcWeights( RandomList callingList  ) {
           // UnityEngine.Debug.Log("RecalcWeights()");


            totalWeight = 0;
            threshCount = 0;

            ArrayList items = callingList.GetAllListItems();

            try
            {
                int itemWeight;

                foreach ( RandomListItem item in items)
                {
                    itemWeight = item.GetWeight();
                    //Debug.Log("wt " + itemWeight);
                    if (itemWeight <= 0) continue;

                    totalWeight += itemWeight;
                }

                callingList.totalWeight = totalWeight;

                //Debug.Log("total: " + totalWeight);

                foreach (RandomListItem item in items)
                {
                    double itemWeightD = item.GetWeight();

                    double percent = itemWeightD / totalWeight;


                    //Debug.Log("......percent " + percent);

                    item.percent = percent * 100;

                    threshCount += percent;
                    item.threshold = threshCount;
                }

            } catch (Exception err)
            {
                Debug.Log("RandomList.recalcWeights() error\n" + err);
            }
}
		
	
		
	} // class
} // pkg

