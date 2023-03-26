using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FishingGame
{
    public partial class registerform : Form
    {
        public registerform()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\ICTPRG443\\FishingGameDB\\db_fishingGameUser.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();


        private void picbox_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text == "" && txtpassword.Text == "" && txtcompassword.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtpassword.Text == txtcompassword.Text)
            {
                con.Open();
                string register = "INSERT INTO db_fishingGameUser VALUES ('" + txtUsername.Text + "', '" + txtpassword.Text + "')";




                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your Account has  been Sucessfully created", "Resgistration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtUsername.Text = "";
                txtpassword.Text = "";
                txtcompassword.Text = "";

            }
            else
            {
                MessageBox.Show("Password does not Match, please Re-enter", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Text = "";
                txtcompassword.Text = "";
                txtUsername.Text = "";

            }
        }

        private void txtComPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcompassword_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                txtpassword.PasswordChar = '\0';
                txtcompassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '*';
                txtcompassword.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtpassword.Text = "";
            txtcompassword.Text = "";

            txtUsername.Focus();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            new loginform().Show();
            this.Hide();
        }
    }
}