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
    public partial class MyCart : Form
    {
        user_ U;
        public MyCart(user_ u)
        {
            InitializeComponent();
            U = u;
        }
    }
}
