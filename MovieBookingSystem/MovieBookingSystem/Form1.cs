using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieBookingSystem
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }



        private void CustomerButton_Click(object sender, EventArgs e)
        {
            SignIn signin = new SignIn(CustomerButton.Name);
            signin.ShowDialog();

        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            SignIn signin = new SignIn(AdminButton.Name);
            signin.ShowDialog();
            
        }
    }
}
