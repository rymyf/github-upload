using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieBookingSystem
{
    public partial class MyCart : Form,IActions
    {
        MovieBookingSystemEntities1 db = new MovieBookingSystemEntities1();
        user_ U;
        movie M;
        List<ticket> tickets;
        int index = 0;
        ticket tic;
        static int sNDelet;

        public string TicketType { set; get; }
      public string SeatNo { set; get; }
        public MyCart(user_ u, movie m=null ,string ticketType=null,string seatNo=null)
        {
            InitializeComponent();
            U = u;
            M = m;
            TicketType = ticketType;
            SeatNo = seatNo;
        }
       
        private void MyCart_Load(object sender, EventArgs e)
        {
            var myTickets = from t in db.ticket
                            where t.cartCode == U.cartCode
                            select t;

            tickets = myTickets.ToList();

            if (TicketType != null)
            {
                if (TicketType == "Adult")
                    tic = new ForAdult() { seatNumber = Convert.ToInt32(SeatNo), movieID = M.movieID, cartCode = (int)U.cartCode};
                   
                else
                    tic = new ForKid() { seatNumber = Convert.ToInt32(SeatNo), movieID = M.movieID, cartCode = (int)U.cartCode };

                tickets.Add(tic);
                db.ticket.Add(tic);
                db.SaveChanges();
            }
            
            if (tickets.Any())
            {
                TicketdataGridView.DataSource = myTickets.ToList();
                displayTicket(tickets, 0);
            }
            else
            {
                
                MessageBox.Show("You Don't Have Any Ticket! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }

        }
        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }
        void displayTicket(List<ticket> Tickets, int Index) {
            int TNo = Index;
            if (Index >= 0 && Index < Tickets.Count)
            {
                ticket tic = Tickets.ElementAt(Index);
                IDlabel.Text = tic.ticketID + "";
                ticketNolabel.Text = (TNo + 1) + "";
                int id = tic.movieID;
                Cinlabel.Text = db.movie.SingleOrDefault(x => x.movieID == id).cinema.SingleOrDefault(x => x.cinemaID == x.cinemaID).cinemaName;
                Namelabel.Text = tic.movie.movieName;
                Typelabel.Text = tic.movie.movieType;
                Datelabel.Text = tic.movie.movieDate.ToString();
                Timelabel.Text = tic.movie.movieTime.ToString();
                UserNameLabel.Text = U.firstName + " " + U.lastName;
                seatlabel.Text = tic.seatNumber + "";
                Pricelabel.Text = (tic.GetType().Name.Contains("ForAdult"))?"60":"48" ;
                MovpictureBox.Image = ByteArrayToImage(tic.movie.moviePicture.ToArray());
            }
            else
            {
                index = (index < 0) ? ++index : (index >= Tickets.Count) ? --index : index;
                MessageBox.Show("You reach the End of Tickets! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void Nextbutton_Click(object sender, EventArgs e)
        {
            displayTicket(tickets, ++index);
        }

        private void Prebutton_Click(object sender, EventArgs e)
        {
            displayTicket(tickets, --index);
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (cancelSeat())
            {
                MessageBox.Show("Deleted Successfully (: ", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
                MessageBox.Show("You Can't Cancel Your Ticket ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            if (tickets.Any())
            {
                Bill bill = new Bill(U, tickets);
                bill.ShowDialog();
            }
            else
                MessageBox.Show("You don't have any Ticket!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void displayAvailableMovie()
        {
            throw new NotImplementedException();
        }

        public void bookSeatNumber()
        {
            throw new NotImplementedException();
        }

        public bool cancelSeat()
        {

            DateTime today = DateTime.Now;
            int y = tickets.ElementAt(index).movie.movieDate.Year;
            int m = tickets.ElementAt(index).movie.movieDate.Month;
            int d = tickets.ElementAt(index).movie.movieDate.Day;
            int h = tickets.ElementAt(index).movie.movieTime.Hours;
            int min = tickets.ElementAt(index).movie.movieTime.Minutes;
            int s = tickets.ElementAt(index).movie.movieTime.Seconds;
            DateTime dateM = new DateTime(y, m, d, h, min, s);
            var hours = (dateM - today).TotalHours;

            if (hours < 12)
            {
                return false;
            }//Can not Delete
            else
            // You Can Delete
            {
                db.ticket.Remove(tickets.ElementAt(index));
                db.SaveChanges();
                tickets.Remove(tickets.ElementAt(index));
                return true;
            }

        }
        public double calculateTotalPrice()
        {
            throw new NotImplementedException();
        }
    }
}
