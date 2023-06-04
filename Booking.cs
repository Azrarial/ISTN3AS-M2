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
    public partial class Booking : Form
    {
        private string bookingID, clientID, classID, bookingDate, status, type, venue;
        public Booking()
        {
            InitializeComponent();
        }

        private void txtClassType_TextChanged(object sender, EventArgs e)
        {
            classTableAdapter.FillByClassType(ds360Box.Class, txtClassType.Text);
        }

        private void txtSearchClientC_TextChanged(object sender, EventArgs e)
        {
            clientTableAdapter.FillByLastName(ds360Box.Client,txtSearchClientC.Text);
        }

        private void btnCancelBooking_Click_1(object sender, EventArgs e)
        {
            ds360Box.Booking.Rows[dgvBookingC.CurrentRow.Index].Delete();
            this.bookingTableAdapter.Fill(this.ds360Box.Booking);
        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            bookingID = generateBookID();
            bookingDate = monthCalendar1.SelectionRange.Start.ToString();
            status = cmbStatus.Text;
            venue = txtVenue.Text;

            bookingTableAdapter.InsertBooking(bookingID, clientID, classID, bookingDate, status, type, venue);
            this.bookingTableAdapter.Fill(this.ds360Box.Booking);
        }

        private void dgvClass_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            classID = Convert.ToString(dgvClass[0, row].Value);
            type = Convert.ToString(dgvClass[3, row].Value);
        }

        private void dgvClient_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            clientID = Convert.ToString(dgvClient[0, row].Value);
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clientTableAdapter.FillByCustID(ds360Box.Client, dgvClient.CurrentRow.Cells[0].Value.ToString());
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            ds360Box.Booking.Rows[dgvBookingC.CurrentRow.Index].Delete();
            this.bookingTableAdapter.Fill(this.ds360Box.Booking);
        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            bookingTableAdapter.FillByDate(ds360Box.Booking, monthCalendar1.SelectionRange.Start.ToString());
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds360Box.Class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.ds360Box.Class);
            // TODO: This line of code loads data into the 'ds360Box.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.ds360Box.Client);
            // TODO: This line of code loads data into the 'ds360Box.Booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter.Fill(this.ds360Box.Booking);
        }

        private void txtSearchClient_TextChanged(object sender, EventArgs e)
        {
            clientTableAdapter.FillByLastName(ds360Box.Client, txtSearchClient.Text);
        }

        private string generateBookID()
        {
            Random random = new Random();
            string id = "";

            int colIndex = 0;
            bool bFound = false;
            bool isFound = false;

            while (bFound == false)
            {
                isFound = false;
                id = (random.Next(10000, 99999)).ToString();
                foreach (DataGridViewRow row in dgvBookingM.Rows)
                {
                    if (row.Cells[colIndex].Value != null && getIntID(row.Cells[colIndex].Value.ToString()) == id)
                    {
                        isFound = true;
                    }
                }

                if (isFound == false)
                {
                    bFound = true;
                }
            }

            return "BK" + id;
        }

        private string getIntID(string id)
        {
            string temp = id.Substring(2);

            return temp;
        }
    }
}
