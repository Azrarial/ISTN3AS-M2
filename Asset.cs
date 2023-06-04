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
    public partial class Asset : Form
    {
        public Asset()
        {
            InitializeComponent();
        }

        private void Asset_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds360Box.Asset' table. You can move, or remove it, as needed.
            this.assetTableAdapter.Fill(this.ds360Box.Asset);

        }

        private void DeleteAsset_Click(object sender, EventArgs e)
        {
            ds360Box.Asset.Rows[dgvAsset.CurrentRow.Index].Delete();
        }

        private void btnAddAsset_Click(object sender, EventArgs e)
        {
            string AssetId = txtAssetID.Text;
            string AssetName = txtAssName.Text;
            string Condition = txtCondition.Text;
            int Quantity = Convert.ToInt32(this.txtQuantity.Text);
            string Type = txtType.Text;
            int CostPrice = Convert.ToInt32(this.txtCostPrice.Text);

            assetTableAdapter.Insert(AssetId, AssetName, Condition, CostPrice, Type, Quantity);
            this.assetTableAdapter.Fill(this.ds360Box.Asset);
        }

        private void btnUpdateAsset_Click(object sender, EventArgs e)
        {
            assetTableAdapter.UpdateConditionMethod(cmbUpdateCondition.Text, dgvAsset.CurrentRow.Cells[0].Value.ToString(), dgvAsset.CurrentRow.Cells[0].Value.ToString());
            assetTableAdapter.UpdateQuantityMethod(int.Parse(txtUpdateQuantity.Text), dgvAsset.CurrentRow.Cells[0].Value.ToString(), dgvAsset.CurrentRow.Cells[0].Value.ToString());
            this.assetTableAdapter.Fill(this.ds360Box.Asset);
        }

        private string getIntID(string id)
        {
            string temp = id.Substring(2);

            return temp;
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
                id = (random.Next(10000, 99999)).ToString();
                foreach (DataGridViewRow row in dgvAsset.Rows)
                {
                    if (row.Cells[colIndex].Value != null && getIntID(row.Cells[colIndex].Value.ToString()) == "AI" + id)
                    {
                        isFound = true;
                    }
                }

                if (isFound == false)
                {
                    bFound = true;
                }
            }

            txtAssetID.Text = "AI" + id;
        }
    }
}
