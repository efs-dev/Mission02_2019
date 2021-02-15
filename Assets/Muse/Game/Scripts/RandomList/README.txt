
The RandomList library is meant to help you serve up random content in interesting ways in your games.

The inspiration for this library came from the random dungeon tables at the back of the AD&D 1st Edition Dungeon Master's Guide, as well as the treasure tables in the Monster Manual.
The code started life as a Java project a long time ago. Since then it's gone through ports to C# and ActionScript. This is the cleanest version yet!


BASIC USAGE
To use the library you first create at least one RandomList and add some items to it. Then, when your game needs it, you pick() an item from the list (asynchronously, using a Future).

In the simplest use case, every item has the same chance of being picked. So a simple use case might look like:

    var rlist = new RandomList("MAIN");

    rlist.add("Copper");
    rlist.add("Silver");
    rlist.add("Gold");
    rlist.add("Platinum");

    rlist.pick().then((obj){
        print( obj );  // equal chance to pick Copper, Silver, Gold, Platinum
    });

Each item added to the list has a 'weight,' which by default is 100. The weight can be increased or decreased to change the likelihood the item will get picked.
So in our exapmple, we might want copper to be common, and platinum to be very rare. So we might change it to:

   var rlist = new RandomList("MAIN");

    rlist.add("Copper", weight:1000);
    rlist.add("Silver");
    rlist.add("Gold");
    rlist.add("Platinum", weight:10);

    rlist.pick().then((obj){
        print( obj );  // much greater chance to pick Copper
    });

The list adds up all weights and normalizes them before generating a # from 0..1 and using that to select an item.

It gets much more interesting though. Some other properties you can set on an item:
* lifetime - This is how many times the item can be picked before it will be removed from the list.
* weightDecrease - if non-zero, every time the item is picked its weight will drop by this amount. Useful for decreasing the likelihood of something.
* weightIncrease - if non-zero, every time SOMETHING ELSE is picked the weight of this item goes up. Useful for increasing chance of picking something.
* removeOnZero - if true and item weight drop to zero or less, the item is removed from the list.

Items can contain a 'payload' object, which can be any arbitrary convenient object. So for instance:

    rlist.add("TOM", tomObj );

In this case "TOM" becomes just an identifier for the item, and the tomObj object is stored in the item.

>> If a payload is specified, IT IS THE PAYLOAD THAT IS RETURNED when you pick that item, NOT the identifier for the item. In the above, tomObj would be returned NOT "TOM".


NESTING LISTS
It starts to get really cool because you can specify a RandomList as the payload for an item and it gets special treatment.

    // first create a child list
    var childList = new RandomList("MAGIC_ITEMS");
    childList.add("Magic Ring");
    childList.add("Magic Wand");
    childList.add("Crystal Ball");

    // now create main list
    var mainList = new RandomList("LOOT");
    mainList.add("Mundane Item", weight:90);    // 90% chance this picked
    mainList.add("MAGIC", childList, weight:10);  // 10% chance this LIST is selected and something is picked from >>IT<<

    mainList.pick().then((obj){
        print( obj );  // 10% chance of getting a random magic item
    });

There is no limit to the depth you can nest lists.


ADVANCED USAGE - FILTERING
Finally, there is another powerful way you can influence what gets picked from a list: filtering.

You can create one or more filters that contain logic for what to allow and disallow to be picked from a list. For example:

     // a filter to apply to the previous example
     var flt = ( RandomListItem item, int attemptsRemaining, RandomListFilterCallback callback) {



       if(item.id == "MAGIC")  {
         if( todayIsThursday ) {
           callback(item, true);  // allow the item
         } else {
           callback(item, false); // disallow the item
         }
         return;
       }

       callback(item, true); // allow any other items
    };


    // use the previous list with a filter
     mainList.pick(filter:flt).then((obj){
        print( obj );  // 10% chance of getting a random magic item ONLY if todayIsThursday is true
    });


