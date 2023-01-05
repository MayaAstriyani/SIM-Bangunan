namespace SIMBangunan.transaksi
{
    partial class Pembelian
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gbDatabarang = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.vpembelianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_vpembelian1 = new SIMBangunan.t_pembelian();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colno_faktur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltanggal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnama_supplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnama_barang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colharga_beli = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coljumlah = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal_harga = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbFakturupdate = new System.Windows.Forms.TextBox();
            this.tbHargau = new System.Windows.Forms.TextBox();
            this.tbJumlahu = new System.Windows.Forms.TextBox();
            this.tbTotalu = new System.Windows.Forms.TextBox();
            this.btnHapus = new DevExpress.XtraEditors.SimpleButton();
            this.btnSimpan = new DevExpress.XtraEditors.SimpleButton();
            this.btnTambah = new DevExpress.XtraEditors.SimpleButton();
            this.label12 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNofaktur = new System.Windows.Forms.TextBox();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.tbJumlah = new System.Windows.Forms.TextBox();
            this.tbTotalharga = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.lsupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_supplier = new SIMBangunan.t_supplier();
            this.cbBarang = new System.Windows.Forms.ComboBox();
            this.lbarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_lbarang = new SIMBangunan.t_lbarang();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.l_barangTableAdapter1 = new SIMBangunan.t_lbarangTableAdapters.l_barangTableAdapter();
            this.l_supplierTableAdapter = new SIMBangunan.t_supplierTableAdapters.l_supplierTableAdapter();
            this.btnBatal = new DevExpress.XtraEditors.SimpleButton();
            this.dtpUpdate = new System.Windows.Forms.DateTimePicker();
            this.lpembelianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbSupplieru = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbBarangu = new System.Windows.Forms.ComboBox();
            this.gbAksi1 = new System.Windows.Forms.GroupBox();
            this.gbAksi2 = new System.Windows.Forms.GroupBox();
            this.btnUbah = new DevExpress.XtraEditors.SimpleButton();
            this.v_pembelianTableAdapter = new SIMBangunan.t_pembelianTableAdapters.v_pembelianTableAdapter();
            this.gbDatabarang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpembelianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_vpembelian1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lsupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_supplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbarangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_lbarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lpembelianBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbAksi1.SuspendLayout();
            this.gbAksi2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "No Faktur";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tanggal";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Supplier";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Barang";
            // 
            // gbDatabarang
            // 
            this.gbDatabarang.Controls.Add(this.gridControl1);
            this.gbDatabarang.Location = new System.Drawing.Point(400, 19);
            this.gbDatabarang.Name = "gbDatabarang";
            this.gbDatabarang.Size = new System.Drawing.Size(888, 514);
            this.gbDatabarang.TabIndex = 7;
            this.gbDatabarang.TabStop = false;
            this.gbDatabarang.Text = "Data Pembelian Barang";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.vpembelianBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(7, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(874, 488);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // vpembelianBindingSource
            // 
            this.vpembelianBindingSource.DataMember = "v_pembelian";
            this.vpembelianBindingSource.DataSource = this.t_vpembelian1;
            // 
            // t_vpembelian1
            // 
            this.t_vpembelian1.DataSetName = "t_vpembelian";
            this.t_vpembelian1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colno_faktur,
            this.coltanggal,
            this.colnama_supplier,
            this.colnama_barang,
            this.colharga_beli,
            this.coljumlah,
            this.coltotal_harga});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colno_faktur
            // 
            this.colno_faktur.Caption = "No Faktur";
            this.colno_faktur.FieldName = "no_faktur";
            this.colno_faktur.Name = "colno_faktur";
            this.colno_faktur.OptionsColumn.AllowEdit = false;
            this.colno_faktur.Visible = true;
            this.colno_faktur.VisibleIndex = 0;
            // 
            // coltanggal
            // 
            this.coltanggal.Caption = "Tanggal Pembelian";
            this.coltanggal.FieldName = "tanggal";
            this.coltanggal.Name = "coltanggal";
            this.coltanggal.OptionsColumn.AllowEdit = false;
            this.coltanggal.Visible = true;
            this.coltanggal.VisibleIndex = 1;
            // 
            // colnama_supplier
            // 
            this.colnama_supplier.Caption = "Nama Supplier";
            this.colnama_supplier.FieldName = "nama_supplier";
            this.colnama_supplier.Name = "colnama_supplier";
            this.colnama_supplier.OptionsColumn.AllowEdit = false;
            this.colnama_supplier.Visible = true;
            this.colnama_supplier.VisibleIndex = 2;
            // 
            // colnama_barang
            // 
            this.colnama_barang.Caption = "Nama Barang";
            this.colnama_barang.FieldName = "nama_barang";
            this.colnama_barang.Name = "colnama_barang";
            this.colnama_barang.OptionsColumn.AllowEdit = false;
            this.colnama_barang.Visible = true;
            this.colnama_barang.VisibleIndex = 3;
            // 
            // colharga_beli
            // 
            this.colharga_beli.Caption = "Harga Beli";
            this.colharga_beli.FieldName = "harga_beli";
            this.colharga_beli.Name = "colharga_beli";
            this.colharga_beli.OptionsColumn.AllowEdit = false;
            this.colharga_beli.Visible = true;
            this.colharga_beli.VisibleIndex = 4;
            // 
            // coljumlah
            // 
            this.coljumlah.Caption = "Jumlah";
            this.coljumlah.FieldName = "jumlah";
            this.coljumlah.Name = "coljumlah";
            this.coljumlah.OptionsColumn.AllowEdit = false;
            this.coljumlah.Visible = true;
            this.coljumlah.VisibleIndex = 5;
            // 
            // coltotal_harga
            // 
            this.coltotal_harga.Caption = "Total Harga";
            this.coltotal_harga.FieldName = "total_harga";
            this.coltotal_harga.Name = "coltotal_harga";
            this.coltotal_harga.OptionsColumn.AllowEdit = false;
            this.coltotal_harga.Visible = true;
            this.coltotal_harga.VisibleIndex = 6;
            // 
            // tbFakturupdate
            // 
            this.tbFakturupdate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vpembelianBindingSource, "no_faktur", true));
            this.tbFakturupdate.Enabled = false;
            this.tbFakturupdate.Location = new System.Drawing.Point(115, 3);
            this.tbFakturupdate.Multiline = true;
            this.tbFakturupdate.Name = "tbFakturupdate";
            this.tbFakturupdate.Size = new System.Drawing.Size(234, 34);
            this.tbFakturupdate.TabIndex = 4;
            // 
            // tbHargau
            // 
            this.tbHargau.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vpembelianBindingSource, "harga_beli", true));
            this.tbHargau.Location = new System.Drawing.Point(115, 163);
            this.tbHargau.Multiline = true;
            this.tbHargau.Name = "tbHargau";
            this.tbHargau.Size = new System.Drawing.Size(234, 34);
            this.tbHargau.TabIndex = 8;
            // 
            // tbJumlahu
            // 
            this.tbJumlahu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vpembelianBindingSource, "jumlah", true));
            this.tbJumlahu.Location = new System.Drawing.Point(115, 203);
            this.tbJumlahu.Multiline = true;
            this.tbJumlahu.Name = "tbJumlahu";
            this.tbJumlahu.Size = new System.Drawing.Size(234, 34);
            this.tbJumlahu.TabIndex = 9;
            // 
            // tbTotalu
            // 
            this.tbTotalu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vpembelianBindingSource, "total_harga", true));
            this.tbTotalu.Enabled = false;
            this.tbTotalu.Location = new System.Drawing.Point(115, 243);
            this.tbTotalu.Multiline = true;
            this.tbTotalu.Name = "tbTotalu";
            this.tbTotalu.Size = new System.Drawing.Size(234, 34);
            this.tbTotalu.TabIndex = 10;
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Harga Beli";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbNofaktur, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbHarga, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbJumlah, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbTotalharga, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.cbSupplier, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbBarang, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtpTanggal, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(352, 285);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Faktur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tanggal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Supplier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Barang";
            // 
            // tbNofaktur
            // 
            this.tbNofaktur.Enabled = false;
            this.tbNofaktur.Location = new System.Drawing.Point(115, 3);
            this.tbNofaktur.Multiline = true;
            this.tbNofaktur.Name = "tbNofaktur";
            this.tbNofaktur.Size = new System.Drawing.Size(234, 34);
            this.tbNofaktur.TabIndex = 4;
            // 
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(115, 163);
            this.tbHarga.Multiline = true;
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(234, 34);
            this.tbHarga.TabIndex = 8;
            // 
            // tbJumlah
            // 
            this.tbJumlah.Location = new System.Drawing.Point(115, 203);
            this.tbJumlah.Multiline = true;
            this.tbJumlah.Name = "tbJumlah";
            this.tbJumlah.Size = new System.Drawing.Size(234, 34);
            this.tbJumlah.TabIndex = 9;
            // 
            // tbTotalharga
            // 
            this.tbTotalharga.Enabled = false;
            this.tbTotalharga.Location = new System.Drawing.Point(115, 243);
            this.tbTotalharga.Multiline = true;
            this.tbTotalharga.Name = "tbTotalharga";
            this.tbTotalharga.Size = new System.Drawing.Size(234, 34);
            this.tbTotalharga.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Harga Beli";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Jumlah Beli";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total Harga";
            // 
            // cbSupplier
            // 
            this.cbSupplier.DataSource = this.lsupplierBindingSource;
            this.cbSupplier.DisplayMember = "nama_supplier";
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(115, 83);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(234, 21);
            this.cbSupplier.TabIndex = 14;
            this.cbSupplier.ValueMember = "id_supplier";
            // 
            // lsupplierBindingSource
            // 
            this.lsupplierBindingSource.DataMember = "l_supplier";
            this.lsupplierBindingSource.DataSource = this.t_supplier;
            // 
            // t_supplier
            // 
            this.t_supplier.DataSetName = "t_supplier";
            this.t_supplier.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbBarang
            // 
            this.cbBarang.DataSource = this.lbarangBindingSource;
            this.cbBarang.DisplayMember = "nama_barang";
            this.cbBarang.FormattingEnabled = true;
            this.cbBarang.Location = new System.Drawing.Point(115, 123);
            this.cbBarang.Name = "cbBarang";
            this.cbBarang.Size = new System.Drawing.Size(234, 21);
            this.cbBarang.TabIndex = 15;
            this.cbBarang.ValueMember = "id_barang";
            // 
            // lbarangBindingSource
            // 
            this.lbarangBindingSource.DataMember = "l_barang";
            this.lbarangBindingSource.DataSource = this.t_lbarang;
            // 
            // t_lbarang
            // 
            this.t_lbarang.DataSetName = "t_lbarang";
            this.t_lbarang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.Location = new System.Drawing.Point(115, 43);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(234, 20);
            this.dtpTanggal.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Jumlah Beli";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 240);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Total Harga";
            // 
            // l_barangTableAdapter1
            // 
            this.l_barangTableAdapter1.ClearBeforeFill = true;
            // 
            // l_supplierTableAdapter
            // 
            this.l_supplierTableAdapter.ClearBeforeFill = true;
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
            // dtpUpdate
            // 
            this.dtpUpdate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vpembelianBindingSource, "tanggal", true));
            this.dtpUpdate.Location = new System.Drawing.Point(115, 43);
            this.dtpUpdate.Name = "dtpUpdate";
            this.dtpUpdate.Size = new System.Drawing.Size(234, 20);
            this.dtpUpdate.TabIndex = 16;
            // 
            // lpembelianBindingSource
            // 
            this.lpembelianBindingSource.DataMember = "l_pembelian";
            // 
            // cbSupplieru
            // 
            this.cbSupplieru.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vpembelianBindingSource, "nama_supplier", true));
            this.cbSupplieru.DataSource = this.lsupplierBindingSource;
            this.cbSupplieru.DisplayMember = "nama_supplier";
            this.cbSupplieru.FormattingEnabled = true;
            this.cbSupplieru.Location = new System.Drawing.Point(115, 83);
            this.cbSupplieru.Name = "cbSupplieru";
            this.cbSupplieru.Size = new System.Drawing.Size(234, 21);
            this.cbSupplieru.TabIndex = 14;
            this.cbSupplieru.ValueMember = "id_supplier";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tbFakturupdate, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbHargau, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.tbJumlahu, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.tbTotalu, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.cbSupplieru, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbBarangu, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.dtpUpdate, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(11, 30);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(352, 285);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cbBarangu
            // 
            this.cbBarangu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vpembelianBindingSource, "nama_barang", true));
            this.cbBarangu.DataSource = this.lbarangBindingSource;
            this.cbBarangu.DisplayMember = "nama_barang";
            this.cbBarangu.FormattingEnabled = true;
            this.cbBarangu.Location = new System.Drawing.Point(115, 123);
            this.cbBarangu.Name = "cbBarangu";
            this.cbBarangu.Size = new System.Drawing.Size(234, 21);
            this.cbBarangu.TabIndex = 15;
            this.cbBarangu.ValueMember = "id_barang";
            // 
            // gbAksi1
            // 
            this.gbAksi1.Controls.Add(this.gbAksi2);
            this.gbAksi1.Controls.Add(this.btnBatal);
            this.gbAksi1.Controls.Add(this.btnHapus);
            this.gbAksi1.Controls.Add(this.btnSimpan);
            this.gbAksi1.Controls.Add(this.btnTambah);
            this.gbAksi1.Controls.Add(this.tableLayoutPanel1);
            this.gbAksi1.Location = new System.Drawing.Point(8, 19);
            this.gbAksi1.Name = "gbAksi1";
            this.gbAksi1.Size = new System.Drawing.Size(386, 376);
            this.gbAksi1.TabIndex = 8;
            this.gbAksi1.TabStop = false;
            this.gbAksi1.Text = "Aksi";
            // 
            // gbAksi2
            // 
            this.gbAksi2.Controls.Add(this.btnUbah);
            this.gbAksi2.Controls.Add(this.tableLayoutPanel2);
            this.gbAksi2.Location = new System.Drawing.Point(0, 0);
            this.gbAksi2.Name = "gbAksi2";
            this.gbAksi2.Size = new System.Drawing.Size(386, 376);
            this.gbAksi2.TabIndex = 7;
            this.gbAksi2.TabStop = false;
            this.gbAksi2.Text = "Aksi Ubah";
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
            // v_pembelianTableAdapter
            // 
            this.v_pembelianTableAdapter.ClearBeforeFill = true;
            // 
            // Pembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 553);
            this.Controls.Add(this.gbDatabarang);
            this.Controls.Add(this.gbAksi1);
            this.Name = "Pembelian";
            this.Text = "Pembelian";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Pembelian_Load);
            this.gbDatabarang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpembelianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_vpembelian1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lsupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_supplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbarangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_lbarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lpembelianBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.gbAksi1.ResumeLayout(false);
            this.gbAksi2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        //private t_barang t_barang;
        //private t_barangTableAdapters.l_barangTableAdapter l_barangTableAdapter;
        //private t_pembelian t_pembelian;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbDatabarang;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource vpembelianBindingSource;
        private t_pembelian t_vpembelian1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colno_faktur;
        private DevExpress.XtraGrid.Columns.GridColumn coltanggal;
        private DevExpress.XtraGrid.Columns.GridColumn colnama_supplier;
        private DevExpress.XtraGrid.Columns.GridColumn colnama_barang;
        private DevExpress.XtraGrid.Columns.GridColumn colharga_beli;
        private DevExpress.XtraGrid.Columns.GridColumn coljumlah;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal_harga;
        private System.Windows.Forms.TextBox tbFakturupdate;
        private System.Windows.Forms.TextBox tbHargau;
        private System.Windows.Forms.TextBox tbJumlahu;
        private System.Windows.Forms.TextBox tbTotalu;
        private DevExpress.XtraEditors.SimpleButton btnHapus;
        private DevExpress.XtraEditors.SimpleButton btnSimpan;
        private DevExpress.XtraEditors.SimpleButton btnTambah;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNofaktur;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.TextBox tbJumlah;
        private System.Windows.Forms.TextBox tbTotalharga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.BindingSource lsupplierBindingSource;
        private t_supplier t_supplier;
        private System.Windows.Forms.ComboBox cbBarang;
        private System.Windows.Forms.BindingSource lbarangBindingSource;
        private t_lbarang t_lbarang;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private t_lbarangTableAdapters.l_barangTableAdapter l_barangTableAdapter1;
        private t_supplierTableAdapters.l_supplierTableAdapter l_supplierTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnBatal;
        private System.Windows.Forms.DateTimePicker dtpUpdate;
        private System.Windows.Forms.BindingSource lpembelianBindingSource;
        private System.Windows.Forms.ComboBox cbSupplieru;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cbBarangu;
        private System.Windows.Forms.GroupBox gbAksi1;
        private System.Windows.Forms.GroupBox gbAksi2;
        private DevExpress.XtraEditors.SimpleButton btnUbah;
        private t_pembelianTableAdapters.v_pembelianTableAdapter v_pembelianTableAdapter;
    }
}