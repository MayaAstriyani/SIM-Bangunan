using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SIMBangunan.master
{
    public partial class User : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=db_bangunan;Integrated Security=True;Pooling=False");

        int id;
        string id_user_fix;

        public User()
        {
            InitializeComponent();
        }

        private void reset() {
            tbKodeuser.Text = "";
            tbNama.Text     = "";
            tbUsername.Text = "";
            tbPassword.Text = "";
        }

        private void User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_user.l_user' table. You can move, or remove it, as needed.
            this.l_userTableAdapter.Fill(this.ds_user.l_user);

            btnSimpan.Enabled = false;

            tbKodeuser.Enabled = false;
            tbNama.Enabled = false;
            tbUsername.Enabled = false;
            tbPassword.Enabled = false;

            gbAksi2.Visible = false;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            SqlCommand KodeUSer = new SqlCommand("SELECT id_user FROM l_user order by right(id_user, 3)", conn);

            conn.Open();
            SqlDataReader kodeUserList = KodeUSer.ExecuteReader();

            while (kodeUserList.Read())
            {
                id = int.Parse(kodeUserList.GetValue(0).ToString().Replace("USR-", ""));
            }

            conn.Close();

            if (id < 9)
            {
                id_user_fix = "USR-00" + (id + 1).ToString();
            }

            else if (id < 99)
            {
                id_user_fix = "USR-0" + (id + 1).ToString();
            }

            else if (id >= 99)
            {
                id_user_fix = "USR-" + (id + 1).ToString();
            }

            btnSimpan.Enabled = true;
            btnBatal.Enabled = true;
            btnTambah.Enabled = false;

            tbKodeuser.Enabled = false;
            tbNama.Enabled = true;
            tbUsername.Enabled = true;
            tbPassword.Enabled = true;

            tbKodeuser.Text = id_user_fix;
            tbNama.Text = "";
            tbUsername.Text = "";
            tbPassword.Text = "";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand simpan = new SqlCommand();
            simpan.Connection = conn;
            simpan.CommandText = "saveuser";
            simpan.CommandType = CommandType.StoredProcedure;

            SqlParameter iduser = new SqlParameter("@id_user", SqlDbType.VarChar);
            SqlParameter nama = new SqlParameter("@nama", SqlDbType.VarChar);
            SqlParameter username = new SqlParameter("@username", SqlDbType.VarChar);
            SqlParameter password = new SqlParameter("@password", SqlDbType.VarChar);

            iduser.Value = tbKodeuser.Text;
            nama.Value = tbNama.Text;
            username.Value = tbUsername.Text;
            password.Value = tbPassword.Text;

            simpan.Parameters.Add(iduser);
            simpan.Parameters.Add(nama);
            simpan.Parameters.Add(username);
            simpan.Parameters.Add(password);

            simpan.ExecuteNonQuery();
            {
                this.l_userTableAdapter.Fill(ds_user.l_user);
            }
            conn.Close();

            btnSimpan.Enabled = false;
            btnTambah.Enabled = true;

            reset();

            tbKodeuser.Enabled = false;
            tbNama.Enabled = false;
            tbUsername.Enabled = false;
            tbPassword.Enabled = false;
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand hapus = new SqlCommand();
            hapus.Connection = conn;
            hapus.CommandText = "deleteuser";
            hapus.CommandType = CommandType.StoredProcedure;

            SqlParameter iduser = new SqlParameter("@id_user", SqlDbType.VarChar);

            iduser.Value = tbKodeupdate.Text;

            hapus.Parameters.Add(iduser);

            hapus.ExecuteNonQuery();
            {
                this.l_userTableAdapter.Fill(ds_user.l_user);
            }
            conn.Close();

            btnSimpan.Enabled = false;
            btnTambah.Enabled = true;

            reset();

            tbKodeuser.Enabled = false;
            tbNama.Enabled = false;
            tbUsername.Enabled = false;
            tbPassword.Enabled = false;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand update = new SqlCommand();
            update.Connection = conn;
            update.CommandText = "updateuser";
            update.CommandType = CommandType.StoredProcedure;

            SqlParameter iduser = new SqlParameter("@id_user", SqlDbType.VarChar);
            SqlParameter nama = new SqlParameter("@nama", SqlDbType.VarChar);
            SqlParameter username = new SqlParameter("@username", SqlDbType.VarChar);
            SqlParameter password = new SqlParameter("@password", SqlDbType.VarChar);

            iduser.Value = tbKodeupdate.Text;
            nama.Value = tbNamaupdate.Text;
            username.Value = tbUserupdate.Text;
            password.Value = tbPassupdate.Text;

            update.Parameters.Add(iduser);
            update.Parameters.Add(nama);
            update.Parameters.Add(username);
            update.Parameters.Add(password);

            update.ExecuteNonQuery();
            {
                this.l_userTableAdapter.Fill(ds_user.l_user);
                gbAksi2.Visible = false;
            }
            conn.Close();

            btnSimpan.Enabled = false;

            reset();
        }

        private void gcDatauser_DoubleClick(object sender, EventArgs e)
        {
            gbAksi2.Visible = true;
        }
    }
}
