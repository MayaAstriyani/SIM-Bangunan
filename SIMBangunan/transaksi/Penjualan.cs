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
    public partial class Penjualan : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=db_bangunan;Integrated Security=True;Pooling=False");

        private void reset()
        {
            tbNofaktur.Text = "";
            tbPelanggan.Text = "";
            dtpTanggal.Text = "";
            tbNamabarang.Text = "";
            tbHargajual.Text = "";
            tbJumlah.Text = "";
            tbSubtotal.Text = "";
            cbPembayaran.Text = "";
            tbBayar.Text = "";
            tbKembalian.Text = "";
        }

        public Penjualan()
        {
            InitializeComponent();
        }

        private void Penjualan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_lmember1.l_member' table. You can move, or remove it, as needed.
            this.l_memberTableAdapter1.Fill(this.ds_lmember1.l_member);
            // TODO: This line of code loads data into the 'ds_lpbarang1.l_barang' table. You can move, or remove it, as needed.
            this.l_barangTableAdapter2.Fill(this.ds_lpbarang1.l_barang);
            // TODO: This line of code loads data into the 't_penjualan.v_penjualan' table. You can move, or remove it, as needed.
            this.v_penjualanTableAdapter.Fill(this.dst_penjualan.v_penjualan);

            gbCaribarang.Visible = false;
            gbCaripelanggan.Visible = false;
        }


        private void btnSimpan_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand simpan = new SqlCommand();
            simpan.Connection = conn;
            simpan.CommandText = "savepenjualan";
            simpan.CommandType = CommandType.StoredProcedure;

            SqlParameter nofaktur = new SqlParameter("@no_faktur", SqlDbType.VarChar);
            SqlParameter pelanggan = new SqlParameter("@id_member", SqlDbType.VarChar);
            SqlParameter tanggal = new SqlParameter("@tanggal", SqlDbType.DateTime);
            SqlParameter idbarang = new SqlParameter("@id_barang", SqlDbType.VarChar);
            SqlParameter hargajual = new SqlParameter("@harga_jual", SqlDbType.Int);
            SqlParameter jumlah = new SqlParameter("@jumlah", SqlDbType.Int);
            SqlParameter subtotal = new SqlParameter("@sub_total", SqlDbType.Int);
            SqlParameter pembayaran = new SqlParameter("@pembayaran", SqlDbType.VarChar);
            SqlParameter jmlbayar = new SqlParameter("@jml_bayar", SqlDbType.Int);
            SqlParameter kembalian = new SqlParameter("@kembalian", SqlDbType.Int);

            nofaktur.Value = tbNofaktur.Text;
            pelanggan.Value = tbPelanggan.Text;
            tanggal.Value = dtpTanggal.Text;
            idbarang.Value = tbNamabarang.Text;
            hargajual.Value = tbHargajual.Text;
            jumlah.Value = tbJumlah.Text;
            subtotal.Value = tbSubtotal.Text;
            pembayaran.Value = cbPembayaran.Text;
            jmlbayar.Value = tbBayar.Text;
            kembalian.Value = tbKembalian.Text;

            simpan.Parameters.Add(nofaktur);
            simpan.Parameters.Add(pelanggan);
            simpan.Parameters.Add(tanggal);
            simpan.Parameters.Add(idbarang);
            simpan.Parameters.Add(hargajual);
            simpan.Parameters.Add(jumlah);
            simpan.Parameters.Add(subtotal);
            simpan.Parameters.Add(pembayaran);
            simpan.Parameters.Add(jmlbayar);
            simpan.Parameters.Add(kembalian);

            simpan.ExecuteNonQuery();
            {
                this.v_penjualanTableAdapter.Fill(dst_penjualan.v_penjualan);
            }
            conn.Close();

            reset();
        }


        private void btnBatal_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void gcDatabarang_DoubleClick(object sender, EventArgs e)
        {
            //gbAksi2.Visible = true;
        }


        private void gridControl1_Click(object sender, EventArgs e)
        {
            gbCaripelanggan.Visible = false;
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {
            gbCaribarang.Visible = false;
        }

        private void tbPelanggan_DoubleClick(object sender, EventArgs e)
        {
            gbCaripelanggan.Visible = true;
        }

        private void tbNamabarang_DoubleClick(object sender, EventArgs e)
        {
            gbCaribarang.Visible = true;
        }

        private void tbSubtotal_Click(object sender, EventArgs e)
        {
            int a = int.Parse(tbJumlah.Text);
            int b = int.Parse(tbHargajual.Text);
            int total_pembayaran = a * b;
            tbSubtotal.Text = Convert.ToString(total_pembayaran);
        }

        private void tbKembalian_Click(object sender, EventArgs e)
        {
            int a = int.Parse(tbSubtotal.Text);
            int b = int.Parse(tbBayar.Text);
            int total_kembalian = b - a;
            tbKembalian.Text = Convert.ToString(total_kembalian);
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            laporan.Perdata a = new laporan.Perdata(lFaktur.Text);
            a.ShowPreview();
        }

    }
}
