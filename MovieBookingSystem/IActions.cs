using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingSystem
{
    interface IActions
    {
       void displayAvailableMovie();
        void bookSeatNumber();
        bool cancelSeat(); 
        double calculateTotalPrice();

    }
}
