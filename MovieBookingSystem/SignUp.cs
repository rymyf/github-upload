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
    public partial class SignUp : Form
    {
        MovieBookingSystemEntities1 db = new MovieBookingSystemEntities1();

        public SignUp()
        {
            InitializeComponent();
        }


        private void SignUpButton_Click(object sender, EventArgs e)
        {
            var Emails = from em in db.user_ select em.email;

                // check Empty
                string fName = FirstNameTextBox.Text;
                string lName = LastNameTextBox.Text;

            // must not be empty!
            if(LastNameTextBox.Text=="" || FirstNameTextBox.Text == "")
            {
                MessageBox.Show("Please enter Your name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                goto End;
            }

            string email = EmailTextBox.Text;

            // email must be uniqu & not empty & contain @
            if (email.Contains("@hotmail.com") || email.Contains("@gmail.com") || email.Contains("@icloud.com") || email != "" )
            {
                    foreach (var checkEmail in Emails)
                    {
                        if (checkEmail == email)
                        {
                            MessageBox.Show("Email used, Please Enter Another Email !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            EmailTextBox.Text = " ";
                        goto End;
                        }

                    }

                // must be (<= 8) &  (password != confirmpassword) &(not empty)
            
                string password = PasswordtextBox.Text;
                string password2 = ConfirmPasswordtextBox.Text;

                if (password.Length != 8) {
                    MessageBox.Show("Password must be equal to 8", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    goto End;
                }

                if (password != password2)
                {
                    MessageBox.Show("Please Confirm your password Corrrectly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    goto End;
                }

                // Correct email & password  then add
                cart c = new cart();
                db.cart.Add(c);
                user_ u = new Customer() { firstName = fName, lastName = lName, password = password, email = email, cartCode = c.cartCode };
                db.user_.Add(u);
                db.SaveChanges();

                Close();
                Search s = new Search(u);
                s.ShowDialog();

            }
            else
            {
                MessageBox.Show("please Enter Correct Email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EmailTextBox.Text = " ";
            }

        End:;
            
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
           Close();
        }
    }
}
