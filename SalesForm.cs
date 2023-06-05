using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISTN3AS_M2
{
    public partial class SalesForm : Form
    {
        string itemid, itemname;
        string unitPrice;
        double totalCost = 0;

        public SalesForm(string data)
        {
            InitializeComponent();
            string managerID = data;
            txtManagerID.Text = managerID;
        }

        StringBuilder sqlQuery = new StringBuilder();

        private void SalesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds360Box.SupplierOrder' table. You can move, or remove it, as needed.
            this.supplierOrderTableAdapter.Fill(this.ds360Box.SupplierOrder);
            // TODO: This line of code loads data into the 'ds360Box.Sale' table. You can move, or remove it, as needed.
            this.saleTableAdapter.Fill(this.ds360Box.Sale);
            // TODO: This line of code loads data into the 'ds360Box.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.ds360Box.Inventory);

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtClientID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult response;
            response = MessageBox.Show("Confirm if Order is Correct","Confirm Order",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);

            if (response == System.Windows.Forms.DialogResult.OK)
            {
                pnlConfirm.Show();
                btnAdd.Enabled = false;
                btnConfirmPayment.Enabled = true;
                btnConfirmOrder.Enabled = false;
            }
        }

        private void SalesForm_VisibleChanged(object sender, EventArgs e)
        {
            pnlConfirm.Hide();
            btnConfirmOrder.Enabled = false;
            btnConfirmPayment.Enabled = false;
            rbtnCash.Checked = true;
        }

        private void rbtnCash_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnConfirmOrder.Enabled = true;
            pnlConfirm.Visible = false;
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            double totalCost = Convert.ToDouble(txtTotal.Text);
            double amtTethered = Convert.ToDouble(txtAmtTethered.Text);
            double change = Convert.ToDouble(txtChange.Text);

            if (totalCost == (amtTethered + change))
            {
                if (txtClientID.Text != "")
                {
                    System.Windows.Forms.DialogResult response;
                    response = MessageBox.Show("Confirm if Payment Details are Correct", "Confirm Order", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (response == System.Windows.Forms.DialogResult.OK)
                    {   



                        MessageBox.Show("Insert statement");




                    }
                }
                else if (txtClientID.Text == "")
                {
                    MessageBox.Show("Enter the Client's ID", "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (totalCost != (amtTethered + change))
            {
                MessageBox.Show("Money does not tally up", "Money Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (dbGridInventory.SelectedCells.Count > 0)
            {
                int selectedrowindex = dbGridInventory.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dbGridInventory.Rows[selectedrowindex];
                itemid = selectedRow.Cells[0].Value.ToString();

                selectedrowindex = dbGridInventory.SelectedCells[0].RowIndex;
                selectedRow = dbGridInventory.Rows[selectedrowindex];
                itemname = selectedRow.Cells[1].Value.ToString();

                selectedrowindex = dbGridInventory.SelectedCells[0].RowIndex;
                selectedRow = dbGridInventory.Rows[selectedrowindex];
                unitPrice = selectedRow.Cells[3].Value.ToString();

                totalCost += Convert.ToDouble(unitPrice);
                txtTotal.Text = totalCost.ToString();
            }

            dbGridTransaction.Rows.Insert(0,itemid,itemname,unitPrice);
            btnConfirmOrder.Enabled = true;
        }
    }
}
