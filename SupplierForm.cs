using ISTN3AS_M2.GroupWst13DataSetTableAdapters;
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
    public partial class SupplierForm : Form
    {
        public SupplierForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string SupplierID = txtSupplierID.Text;
            string SupplierName = txtSuppName.Text;
            string SupplierCell = txtCellNum.Text;
            string SupplierEmail = txtEmail.Text;

            //supplierTableAdapter.Insert(SupplierID, SupplierName, SupplierCell, SupplierEmail);
            //this.supplierTableAdapter.Fill(this.dsBox360.Supplier);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // dsBox360.Supplier.Rows[dbSupplier.CurrentRow.Index].Delete();
        }

        private void button2_Click(object sender, EventArgs e)
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
                foreach (DataGridViewRow row in dbSupplier.Rows)
                {
                    if (row.Cells[colIndex].Value != null && getIntID(row.Cells[colIndex].Value.ToString()) == "SP" + id)
                    {
                        isFound = true;
                    }
                }

                if (isFound == false)
                {
                    bFound = true;
                }
            }

            txtSupplierID.Text = "SP" + id;
        }

        private string getIntID(string id)
        {
            string temp = id.Substring(2);

            return temp;
        }

        private void dbSupplier_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtUpdateName.Text = dbSupplier.CurrentRow.Cells[1].Value.ToString();
            txtUpdateContactNum.Text = dbSupplier.CurrentRow.Cells[2].Value.ToString();
            txtUpdateEmail.Text = dbSupplier.CurrentRow.Cells[3].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
          //  supplierTableAdapter.UpdateSupplierName(txtUpdateName.Text, dbSupplier.CurrentRow.Cells[0].Value.ToString(), dbSupplier.CurrentRow.Cells[0].Value.ToString());
          //  supplierTableAdapter.UpdateContactNumber(txtUpdateContactNum.Text, dbSupplier.CurrentRow.Cells[0].Value.ToString(), dbSupplier.CurrentRow.Cells[0].Value.ToString());
          //  supplierTableAdapter.UpdateEmail(txtUpdateEmail.Text, dbSupplier.CurrentRow.Cells[0].Value.ToString(), dbSupplier.CurrentRow.Cells[0].Value.ToString());
          //  this.supplierTableAdapter.Fill(this.dsBox360.Supplier);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //supplierTableAdapter.FillBySupplierName(dsBox360.Supplier, txtSearch.Text);
        }
    }
}
