/*Assignment1_FrancisGarlejo.sln
 * Assignment 1 - MCQ Game
 * 
 * Revision History:
 *      Francis Gerald Garlejo 
 *      2022.09.24: Created,
 *      2022.09.27: Revised,
 *      2022.09.28: Revised,
 *      2022.10.01: Finalized
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assignment1_FrancisGarlejo
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();           
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try {
                if (txtBoxEnterName.Text == "" || txtBoxEnterName.Text.Length > 20)
                {
                    MessageBox.Show("Cannot be null or greater than 20 characters");
                    txtBoxEnterName.Text = String.Empty;
                }
                else
                {
                    FormMCQ formMCQ = new FormMCQ();
                    formMCQ.enterName(txtBoxEnterName.Text);
                    formMCQ.Show();
                    this.Hide();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }         
        }
    }
}
