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
    public partial class Movies : Form, IActions
    {
        static MovieBookingSystemEntities1 db = new MovieBookingSystemEntities1();
        user_ U;
        public DateTime Date { set; get; }
        public string CinemaName { set; get; }
        public string MovieName { set; get; }

        movie selectedMovie;

        double price = 60;
        string ticketType;

        List<movie> movies;
        int index = 0;

        public Movies(user_ u, DateTime date = default(DateTime), string cName = null, string mName = null)
        {
            InitializeComponent();
            U = u;
            Date = date;
            CinemaName = cName;
            MovieName = mName;

        }
        private void Movies_Load(object sender, EventArgs e)
        {
            displayAvailableMovie();
        }
        
        private void Bookbutton_Click(object sender, EventArgs e)
        {
            Bookpanel.Visible = true;
            selectedMovie = movies.ElementAt(index);

        }

        public void displayAvailableMovie()
        {

            if (Date != default(DateTime))
            {
                var byDate = from mov in db.movie
                             where mov.movieDate == Date.Date
                             select mov;


                movies = byDate.ToList();
                
            }
            else if (MovieName != null) {

                var byMName = from mov in db.movie
                              where mov.movieName == MovieName
                              select mov;

                movies = byMName.ToList();

            } else if (CinemaName != null) {

                var byCinName = from movies in db.movie
                                from cinemas in movies.cinema
                                where cinemas.cinemaName == CinemaName
                                select movies;

                movies = byCinName.ToList();
            }


            if (movies.Any())
            {
                dataGridViewMovies.DataSource = movies;
                printInfoMovies(movies, 0);
            }
            else {
                Close();
                MessageBox.Show("Movies Not Found! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            printInfoMovies(movies, ++index);
        }

        private void Prebutton_Click(object sender, EventArgs e)
        {
            printInfoMovies(movies, --index);
        }

        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }

        public void printInfoMovies(List<movie> movies, int index) {
           
            if (index >= 0 && index < movies.Count)
            {
                movie mov = movies.ElementAt(index);
                int id = movies.ElementAt(index).movieID;
                Cinlabel.Text = db.movie.SingleOrDefault(x => x.movieID == id).cinema.SingleOrDefault(x => x.cinemaID == x.cinemaID).cinemaName;
                Namelabel.Text = mov.movieName;
                Typelabel.Text = mov.movieType;
                Datelabel.Text = mov.movieDate.ToShortDateString();
                Timelabel.Text = mov.movieTime.ToString();

                MovpictureBox.Image = ByteArrayToImage(mov.moviePicture.ToArray());
                int availableNumberS = mov.availableSeat;
                if (db.ticket.Any())
                {

                    var seatTic = from t in db.ticket
                                  where t.movieID == mov.movieID
                                  select t.seatNumber;

                    List<int> listOfSeat=new List<int>() ;
                    foreach (int seat in seatTic) {
                        listOfSeat.Add(seat);
                    }

                    for (int i = 1; i <= availableNumberS; i++)
                    {
                        if (listOfSeat.Contains(i))
                            continue;
                        else
                            SeatNocomboBox.Items.Add(i);
                    }

                }
                else {
                    for(int i =1;i<= availableNumberS;i++)
                        SeatNocomboBox.Items.Add(i); 
                }

            }
            else
            {
                this.index = (index < 0) ? ++index : (index >= movies.Count) ? --index : index;
                MessageBox.Show("You reach the End of movies! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void bookSeatNumber()
        {
            DialogResult dialogResult = MessageBox.Show("Remember You can't delete your ticket 12 hours before the show\nAre You sure? ", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                MyCart mycart = new MyCart(U, selectedMovie, ticketType, SeatNocomboBox.Text);
                mycart.ShowDialog();
            }
        }

        public bool cancelSeat()
        {
            throw new NotImplementedException();
        }

        public double calculateTotalPrice()
        {
            throw new NotImplementedException();
        }

        private void AdultradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (AdultradioButton.Checked)
            {
                price = 60;
                priceLabel.Text = "The price is: " + price + " SR";
                ticketType = "Adult";
            }
            
        }

        private void KidradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (KidradioButton.Checked)
            {
                price = price - (price * 0.2);
                priceLabel.Text = "The price is: " + (price) + " SR";
                ticketType = "Kid";
            }
        }

        private void ToCartbutton_Click(object sender, EventArgs e)
        {
            bookSeatNumber();
        }
    }
}
