using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace MovieBookingSystem
{
    public partial class Movies : Form
    {
        MovieBookingSystemEntities1 db = new MovieBookingSystemEntities1();
        user_ U;
       public DateTime Date { set; get; }
       public string cinemaName { set; get; }
        public string movieName { set; get; }




        public Movies(user_ u, DateTime date = default(DateTime), string cName =null, string mName=null)
        {
            InitializeComponent();
            U = u;
            Date = date;
            cinemaName = cName;
            movieName = mName;

        }
        int index=0;
        //public static Bitmap ByteToImage(byte[] blob)
        //{
        //    MemoryStream mStream = new MemoryStream();
        //    byte[] pData = blob;
        //    mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
        //    Bitmap bm = new Bitmap(mStream, false);
        //    mStream.Dispose();
        //    return bm;
        //}
        private void Movies_Load(object sender, EventArgs e)
        {
            if (Date != null)
            {
                var byDate = from mov in db.movie
                             where mov.movieDate == Date
                             select mov;
                List<movie> movies = byDate.ToList();
                dataGridViewMovies.DataSource = movies;
                

                //Cinlabel.Text= movies.ElementAt(index).cinema.cinemaName;
                Namelabel.Text = movies.ElementAt(index).movieName;
                Typelabel.Text = movies.ElementAt(index).movieType;
                Datelabel.Text = movies.ElementAt(index).movieDate.ToString();
                Timelabel.Text = movies.ElementAt(index).movieTime.ToString();
                //MovpictureBox.Image = ByteToImage(movies.ElementAt(index).moviePicture);
                int n = movies.ElementAt(index).availableSeat;
                
                // Seat ComboBox + movie Pic + (checkChange for 2 radio Button) + (Next and Pre Buttons)!

            }



        }

        private void Typelabel_Click(object sender, EventArgs e)
        {

        }

        private void Datelabel_Click(object sender, EventArgs e)
        {

        }

        private void Timelabel_Click(object sender, EventArgs e)
        {

        }

        private void Bookbutton_Click(object sender, EventArgs e)
        {
            Bookpanel.Visible = true;

        }
    }
}
