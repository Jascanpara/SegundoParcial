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
            panelRegister.Visible = false;
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
            loguear(this.txtUsername.Text, this.txtPassword.Text);
            /*con.Open();
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
            con.Close();*/
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserEnteredRegister(object sender, EventArgs e)
        {
            if (txtUsernameRegister.Text.Equals(@"Username \ Email"))
            {
                txtUsername.Text = "";
            }
        }

        private void txtUserLeaveRegister(object sender, EventArgs e)
        {
            if (txtUsernameRegister.Text.Equals(""))
            {
                txtUsername.Text = @"Username \ Email";
            }
        }

        private void txtPassEnterRegister(object sender, EventArgs e)
        {
            if (txtPasswordRegister.Text.Equals("Password"))
            {
                txtPassword.Text = "";
            }
        }

        private void txtPassLeaveRegister(object sender, EventArgs e)
        {
            if (txtPasswordRegister.Text.Equals(""))
            {
                txtPassword.Text = "Password";
            }
        }

        private void BtnLoginHome_Click(object sender, EventArgs e)
        {
            panelHome.Visible = false;
        }

        private void BtnRegisterHome_Click(object sender, EventArgs e)
        {
            panelRegister.Visible = true;
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        public void loguear (string usuario, string contrasena)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Username, Password FROM Users WHERE Username = @usuario AND Password = @pas ", con);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("pas", contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide(); //esto oculta el Form en el que estamos
                    new Inicio(dt.Rows[0][0].ToString()).Show();
                }
                else
                {
                    MessageBox.Show("Either Username or Passwor is Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
