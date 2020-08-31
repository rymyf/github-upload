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
            SearchDatebutton.Click += new EventHandler(type);
        }

        private void type(object sender, EventArgs e) {

            Button B = (Button)sender;
            string type = (string)B.Tag;
            if (type.Equals("date")) {
                Movies searchbyDate = new Movies(U,SearchDateTimePicker.Value) ;
            }
            else if (type.Equals("cinema")) {
                Movies searchbyDate = new Movies(U) { cinemaName = CinemaNamecomboBox.Text};
            }
            else {
                Movies searchbyDate = new Movies(U) { movieName = MovieNametextBox.Text};
            }

        }

        private void Searchbutton1_Click(object sender, EventArgs e)
        {

        }

        private void Cartbutton2_Click(object sender, EventArgs e)
        {
            MyCart myCart = new MyCart(U);
            myCart.ShowDialog();
        }

        private void MyMoviebutton_Click(object sender, EventArgs e)
        {
            MyMovies myMovies = new MyMovies(U);
            myMovies.ShowDialog();


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
         
        private void Searchbutton_Click(object sender, EventArgs e)
        {
            //var searchBy =(object)null ;
            //if (MovieNameradioButton.Checked)
            //    searchBy=MovieNametextBox.Text;
            //else if (CinNameradioButton.Checked)
            //    searchBy=CinemaNamecomboBox.Text;
            //else if (DateradioButton.Checked)
            //    searchBy= ;

            //Movies searchbyDate = new Movies(U);
            //searchbyDate.ShowDialog();
            
    }

        private void SearchCinbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
