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
    public partial class Delete : Form
    {
        public int itemId { get; private set; }
        public string itemName { get; private set; }
        public string itemDesc { get; private set; }
        public decimal itemPrice { get; private set; }
        public int numInStock { get; private set; }
        public int rating { get; private set; }

        public int index { get; private set; }

        int attepts = 3;




        public Delete(int itemIdVal, string itemNameVal, string itemDescVal, decimal itemPriceVal, int numInStockVal, int ratingVal, int indexVal)
        {
            InitializeComponent();

            itemId = itemIdVal;
            itemName = itemNameVal;
            itemDesc = itemDescVal;
            itemPrice = itemPriceVal;
            numInStock = numInStockVal;
            rating = ratingVal;

            index = indexVal;
            

            lblItemToDelete.Text = string.Format("This is the inventory to delete: \n" + "Item Number: {0}\nItem Name: {1}\nItem Description: {2}\nItem Price: ${3}\nNumber in Stock: {4}\nItems Rating: {5}", itemId, itemName, itemDesc, itemPrice, numInStock, rating);
        }

        private void Delete_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string correctPassword = "Password";
            string password = txtPassword.Text;
            

            if(password != correctPassword)
            {
                MessageBox.Show("That was not the correct password. You have " + attepts + " left");
                attepts--;
                if (attepts <= 0)
                {
                    this.Close();
                }
                
                     
            }
            else
            {
                mainScreen.staticVar.dgvMainScreen.Rows.RemoveAt(index);
                mainScreen.mainList = mainScreen.newItem.delete(mainScreen.mainList, index);
            }

           
        }
    }
}
