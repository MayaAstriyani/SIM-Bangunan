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
    public partial class Supplier : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=db_bangunan;Integrated Security=True;Pooling=False");

        int id;
        string id_supplier_fix;

        public Supplier()
        {
            InitializeComponent();
        }

        private void gbDatasupplier_Enter(object sender, EventArgs e)
        {

        }

        private void reset() {
            tbKodesupplier.Text = "";
            tbNamasupplier.Text = "";
            tbAlamat.Text       = "";
            tbNotelp.Text       = "";
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsSupplier.l_supplier' table. You can move, or remove it, as needed.
            this.l_supplierTableAdapter.Fill(this.ds_supplier.l_supplier);
            btnSimpan.Enabled = false;

            tbKodesupplier.Enabled = false;
            tbNamasupplier.Enabled = false;
            tbAlamat.Enabled = false;
            tbNotelp.Enabled = false;

            gbAksi2.Visible = false;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            SqlCommand KodeSupplier = new SqlCommand("SELECT id_supplier FROM l_supplier order by right(id_supplier, 3)", conn);

            conn.Open();
            SqlDataReader kodeSupplierList = KodeSupplier.ExecuteReader();

            while (kodeSupplierList.Read())
            {
                id = int.Parse(kodeSupplierList.GetValue(0).ToString().Replace("SUP-", ""));
            }

            conn.Close();

            if (id < 9)
            {
                id_supplier_fix = "SUP-00" + (id + 1).ToString();
            }

            else if (id < 99)
            {
                id_supplier_fix = "SUP-0" + (id + 1).ToString();
            }

            else if (id >= 99)
            {
                id_supplier_fix = "SUP-" + (id + 1).ToString();
            }

            btnSimpan.Enabled = true;
            btnBatal.Enabled = true;
            btnTambah.Enabled = false;

            tbKodesupplier.Enabled = false;
            tbNamasupplier.Enabled = true;
            tbAlamat.Enabled = true;
            tbNotelp.Enabled = true;

            tbKodesupplier.Text = id_supplier_fix;
            tbNamasupplier.Text = "";
            tbAlamat.Text = "";
            tbNotelp.Text = "";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand simpan = new SqlCommand();
            simpan.Connection = conn;
            simpan.CommandText = "savesupplier";
            simpan.CommandType = CommandType.StoredProcedure;

            SqlParameter idsupplier = new SqlParameter("@id_supplier", SqlDbType.VarChar);
            SqlParameter namasupplier = new SqlParameter("@nama_supplier", SqlDbType.VarChar);
            SqlParameter alamat = new SqlParameter("@alamat", SqlDbType.VarChar);
            SqlParameter notelp = new SqlParameter("@no_telp", SqlDbType.VarChar);

            idsupplier.Value = tbKodesupplier.Text;
            namasupplier.Value = tbNamasupplier.Text;
            alamat.Value = tbAlamat.Text;
            notelp.Value = tbNotelp.Text;

            simpan.Parameters.Add(idsupplier);
            simpan.Parameters.Add(namasupplier);
            simpan.Parameters.Add(alamat);
            simpan.Parameters.Add(notelp);

            simpan.ExecuteNonQuery();
            {
                this.l_supplierTableAdapter.Fill(ds_supplier.l_supplier);
            }
            conn.Close();

            btnSimpan.Enabled = false;
            btnTambah.Enabled = true;

            reset();

            tbKodesupplier.Enabled = false;
            tbNamasupplier.Enabled = false;
            tbAlamat.Enabled = false;
            tbNotelp.Enabled = false;
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand hapus = new SqlCommand();
            hapus.Connection = conn;
            hapus.CommandText = "deletesupplier";
            hapus.CommandType = CommandType.StoredProcedure;

            SqlParameter idsupplier = new SqlParameter("@id_supplier", SqlDbType.VarChar);

            idsupplier.Value = tbKodeupdate.Text;

            hapus.Parameters.Add(idsupplier);

            hapus.ExecuteNonQuery();
            {
                this.l_supplierTableAdapter.Fill(ds_supplier.l_supplier);
            }
            conn.Close();

            btnSimpan.Enabled = false;
            btnTambah.Enabled = true;

            reset();

            tbKodesupplier.Enabled = false;
            tbNamasupplier.Enabled = false;
            tbAlamat.Enabled = false;
            tbNotelp.Enabled = false;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();

            //reset();

            //btnTambah.Enabled = true;
            //btnSimpan.Enabled = false;
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand update = new SqlCommand();
            update.Connection = conn;
            update.CommandText = "updatesupplier";
            update.CommandType = CommandType.StoredProcedure;

            SqlParameter idsupplier = new SqlParameter("@id_supplier", SqlDbType.VarChar);
            SqlParameter namasupplier = new SqlParameter("@nama_supplier", SqlDbType.VarChar);
            SqlParameter alamat = new SqlParameter("@alamat", SqlDbType.VarChar);
            SqlParameter notelp = new SqlParameter("@no_telp", SqlDbType.VarChar);

            idsupplier.Value = tbKodeupdate.Text;
            namasupplier.Value = tbNamaupdate.Text;
            alamat.Value = tbAlamatupdate.Text;
            notelp.Value = tbTelpupdate.Text;

            update.Parameters.Add(idsupplier);
            update.Parameters.Add(namasupplier);
            update.Parameters.Add(alamat);
            update.Parameters.Add(notelp);

            update.ExecuteNonQuery();
            {
                this.l_supplierTableAdapter.Fill(ds_supplier.l_supplier);
                gbAksi2.Visible = false;
            }
            conn.Close();

            btnSimpan.Enabled = false;

            reset();
        }

        private void gcDatasupplier_DoubleClick(object sender, EventArgs e)
        {
            gbAksi2.Visible = true;
        }
    }
}
