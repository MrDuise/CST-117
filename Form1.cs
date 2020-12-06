/*Michael Duisenberg
 * CST-117 
 * Inventory Project main inventory screen
 * Updated 12-5-20
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
    public partial class mainScreen : Form
    {

        public static List<VideoGames> mainList = new List<VideoGames>();

        public static Manager newItem = new Manager(12, "Default Shirt", "This is a shirt", 12.99m, 6, 10,  mainList);


        public mainScreen()
        {
            InitializeComponent();
        }

        //this code was gotten from this website
        //https://www.techrepublic.com/article/opening-form-instances-in-c/
        //it allows me to open up the current instance of this form instead of making a new one each time I add an item
        public static mainScreen staticVar = null;





        /// <summary>
        /// Add button event handler. Creates a new add form and then displays that form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddItemForm_Click(object sender, EventArgs e)
        {
            staticVar = this;
            addItemForm addForm = new addItemForm();
            addForm.Show();
            
        }

        private void btnSearchForm_Click(object sender, EventArgs e)
        {
            searchInventory searchForm = new searchInventory();
            searchForm.Show();

        }

        private void dgvMainScreen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        /// <summary>
        /// This method loads in the file and displays it to the screen when the program starts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainScreen_Load(object sender, EventArgs e)
        {
            //var index = dgvMainScreen.Rows.Add();

            //List<VideoGames> myInv = new List<VideoGames>();
            //List<string> myInventoryDisplay = new List<string>();

           

            //string dirLocation = Directory.GetCurrentDirectory() + @"\DataFile";
            //string fullDirLocation = dirLocation + @"\" + "InventoryItemSaves.txt";

            //myInventoryDisplay = newItem.display(fullDirLocation);



            //dgvMainScreen.Rows[index].Cells[1].Value = myInventoryDisplay[0];
            //dgvMainScreen.Rows[index].Cells[2].Value = myInventoryDisplay[1];
            //dgvMainScreen.Rows[index].Cells[3].Value = myInventoryDisplay[2];
            //dgvMainScreen.Rows[index].Cells[4].Value = myInventoryDisplay[3];
            //dgvMainScreen.Rows[index].Cells[5].Value = myInventoryDisplay[4];
            //dgvMainScreen.Rows[index].Cells[6].Value = myInventoryDisplay[5];
        }


        /// <summary>
        /// Delete button event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            int index;
            
            foreach (DataGridViewCell oneCell in dgvMainScreen.SelectedCells)
            {
                if (oneCell.Selected)
                {
                    index = oneCell.RowIndex;
                    dgvMainScreen.Rows.RemoveAt(oneCell.RowIndex);
                    mainList = newItem.delete(mainList, index);
                }
                    
            }

        }

        private void btnUpDateNumInStock_Click(object sender, EventArgs e)
        {
            staticVar = this;
            UpdateNumInStockForm newUpdate = new UpdateNumInStockForm();
            newUpdate.Show();
        }
    }
}
