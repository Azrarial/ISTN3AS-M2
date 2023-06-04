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
    public partial class ClassesForm : Form
    {
        public ClassesForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
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
                foreach (DataGridViewRow row in dbClass.Rows)
                {
                    if (row.Cells[colIndex].Value != null && getIntID(row.Cells[colIndex].Value.ToString()) == "CL" + id)
                    {
                        isFound = true;
                    }
                }

                if (isFound == false)
                {
                    bFound = true;
                }
            }

            txtClassID.Text = "CL" + id;
        }

        private string getIntID(string id)
        {
            string temp = id.Substring(2);

            return temp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ClassID = txtClassID.Text;
            string CoachID = txtCoachID.Text;
            string GroupType = cmbGroupType.Text;
            string ClassType = cmbClassType.Text;

            TimeSpan startTime = dateTimePicker1.Value.TimeOfDay;
            TimeSpan endTime = dateTimePicker2.Value.TimeOfDay;
            int MaxCap = (int)SpinMax.Value;
            int CurrentCap = (int)SpinCurrent.Value;
            bool PublicClass = chkPublic.Checked;



            classTableAdapter1.Insert(ClassID, CoachID, GroupType, ClassType, startTime, endTime, MaxCap, CurrentCap, PublicClass);
            this.classTableAdapter1.Fill(this.dsBox360.Class);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dsBox360.Class.Rows[dbClass.CurrentRow.Index].Delete();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan startTime = dateTimePicker3.Value.TimeOfDay;
            TimeSpan endTime = dateTimePicker4.Value.TimeOfDay;
            /*
            classTableAdapter1.UpdateClassType(cmbUpdateClass.Text, dbClass.CurrentRow.Cells[0].Value.ToString(), dbClass.CurrentRow.Cells[0].Value.ToString());
            classTableAdapter1.UpdateGroupType(cmbUpdateGroup.Text, dbClass.CurrentRow.Cells[0].Value.ToString(), dbClass.CurrentRow.Cells[0].Value.ToString());
            classTableAdapter1.UpdateStartTime(startTime.ToString(), dbClass.CurrentRow.Cells[0].Value.ToString(), dbClass.CurrentRow.Cells[0].Value.ToString());
            classTableAdapter1.UpdateEndTime(endTime.ToString(), dbClass.CurrentRow.Cells[0].Value.ToString(), dbClass.CurrentRow.Cells[0].Value.ToString());
            this.classTableAdapter1.Fill(this.dsBox360.Class);
            */
        }

        private void dbClass_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cmbUpdateGroup.Text = dbClass.CurrentRow.Cells[2].Value.ToString();
            cmbUpdateClass.Text = dbClass.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker3.Text = dbClass.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker4.Text = dbClass.CurrentRow.Cells[5].Value.ToString();
        }

        private void dbCoach_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            txtCoachID.Text = Convert.ToString(dbCoach[0, row].Value);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
          //  classTableAdapter1.FillByClassType(dsBox360.Class, textBox4.Text);
        }
    }
}
