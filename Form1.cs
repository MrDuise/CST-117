/*Michael Duisenberg
 * CST-117 
 * Inventory Project main inventory screen
 * Updated 11-14-20
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
    public partial class mainScreen : Form
    {
        public mainScreen()
        {
            InitializeComponent();
        }

        //this code was gotten from this website
        //https://www.techrepublic.com/article/opening-form-instances-in-c/
        //it allows me to open up the current instance of this form instead of making a new one each time I add an item
        public static mainScreen staticVar = null;






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
    }
}
