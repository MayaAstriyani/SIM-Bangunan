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
    public partial class Pembelian : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=db_bangunan;Integrated Security=True;Pooling=False");

        int id;
        string id_faktur_fix;

        private void reset()
        {
            tbNofaktur.Text = "";
            dtpTanggal.Text = "";
            cbSupplier.Text = "";
            cbBarang.Text = "";
            tbHarga.Text = "";
            tbJumlah.Text = "";
            tbTotalharga.Text = "";
        }

        private void ebutton()
        {
            tbNofaktur.Enabled = false;
            dtpTanggal.Enabled = false;
            cbSupplier.Enabled = false;
            cbBarang.Enabled = false;
            tbHarga.Enabled = false;
            tbJumlah.Enabled = false;
            tbTotalharga.Enabled = false;
        }

        public Pembelian()
        {
            InitializeComponent();
        }

        private void Pembelian_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't_pembelian1.v_pembelian' table. You can move, or remove it, as needed.
            this.v_pembelianTableAdapter.Fill(this.t_vpembelian1.v_pembelian);
            // TODO: This line of code loads data into the 't_lbarang.l_barang' table. You can move, or remove it, as needed.
            this.l_barangTableAdapter1.Fill(this.t_lbarang.l_barang);
            // TODO: This line of code loads data into the 't_supplier.l_supplier' table. You can move, or remove it, as needed.
            this.l_supplierTableAdapter.Fill(this.t_supplier.l_supplier);

            btnSimpan.Enabled = false;

            ebutton();

            gbAksi2.Visible = false;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            SqlCommand NoFaktur = new SqlCommand("SELECT no_faktur FROM l_pembelian order by right(no_faktur, 6)", conn);

            conn.Open();
            SqlDataReader NoFakturList = NoFaktur.ExecuteReader();

            while (NoFakturList.Read())
            {
                id = int.Parse(NoFakturList.GetValue(0).ToString().Replace("FKTRPM", ""));
            }

            conn.Close();

            if (id < 9)
            {
                id_faktur_fix = "FKTRPM0000" + (id + 1).ToString();
            }

            else if (id < 99)
            {
                id_faktur_fix = "FKTRPM000" + (id + 1).ToString();
            }

            else if (id >= 99)
            {
                id_faktur_fix = "FKTRPM00" + (id + 1).ToString();
            }

            btnSimpan.Enabled = true;
            btnBatal.Enabled = true;
            btnTambah.Enabled = false;

            tbNofaktur.Enabled = false;
            dtpTanggal.Enabled = true;
            cbSupplier.Enabled = true;
            cbBarang.Enabled = true;
            tbHarga.Enabled = true;
            tbJumlah.Enabled = true;
            tbTotalharga.Enabled = false;

            tbNofaktur.Text = id_faktur_fix;
            dtpTanggal.Text = "";
            cbSupplier.Text = "";
            cbBarang.Text = "";
            tbHarga.Text = "";
            tbJumlah.Text = "";
            tbTotalharga.Text = "";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            int a = int.Parse(tbJumlah.Text);
            int b = int.Parse(tbHarga.Text);
            int total_pembayaran = a * b;

            conn.Open();
            SqlCommand simpan = new SqlCommand();
            simpan.Connection = conn;
            simpan.CommandText = "savepembelian";
            simpan.CommandType = CommandType.StoredProcedure;

            SqlParameter nofaktur = new SqlParameter("@no_faktur", SqlDbType.VarChar);
            SqlParameter tanggal = new SqlParameter("@tanggal", SqlDbType.DateTime);
            SqlParameter idsupplier = new SqlParameter("@id_supplier", SqlDbType.VarChar);
            SqlParameter idbarang = new SqlParameter("@id_barang", SqlDbType.VarChar);
            SqlParameter hargabeli = new SqlParameter("@harga_beli", SqlDbType.Int);
            SqlParameter jumlah = new SqlParameter("@jumlah", SqlDbType.Int);
            SqlParameter totalharga = new SqlParameter("@total_harga", SqlDbType.Int);

            nofaktur.Value = tbNofaktur.Text;
            tanggal.Value = dtpTanggal.Text;
            idsupplier.Value = cbSupplier.SelectedValue;
            idbarang.Value = cbBarang.SelectedValue;
            jumlah.Value = tbJumlah.Text;
            hargabeli.Value = tbHarga.Text;
            totalharga.Value = Convert.ToString(total_pembayaran);

            simpan.Parameters.Add(nofaktur);
            simpan.Parameters.Add(tanggal);
            simpan.Parameters.Add(idsupplier);
            simpan.Parameters.Add(idbarang);
            simpan.Parameters.Add(jumlah);
            simpan.Parameters.Add(hargabeli);
            simpan.Parameters.Add(totalharga);

            simpan.ExecuteNonQuery();
            {
                this.v_pembelianTableAdapter.Fill(t_vpembelian1.v_pembelian);
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
            hapus.CommandText = "deletepembelian";
            hapus.CommandType = CommandType.StoredProcedure;

            SqlParameter nofaktur = new SqlParameter("@no_faktur", SqlDbType.VarChar);

            nofaktur.Value = tbFakturupdate.Text;

            hapus.Parameters.Add(nofaktur);

            hapus.ExecuteNonQuery();
            {
                this.v_pembelianTableAdapter.Fill(t_vpembelian1.v_pembelian);
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
            int a = int.Parse(tbJumlahu.Text);
            int b = int.Parse(tbHargau.Text);
            int total_pembayaran = a * b;

            conn.Open();
            SqlCommand ubah = new SqlCommand();
            ubah.Connection = conn;
            ubah.CommandText = "updatepembelian";
            ubah.CommandType = CommandType.StoredProcedure;

            SqlParameter nofaktur = new SqlParameter("@no_faktur", SqlDbType.VarChar);
            SqlParameter tanggal = new SqlParameter("@tanggal", SqlDbType.DateTime);
            SqlParameter idsupplier = new SqlParameter("@id_supplier", SqlDbType.VarChar);
            SqlParameter idbarang = new SqlParameter("@id_barang", SqlDbType.VarChar);
            SqlParameter hargabeli = new SqlParameter("@harga_beli", SqlDbType.Int);
            SqlParameter jumlah = new SqlParameter("@jumlah", SqlDbType.Int);
            SqlParameter totalharga = new SqlParameter("@total_harga", SqlDbType.Int);

            nofaktur.Value = tbFakturupdate.Text;
            tanggal.Value = dtpUpdate.Text;
            idsupplier.Value = cbSupplieru.SelectedValue;
            idbarang.Value = cbBarangu.SelectedValue;
            jumlah.Value = tbJumlahu.Text;
            hargabeli.Value = tbHargau.Text;
            totalharga.Value = Convert.ToString(total_pembayaran);

            ubah.Parameters.Add(nofaktur);
            ubah.Parameters.Add(tanggal);
            ubah.Parameters.Add(idsupplier);
            ubah.Parameters.Add(idbarang);
            ubah.Parameters.Add(jumlah);
            ubah.Parameters.Add(hargabeli);
            ubah.Parameters.Add(totalharga);

            ubah.ExecuteNonQuery();
            {
                this.v_pembelianTableAdapter.Fill(t_vpembelian1.v_pembelian);
                gbAksi2.Visible = false;
            }
            conn.Close();

            btnSimpan.Enabled = false;
            btnTambah.Enabled = true;

            reset();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            gbAksi2.Visible = true;
        }

    }
}
