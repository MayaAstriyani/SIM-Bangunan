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
    public partial class Satuan : Form
    {
        
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=db_bangunan;Integrated Security=True;Pooling=False");

        int id;
        string id_satuan_fix;

        public Satuan()
        {
            InitializeComponent();
        }

        private void reset() {
            tbKodesatuan.Text = "";
            tbSatuan.Text     = "";
        }

        private void Satuan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_satuan3.l_satuan' table. You can move, or remove it, as needed.
            this.l_satuanTableAdapter.Fill(this.ds_satuan.l_satuan);

            btnSimpan.Enabled = false;

            tbKodesatuan.Enabled = false;
            tbSatuan.Enabled = false;

            gbAksi2.Visible = false;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            SqlCommand KodeSatuan = new SqlCommand("SELECT id_satuan FROM l_satuan order by right(id_satuan, 3)", conn);

            conn.Open();
            SqlDataReader kodeSatuanList = KodeSatuan.ExecuteReader();

            while (kodeSatuanList.Read())
            {
                id = int.Parse(kodeSatuanList.GetValue(0).ToString().Replace("SBR-", ""));
            }

            conn.Close();

            if (id < 9)
            {
                id_satuan_fix = "SBR-00" + (id + 1).ToString();
            }

            else if (id < 99)
            {
                id_satuan_fix = "SBR-0" + (id + 1).ToString();
            }

            else if (id >= 99)
            {
                id_satuan_fix = "SBR-" + (id + 1).ToString();
            }

            btnSimpan.Enabled = true;
            btnBatal.Enabled = true;
            btnTambah.Enabled = false;

            tbKodesatuan.Enabled = false;
            tbSatuan.Enabled = true;

            tbKodesatuan.Text = id_satuan_fix;
            tbSatuan.Text = "";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand simpan = new SqlCommand();
            simpan.Connection = conn;
            simpan.CommandText = "savesatuan";
            simpan.CommandType = CommandType.StoredProcedure;

            SqlParameter idsatuan = new SqlParameter("@id_satuan", SqlDbType.VarChar);
            SqlParameter namasatuan = new SqlParameter("@nama_satuan", SqlDbType.VarChar);

            idsatuan.Value = tbKodesatuan.Text;
            namasatuan.Value = tbSatuan.Text;

            simpan.Parameters.Add(idsatuan);
            simpan.Parameters.Add(namasatuan);

            simpan.ExecuteNonQuery();
            {
                this.l_satuanTableAdapter.Fill(ds_satuan.l_satuan);
            }
            conn.Close();

            btnSimpan.Enabled = false;
            btnTambah.Enabled = true;

            reset();

            tbKodesatuan.Enabled = false;
            tbSatuan.Enabled = false;
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand hapus = new SqlCommand();
            hapus.Connection = conn;
            hapus.CommandText = "deletesatuan";
            hapus.CommandType = CommandType.StoredProcedure;

            SqlParameter idsatuan = new SqlParameter("@id_satuan", SqlDbType.VarChar);

            idsatuan.Value = tbKodeupdate.Text;

            hapus.Parameters.Add(idsatuan);

            hapus.ExecuteNonQuery();
            {
                this.l_satuanTableAdapter.Fill(ds_satuan.l_satuan);
            }
            conn.Close();

            btnSimpan.Enabled = false;
            btnTambah.Enabled = true;

            reset();

            tbKodesatuan.Enabled = false;
            tbSatuan.Enabled = false;
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
            update.CommandText = "updatesatuan";
            update.CommandType = CommandType.StoredProcedure;

            SqlParameter idsatuan = new SqlParameter("@id_satuan", SqlDbType.VarChar);
            SqlParameter namasatuan = new SqlParameter("@nama_satuan", SqlDbType.VarChar);

            idsatuan.Value = tbKodeupdate.Text;
            namasatuan.Value = tbSatuanupdate.Text;

            update.Parameters.Add(idsatuan);
            update.Parameters.Add(namasatuan);

            update.ExecuteNonQuery();
            {
                this.l_satuanTableAdapter.Fill(ds_satuan.l_satuan);
                gbAksi2.Visible = false;
                btnTambah.Enabled = true;
                btnHapus.Enabled = true;
                btnBatal.Enabled = true;
                btnSimpan.Enabled = false;
            }
            conn.Close();

            reset();
        }

        private void gcDatasatuan_DoubleClick_1(object sender, EventArgs e)
        {
            btnTambah.Enabled = false;
            btnHapus.Enabled = false;
            btnBatal.Enabled = false;
            btnSimpan.Enabled = false;
            gbAksi2.Visible = true;
        }
    }
}
