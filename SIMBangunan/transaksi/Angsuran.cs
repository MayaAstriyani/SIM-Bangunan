using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SIMBangunan.transaksi
{
    public partial class Angsuran : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=db_bangunan;Integrated Security=True;Pooling=False");

        int id;
        string id_angsuran_fix;

        public Angsuran()
        {
            InitializeComponent();
        }

        private void Angsuran_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_vlkredit.v_lkredit' table. You can move, or remove it, as needed.
            this.v_lkreditTableAdapter.Fill(this.ds_vlkredit.v_lkredit);
            // TODO: This line of code loads data into the 'ds_vangsuran.v_angsuran' table. You can move, or remove it, as needed.
            this.v_angsuranTableAdapter.Fill(this.ds_vangsuran.v_angsuran);
            // TODO: This line of code loads data into the 'ds_vkredit.v_kredit' table. You can move, or remove it, as needed.
            this.v_kreditTableAdapter.Fill(this.ds_vkredit.v_kredit);
            btnSimpan.Enabled = false;

            tbIdangsuran.Enabled = false;
            dtpTanggal.Enabled = false;
            cbPelanggan.Enabled = false;
            tbJml.Enabled = false;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            SqlCommand KodeSupplier = new SqlCommand("SELECT id_angsuran FROM l_angsuran order by right(id_angsuran, 3)", conn);

            conn.Open();
            SqlDataReader kodeSupplierList = KodeSupplier.ExecuteReader();

            while (kodeSupplierList.Read())
            {
                id = int.Parse(kodeSupplierList.GetValue(0).ToString().Replace("KRD-", ""));
            }

            conn.Close();

            if (id < 9)
            {
                id_angsuran_fix = "KRD-00" + (id + 1).ToString();
            }

            else if (id < 99)
            {
                id_angsuran_fix = "KRD-0" + (id + 1).ToString();
            }

            else if (id >= 99)
            {
                id_angsuran_fix = "KRD-" + (id + 1).ToString();
            }

            btnSimpan.Enabled = true;
            btnBatal.Enabled = true;
            btnTambah.Enabled = false;

            tbIdangsuran.Enabled = false;
            dtpTanggal.Enabled = true;
            cbPelanggan.Enabled = true;
            tbJml.Enabled = true;

            tbIdangsuran.Text = id_angsuran_fix;
            dtpTanggal.Text = "";
            cbPelanggan.Text = "";
            tbJml.Text = "";
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand simpan = new SqlCommand();
            simpan.Connection = conn;
            simpan.CommandText = "saveangsuran";
            simpan.CommandType = CommandType.StoredProcedure;

            SqlParameter idangsuran = new SqlParameter("@id_angsuran", SqlDbType.VarChar);
            SqlParameter tanggal = new SqlParameter("@tanggal", SqlDbType.Date);
            SqlParameter pelanggan = new SqlParameter("@id_member", SqlDbType.VarChar);
            SqlParameter jumlah = new SqlParameter("@jml_angsuran", SqlDbType.Int);

            idangsuran.Value = tbIdangsuran.Text;
            tanggal.Value = dtpTanggal.Text;
            pelanggan.Value = cbPelanggan.SelectedValue;
            jumlah.Value = tbJml.Text;

            simpan.Parameters.Add(idangsuran);
            simpan.Parameters.Add(tanggal);
            simpan.Parameters.Add(pelanggan);
            simpan.Parameters.Add(jumlah);

            simpan.ExecuteNonQuery();
            {
                this.v_angsuranTableAdapter.Fill(ds_vangsuran.v_angsuran);
            }
            conn.Close();

            btnSimpan.Enabled = false;
            btnTambah.Enabled = true;

            tbIdangsuran.Text = "";
            dtpTanggal.Text = "";
            cbPelanggan.Text = "";
            tbJml.Text = "";

            tbIdangsuran.Enabled = false;
            dtpTanggal.Enabled = false;
            cbPelanggan.Enabled = false;
            tbJml.Enabled = false;
        }
    }
}
