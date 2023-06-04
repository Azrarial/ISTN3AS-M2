using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISTN3AS_M2
{
    public partial class ViewBooking : Form
    {
        public ViewBooking()
        {
            InitializeComponent();
        }

        private void ViewBooking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds360Box.Booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter.Fill(this.ds360Box.Booking);

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            bookingTableAdapter.FillByDate(ds360Box.Booking, monthCalendar1.SelectionRange.Start.ToString());
        }
    }
}
