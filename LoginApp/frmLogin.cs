using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginApp
{
    public partial class frmLogin : Form
    {
        int clickCounter = 0;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //SqlConnection sqlcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\LoginApp\DB\LoginDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            //string query = "Select * from tbl_Login Where username = '" + txtUsername.Text.Trim() + "' and password = '" + txtPassword.Text.Trim() + "'";
            //SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            //DataTable dtbl = new DataTable();
            //sda.Fill(dtbl);
            //if (dtbl.Rows.Count == 1)
            //{
            //    frmMain objFrmMain = new frmMain();
            //    this.Hide();
            //    objFrmMain.Show();
            //}
            Users user = new Users(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            if (user._Username != null && user._Password != null)
            {
                frmMain objFrmMain = new frmMain();
                this.Hide();
                objFrmMain.Show();
            }
            else
            {
                MessageBox.Show("Check your username and password");
                clickCounter++;
            }
            if(clickCounter > 2)
            {
                MessageBox.Show("You tried more than 3 times, the application will now be locked.");
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
                btnLogin.Enabled = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
