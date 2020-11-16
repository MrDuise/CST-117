using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryItems
{
    public class VideoGames : Item
    {

        //add in video game variables

         public string ageRating { get; private set; }
        public string genre { get; private set; }
        public double gameLength { get; private set; }

        //add in new party variables

        
        public VideoGames(int itemIdVal, string nameVal, string descriptionVal, decimal priceVal, int numInStockVal, int ratingVal, string ageRatingVal, string genreVal, double gameLengthVal) : base(itemIdVal, nameVal, descriptionVal, priceVal, numInStockVal, ratingVal)
        {
            ageRating = ageRatingVal;
            genre = genreVal;
            gameLength = gameLengthVal; 
        }
    }
}
