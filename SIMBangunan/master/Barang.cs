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
    public partial class Barang : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=db_bangunan;Integrated Security=True;Pooling=False");

        int id;
        string id_barang_fix;

        private void reset()
        {
            tbKodebarang.Text = "";
            tbNamabarang.Text = "";
            cbJenis.Text = "";
            cbSatuan.Text = "";
            tbStok.Text = "";
            tbHargabeli.Text = "";
            tbHargajual.Text = "";
        }

        private void ebutton()
        {
            tbKodebarang.Enabled = false;
            tbNamabarang.Enabled = false;
            cbJenis.Enabled = false;
            cbSatuan.Enabled = false;
            tbStok.Enabled = false;
            tbHargabeli.Enabled = false;
            tbHargajual.Enabled = false;
        }

        public Barang()
        {
            InitializeComponent();
        }

        private void Barang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_lbarang.l_barang' table. You can move, or remove it, as needed.
            //this.l_barangTableAdapter.Fill(this.ds_lbarang.l_barang);
            // TODO: This line of code loads data into the 'ds_jenis1.l_jenis' table. You can move, or remove it, as needed.
            this.l_jenisTableAdapter1.Fill(this.ds_jenis1.l_jenis);
            // TODO: This line of code loads data into the 'ds_satuan1.l_satuan' table. You can move, or remove it, as needed.
            this.l_satuanTableAdapter1.Fill(this.ds_satuan1.l_satuan);
            // TODO: This line of code loads data into the 'ds_ljenis.l_jenis' table. You can move, or remove it, as needed.
            //this.l_jenisTableAdapter.Fill(this.ds_ljenis.l_jenis);
            // TODO: This line of code loads data into the 'ds_lsatuan.l_satuan' table. You can move, or remove it, as needed.
            //this.l_satuanTableAdapter.Fill(this.ds_lsatuan.l_satuan);
            // TODO: This line of code loads data into the 'ds_vbarang.v_barang' table. You can move, or remove it, as needed.
            this.v_barangTableAdapter.Fill(this.ds_vbarang1.v_barang);

            btnSimpan.Enabled = false;

            ebutton();

            gbAksi2.Visible = false;

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            SqlCommand KodeBarang = new SqlCommand("SELECT id_barang FROM l_barang order by right(id_barang, 3)", conn);

            conn.Open();
            SqlDataReader kodeBarangList = KodeBarang.ExecuteReader();

            while (kodeBarangList.Read())
            {
                id = int.Parse(kodeBarangList.GetValue(0).ToString().Replace("BRG-", ""));
            }

            conn.Close();

            if (id < 9)
            {
                id_barang_fix = "BRG-00" + (id + 1).ToString();
            }

            else if (id < 99)
            {
                id_barang_fix = "BRG-0" + (id + 1).ToString();
            }

            else if (id >= 99)
            {
                id_barang_fix = "BRG-" + (id + 1).ToString();
            }

            btnSimpan.Enabled = true;
            btnBatal.Enabled = true;
            btnTambah.Enabled = false;

            tbKodebarang.Enabled = false;
            tbNamabarang.Enabled = true;
            cbJenis.Enabled = true;
            cbSatuan.Enabled = true;
            tbStok.Enabled = true;
            tbHargabeli.Enabled = true;
            tbHargajual.Enabled = true;

            tbKodebarang.Text = id_barang_fix;
            tbNamabarang.Text = "";
            cbJenis.Text = "";
            cbSatuan.Text = "";
            tbStok.Text = "";
            tbHargabeli.Text = "";
            tbHargajual.Text = "";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand simpan = new SqlCommand();
            simpan.Connection = conn;
            simpan.CommandText = "savebarang";
            simpan.CommandType = CommandType.StoredProcedure;

            SqlParameter idbarang = new SqlParameter("@id_barang", SqlDbType.VarChar);
            SqlParameter namabarang = new SqlParameter("@nama_barang", SqlDbType.VarChar);
            SqlParameter idsatuan = new SqlParameter("@id_satuan", SqlDbType.VarChar);
            SqlParameter idjenis = new SqlParameter("@id_jenis", SqlDbType.VarChar);
            SqlParameter stok = new SqlParameter("@stok", SqlDbType.Int);
            SqlParameter hargabeli = new SqlParameter("@harga_beli", SqlDbType.Int);
            SqlParameter hargajual = new SqlParameter("@harga_jual", SqlDbType.Int);

            idbarang.Value = tbKodebarang.Text;
            namabarang.Value = tbNamabarang.Text;
            idsatuan.Value = cbSatuan.SelectedValue;
            idjenis.Value = cbJenis.SelectedValue;
            stok.Value = tbStok.Text;
            hargabeli.Value = tbHargabeli.Text;
            hargajual.Value = tbHargajual.Text;

            simpan.Parameters.Add(idbarang);
            simpan.Parameters.Add(namabarang);
            simpan.Parameters.Add(idsatuan);
            simpan.Parameters.Add(idjenis);
            simpan.Parameters.Add(stok);
            simpan.Parameters.Add(hargabeli);
            simpan.Parameters.Add(hargajual);

            simpan.ExecuteNonQuery();
            {
                this.v_barangTableAdapter.Fill(ds_vbarang1.v_barang);
            }
            conn.Close();

            btnSimpan.Enabled = false;
            btnTambah.Enabled = true;

            reset();

            ebutton();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand hapus = new SqlCommand();
            hapus.Connection = conn;
            hapus.CommandText = "deletebarang";
            hapus.CommandType = CommandType.StoredProcedure;

            SqlParameter iduser = new SqlParameter("@id_barang", SqlDbType.VarChar);

            iduser.Value = tbKodeupdate.Text;

            hapus.Parameters.Add(iduser);

            hapus.ExecuteNonQuery();
            {
                this.v_barangTableAdapter.Fill(ds_vbarang1.v_barang);
            }
            conn.Close();

            btnSimpan.Enabled = false;
            btnTambah.Enabled = true;

            reset();

            ebutton();
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
            update.CommandText = "updatebarang";
            update.CommandType = CommandType.StoredProcedure;

            SqlParameter idbarang = new SqlParameter("@id_barang", SqlDbType.VarChar);
            SqlParameter namabarang = new SqlParameter("@nama_barang", SqlDbType.VarChar);
            SqlParameter idsatuan = new SqlParameter("@id_satuan", SqlDbType.VarChar);
            SqlParameter idjenis = new SqlParameter("@id_jenis", SqlDbType.VarChar);
            SqlParameter stok = new SqlParameter("@stok", SqlDbType.Int);
            SqlParameter hargabeli = new SqlParameter("@harga_beli", SqlDbType.Int);
            SqlParameter hargajual = new SqlParameter("@harga_jual", SqlDbType.Int);

            idbarang.Value = tbKodeupdate.Text;
            namabarang.Value = tbNamaupdate.Text;
            idsatuan.Value = cbSatuanupdate.SelectedValue;
            idjenis.Value = cbJenisupdate.SelectedValue;
            stok.Value = tbStokupdate.Text;
            hargabeli.Value = tbBeliupdate.Text;
            hargajual.Value = tbJualupdate.Text;

            update.Parameters.Add(idbarang);
            update.Parameters.Add(namabarang);
            update.Parameters.Add(idsatuan);
            update.Parameters.Add(idjenis);
            update.Parameters.Add(stok);
            update.Parameters.Add(hargabeli);
            update.Parameters.Add(hargajual);

            update.ExecuteNonQuery();
            {
                this.v_barangTableAdapter.Fill(ds_vbarang1.v_barang);
                gbAksi2.Visible = false;
            }
            conn.Close();

            btnSimpan.Enabled = false;

            reset();
        }

        private void gcDatabarang_DoubleClick(object sender, EventArgs e)
        {
            gbAksi2.Visible = true;
        }
    }
}
