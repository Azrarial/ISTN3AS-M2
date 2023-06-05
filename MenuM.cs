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
    public partial class MenuM : Form
    {
        string managerID;
        public MenuM(string data)
        {
            InitializeComponent();
            managerID = data;
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            Booking bookingform = new Booking();
            this.Hide();
            bookingform.ShowDialog();
            this.Show();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            SalesForm salesform = new SalesForm(managerID);
            this.Hide();
            salesform.ShowDialog();
            this.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {

        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            SupplierOrderForm supplierorderform = new SupplierOrderForm(managerID);
            this.Hide();
            supplierorderform.ShowDialog();
            this.Show();
        }

        private void btnAsset_Click_1(object sender, EventArgs e)
        {

        }
    }
}
