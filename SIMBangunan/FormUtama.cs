using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace SIMBangunan
{
    public partial class frmUtama : XtraForm
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=db_bangunan;Integrated Security=True;Pooling=False");
        private SqlDataReader dr;

        public frmUtama()
        {
            InitializeComponent();
            InitSkinGallery();
            InitGrid();

        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }
        BindingList<Person> gridDataList = new BindingList<Person>();
        void InitGrid()
        {
        }

        private void btnUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            master.User user = new master.User();
            user.MdiParent = this;
            user.Show();
        }

        private void btnSupplier_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            master.Supplier supplier = new master.Supplier();
            supplier.MdiParent = this;
            supplier.Show();
        }

        private void btnJenis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            master.Jenis jenis = new master.Jenis();
            jenis.MdiParent = this;
            jenis.Show();
        }

        private void btnSatuan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            master.Satuan satuan = new master.Satuan();
            satuan.MdiParent = this;
            satuan.Show();
        }

        private void btnBarangbeli_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            transaksi.Pembelian pembelian = new transaksi.Pembelian();
            pembelian.MdiParent = this;
            pembelian.Show();
        }

        private void btnBelijual_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            transaksi.Penjualan penjualan = new transaksi.Penjualan();
            penjualan.MdiParent = this;
            penjualan.Show();
        }

        private void btnBarang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            master.Barang barang = new master.Barang();
            barang.MdiParent = this;
            barang.Show();
        }

        private void btnMember_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            master.Member member = new master.Member();
            member.MdiParent = this;
            member.Show();
        }

        private void btnPerbulan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            laporan.Perbulan a = new laporan.Perbulan();
            a.ShowPreview();
        }

        private void btnPertahun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            laporan.Pertahun a = new laporan.Pertahun();
            a.ShowPreview();
        }

        private void btnLaporanbln_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            laporan.Pembelianbulan a = new laporan.Pembelianbulan();
            a.ShowPreview();
        }

        private void btnLaporanthn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            laporan.Pembeliantahun a = new laporan.Pembeliantahun();
            a.ShowPreview();
        }

        private void btnPernama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            laporan.Pembelianbarang a = new laporan.Pembelianbarang();
            a.ShowPreview();
        }

        private void btnLbarang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            laporan.Stokbarang a = new laporan.Stokbarang();
            a.ShowPreview();
        }

        private void btnKredit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            laporan.Kredit a = new laporan.Kredit();
            a.ShowPreview();
        }

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pLogin.Visible = true;
            rpgLogin.Visible = false;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            tbUsername.Text = "";
            tbPassword.Text = "";
        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select username, password from l_user where username='"+tbUsername.Text+"' and password = '"+tbPassword.Text+"'", conn);
            dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.HasRows)
            {
                rpMaster.Visible = true;
                rpTransaksi.Visible = true;
                rpLaporan.Visible = true;
                pLogin.Visible = false;
                rpgLogin.Visible = false;
                rpgLogout.Visible = true;
                tbUsername.Text = "";
                tbPassword.Text = "";
                conn.Close();
            }
            else
            {
                MessageBox.Show("Username dan Password Salah!");
                conn.Close();
            }
        }

        private void frmUtama_Load(object sender, EventArgs e)
        {
            pLogin.Visible = false;
            rpgLogin.Visible = true;
            rpgLogout.Visible = false;
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rpgLogout.Visible = false;
            rpgLogin.Visible = true;
            rpMaster.Visible = false;
            rpTransaksi.Visible = false;
            rpLaporan.Visible = false;
        }

        private void btnAngsuran_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            transaksi.Angsuran angsuran = new transaksi.Angsuran();
            angsuran.MdiParent = this;
            angsuran.Show();
        }

        private void btnAngsuran2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            laporan.Angsuran a = new laporan.Angsuran();
            a.ShowPreview();
        }

    }
}