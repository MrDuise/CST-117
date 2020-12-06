/*Michael Duisenberg
 * CST-117 
 * Update Number Of Items in stock form
 * Code Updated on 12-4/20
 * This is all my own code unless otherwise stated
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
    public partial class UpdateNumInStockForm : Form
    {
        public UpdateNumInStockForm()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index;
            int newNumber = Convert.ToInt32(txtNewNumInStock.Text);

            foreach (DataGridViewCell oneCell in mainScreen.staticVar.dgvMainScreen.SelectedCells)
            {
                if (oneCell.Selected)
                {
                    index = oneCell.RowIndex;
                    mainScreen.mainList =  mainScreen.newItem.updateNumInStock(mainScreen.mainList, index, newNumber);
                    
                }

            }

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
