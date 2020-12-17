/*Michael Duisenberg
 * CST-117 
 * Search inventory screen
 * updated on 12-5-20
 * this is my own code
*/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryItems;

namespace Inventory_Project
{
    public partial class searchInventory : Form
    {
        public searchInventory()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //manager object that allows me to call the methods
            Manager searchItem = new Manager(12, "Default Shirt", "This is a shirt", 12.99m, 6, 10, mainScreen.mainList);

            //list to store and display the search results
            List<VideoGames> newList = new List<VideoGames>();

            string id = txtItemIdSearch.Text;
            string price = txtItemPriceSearch.Text;
            string name = txtNameSearch.Text;

            if(txtItemIdSearch.Text == null)
            {
                MessageBox.Show("Please Enter A value");
            }

            //results of search are added into the newList List object
            newList = searchItem.search(mainScreen.mainList, id, price, name);

            //display the search results 
            foreach (var item in newList)
            {
                dgvSearchPage.Rows.Add(item.itemId, item.name, item.description, item.price, item.numInStock, item.rating);
            }

            txtItemIdSearch.Clear();
            txtItemPriceSearch.Clear();
            txtNameSearch.Clear();
        }
    }
}
