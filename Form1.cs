//Michael Duisenberg
//CST-117
//09-14-20
//Professor Hughes 




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //This displays a pop up window
        private void messageButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }

        //this also displays a pop of window 
        private void welcomeClassButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello there my fellow class mates of CST-117");
        }
    }
}
