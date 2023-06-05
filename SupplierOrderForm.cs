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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ISTN3AS_M2
{
    public partial class SupplierOrderForm : Form
    {
        string itemid, itemname;
        string unitPrice;
        string supID;
        double totalCost = 0;
        decimal dQuantity = 0;
        int iQuantity = 0;

        string managerID;
        public SupplierOrderForm(string data)
        {
            InitializeComponent();
            managerID = data;
        }

        private void SupplierOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds360Box.SupplierOrder' table. You can move, or remove it, as needed.
            this.supplierOrderTableAdapter.Fill(this.ds360Box.SupplierOrder);
            // TODO: This line of code loads data into the 'ds360Box.Asset' table. You can move, or remove it, as needed.
            this.assetTableAdapter.Fill(this.ds360Box.Asset);


            using (SqlConnection connection = new SqlConnection("Data Source=146.230.177.46;Initial Catalog = GroupWst13; Persist Security Info=True;User ID = GroupWst13; Password=kqf42"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT SupplierID FROM Supplier", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        cmbSupplier.Items.Clear();
                        while (reader.Read())
                        {
                            string primaryKeyValue = reader.GetString(0);
                            cmbSupplier.Items.Add(primaryKeyValue);
                        }
                    }
                }
            }



        }

        private void updwnQuantity_ValueChanged(object sender, EventArgs e)
        {
            dQuantity = updwnQuantity.Value;
            iQuantity = Convert.ToInt32(dQuantity.ToString());
            totalCost = Convert.ToDouble(unitPrice) * iQuantity;
            txtTotal.Text = totalCost.ToString();
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            if (cmbSupplier.Text != "Supplier")
            {
                System.Windows.Forms.DialogResult response;
                response = MessageBox.Show("Confirm Order of " + Convert.ToString(iQuantity) + " " + itemname + " From Supplier :" + cmbSupplier.Text + " for the value of R" + txtTotal.Text + "?", "Confirm Order", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (response == System.Windows.Forms.DialogResult.OK)
                {

                    Random random = new Random();
                    string supplierOrderID = "SOID" + (random.Next(100000, 999999)).ToString();
                    string supplierID = cmbSupplier.Text;
                    string assetID = itemid;
                    decimal totalAmt = Convert.ToDecimal(txtTotal.Text);
                    DateTime now = DateTime.Now;
                    string currentDate = now.ToString("yyyy-MM-dd");
                    string status = "Active";



                    supplierOrderTableAdapter.InsertOrder(supplierOrderID, supplierID, assetID, totalAmt, currentDate, iQuantity, status);
                    MessageBox.Show("Insert Statement");
                    this.supplierOrderTableAdapter.Fill(this.ds360Box.SupplierOrder);

                }
            }
            else if (cmbSupplier.Text == "Supplier")
            {
                MessageBox.Show("Select a Supplier","Supplier Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void SupplierOrderForm_VisibleChanged(object sender, EventArgs e)
        {
            cmbSupplier.Text = "Supplier";
            cmbStatus.Text = "New Status";
            txtTotal.Text = "";
            updwnQuantity.Value = 1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dbGridSupplier.SelectedCells.Count > 0)
            {
                int selectedrowindex = dbGridSupplier.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dbGridSupplier.Rows[selectedrowindex];
                supID = selectedRow.Cells[0].Value.ToString();
            }

            System.Windows.Forms.DialogResult response;
            response = MessageBox.Show("Confirm Status Change to " + cmbStatus.Text + " of Order No: " + supID + " ?", "Status Change" , MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (response == System.Windows.Forms.DialogResult.OK)
            {

                string newStatus = cmbStatus.Text;
                supplierOrderTableAdapter.UpdateStatus(newStatus, supID, supID);
                this.supplierOrderTableAdapter.Fill(this.ds360Box.SupplierOrder);

                MessageBox.Show("Update Successful");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dbGridAssets.SelectedCells.Count > 0)
            {
                int selectedrowindex = dbGridAssets.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dbGridAssets.Rows[selectedrowindex];
                itemid = selectedRow.Cells[0].Value.ToString();

                selectedrowindex = dbGridAssets.SelectedCells[0].RowIndex;
                selectedRow = dbGridAssets.Rows[selectedrowindex];
                itemname = selectedRow.Cells[1].Value.ToString();

                selectedrowindex = dbGridAssets.SelectedCells[0].RowIndex;
                selectedRow = dbGridAssets.Rows[selectedrowindex];
                unitPrice = selectedRow.Cells[3].Value.ToString();

                dQuantity = updwnQuantity.Value;
                iQuantity = Convert.ToInt32(dQuantity.ToString());
                totalCost = Convert.ToDouble(unitPrice)*iQuantity;
                txtTotal.Text = totalCost.ToString();
            }

            dbGridTransaction.Rows.Clear();
            dbGridTransaction.Rows.Insert(0, itemid, itemname, unitPrice);
        }
    }
}
