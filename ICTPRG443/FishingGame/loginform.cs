using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Drawing.Text;

namespace FishingGame
{
    public partial class loginform : Form
    {
        public static string? username;
        public loginform()
        {
            InitializeComponent();

        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\ICTPRG443\\FishingGameDB\\db_fishingGameUser.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();


        private void picbox_Click(object sender, EventArgs e)
        {

        }

        private void textBoxlogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            txtpassword.Text = "";
            txtUsername.Text = "";
            txtUsername.Focus();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            new registerform().Show();
            this.Hide();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '*';
            }
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {


            con.Open();
            string login = " SELECT * FROM db_fishingGameUser WHERE username = '" + txtUsername.Text + "' and password= '" + txtpassword.Text + "'";
            cmd = new OleDbCommand(login, con);
            var dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                username = txtUsername.Text;
                MainWindow main = new MainWindow();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Please Try Again", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtpassword.Text = "";

                txtUsername.Focus();


            }


            con.Close();
        }

        private void loginform_Load(object sender, EventArgs e)
        {

        }
    }
}
