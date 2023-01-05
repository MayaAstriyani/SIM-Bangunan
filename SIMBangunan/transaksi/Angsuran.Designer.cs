namespace SIMBangunan.transaksi
{
    partial class Angsuran
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.vkreditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_vkredit = new SIMBangunan.ds_vkredit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbIdangsuran = new System.Windows.Forms.TextBox();
            this.tbJml = new System.Windows.Forms.TextBox();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.cbPelanggan = new System.Windows.Forms.ComboBox();
            this.vlkreditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_vlkredit = new SIMBangunan.ds_vlkredit();
            this.v_kreditTableAdapter = new SIMBangunan.ds_vkreditTableAdapters.v_kreditTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.vangsuranBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_vangsuran = new SIMBangunan.ds_vangsuran();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnama1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltanggal1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkembalian1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coljml_angsuran = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsisa_hutang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.v_angsuranTableAdapter = new SIMBangunan.ds_vangsuranTableAdapters.v_angsuranTableAdapter();
            this.v_lkreditTableAdapter = new SIMBangunan.ds_vlkreditTableAdapters.v_lkreditTableAdapter();
            this.colno_faktur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltanggal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnama_barang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkembalian = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vkreditBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_vkredit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vlkreditBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_vlkredit)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vangsuranBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_vangsuran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControl1);
            this.groupBox1.Location = new System.Drawing.Point(14, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1100, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Piutang";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.vkreditBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(15, 26);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1072, 227);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // vkreditBindingSource
            // 
            this.vkreditBindingSource.DataMember = "v_kredit";
            this.vkreditBindingSource.DataSource = this.ds_vkredit;
            // 
            // ds_vkredit
            // 
            this.ds_vkredit.DataSetName = "ds_vkredit";
            this.ds_vkredit.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colno_faktur,
            this.colnama,
            this.coltanggal,
            this.colnama_barang,
            this.colkembalian});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBatal);
            this.groupBox2.Controls.Add(this.btnSimpan);
            this.groupBox2.Controls.Add(this.btnTambah);
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(14, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 215);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input Angsuran";
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(265, 177);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(83, 23);
            this.btnBatal.TabIndex = 3;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(146, 177);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(83, 23);
            this.btnSimpan.TabIndex = 2;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(13, 177);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(98, 23);
            this.btnTambah.TabIndex = 1;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.26829F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.7317F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbIdangsuran, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbJml, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtpTanggal, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbPelanggan, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(338, 142);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id Angsuran";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tanggal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pelanggan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Jumlah Bayar";
            // 
            // tbIdangsuran
            // 
            this.tbIdangsuran.Enabled = false;
            this.tbIdangsuran.Location = new System.Drawing.Point(101, 3);
            this.tbIdangsuran.Multiline = true;
            this.tbIdangsuran.Name = "tbIdangsuran";
            this.tbIdangsuran.Size = new System.Drawing.Size(234, 29);
            this.tbIdangsuran.TabIndex = 6;
            // 
            // tbJml
            // 
            this.tbJml.Location = new System.Drawing.Point(101, 108);
            this.tbJml.Multiline = true;
            this.tbJml.Name = "tbJml";
            this.tbJml.Size = new System.Drawing.Size(234, 31);
            this.tbJml.TabIndex = 7;
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTanggal.Location = new System.Drawing.Point(101, 42);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(234, 20);
            this.dtpTanggal.TabIndex = 8;
            // 
            // cbPelanggan
            // 
            this.cbPelanggan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbPelanggan.DataSource = this.vlkreditBindingSource;
            this.cbPelanggan.DisplayMember = "nama";
            this.cbPelanggan.FormattingEnabled = true;
            this.cbPelanggan.Location = new System.Drawing.Point(101, 77);
            this.cbPelanggan.Name = "cbPelanggan";
            this.cbPelanggan.Size = new System.Drawing.Size(234, 21);
            this.cbPelanggan.TabIndex = 9;
            this.cbPelanggan.ValueMember = "id_member";
            // 
            // vlkreditBindingSource
            // 
            this.vlkreditBindingSource.DataMember = "v_lkredit";
            this.vlkreditBindingSource.DataSource = this.ds_vlkredit;
            // 
            // ds_vlkredit
            // 
            this.ds_vlkredit.DataSetName = "ds_vlkredit";
            this.ds_vlkredit.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_kreditTableAdapter
            // 
            this.v_kreditTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridControl2);
            this.groupBox3.Location = new System.Drawing.Point(422, 286);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(692, 215);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Angsuran";
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.vangsuranBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(6, 19);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(673, 181);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // vangsuranBindingSource
            // 
            this.vangsuranBindingSource.DataMember = "v_angsuran";
            this.vangsuranBindingSource.DataSource = this.ds_vangsuran;
            // 
            // ds_vangsuran
            // 
            this.ds_vangsuran.DataSetName = "ds_vangsuran";
            this.ds_vangsuran.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnama1,
            this.coltanggal1,
            this.colkembalian1,
            this.coljml_angsuran,
            this.colsisa_hutang});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // colnama1
            // 
            this.colnama1.Caption = "Nama Pelanggan";
            this.colnama1.FieldName = "nama";
            this.colnama1.Name = "colnama1";
            this.colnama1.Visible = true;
            this.colnama1.VisibleIndex = 0;
            // 
            // coltanggal1
            // 
            this.coltanggal1.Caption = "Tanggal";
            this.coltanggal1.FieldName = "tanggal";
            this.coltanggal1.Name = "coltanggal1";
            this.coltanggal1.Visible = true;
            this.coltanggal1.VisibleIndex = 1;
            // 
            // colkembalian1
            // 
            this.colkembalian1.Caption = "Jumlah Hutang";
            this.colkembalian1.FieldName = "kembalian";
            this.colkembalian1.Name = "colkembalian1";
            this.colkembalian1.Visible = true;
            this.colkembalian1.VisibleIndex = 2;
            // 
            // coljml_angsuran
            // 
            this.coljml_angsuran.Caption = "Angsuran";
            this.coljml_angsuran.FieldName = "jml_angsuran";
            this.coljml_angsuran.Name = "coljml_angsuran";
            this.coljml_angsuran.Visible = true;
            this.coljml_angsuran.VisibleIndex = 3;
            // 
            // colsisa_hutang
            // 
            this.colsisa_hutang.Caption = "Sisa Hutang";
            this.colsisa_hutang.FieldName = "sisa_hutang";
            this.colsisa_hutang.Name = "colsisa_hutang";
            this.colsisa_hutang.OptionsColumn.ReadOnly = true;
            this.colsisa_hutang.Visible = true;
            this.colsisa_hutang.VisibleIndex = 4;
            // 
            // v_angsuranTableAdapter
            // 
            this.v_angsuranTableAdapter.ClearBeforeFill = true;
            // 
            // v_lkreditTableAdapter
            // 
            this.v_lkreditTableAdapter.ClearBeforeFill = true;
            // 
            // colno_faktur
            // 
            this.colno_faktur.Caption = "No Faktur";
            this.colno_faktur.FieldName = "no_faktur";
            this.colno_faktur.Name = "colno_faktur";
            this.colno_faktur.Visible = true;
            this.colno_faktur.VisibleIndex = 0;
            // 
            // colnama
            // 
            this.colnama.Caption = "Nama Pelanggan";
            this.colnama.FieldName = "nama";
            this.colnama.Name = "colnama";
            this.colnama.Visible = true;
            this.colnama.VisibleIndex = 1;
            // 
            // coltanggal
            // 
            this.coltanggal.Caption = "Tanggal Pembelian";
            this.coltanggal.FieldName = "tanggal";
            this.coltanggal.Name = "coltanggal";
            this.coltanggal.Visible = true;
            this.coltanggal.VisibleIndex = 2;
            // 
            // colnama_barang
            // 
            this.colnama_barang.Caption = "Nama Barang";
            this.colnama_barang.FieldName = "nama_barang";
            this.colnama_barang.Name = "colnama_barang";
            this.colnama_barang.Visible = true;
            this.colnama_barang.VisibleIndex = 3;
            // 
            // colkembalian
            // 
            this.colkembalian.Caption = "Jumlah Hutang";
            this.colkembalian.FieldName = "kembalian";
            this.colkembalian.Name = "colkembalian";
            this.colkembalian.Visible = true;
            this.colkembalian.VisibleIndex = 4;
            // 
            // Angsuran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 548);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Angsuran";
            this.Text = "Angsuran";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Angsuran_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vkreditBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_vkredit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vlkreditBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_vlkredit)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vangsuranBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_vangsuran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private ds_vkredit ds_vkredit;
        private System.Windows.Forms.BindingSource vkreditBindingSource;
        private ds_vkreditTableAdapters.v_kreditTableAdapter v_kreditTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbIdangsuran;
        private System.Windows.Forms.TextBox tbJml;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.ComboBox cbPelanggan;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private ds_vangsuran ds_vangsuran;
        private System.Windows.Forms.BindingSource vangsuranBindingSource;
        private ds_vangsuranTableAdapters.v_angsuranTableAdapter v_angsuranTableAdapter;
        private ds_vlkredit ds_vlkredit;
        private System.Windows.Forms.BindingSource vlkreditBindingSource;
        private ds_vlkreditTableAdapters.v_lkreditTableAdapter v_lkreditTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnama1;
        private DevExpress.XtraGrid.Columns.GridColumn coltanggal1;
        private DevExpress.XtraGrid.Columns.GridColumn colkembalian1;
        private DevExpress.XtraGrid.Columns.GridColumn coljml_angsuran;
        private DevExpress.XtraGrid.Columns.GridColumn colsisa_hutang;
        private DevExpress.XtraGrid.Columns.GridColumn colno_faktur;
        private DevExpress.XtraGrid.Columns.GridColumn colnama;
        private DevExpress.XtraGrid.Columns.GridColumn coltanggal;
        private DevExpress.XtraGrid.Columns.GridColumn colnama_barang;
        private DevExpress.XtraGrid.Columns.GridColumn colkembalian;
    }
}