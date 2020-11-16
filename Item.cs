//Michael Duisenberg
//11-12-20
//This class is the parent class for my inventory project
//This is all my own code



using System;

namespace InventoryItems
{
    public class Item
    {
        public int itemId { get; private set; }
        public string name { get; private set; }
        public string description { get; private set; }
        public decimal price { get; private set; }
        public int numInStock { get; private set; }
        public int rating { get; private set; }//must be set between 1 - 10

        /// <summary>
        /// creates a constructor of an Item Class
        /// </summary>
        /// <param name="itemIdVal"></param>
        /// <param name="nameVal"></param>
        /// <param name="descriptionVal"></param>
        /// <param name="priceVal"></param>
        /// <param name="numInStockVal"></param>
        /// <param name="ratingVal"></param>
        public Item(int itemIdVal, string nameVal, string descriptionVal, decimal priceVal, int numInStockVal, int ratingVal)
        {
            itemId = itemIdVal;
            name = nameVal;
            description = descriptionVal;
            price = priceVal;
            numInStock = numInStockVal;
            rating = ratingVal;
        }


    }
}
