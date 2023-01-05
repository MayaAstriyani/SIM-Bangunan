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
    public partial class Jenis : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=db_bangunan;Integrated Security=True;Pooling=False");

        int id;
        string id_jenis_fix;

        public Jenis()
        {
            InitializeComponent();
        }

        private void reset() {
            tbKodejenis.Text = "";
            tbJenis.Text     = "";
        }

        private void Jenis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_jenis.l_jenis' table. You can move, or remove it, as needed.
            this.l_jenisTableAdapter.Fill(this.ds_jenis.l_jenis);

            btnSimpan.Enabled = false;

            tbKodejenis.Enabled = false;
            tbJenis.Enabled = false;

            gbAksi2.Visible = false;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            SqlCommand KodeJenis = new SqlCommand("SELECT id_jenis FROM l_jenis order by right(id_jenis, 3)", conn);

            conn.Open();
            SqlDataReader kodeJenisList = KodeJenis.ExecuteReader();

            while (kodeJenisList.Read())
            {
                id = int.Parse(kodeJenisList.GetValue(0).ToString().Replace("JBR-", ""));
            }

            conn.Close();

            if (id < 9)
            {
                id_jenis_fix = "JBR-00" + (id + 1).ToString();
            }

            else if (id < 99)
            {
                id_jenis_fix = "JBR-0" + (id + 1).ToString();
            }

            else if (id >= 99)
            {
                id_jenis_fix = "JBR-" + (id + 1).ToString();
            }

            btnSimpan.Enabled = true;
            btnBatal.Enabled = true;
            btnTambah.Enabled = false;

            tbKodejenis.Enabled = false;
            tbJenis.Enabled = true;

            tbKodejenis.Text = id_jenis_fix;
            tbJenis.Text = "";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand simpan = new SqlCommand();
            simpan.Connection = conn;
            simpan.CommandText = "savejenis";
            simpan.CommandType = CommandType.StoredProcedure;

            SqlParameter idjenis = new SqlParameter("@id_jenis", SqlDbType.VarChar);
            SqlParameter namajenis = new SqlParameter("@nama_jenis", SqlDbType.VarChar);

            idjenis.Value = tbKodejenis.Text;
            namajenis.Value = tbJenis.Text;

            simpan.Parameters.Add(idjenis);
            simpan.Parameters.Add(namajenis);

            simpan.ExecuteNonQuery();
            {
                this.l_jenisTableAdapter.Fill(ds_jenis.l_jenis);
            }
            conn.Close();

            btnSimpan.Enabled = false;
            btnTambah.Enabled = true;

            reset();

            tbKodejenis.Enabled = false;
            tbJenis.Enabled = false;
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand hapus = new SqlCommand();
            hapus.Connection = conn;
            hapus.CommandText = "deletejenis";
            hapus.CommandType = CommandType.StoredProcedure;

            SqlParameter idjenis = new SqlParameter("@id_jenis", SqlDbType.VarChar);

            idjenis.Value = tbKodeupdate.Text;

            hapus.Parameters.Add(idjenis);

            hapus.ExecuteNonQuery();
            {
                this.l_jenisTableAdapter.Fill(ds_jenis.l_jenis);
            }
            conn.Close();

            btnSimpan.Enabled = false;
            btnTambah.Enabled = true;

            reset();

            tbKodejenis.Enabled = false;
            tbJenis.Enabled = false;
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
            update.CommandText = "updatejenis";
            update.CommandType = CommandType.StoredProcedure;

            SqlParameter idjenis = new SqlParameter("@id_jenis", SqlDbType.VarChar);
            SqlParameter namajenis = new SqlParameter("@nama_jenis", SqlDbType.VarChar);

            idjenis.Value = tbKodeupdate.Text;
            namajenis.Value = tbJenisupdate.Text;

            update.Parameters.Add(idjenis);
            update.Parameters.Add(namajenis);

            update.ExecuteNonQuery();
            {
                this.l_jenisTableAdapter.Fill(ds_jenis.l_jenis);
                gbAksi2.Visible = false;
                btnTambah.Enabled = true;
                btnHapus.Enabled = true;
                btnBatal.Enabled = true;
                btnSimpan.Enabled = false;
            }
            conn.Close();

            reset();
        }

        private void gcDatajenis_DoubleClick(object sender, EventArgs e)
        {
            btnTambah.Enabled = false;
            btnHapus.Enabled = false;
            btnBatal.Enabled = false;
            btnSimpan.Enabled = false;
            gbAksi2.Visible = true;
        }
    }
}
