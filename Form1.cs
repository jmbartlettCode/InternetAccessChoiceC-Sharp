/* 
Josh Bartlett
3Aug2019
Assignment 7.2
Display a MessageBox asking users whether they want internet access. If they do not, their total price is $0. 
If they do, display a second MessageBox asking whether they want limited access (at $10.95 per month) or unlimited 
access (at $19.95 per month). Display the total price in a third MessageBox.   
*/

using System;
using System.Windows.Forms;

namespace InternetAccess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Declare variables to use with MessageBox.Show()
            string message = "Do you want Internet access?";
            string title = "Internet Access";
            // Create the Yes No buttons to answer the question in the message
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            // Declares the DialogResult variable to hold the value of the button that the user selected and 
            // displays the MessageBox with the first message, title and buttons 
            DialogResult result = MessageBox.Show(message, title, buttons);

            // Checks if the user selected the Yes button
            if(result == DialogResult.Yes)
            {
                // Changes the message to ask if they want unlimited
                message = "Would you like unlimited access for $19.95 per month? If not, limited access is $10.95 per month.";
                // Displays second MessageBox changes result variable to what button the user selected from the second MessageBox
                result = MessageBox.Show(message, title, buttons);
                
                // Checks if the user selected the Yes button
                if(result == DialogResult.Yes)
                {
                    // Changes the message variable to the total price for unlimited access
                    message = "The total price for unlimited Internet access is $19.95 per month.";
                    // Display thrid message box for total price
                    MessageBox.Show(message, title);
                }
                else
                {
                    // Changes the message variable to the total price for limited access
                    message = "The total price for limited Internet Access is $10.95 per month.";
                    // Display thrid message box for total price
                    MessageBox.Show(message, title);
                }
            }
            else
            {
                // Changes the message variable to the total price for no access
                message = "The total price for no Internet access is $0 per month.";
                // Display message box for total price
                MessageBox.Show(message, title);
            }
            // Exits application after all MessageBoxs
            Application.Exit();
        }
    }
}