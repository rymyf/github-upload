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
    public partial class Search : Form
    {
        user_ U;
        MovieBookingSystemEntities1 db = new MovieBookingSystemEntities1();

        public Search(user_ u)
        {
            InitializeComponent();
            Namelabel.Text = u.firstName + " " + u.lastName;
            U = u;

            SearchDatebutton.Click += new EventHandler(type);
            SearchCinbutton.Click += new EventHandler(type);
            SearchMovbutton.Click += new EventHandler(type);
        }

        private void type(object sender, EventArgs e) {
            Movies displayMovie=null;
            Button B = (Button)sender;
            string type = (string)B.Tag;

            if (type.Equals("date"))
                displayMovie = new Movies(U, SearchDateTimePicker.Value);
            else if (type.Equals("cinema"))
                displayMovie = new Movies(U) { CinemaName = CinemaNamecomboBox.Text };
            else if (type.Equals("movie"))
                displayMovie = new Movies(U) { MovieName = MovieNametextBox.Text };
            
            displayMovie.ShowDialog();
        }
        
        private void Cartbutton2_Click(object sender, EventArgs e)
        {
            MyCart myCart = new MyCart(U);
            myCart.ShowDialog();
        }
        
        private void DateradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (DateradioButton.Checked)
                Datepanel.Visible = true;
            else 
                Datepanel.Visible = false;
        }

        private void CinNameradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CinNameradioButton.Checked)
                Cinemapanel.Visible = true;
            else
                Cinemapanel.Visible = false;
        }

        private void MovieNameradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MovieNameradioButton.Checked)
                Moviepanel.Visible = true;
            else
                Moviepanel.Visible = false;
        }

        private void MyMoviebutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
