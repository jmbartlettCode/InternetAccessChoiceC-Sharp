/* 
Josh Bartlett
3Aug2019
Assignment 7.2
Display a MessageBox asking users whether they want internet access. If they do not, their total price is $0. 
If they do, display a second MessageBox asking whether they want limited access (at $10.95 per month) or unlimited 
access (at $19.95 per month). Display the total price in a third MessageBox.   
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetAccess
{
    static class InternetAccess
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
