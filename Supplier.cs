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
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
        }

        private void txtSearchSupplier_TextChanged(object sender, EventArgs e)
        {
            supplierTableAdapter.FillBySupplierName(ds360Box.Supplier, txtSearchSupplier.Text);
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds360Box.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.ds360Box.Supplier);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            supplierTableAdapter.UpdateSupplierName(txtUpdateName.Text, dgvSupplier.CurrentRow.Cells[0].Value.ToString(), dgvSupplier.CurrentRow.Cells[0].Value.ToString());
            supplierTableAdapter.UpdateContactNumber(txtUpdateContactNum.Text, dgvSupplier.CurrentRow.Cells[0].Value.ToString(), dgvSupplier.CurrentRow.Cells[0].Value.ToString());
            supplierTableAdapter.UpdateEmail(txtUpdateEmail.Text, dgvSupplier.CurrentRow.Cells[0].Value.ToString(), dgvSupplier.CurrentRow.Cells[0].Value.ToString());
            this.supplierTableAdapter.Fill(this.ds360Box.Supplier);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string SupplierID = txtSupplierID.Text;
            string SupplierName = txtSuppName.Text;
            string SupplierCell = txtContactNum.Text;
            string SupplierEmail = txtEmail.Text;

            supplierTableAdapter.Insert(SupplierID, SupplierName, SupplierCell, SupplierEmail);
            this.supplierTableAdapter.Fill(this.ds360Box.Supplier);
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
                foreach (DataGridViewRow row in dgvSupplier.Rows)
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ds360Box.Supplier.Rows[dgvSupplier.CurrentRow.Index].Delete();
        }
    }
}
