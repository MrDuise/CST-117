//Michael Duisenberg
//VideoGames class, child class of Item class
//Each item in the inventory is of the VideoGame class
//updated on 12-1-20
//This is all my own code





using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryItems
{
    public class VideoGames : Item
    {

        public VideoGames(int itemIdVal, string nameVal, string descriptionVal, decimal priceVal, int numInStockVal, int ratingVal) : base(itemIdVal, nameVal, descriptionVal, priceVal, numInStockVal, ratingVal)
        {
           
        }
    }
}
