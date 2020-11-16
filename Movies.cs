//Michael Duisenberg
//11-12-20
//This class is a child class of the Item Class for my inventory project
//This is all my own code

using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryItems
{
    public class Movies : Item
    {
        //add in movie varbiables
        public int length { get; private set; }
        public string maturityLevel { get; private set; }

        public string genre { get; private set; }

        /// <summary>
        /// creates a constructor of the Movies Class
        /// </summary>
        /// <param name="itemIdVal"></param>
        /// <param name="nameVal"></param>
        /// <param name="descriptionVal"></param>
        /// <param name="priceVal"></param>
        /// <param name="numInStockVal"></param>
        /// <param name="ratingVal"></param>
        /// <param name="lengthVal"></param>
        /// <param name="maturityLevelVal"></param>
        /// <param name="genreVal"></param>
        public Movies(int itemIdVal, string nameVal, string descriptionVal, decimal priceVal, int numInStockVal, int ratingVal, int lengthVal, string maturityLevelVal, string genreVal) : base(itemIdVal, nameVal, descriptionVal, priceVal, numInStockVal, ratingVal)
        {
            length = lengthVal;
            maturityLevel = maturityLevelVal;
            genre = genreVal;
        }
    }
}
