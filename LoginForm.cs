﻿using System;
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
                // frmMenu form = new frmMenu();
                //  form.ShowDialog();
                //    this.Hide();
                MessageBox.Show("Manager Login");
            }
            else if ((result > 0) && (rbtnCoach.Checked))
            {
                MessageBox.Show("Coach Login");
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
            }  
        }

        private void txtUserName_MouseLeave(object sender, EventArgs e)
        {
            if ((txtUserName.Text == "") && (rbtnManager.Checked))
            {
                txtUserName.Text = "ManagerID";
            }
            else if ((txtUserName.Text == "") && (rbtnCoach.Checked))
            {
                txtUserName.Text = "CoachID";
            }
        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password") 
            {
                txtPassword.Text = "";
                txtPassword.Focus();
            }
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
            }
        }

        private void rbtnManager_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnManager.Checked)
            {
                txtUserName.Text = "ManagerID";
            }
        }

        private void rbtnCoach_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCoach.Checked)
            {
                txtUserName.Text = "CoachID";
            }
        }
    }
}
