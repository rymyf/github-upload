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
    public partial class SignIn : Form
    {
        MovieBookingSystemEntities1 db = new MovieBookingSystemEntities1();
        string type;

        public SignIn(string t)
        {
            InitializeComponent();
            type = t;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            if(type == "AdminButton")
            {
                SignUpLabel.Visible = false;
                Qlabel.Visible = false;
            }
        }

        private void SignUpLabel_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.ShowDialog();

        }

        private void SignButton_Click(object sender, EventArgs e)
        {
           

            user_ user;
            var users = from u in db.user_ select u;
            foreach (var u in users) {
                if (u.email == EmailTextBox.Text && u.password==PasswordTextBox.Text)
                {
                    user = u;
                    goto UserFound;

                }
            }

            MessageBox.Show("Please Check your Email or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            goto End;



            UserFound:
            if (type == "AdminButton")
            {
                clean();
                AdminControl admin = new AdminControl(user);
                admin.ShowDialog();
                
            }
            else
            {
                clean();
                Search customer = new Search(user);
                customer.ShowDialog();

            }
            End:;
        }

        private void clean()
        {
            EmailTextBox.ForeColor = Color.Gray;
            PasswordTextBox.ForeColor = Color.Gray;
            
            EmailTextBox.Text = "Email";
            PasswordTextBox.Text = "Password";
            PasswordTextBox.PasswordChar = '\u0000';
        }


        private void EmailTextBox_Enter(object sender, EventArgs e)
        {
            if (EmailTextBox.Text == "Email")
            {
                EmailTextBox.Text = "";
                EmailTextBox.ForeColor = Color.Black;
            }

        }

        private void EmailTextBox_Leave(object sender, EventArgs e)
        {
            if (EmailTextBox.Text == "")
            {
                EmailTextBox.Text = "Email";
                EmailTextBox.ForeColor = Color.Gray;
            }
        }

        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "Password")
            {
                PasswordTextBox.Text = "";
                PasswordTextBox.ForeColor = Color.Black;
            }
        }

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "")
            {
                PasswordTextBox.Text = "Password";
                PasswordTextBox.ForeColor = Color.Gray;
            }

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            PasswordTextBox.PasswordChar = '*';
        }
    }
}
