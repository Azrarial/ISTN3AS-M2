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
    public partial class LoginForm : Form
    {
        private SqlConnection connection;
        private string connectString = "Data Source=146.230.177.46;Initial Catalog = GroupWst13; Persist Security Info=True;User ID = GroupWst13; Password=kqf42";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectString);
            connection.Open();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            string query = "";

            if (rbtnManager.Checked)
            {
                query = "SELECT COUNT(*) FROM Manager WHERE ManagerID = @Username AND Password = @Password";
            }
            else if (rbtnCoach.Checked)
            {
                query = "SELECT COUNT(*) FROM Coach WHERE CoachID = @Username AND Password = @Password";
            }
    
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);

            int result = (int)command.ExecuteScalar();

            if ((result > 0) && (rbtnManager.Checked))
            {
                MenuM managermenuform = new MenuM(username);
                this.Hide();
                MessageBox.Show("Manager Login");
                managermenuform.ShowDialog();
                this.Show();
            }
            else if ((result > 0) && (rbtnCoach.Checked))
            {
                MenuC coachmenuform = new MenuC();
                this.Hide();
                MessageBox.Show("Coach Login");
                coachmenuform.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password!\nPlease enter a valid Username or Password.", "Unsuccessful Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtUserName_MouseEnter(object sender, EventArgs e)
        {
            if ((txtUserName.Text == "ManagerID") || (txtUserName.Text == "CoachID"))
            {
                txtUserName.Text = "";
                txtUserName.Focus();
                txtUserName.ForeColor = Color.White;
            }  
        }

        private void txtUserName_MouseLeave(object sender, EventArgs e)
        {
            if ((txtUserName.Text == "") && (rbtnManager.Checked))
            {
                txtUserName.Text = "ManagerID";
                txtUserName.ForeColor = Color.LightGray;
                btnLogin.Focus();
            }
            else if ((txtUserName.Text == "") && (rbtnCoach.Checked))
            {
                txtUserName.Text = "CoachID";
                txtUserName.ForeColor = Color.LightGray;
                btnLogin.Focus();
            }
        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password") 
            {
                txtPassword.Text = "";
                txtPassword.Focus();
                txtPassword.ForeColor = Color.White;
            }
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.LightGray;
                btnLogin.Focus();
            }
        }

        private void rbtnManager_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnManager.Checked)
            {
                txtUserName.Text = "ManagerID";
                txtUserName.ForeColor = Color.LightGray;
            }
        }

        private void rbtnCoach_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCoach.Checked)
            {
                txtUserName.Text = "CoachID";
                txtUserName.ForeColor = Color.LightGray;
            }
        }

        private void LoginForm_VisibleChanged(object sender, EventArgs e)
        {
            rbtnManager.Checked = true;
            rbtnCoach.Checked = false;
            txtUserName.Text = "ManagerID";
            txtUserName.ForeColor = Color.LightGray;
            txtPassword.Text = "Password";
            txtPassword.ForeColor = Color.LightGray;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private Point offset;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Calculate the offset between the mouse cursor and the top-left corner of the form
                offset = new Point(e.X, e.Y);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Calculate the new position of the form based on the offset and the current mouse cursor position
                Point newPosition = PointToScreen(new Point(e.X, e.Y));
                newPosition.Offset(-offset.X, -offset.Y);
                Location = newPosition;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
