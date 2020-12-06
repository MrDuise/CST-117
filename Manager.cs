/*Michael Duisenberg
 * CST-117 
 * Manager Class
 * This class is in the data access layer and allows for the creation and update of List<VideoGames> objects
 * Code Updated on 12-04-20
 * This is all my own code unless otherwise stated
*/



using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventoryItems
{


    public class Manager : Item
    {

        private List<VideoGames> myInventory;


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="itemIdVal"></param>
        /// <param name="nameVal"></param>
        /// <param name="descriptionVal"></param>
        /// <param name="priceVal"></param>
        /// <param name="numInStockVal"></param>
        /// <param name="ratingVal"></param>
        /// <param name="myInventoryVal"></param>
        public Manager(int itemIdVal, string nameVal, string descriptionVal, decimal priceVal, int numInStockVal, int ratingVal, List<VideoGames> myInventoryVal) : base(itemIdVal, nameVal, descriptionVal, priceVal, numInStockVal, ratingVal)
        {
            myInventory = myInventoryVal;
        }



        /// <summary>
        /// Adds an inventroy item to a List object, it then returns said list object. returned object can than be used to display to screen
        /// </summary>
        /// <param name="itemTypeVal"></param>
        /// <param name="itemIdVal"></param>
        /// <param name="nameVal"></param>
        /// <param name="descriptionVal"></param>
        /// <param name="priceVal"></param>
        /// <param name="numInStockVal"></param>
        /// <param name="ratingVal"></param>
        /// <param name="fullDirLocationVal"></param>
        public List<VideoGames> AddToList(string fullDirLocationVal)
        {

            myInventory.Add(new VideoGames(itemId, name, description, price, numInStock, rating));

            //-------------------------
            //Following code will save List to txt file found at fullDirLocationVal. Code does not work yet
            //-------------------------

            // File.WriteAllLines(fullDirLocationVal, myInventory);

            //using (StreamWriter itemSave = new StreamWriter(fullDirLocationVal))
            //{
            //    foreach(string items in myInventory.ToString())

            //        itemSave.WriteLine(items);

            //}

            return (myInventory);
        }

        /// <summary>
        /// reads in file, then loads file contents to array and returns array
        /// </summary>
        /// <param name="fullDirLocation"></param>
        /// <returns></returns>
        public List<string> display(string fullDirLocation)
        {

            List<string> fileContents = new List<string>();

            using (StreamReader file = new StreamReader(fullDirLocation))
            {
                fileContents.Add(file.ReadLine());
            }

            return fileContents;
        }

        /// <summary>
        /// This method deletes an item from a List at the index point that is given and than returns the updated List
        /// </summary>
        /// <param name="myInv"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public List<VideoGames> delete(List<VideoGames> myInv, int index)
        {
            List<VideoGames> updatedList = new List<VideoGames>();

            updatedList = myInv;

            updatedList.RemoveAt(index);

            return updatedList;
        }

        /// <summary>
        /// updates the numInStock attrupitue 
        /// </summary>
        /// <param name="myInv"></param>
        /// <param name="index"></param>
        /// <param name="newStockNumber"></param>
        /// <returns></returns>
        public List<VideoGames> updateNumInStock(List<VideoGames> myInv, int index, int newStockNumber)
        {
            List<VideoGames> updatedList = new List<VideoGames>();

            updatedList = myInv;

            updatedList[index].numInStock = newStockNumber;

            return updatedList;
        }



        /// <summary>
        /// Searchs for items in the list based off the id and the price of the item
        /// </summary>
        /// <param name="myInv"></param>
        /// <param name="id"></param>
        /// <param name="price"></param>
        /// <returns></returns>
        public List<VideoGames> search(List<VideoGames> myInv, string id, string price)
        {
            
            List<VideoGames> newListSearch = new List<VideoGames>();
            List<VideoGames> newListDisplay = new List<VideoGames>();

            //load the myInv paramater into the list that is being searched
            newListSearch = myInv;
            try
            {

                int id1 = Convert.ToInt32(id);
                decimal priceVal = Convert.ToDecimal(price);

                //--------------------------------------------------------------------------
                //following website was the location for code of list.Exists and list.Find
                //https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.find?view=net-5.0
                //----------------------------------------------------------------------------

                if (newListSearch.Exists(x => x.itemId == id1 && x.price == priceVal) == false)
                {
                    MessageBox.Show("There was nothing that matched your search");
                }
                else if (newListSearch == null)
                {
                    MessageBox.Show("List is empty");
                }
                else
                {
                    //if a result is found, add the results to the display list
                    newListDisplay.Add(newListSearch.Find(x => x.itemId == id1 && x.price == priceVal));

                }

            }
            //catch statement for if the user doesn't enter anything into the search boxes, which means that id and price would be empty
            catch
            {
                MessageBox.Show("You must enter a value to search");
            }

            //return the display list
            return newListDisplay;
        }

    }
}