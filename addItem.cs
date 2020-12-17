/*Michael Duisenberg
 * CST-117 
 * Add item to inventory form
 * Code Updated on 12-5-20
 * This is my own code unless otherwise stated
*/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryItems;



namespace Inventory_Project
{
    public partial class addItemForm : Form
    {

        
        List<string> myInventoryDisplay = new List<string>();
        
        public addItemForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Add Item Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            string name = txtName.Text;
            string description = rchTxtDescription.Text;
            decimal price = Convert.ToDecimal(txtPrice.Text);
            int numINStock = Convert.ToInt32(txtNumInStock.Text);
            int rating = Convert.ToInt32(txtRating.Text);

            //code of mainScreen.staticVar is a combo of my code as well as code gotten from
            //https://www.techrepublic.com/article/opening-form-instances-in-c/
            //Code to display items on inventory dataView control was gotten from Classmate Zac Almas

            



            Manager newItem = new Manager(id, name, description, price, numINStock, rating, mainScreen.mainList);

            string dirLocation = Directory.GetCurrentDirectory() + @"\DataFile";
            string fullDirLocation = dirLocation + @"\" + "InventoryItemSaves.txt";



            mainScreen.mainList = newItem.AddToList(fullDirLocation);

            myInventoryDisplay = newItem.display(fullDirLocation);

            mainScreen.staticVar.dgvMainScreen.Rows.Clear();

            foreach (var item in mainScreen.mainList)
            {
                mainScreen.staticVar.dgvMainScreen.Rows.Add(false, item.itemId, item.name, item.description, item.price, item.numInStock, item.rating);
            }

            this.Hide();
            mainScreen.staticVar.Show();

        }
    }
}
