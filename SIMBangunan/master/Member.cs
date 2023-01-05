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
    public partial class Member : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=db_bangunan;Integrated Security=True;Pooling=False");

        int id;
        string id_member_fix;

        public Member()
        {
            InitializeComponent();
        }

        private void Member_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_member.l_member' table. You can move, or remove it, as needed.
            this.l_memberTableAdapter.Fill(this.ds_member.l_member);
            btnSimpan.Enabled = false;

            tbKodemember.Enabled = false;
            tbNama.Enabled = false;
            dpTgldaftar.Enabled = false;
            cbJk.Enabled = false;
            tbNohp.Enabled = false;
            tbAlamat.Enabled = false;

            gbAksi2.Visible = false;
        }

        private void reset() {
            tbKodemember.Text = "";
            tbNama.Text       = "";
            dpTgldaftar.Text  = "";
            cbJk.Text         = "";
            tbNohp.Text       = "";
            tbAlamat.Text     = "";
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            SqlCommand KodeMember = new SqlCommand("SELECT id_member FROM l_member order by right(id_member, 3)", conn);

            conn.Open();
            SqlDataReader kodeMemberList = KodeMember.ExecuteReader();

            while (kodeMemberList.Read())
            {
                id = int.Parse(kodeMemberList.GetValue(0).ToString().Replace("MEMBER-", ""));
            }

            conn.Close();

            if (id < 9)
            {
                id_member_fix = "MEMBER-00" + (id + 1).ToString();
            }

            else if (id < 99)
            {
                id_member_fix = "MEMBER-0" + (id + 1).ToString();
            }

            else if (id >= 99)
            {
                id_member_fix = "MEMBER-" + (id + 1).ToString();
            }

             btnSimpan.Enabled = true;
           btnBatal.Enabled = true;
            btnTambah.Enabled = false;
            
            tbKodemember.Enabled = false;
            tbNama.Enabled = true;
            dpTgldaftar.Enabled = true;
            cbJk.Enabled = true;
            tbNohp.Enabled = true;
            tbAlamat.Enabled = true;

            tbKodemember.Text = id_member_fix;
            tbNama.Text       = "";
            dpTgldaftar.Text  = "";
            cbJk.Text         = "";
            tbNohp.Text       = "";
            tbAlamat.Text     = "";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand simpan = new SqlCommand();
            simpan.Connection = conn;
            simpan.CommandText = "savemember";
            simpan.CommandType = CommandType.StoredProcedure;

            SqlParameter idmember = new SqlParameter("@id_member", SqlDbType.VarChar);
            SqlParameter namammeber = new SqlParameter("@nama", SqlDbType.VarChar);
            SqlParameter tgldaftar = new SqlParameter("@tgl_daftar", SqlDbType.Date);
            SqlParameter jk = new SqlParameter("@jenis_kelamin", SqlDbType.VarChar);
            SqlParameter nohp = new SqlParameter("@no_hp", SqlDbType.BigInt);
            SqlParameter alamat = new SqlParameter("@alamat", SqlDbType.VarChar);

            idmember.Value = tbKodemember.Text;
            namammeber.Value = tbNama.Text;
            tgldaftar.Value = dpTgldaftar.Text;
            jk.Value = cbJk.Text;
            nohp.Value = tbNohp.Text;
            alamat.Value = tbAlamat.Text;

            simpan.Parameters.Add(idmember);
            simpan.Parameters.Add(namammeber);
            simpan.Parameters.Add(tgldaftar);
            simpan.Parameters.Add(jk);
            simpan.Parameters.Add(nohp);
            simpan.Parameters.Add(alamat);

            simpan.ExecuteNonQuery();
            {
                this.l_memberTableAdapter.Fill(ds_member.l_member);
            }
            conn.Close();

            btnSimpan.Enabled = false;
            btnTambah.Enabled = true;

            reset();

            tbKodemember.Enabled = false;
            tbNama.Enabled = false;
            dpTgldaftar.Enabled = false;
            cbJk.Enabled = false;
            tbNohp.Enabled = false;
            tbAlamat.Enabled = false;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand hapus = new SqlCommand();
            hapus.Connection = conn;
            hapus.CommandText = "deletemember";
            hapus.CommandType = CommandType.StoredProcedure;

            SqlParameter idmember = new SqlParameter("@id_member", SqlDbType.VarChar);

            idmember.Value = tbUkodemember.Text;

            hapus.Parameters.Add(idmember);

            hapus.ExecuteNonQuery();
            {
                this.l_memberTableAdapter.Fill(ds_member.l_member);
            }
            conn.Close();

            btnSimpan.Enabled = false;
            btnTambah.Enabled = true;

            reset();

            tbKodemember.Enabled = false;
            tbNama.Enabled = false;
            dpTgldaftar.Enabled = false;
            cbJk.Enabled = false;
            tbNohp.Enabled = false;
            tbAlamat.Enabled = false;
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {

            conn.Open();
            SqlCommand update = new SqlCommand();
            update.Connection = conn;
            update.CommandText = "updatemember";
            update.CommandType = CommandType.StoredProcedure;

            SqlParameter idmember = new SqlParameter("@id_member", SqlDbType.VarChar);
            SqlParameter namammeber = new SqlParameter("@nama", SqlDbType.VarChar);
            SqlParameter tgldaftar = new SqlParameter("@tgl_daftar", SqlDbType.Date);
            SqlParameter jk = new SqlParameter("@jenis_kelamin", SqlDbType.VarChar);
            SqlParameter nohp = new SqlParameter("@no_hp", SqlDbType.BigInt);
            SqlParameter alamat = new SqlParameter("@alamat", SqlDbType.VarChar);

            idmember.Value = tbUkodemember.Text;
            namammeber.Value = tbUnama.Text;
            tgldaftar.Value = dpUtgl.Text;
            jk.Value = cbUjk.Text;
            nohp.Value = tbUnohp.Text;
            alamat.Value = tbUalamat.Text;

            update.Parameters.Add(idmember);
            update.Parameters.Add(namammeber);
            update.Parameters.Add(tgldaftar);
            update.Parameters.Add(jk);
            update.Parameters.Add(nohp);
            update.Parameters.Add(alamat);

            update.ExecuteNonQuery();
            {
                this.l_memberTableAdapter.Fill(ds_member.l_member);
                gbAksi2.Visible = false;
            }
            conn.Close();

            btnSimpan.Enabled = false;

            reset();
        }

        private void gcDatamember_DoubleClick(object sender, EventArgs e)
        {
            gbAksi2.Visible = true;
        }
    }
}
