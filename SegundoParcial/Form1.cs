using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SegundoParcial
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public Form1()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=JSPALACIOS\SQLEXPRESS;Initial Catalog=Video;Integrated Security=True";
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUserEntered(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(@"Username \ Email"))
            {
                txtUsername.Text = "";
            }
        }

        private void txtUserLeave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(""))
            {
                txtUsername.Text = @"Username \ Email";
            }
        }

        private void txtPassEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("Password"))
            {
                txtPassword.Text = "";
            }
        }

        private void txtPassLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.Text = "Password";
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT * from Users";
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                if(txtUsername.Text.Equals(dr["Username"].ToString()) && txtPassword.Text.Equals(dr["Password"].ToString()))
                {
                    MessageBox.Show("Login Successlly","Welcome", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Either Username or Passwor is Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            con.Close();
        }
    }
}
