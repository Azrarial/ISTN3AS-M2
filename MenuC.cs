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
    public partial class MenuC : Form
    {
        public MenuC()
        {
            InitializeComponent();
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAsset_Click(object sender, EventArgs e)
        {
            ViewBooking viewbookingform = new ViewBooking();
            this.Hide();
            viewbookingform.ShowDialog();
            this.Show();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            Class classform = new Class();
            this.Hide();
            classform.ShowDialog();
            this.Show();
        }
    }
}
