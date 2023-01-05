namespace SIMBangunan.master
{
    partial class Barang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbAksi1 = new System.Windows.Forms.GroupBox();
            this.btnBatal = new DevExpress.XtraEditors.SimpleButton();
            this.btnHapus = new DevExpress.XtraEditors.SimpleButton();
            this.btnSimpan = new DevExpress.XtraEditors.SimpleButton();
            this.btnTambah = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbNamabarang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbKodebarang = new System.Windows.Forms.TextBox();
            this.tbStok = new System.Windows.Forms.TextBox();
            this.tbHargabeli = new System.Windows.Forms.TextBox();
            this.tbHargajual = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSatuan = new System.Windows.Forms.ComboBox();
            this.lsatuanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ds_satuan1 = new SIMBangunan.ds_satuan1();
            this.cbJenis = new System.Windows.Forms.ComboBox();
            this.ljenisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ds_jenis1 = new SIMBangunan.ds_jenis1();
            this.gbAksi2 = new System.Windows.Forms.GroupBox();
            this.btnUbah = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbJenisupdate = new System.Windows.Forms.ComboBox();
            this.vbarangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ds_vbarang1 = new SIMBangunan.ds_vbarang();
            this.tbNamaupdate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbKodeupdate = new System.Windows.Forms.TextBox();
            this.tbStokupdate = new System.Windows.Forms.TextBox();
            this.tbBeliupdate = new System.Windows.Forms.TextBox();
            this.tbJualupdate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbSatuanupdate = new System.Windows.Forms.ComboBox();
            this.ljenisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lsatuanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbDatabarang = new System.Windows.Forms.GroupBox();
            this.gcDatabarang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_barang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnama_barang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnama_satuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnama_jenis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstok = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colharga_beli = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colharga_jual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_barangTableAdapter = new SIMBangunan.ds_vbarangTableAdapters.v_barangTableAdapter();
            this.l_satuanTableAdapter1 = new SIMBangunan.ds_satuan1TableAdapters.l_satuanTableAdapter();
            this.l_jenisTableAdapter1 = new SIMBangunan.ds_jenis1TableAdapters.l_jenisTableAdapter();
            this.gbAksi1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lsatuanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_satuan1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ljenisBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_jenis1)).BeginInit();
            this.gbAksi2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vbarangBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_vbarang1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ljenisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lsatuanBindingSource)).BeginInit();
            this.gbDatabarang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatabarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbarangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAksi1
            // 
            this.gbAksi1.Controls.Add(this.btnBatal);
            this.gbAksi1.Controls.Add(this.btnHapus);
            this.gbAksi1.Controls.Add(this.btnSimpan);
            this.gbAksi1.Controls.Add(this.btnTambah);
            this.gbAksi1.Controls.Add(this.tableLayoutPanel1);
            this.gbAksi1.Location = new System.Drawing.Point(12, 12);
            this.gbAksi1.Name = "gbAksi1";
            this.gbAksi1.Size = new System.Drawing.Size(386, 376);
            this.gbAksi1.TabIndex = 2;
            this.gbAksi1.TabStop = false;
            this.gbAksi1.Text = "Aksi";
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(287, 335);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 4;
            this.btnBatal.Text = "Batal";
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(193, 335);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(103, 335);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 2;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(10, 335);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 1;
            this.btnTambah.Text = "Tambah Baru";
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel1.Controls.Add(this.tbNamabarang, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbKodebarang, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbStok, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbHargabeli, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbHargajual, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.cbSatuan, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbJenis, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.39759F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.60241F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(352, 285);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbNamabarang
            // 
            this.tbNamabarang.Location = new System.Drawing.Point(115, 44);
            this.tbNamabarang.Multiline = true;
            this.tbNamabarang.Name = "tbNamabarang";
            this.tbNamabarang.Size = new System.Drawing.Size(234, 34);
            this.tbNamabarang.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Satuan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jenis";
            // 
            // tbKodebarang
            // 
            this.tbKodebarang.Enabled = false;
            this.tbKodebarang.Location = new System.Drawing.Point(115, 3);
            this.tbKodebarang.Multiline = true;
            this.tbKodebarang.Name = "tbKodebarang";
            this.tbKodebarang.Size = new System.Drawing.Size(234, 34);
            this.tbKodebarang.TabIndex = 4;
            // 
            // tbStok
            // 
            this.tbStok.Location = new System.Drawing.Point(115, 166);
            this.tbStok.Multiline = true;
            this.tbStok.Name = "tbStok";
            this.tbStok.Size = new System.Drawing.Size(234, 34);
            this.tbStok.TabIndex = 8;
            // 
            // tbHargabeli
            // 
            this.tbHargabeli.Location = new System.Drawing.Point(115, 207);
            this.tbHargabeli.Multiline = true;
            this.tbHargabeli.Name = "tbHargabeli";
            this.tbHargabeli.Size = new System.Drawing.Size(234, 34);
            this.tbHargabeli.TabIndex = 9;
            // 
            // tbHargajual
            // 
            this.tbHargajual.Location = new System.Drawing.Point(115, 248);
            this.tbHargajual.Multiline = true;
            this.tbHargajual.Name = "tbHargajual";
            this.tbHargajual.Size = new System.Drawing.Size(234, 34);
            this.tbHargajual.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Stok";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Harga Beli Satuan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Harga Jual Satuan";
            // 
            // cbSatuan
            // 
            this.cbSatuan.DataSource = this.lsatuanBindingSource1;
            this.cbSatuan.DisplayMember = "nama_satuan";
            this.cbSatuan.FormattingEnabled = true;
            this.cbSatuan.Location = new System.Drawing.Point(115, 86);
            this.cbSatuan.Name = "cbSatuan";
            this.cbSatuan.Size = new System.Drawing.Size(234, 21);
            this.cbSatuan.TabIndex = 14;
            this.cbSatuan.ValueMember = "id_satuan";
            // 
            // lsatuanBindingSource1
            // 
            this.lsatuanBindingSource1.DataMember = "l_satuan";
            this.lsatuanBindingSource1.DataSource = this.ds_satuan1;
            // 
            // ds_satuan1
            // 
            this.ds_satuan1.DataSetName = "ds_satuan1";
            this.ds_satuan1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbJenis
            // 
            this.cbJenis.DataSource = this.ljenisBindingSource1;
            this.cbJenis.DisplayMember = "nama_jenis";
            this.cbJenis.FormattingEnabled = true;
            this.cbJenis.Location = new System.Drawing.Point(115, 126);
            this.cbJenis.Name = "cbJenis";
            this.cbJenis.Size = new System.Drawing.Size(234, 21);
            this.cbJenis.TabIndex = 15;
            this.cbJenis.ValueMember = "id_jenis";
            // 
            // ljenisBindingSource1
            // 
            this.ljenisBindingSource1.DataMember = "l_jenis";
            this.ljenisBindingSource1.DataSource = this.ds_jenis1;
            // 
            // ds_jenis1
            // 
            this.ds_jenis1.DataSetName = "ds_jenis1";
            this.ds_jenis1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbAksi2
            // 
            this.gbAksi2.Controls.Add(this.btnUbah);
            this.gbAksi2.Controls.Add(this.tableLayoutPanel2);
            this.gbAksi2.Location = new System.Drawing.Point(12, 12);
            this.gbAksi2.Name = "gbAksi2";
            this.gbAksi2.Size = new System.Drawing.Size(386, 376);
            this.gbAksi2.TabIndex = 6;
            this.gbAksi2.TabStop = false;
            this.gbAksi2.Text = "Aksi";
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(10, 335);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(75, 23);
            this.btnUbah.TabIndex = 1;
            this.btnUbah.Text = "Simpan Ubah";
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel2.Controls.Add(this.cbJenisupdate, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.tbNamaupdate, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tbKodeupdate, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbStokupdate, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.tbBeliupdate, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.tbJualupdate, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.cbSatuanupdate, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(11, 30);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.39759F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.60241F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(352, 285);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cbJenisupdate
            // 
            this.cbJenisupdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbJenisupdate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vbarangBindingSource1, "nama_jenis", true));
            this.cbJenisupdate.DataSource = this.ljenisBindingSource1;
            this.cbJenisupdate.DisplayMember = "nama_jenis";
            this.cbJenisupdate.FormattingEnabled = true;
            this.cbJenisupdate.Location = new System.Drawing.Point(115, 132);
            this.cbJenisupdate.Name = "cbJenisupdate";
            this.cbJenisupdate.Size = new System.Drawing.Size(234, 21);
            this.cbJenisupdate.TabIndex = 15;
            this.cbJenisupdate.ValueMember = "id_jenis";
            // 
            // vbarangBindingSource1
            // 
            this.vbarangBindingSource1.DataMember = "v_barang";
            this.vbarangBindingSource1.DataSource = this.ds_vbarang1;
            // 
            // ds_vbarang1
            // 
            this.ds_vbarang1.DataSetName = "ds_vbarang";
            this.ds_vbarang1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbNamaupdate
            // 
            this.tbNamaupdate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vbarangBindingSource1, "nama_barang", true));
            this.tbNamaupdate.Location = new System.Drawing.Point(115, 44);
            this.tbNamaupdate.Multiline = true;
            this.tbNamaupdate.Name = "tbNamaupdate";
            this.tbNamaupdate.Size = new System.Drawing.Size(234, 34);
            this.tbNamaupdate.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Kode Barang";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Nama Barang";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Satuan";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Jenis";
            // 
            // tbKodeupdate
            // 
            this.tbKodeupdate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vbarangBindingSource1, "id_barang", true));
            this.tbKodeupdate.Enabled = false;
            this.tbKodeupdate.Location = new System.Drawing.Point(115, 3);
            this.tbKodeupdate.Multiline = true;
            this.tbKodeupdate.Name = "tbKodeupdate";
            this.tbKodeupdate.Size = new System.Drawing.Size(234, 34);
            this.tbKodeupdate.TabIndex = 4;
            // 
            // tbStokupdate
            // 
            this.tbStokupdate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vbarangBindingSource1, "stok", true));
            this.tbStokupdate.Location = new System.Drawing.Point(115, 166);
            this.tbStokupdate.Multiline = true;
            this.tbStokupdate.Name = "tbStokupdate";
            this.tbStokupdate.Size = new System.Drawing.Size(234, 34);
            this.tbStokupdate.TabIndex = 8;
            // 
            // tbBeliupdate
            // 
            this.tbBeliupdate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vbarangBindingSource1, "harga_beli", true));
            this.tbBeliupdate.Location = new System.Drawing.Point(115, 207);
            this.tbBeliupdate.Multiline = true;
            this.tbBeliupdate.Name = "tbBeliupdate";
            this.tbBeliupdate.Size = new System.Drawing.Size(234, 34);
            this.tbBeliupdate.TabIndex = 9;
            // 
            // tbJualupdate
            // 
            this.tbJualupdate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vbarangBindingSource1, "harga_jual", true));
            this.tbJualupdate.Location = new System.Drawing.Point(115, 248);
            this.tbJualupdate.Multiline = true;
            this.tbJualupdate.Name = "tbJualupdate";
            this.tbJualupdate.Size = new System.Drawing.Size(234, 34);
            this.tbJualupdate.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Stok";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 204);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Harga Beli";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 245);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Harga Jual";
            // 
            // cbSatuanupdate
            // 
            this.cbSatuanupdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbSatuanupdate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vbarangBindingSource1, "nama_satuan", true));
            this.cbSatuanupdate.DataSource = this.lsatuanBindingSource1;
            this.cbSatuanupdate.DisplayMember = "nama_satuan";
            this.cbSatuanupdate.FormattingEnabled = true;
            this.cbSatuanupdate.Location = new System.Drawing.Point(115, 92);
            this.cbSatuanupdate.Name = "cbSatuanupdate";
            this.cbSatuanupdate.Size = new System.Drawing.Size(234, 21);
            this.cbSatuanupdate.TabIndex = 14;
            this.cbSatuanupdate.ValueMember = "id_satuan";
            // 
            // ljenisBindingSource
            // 
            this.ljenisBindingSource.DataMember = "l_jenis";
            // 
            // lsatuanBindingSource
            // 
            this.lsatuanBindingSource.DataMember = "l_satuan";
            // 
            // gbDatabarang
            // 
            this.gbDatabarang.Controls.Add(this.gcDatabarang);
            this.gbDatabarang.Location = new System.Drawing.Point(404, 12);
            this.gbDatabarang.Name = "gbDatabarang";
            this.gbDatabarang.Size = new System.Drawing.Size(888, 514);
            this.gbDatabarang.TabIndex = 4;
            this.gbDatabarang.TabStop = false;
            this.gbDatabarang.Text = "Data Barang";
            // 
            // gcDatabarang
            // 
            this.gcDatabarang.DataSource = this.vbarangBindingSource1;
            this.gcDatabarang.Location = new System.Drawing.Point(8, 19);
            this.gcDatabarang.MainView = this.gridView1;
            this.gcDatabarang.Name = "gcDatabarang";
            this.gcDatabarang.Size = new System.Drawing.Size(874, 483);
            this.gcDatabarang.TabIndex = 0;
            this.gcDatabarang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcDatabarang.DoubleClick += new System.EventHandler(this.gcDatabarang_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_barang,
            this.colnama_barang,
            this.colnama_satuan,
            this.colnama_jenis,
            this.colstok,
            this.colharga_beli,
            this.colharga_jual});
            this.gridView1.GridControl = this.gcDatabarang;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colid_barang
            // 
            this.colid_barang.Caption = "Kode barang";
            this.colid_barang.FieldName = "id_barang";
            this.colid_barang.Name = "colid_barang";
            this.colid_barang.Visible = true;
            this.colid_barang.VisibleIndex = 0;
            // 
            // colnama_barang
            // 
            this.colnama_barang.Caption = "Nama barang";
            this.colnama_barang.FieldName = "nama_barang";
            this.colnama_barang.Name = "colnama_barang";
            this.colnama_barang.Visible = true;
            this.colnama_barang.VisibleIndex = 1;
            // 
            // colnama_satuan
            // 
            this.colnama_satuan.Caption = "Satuan";
            this.colnama_satuan.FieldName = "nama_satuan";
            this.colnama_satuan.Name = "colnama_satuan";
            this.colnama_satuan.Visible = true;
            this.colnama_satuan.VisibleIndex = 2;
            // 
            // colnama_jenis
            // 
            this.colnama_jenis.Caption = "Jenis";
            this.colnama_jenis.FieldName = "nama_jenis";
            this.colnama_jenis.Name = "colnama_jenis";
            this.colnama_jenis.Visible = true;
            this.colnama_jenis.VisibleIndex = 3;
            // 
            // colstok
            // 
            this.colstok.Caption = "Stok";
            this.colstok.FieldName = "stok";
            this.colstok.Name = "colstok";
            this.colstok.Visible = true;
            this.colstok.VisibleIndex = 4;
            // 
            // colharga_beli
            // 
            this.colharga_beli.Caption = "Harga beli satuan";
            this.colharga_beli.FieldName = "harga_beli";
            this.colharga_beli.Name = "colharga_beli";
            this.colharga_beli.Visible = true;
            this.colharga_beli.VisibleIndex = 5;
            // 
            // colharga_jual
            // 
            this.colharga_jual.Caption = "Harga jual satuan";
            this.colharga_jual.FieldName = "harga_jual";
            this.colharga_jual.Name = "colharga_jual";
            this.colharga_jual.Visible = true;
            this.colharga_jual.VisibleIndex = 6;
            // 
            // lbarangBindingSource
            // 
            this.lbarangBindingSource.DataMember = "l_barang";
            // 
            // v_barangTableAdapter
            // 
            this.v_barangTableAdapter.ClearBeforeFill = true;
            // 
            // l_satuanTableAdapter1
            // 
            this.l_satuanTableAdapter1.ClearBeforeFill = true;
            // 
            // l_jenisTableAdapter1
            // 
            this.l_jenisTableAdapter1.ClearBeforeFill = true;
            // 
            // Barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 553);
            this.Controls.Add(this.gbAksi2);
            this.Controls.Add(this.gbDatabarang);
            this.Controls.Add(this.gbAksi1);
            this.Name = "Barang";
            this.Text = "Barang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Barang_Load);
            this.gbAksi1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lsatuanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_satuan1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ljenisBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_jenis1)).EndInit();
            this.gbAksi2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vbarangBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_vbarang1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ljenisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lsatuanBindingSource)).EndInit();
            this.gbDatabarang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDatabarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbarangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAksi1;
        private DevExpress.XtraEditors.SimpleButton btnBatal;
        private DevExpress.XtraEditors.SimpleButton btnHapus;
        private DevExpress.XtraEditors.SimpleButton btnSimpan;
        private DevExpress.XtraEditors.SimpleButton btnTambah;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbNamabarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbKodebarang;
        private System.Windows.Forms.TextBox tbStok;
        private System.Windows.Forms.TextBox tbHargabeli;
        private System.Windows.Forms.TextBox tbHargajual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbDatabarang;
        private DevExpress.XtraGrid.GridControl gcDatabarang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_barang;
        private DevExpress.XtraGrid.Columns.GridColumn colnama_barang;
        private DevExpress.XtraGrid.Columns.GridColumn colnama_satuan;
        private DevExpress.XtraGrid.Columns.GridColumn colnama_jenis;
        private DevExpress.XtraGrid.Columns.GridColumn colstok;
        private DevExpress.XtraGrid.Columns.GridColumn colharga_beli;
        private DevExpress.XtraGrid.Columns.GridColumn colharga_jual;
        private ds_vbarang ds_vbarang1;
        private ds_vbarangTableAdapters.v_barangTableAdapter v_barangTableAdapter;
        //private ds_lsatuan ds_lsatuan;
        private System.Windows.Forms.BindingSource lsatuanBindingSource;
        //private ds_lsatuanTableAdapters.l_satuanTableAdapter l_satuanTableAdapter;
        //private ds_ljenis ds_ljenis;
        private System.Windows.Forms.BindingSource ljenisBindingSource;
        //private ds_ljenisTableAdapters.l_jenisTableAdapter l_jenisTableAdapter;
        private System.Windows.Forms.GroupBox gbAksi2;
        private DevExpress.XtraEditors.SimpleButton btnUbah;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cbJenisupdate;
        private System.Windows.Forms.TextBox tbNamaupdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbKodeupdate;
        private System.Windows.Forms.TextBox tbStokupdate;
        private System.Windows.Forms.TextBox tbBeliupdate;
        private System.Windows.Forms.TextBox tbJualupdate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbSatuanupdate;
        private ds_satuan1 ds_satuan1;
        private System.Windows.Forms.BindingSource lsatuanBindingSource1;
        private ds_satuan1TableAdapters.l_satuanTableAdapter l_satuanTableAdapter1;
        private ds_jenis1 ds_jenis1;
        private System.Windows.Forms.BindingSource ljenisBindingSource1;
        private ds_jenis1TableAdapters.l_jenisTableAdapter l_jenisTableAdapter1;
        private System.Windows.Forms.BindingSource vbarangBindingSource1;
        private System.Windows.Forms.ComboBox cbSatuan;
        private System.Windows.Forms.ComboBox cbJenis;
        //private ds_lbarang ds_lbarang;
        private System.Windows.Forms.BindingSource lbarangBindingSource;
        //private ds_lbarangTableAdapters.l_barangTableAdapter l_barangTableAdapter;
    }
}