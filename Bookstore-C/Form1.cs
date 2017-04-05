using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bookstore_C;

namespace Bookstore_C
{
    public partial class Form1 : Form
    {
        StoreLogic store;
        public Form1()
        {
            InitializeComponent();
            store = new StoreLogic();
        }

        // This is of no importance
        private void SearchField_TextChanged(object sender, EventArgs e)
        {
            
        }

        // Add book(s) to cart
        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ListOfBooksFound.SelectedItems.Count; i++)
            {
                //store.AddToCart();
                StatusLog.Text = store.Messages;
            }
        }

        // Remove book(s) from cart
        private void RemoveBookFromCartButton_Click(object sender, EventArgs e)
        {
            for(int i = 0; i< CartBox.SelectedItems.Count; i++)
            {
                //store.RemoveFromCart(CartBox.SelectedItems[i]);
                StatusLog.Text = store.Messages;
            }
        }

        // Start checkout procedure
        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            store.PlaceOrder();
            StatusLog.Text = store.Messages;
        }

        // Clear log history
        private void ClearLogButton_Click_1(object sender, EventArgs e)
        {
            StatusLog.Text = "Cleared...";
        }

        // Close application
        private void CloseApplicationButton_Click(object sender, EventArgs e)
        {
            if (true)
            {
                this.Close();
            }
        }

        // Start searching for book(s)
        private void SearchButton_Click(object sender, EventArgs e)
        {
            store.GetBooksAsync(SearchField.Text);
            StatusLog.Text = store.Messages;
        }
    }
}
