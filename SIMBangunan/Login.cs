using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SIMBangunan
{
    public partial class Login : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=db_bangunan;Integrated Security=True;Pooling=False");
        private SqlDataAdapter da;
        private SqlDataReader dr;

        public Login()
        {
            InitializeComponent();
        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select username,password from l_user where username='" + tbUsername + "' and password = '" + tbPassword + "'",conn);
            dr = cmd.ExecuteReader();
            dr.Read();

            if(dr.HasRows){
                this.Hide();
                frmUtama a = new frmUtama();
                a.Show();
                conn.Close(); 
            } else{
                conn.Open();
                MessageBox.Show("Username dan Password Salah!");
                conn.Close(); 
            }
        }
    }
}
