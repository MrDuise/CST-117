/*Michael Duisenberg
 * CST-117 
 * Add item to inventory form
 * Code Updated on 11-14-20
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
    public partial class addItemForm : Form
    {
        public addItemForm()
        {
            InitializeComponent();
        }

        

       

       

        
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            string name = txtName.Text;
            string description = rchTxtDescription.Text;
            decimal price = Convert.ToDecimal(txtPrice.Text);
            int numINStock = Convert.ToInt32(txtNumInStock.Text);
            int rating = Convert.ToInt32(txtRating.Text);
            
           
            
            string itemSelect;

            if (lstBoxSelectItemType.SelectedIndex != -1)
            {
                itemSelect = lstBoxSelectItemType.SelectedItem.ToString();

                //code of mainScreen.staticVar is a combo of my code as well as code gotten from
                //https://www.techrepublic.com/article/opening-form-instances-in-c/
                //Code to display items on inventory dataView control was gotten from Classmate Zac Almas

                var index = mainScreen.staticVar.dgvMainScreen.Rows.Add();
                switch (itemSelect)
                {
                    case "Video Games":
                        string ageRating = lstBoxMaturityLevel.Text;
                        string gameGenre = txtGameGenre.Text;
                        double gameLength = Convert.ToInt32(txtGameLength.Text);
                        //create an instance of the videogames class
                        VideoGames newGame = new VideoGames(id, name, description, price, numINStock, rating, ageRating, gameGenre, gameLength);
                        
                       
                        mainScreen.staticVar.dgvMainScreen.Rows[index].Cells[1].Value = newGame.itemId;
                        mainScreen.staticVar.dgvMainScreen.Rows[index].Cells[2].Value = newGame.name;
                        mainScreen.staticVar.dgvMainScreen.Rows[index].Cells[3].Value = newGame.description;
                        mainScreen.staticVar.dgvMainScreen.Rows[index].Cells[4].Value = newGame.price;
                        mainScreen.staticVar.dgvMainScreen.Rows[index].Cells[5].Value = newGame.numInStock;
                        mainScreen.staticVar.dgvMainScreen.Rows[index].Cells[6].Value = newGame.rating;
                        this.Hide();
                        mainScreen.staticVar.Show();

                        break;
                    case "Books":

                        int numOfPages = Convert.ToInt32(txtNumOfPages.Text);
                        Books newBook = new Books(id, name, description, price, numINStock, rating, numOfPages);
                       
                        mainScreen.staticVar.dgvMainScreen.Rows[index].Cells[1].Value = newBook.itemId;
                        mainScreen.staticVar.dgvMainScreen.Rows[index].Cells[2].Value = newBook.name;
                        mainScreen.staticVar.dgvMainScreen.Rows[index].Cells[3].Value = newBook.description;
                        mainScreen.staticVar.dgvMainScreen.Rows[index].Cells[4].Value = newBook.price;
                        mainScreen.staticVar.dgvMainScreen.Rows[index].Cells[5].Value = newBook.numInStock;
                        mainScreen.staticVar.dgvMainScreen.Rows[index].Cells[6].Value = newBook.rating;
                        this.Hide();
                        mainScreen.staticVar.Show();

                        break;

                    case "Movies":
                        int movieLength = Convert.ToInt32(txtMovieLength.Text);
                        string maturityLevel = lstBoxMaturityLevel.Text;
                        string genre = txtGenre.Text;

                        Movies newMovie = new Movies(id, name, description, price, numINStock, rating, movieLength, maturityLevel, genre);
                        
                        mainScreen.staticVar.dgvMainScreen.Rows[index].Cells[1].Value = newMovie.itemId;
                        mainScreen.staticVar.dgvMainScreen.Rows[index].Cells[2].Value = newMovie.name;
                        mainScreen.staticVar.dgvMainScreen.Rows[index].Cells[3].Value = newMovie.description;
                        mainScreen.staticVar.dgvMainScreen.Rows[index].Cells[4].Value = newMovie.price;
                        mainScreen.staticVar.dgvMainScreen.Rows[index].Cells[5].Value = newMovie.numInStock;
                        mainScreen.staticVar.dgvMainScreen.Rows[index].Cells[6].Value = newMovie.rating;
                        this.Hide();
                        mainScreen.staticVar.Show();
                        break;

                    case "Other":

                        Item newItem = new Item(id, name, description, price, numINStock, rating);

                        
                        mainScreen.staticVar.dgvMainScreen.Rows[index].Cells[1].Value = newItem.itemId;
                        mainScreen.staticVar.dgvMainScreen.Rows[index].Cells[2].Value = newItem.name;
                        mainScreen.staticVar.dgvMainScreen.Rows[index].Cells[3].Value = newItem.description;
                        mainScreen.staticVar.dgvMainScreen.Rows[index].Cells[4].Value = newItem.price;
                        mainScreen.staticVar.dgvMainScreen.Rows[index].Cells[5].Value = newItem.numInStock;
                        mainScreen.staticVar.dgvMainScreen.Rows[index].Cells[6].Value = newItem.rating;
                        this.Hide();
                        mainScreen.staticVar.Show();

                        break; 
                }
            }


        }

        private void lstBoxSelectItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemSelect;

            if(lstBoxSelectItemType.SelectedIndex != -1)
            {
                itemSelect = lstBoxSelectItemType.SelectedItem.ToString();

                switch (itemSelect)
                {
                    case "Video Games":
                        //make non-videogame controls invisable
                        lblGenre.Visible = false;
                        lblMaturityLevel.Visible = false;
                        lblMovieLength.Visible = false;
                        lblNumOfPages.Visible = false;
                        txtGenre.Visible = false;
                        txtMovieLength.Visible = false;
                        lstBoxMaturityLevel.Visible = false;
                        txtNumOfPages.Visible = false;

                        //make video game controls visable

                        lblAgeRating.Visible = true;
                        lstBoxAgeRating.Visible = true;
                        lblGameGenre.Visible = true;
                        txtGameGenre.Visible = true;
                        lblGameLength.Visible = true;
                        txtGameLength.Visible = true;
                        break;
                    case "Books":

                        lblAgeRating.Visible = false;
                        lstBoxAgeRating.Visible = false;
                        lblGameGenre.Visible = false;
                        txtGameGenre.Visible = false;
                        lblGameLength.Visible = false;
                        txtGameLength.Visible = false;
                        lblGenre.Visible = false;
                        lblMaturityLevel.Visible = false;
                        lblMovieLength.Visible = false;
                        txtGenre.Visible = false;
                        txtMovieLength.Visible = false;
                        lstBoxMaturityLevel.Visible = false;

                        //make book controls visable
                        lblNumOfPages.Visible = true;
                        txtNumOfPages.Visible = true;
                        break;

                    case "Movies":

                        lblAgeRating.Visible = false;
                        lstBoxAgeRating.Visible = false;
                        lblGameGenre.Visible = false;
                        txtGameGenre.Visible = false;
                        lblGameLength.Visible = false;
                        txtGameLength.Visible = false;
                        lblNumOfPages.Visible = false;
                        txtNumOfPages.Visible = false;

                        //
                        lblGenre.Visible = true;
                        lblMaturityLevel.Visible = true;
                        lblMovieLength.Visible = true;
                        txtGenre.Visible = true;
                        txtMovieLength.Visible = true;
                        lstBoxMaturityLevel.Visible = true;
                        break;

                    case "Other":

                        //make all extra controls invisable
                        lblAgeRating.Visible = false;
                        lstBoxAgeRating.Visible = false;
                        lblGameGenre.Visible = false;
                        txtGameGenre.Visible = false;
                        lblGameLength.Visible = false;
                        txtGameLength.Visible = false;
                        lblGenre.Visible = false;
                        lblMaturityLevel.Visible = false;
                        lblMovieLength.Visible = false;
                        txtGenre.Visible = false;
                        txtMovieLength.Visible = false;
                        lstBoxMaturityLevel.Visible = false;
                        lblNumOfPages.Visible = false;
                        txtNumOfPages.Visible = false;

                        break;

                }
            }
           

        }
    }
}
