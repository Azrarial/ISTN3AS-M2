using ISTN3AS_M2.ds360BoxTableAdapters;
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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds360Box.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.ds360Box.Inventory);

        }

        private void btnGenerateID_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string id = "";

            int colIndex = 0;
            bool bFound = false;
            bool isFound = false;

            while (bFound == false)
            {
                isFound = false;
                id = (random.Next(1000000, 9999999)).ToString();
                foreach (DataGridViewRow row in dgvInventory.Rows)
                {
                    if (row.Cells[colIndex].Value != null && getIntID(row.Cells[colIndex].Value.ToString()) == "ID" + id)
                    {
                        isFound = true;
                    }
                }

                if (isFound == false)
                {
                    bFound = true;
                }
            }

            txtItemID.Text = "ID" + id;
        }

        private string getIntID(string id)
        {
            string temp = id.Substring(2);

            return temp;
        }

        private void btnAddInv_Click(object sender, EventArgs e)
        {
            string itemId = txtItemID.Text;
            string itemName = txtItemName.Text;
            string itemDescr = txtItemDescr.Text;
            int SellingPrice = Convert.ToInt32(this.txtSellingPrice.Text);
            string Type = txtType.Text;
            int CostPrice = Convert.ToInt32(this.txtCostPrice.Text);
            int Quantity = Convert.ToInt32(this.txtQuantity.Text);

            inventoryTableAdapter.Insert(itemId, itemName, itemDescr, SellingPrice, Type, CostPrice,Quantity);
            this.inventoryTableAdapter.Fill(this.ds360Box.Inventory);
        }

        private void btnDeleteInv_Click(object sender, EventArgs e)
        {
            ds360Box.Inventory.Rows[dgvInventory.CurrentRow.Index].Delete();
        }

        private void btnUpdateAsset_Click(object sender, EventArgs e)
        {
            inventoryTableAdapter.UpdateQuantity(int.Parse(txtQuantity.Text), dgvInventory.CurrentRow.Cells[0].Value.ToString(), dgvInventory.CurrentRow.Cells[0].Value.ToString());
            inventoryTableAdapter.UpdateCostPrice(int.Parse(txtCostPrice.Text), dgvInventory.CurrentRow.Cells[0].Value.ToString(), dgvInventory.CurrentRow.Cells[0].Value.ToString());
            inventoryTableAdapter.UpdateSellingPrice(int.Parse(txtSellingPrice.Text), dgvInventory.CurrentRow.Cells[0].Value.ToString(), dgvInventory.CurrentRow.Cells[0].Value.ToString());
            this.inventoryTableAdapter.Fill(this.ds360Box.Inventory);
        }
    }
}
