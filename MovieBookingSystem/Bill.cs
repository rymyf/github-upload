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
    public partial class Bill : Form,IActions
    {
        user_ U;
        List<ticket> Tickets;
        double discount;
        public Bill(user_ u,List<ticket> tickets)
        {
            InitializeComponent();
            U = u;
            Tickets = tickets;
        }

        public void bookSeatNumber()
        {
            throw new NotImplementedException();
        }
        
        public double calculateTotalPrice()
        {
            double price = 0.0;
            discount = 0.0;
            foreach (var t in Tickets)
            {
                if (t is ForAdult)
                    price += 60;//price = price+60;
                else if (t is ForKid)
                {
                    price += 48;
                    discount += 0.2;

                }

            }
            return price;
        }

        public bool cancelSeat()
        {
            throw new NotImplementedException();
        }

        public void displayAvailableMovie()
        {
            throw new NotImplementedException();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            totalPlabel.Text= ""+calculateTotalPrice();
            dislabel.Text = discount + "";
        }

        private void Donebutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
