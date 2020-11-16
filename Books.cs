using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryItems
{
    public class Books : Item
    {
        //add in book variables

        public int numOfPages { get; private set; }

        public Books(int itemIdVal, string nameVal, string descriptionVal, decimal priceVal, int numInStockVal, int ratingVal, int numOfPagesVal) : base(itemIdVal, nameVal, descriptionVal, priceVal, numInStockVal, ratingVal)
        {
            numOfPages = numOfPagesVal;
        }
    }
}
