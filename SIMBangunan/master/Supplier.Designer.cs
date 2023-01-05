namespace SIMBangunan.master
{
    partial class Supplier
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
            this.gbAksi2 = new System.Windows.Forms.GroupBox();
            this.btnUbah = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tbTelpupdate = new System.Windows.Forms.TextBox();
            this.lsupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_supplier = new SIMBangunan.dsSupplier();
            this.tbAlamatupdate = new System.Windows.Forms.TextBox();
            this.tbNamaupdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbKodeupdate = new System.Windows.Forms.TextBox();
            this.gbAksi1 = new System.Windows.Forms.GroupBox();
            this.btnBatal = new DevExpress.XtraEditors.SimpleButton();
            this.btnHapus = new DevExpress.XtraEditors.SimpleButton();
            this.btnSimpan = new DevExpress.XtraEditors.SimpleButton();
            this.btnTambah = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tbNotelp = new System.Windows.Forms.TextBox();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.tbNamasupplier = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbKodesupplier = new System.Windows.Forms.TextBox();
            this.gbDatasupplier = new System.Windows.Forms.GroupBox();
            this.gcDatasupplier = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_supplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnama_supplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colalamat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colno_telp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.l_supplierTableAdapter = new SIMBangunan.dsSupplierTableAdapters.l_supplierTableAdapter();
            this.gbAksi2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lsupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_supplier)).BeginInit();
            this.gbAksi1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.gbDatasupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatasupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAksi2
            // 
            this.gbAksi2.Controls.Add(this.btnUbah);
            this.gbAksi2.Controls.Add(this.tableLayoutPanel2);
            this.gbAksi2.Location = new System.Drawing.Point(0, 0);
            this.gbAksi2.Name = "gbAksi2";
            this.gbAksi2.Size = new System.Drawing.Size(386, 253);
            this.gbAksi2.TabIndex = 6;
            this.gbAksi2.TabStop = false;
            this.gbAksi2.Text = "Aksi";
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(11, 210);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(75, 23);
            this.btnUbah.TabIndex = 2;
            this.btnUbah.Text = "Simpan Ubah";
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel2.Controls.Add(this.tbTelpupdate, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.tbAlamatupdate, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tbNamaupdate, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tbKodeupdate, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(11, 34);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.36709F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.63291F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(352, 157);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tbTelpupdate
            // 
            this.tbTelpupdate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lsupplierBindingSource, "no_telp", true));
            this.tbTelpupdate.Location = new System.Drawing.Point(115, 120);
            this.tbTelpupdate.Multiline = true;
            this.tbTelpupdate.Name = "tbTelpupdate";
            this.tbTelpupdate.Size = new System.Drawing.Size(234, 34);
            this.tbTelpupdate.TabIndex = 7;
            // 
            // lsupplierBindingSource
            // 
            this.lsupplierBindingSource.DataMember = "l_supplier";
            this.lsupplierBindingSource.DataSource = this.ds_supplier;
            // 
            // ds_supplier
            // 
            this.ds_supplier.DataSetName = "ds_supplier";
            this.ds_supplier.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbAlamatupdate
            // 
            this.tbAlamatupdate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lsupplierBindingSource, "alamat", true));
            this.tbAlamatupdate.Location = new System.Drawing.Point(115, 82);
            this.tbAlamatupdate.Multiline = true;
            this.tbAlamatupdate.Name = "tbAlamatupdate";
            this.tbAlamatupdate.Size = new System.Drawing.Size(234, 32);
            this.tbAlamatupdate.TabIndex = 6;
            // 
            // tbNamaupdate
            // 
            this.tbNamaupdate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lsupplierBindingSource, "nama_supplier", true));
            this.tbNamaupdate.Location = new System.Drawing.Point(115, 42);
            this.tbNamaupdate.Multiline = true;
            this.tbNamaupdate.Name = "tbNamaupdate";
            this.tbNamaupdate.Size = new System.Drawing.Size(234, 34);
            this.tbNamaupdate.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kode Supplier";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nama Supplier";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Alamat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "No Telp";
            // 
            // tbKodeupdate
            // 
            this.tbKodeupdate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lsupplierBindingSource, "id_supplier", true));
            this.tbKodeupdate.Enabled = false;
            this.tbKodeupdate.Location = new System.Drawing.Point(115, 3);
            this.tbKodeupdate.Multiline = true;
            this.tbKodeupdate.Name = "tbKodeupdate";
            this.tbKodeupdate.Size = new System.Drawing.Size(234, 33);
            this.tbKodeupdate.TabIndex = 4;
            // 
            // gbAksi1
            // 
            this.gbAksi1.Controls.Add(this.gbAksi2);
            this.gbAksi1.Controls.Add(this.btnBatal);
            this.gbAksi1.Controls.Add(this.btnHapus);
            this.gbAksi1.Controls.Add(this.btnSimpan);
            this.gbAksi1.Controls.Add(this.btnTambah);
            this.gbAksi1.Controls.Add(this.tableLayoutPanel3);
            this.gbAksi1.Location = new System.Drawing.Point(12, 12);
            this.gbAksi1.Name = "gbAksi1";
            this.gbAksi1.Size = new System.Drawing.Size(386, 253);
            this.gbAksi1.TabIndex = 7;
            this.gbAksi1.TabStop = false;
            this.gbAksi1.Text = "Aksi";
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(288, 209);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 4;
            this.btnBatal.Text = "Batal";
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(194, 209);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(104, 209);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 2;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(11, 209);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 1;
            this.btnTambah.Text = "Tambah Baru";
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel3.Controls.Add(this.tbNotelp, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.tbAlamat, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.tbNamasupplier, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label12, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.tbKodesupplier, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(11, 34);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.36709F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.63291F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(352, 157);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tbNotelp
            // 
            this.tbNotelp.Location = new System.Drawing.Point(115, 120);
            this.tbNotelp.Multiline = true;
            this.tbNotelp.Name = "tbNotelp";
            this.tbNotelp.Size = new System.Drawing.Size(234, 34);
            this.tbNotelp.TabIndex = 7;
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(115, 82);
            this.tbAlamat.Multiline = true;
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(234, 32);
            this.tbAlamat.TabIndex = 6;
            // 
            // tbNamasupplier
            // 
            this.tbNamasupplier.Location = new System.Drawing.Point(115, 42);
            this.tbNamasupplier.Multiline = true;
            this.tbNamasupplier.Name = "tbNamasupplier";
            this.tbNamasupplier.Size = new System.Drawing.Size(234, 34);
            this.tbNamasupplier.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Kode User";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Nama Supplier";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Alamat";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "No Telp";
            // 
            // tbKodesupplier
            // 
            this.tbKodesupplier.Location = new System.Drawing.Point(115, 3);
            this.tbKodesupplier.Multiline = true;
            this.tbKodesupplier.Name = "tbKodesupplier";
            this.tbKodesupplier.Size = new System.Drawing.Size(234, 33);
            this.tbKodesupplier.TabIndex = 4;
            // 
            // gbDatasupplier
            // 
            this.gbDatasupplier.Controls.Add(this.gcDatasupplier);
            this.gbDatasupplier.Location = new System.Drawing.Point(404, 12);
            this.gbDatasupplier.Name = "gbDatasupplier";
            this.gbDatasupplier.Size = new System.Drawing.Size(654, 526);
            this.gbDatasupplier.TabIndex = 8;
            this.gbDatasupplier.TabStop = false;
            this.gbDatasupplier.Text = "Data Supplier";
            this.gbDatasupplier.Enter += new System.EventHandler(this.gbDatasupplier_Enter);
            // 
            // gcDatasupplier
            // 
            this.gcDatasupplier.DataSource = this.lsupplierBindingSource;
            this.gcDatasupplier.Location = new System.Drawing.Point(6, 19);
            this.gcDatasupplier.MainView = this.gridView1;
            this.gcDatasupplier.Name = "gcDatasupplier";
            this.gcDatasupplier.Size = new System.Drawing.Size(576, 501);
            this.gcDatasupplier.TabIndex = 0;
            this.gcDatasupplier.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcDatasupplier.DoubleClick += new System.EventHandler(this.gcDatasupplier_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_supplier,
            this.colnama_supplier,
            this.colalamat,
            this.colno_telp});
            this.gridView1.GridControl = this.gcDatasupplier;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colid_supplier
            // 
            this.colid_supplier.Caption = "Kode Supplier";
            this.colid_supplier.FieldName = "id_supplier";
            this.colid_supplier.Name = "colid_supplier";
            this.colid_supplier.OptionsColumn.AllowEdit = false;
            this.colid_supplier.Visible = true;
            this.colid_supplier.VisibleIndex = 0;
            // 
            // colnama_supplier
            // 
            this.colnama_supplier.Caption = "Nama Supplier";
            this.colnama_supplier.FieldName = "nama_supplier";
            this.colnama_supplier.Name = "colnama_supplier";
            this.colnama_supplier.OptionsColumn.AllowEdit = false;
            this.colnama_supplier.Visible = true;
            this.colnama_supplier.VisibleIndex = 1;
            // 
            // colalamat
            // 
            this.colalamat.Caption = "Alamat";
            this.colalamat.FieldName = "alamat";
            this.colalamat.Name = "colalamat";
            this.colalamat.OptionsColumn.AllowEdit = false;
            this.colalamat.Visible = true;
            this.colalamat.VisibleIndex = 2;
            // 
            // colno_telp
            // 
            this.colno_telp.Caption = "No Telp";
            this.colno_telp.FieldName = "no_telp";
            this.colno_telp.Name = "colno_telp";
            this.colno_telp.OptionsColumn.AllowEdit = false;
            this.colno_telp.Visible = true;
            this.colno_telp.VisibleIndex = 3;
            // 
            // l_supplierTableAdapter
            // 
            this.l_supplierTableAdapter.ClearBeforeFill = true;
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 550);
            this.Controls.Add(this.gbDatasupplier);
            this.Controls.Add(this.gbAksi1);
            this.Name = "Supplier";
            this.Text = "Supplier";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Supplier_Load);
            this.gbAksi2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lsupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_supplier)).EndInit();
            this.gbAksi1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.gbDatasupplier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDatasupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAksi2;
        private DevExpress.XtraEditors.SimpleButton btnUbah;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tbTelpupdate;
        private System.Windows.Forms.TextBox tbAlamatupdate;
        private System.Windows.Forms.TextBox tbNamaupdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbKodeupdate;
        private System.Windows.Forms.GroupBox gbAksi1;
        private DevExpress.XtraEditors.SimpleButton btnBatal;
        private DevExpress.XtraEditors.SimpleButton btnHapus;
        private DevExpress.XtraEditors.SimpleButton btnSimpan;
        private DevExpress.XtraEditors.SimpleButton btnTambah;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox tbNotelp;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.TextBox tbNamasupplier;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbKodesupplier;
        private System.Windows.Forms.GroupBox gbDatasupplier;
        private DevExpress.XtraGrid.GridControl gcDatasupplier;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsSupplier ds_supplier;
        private System.Windows.Forms.BindingSource lsupplierBindingSource;
        private dsSupplierTableAdapters.l_supplierTableAdapter l_supplierTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colid_supplier;
        private DevExpress.XtraGrid.Columns.GridColumn colnama_supplier;
        private DevExpress.XtraGrid.Columns.GridColumn colalamat;
        private DevExpress.XtraGrid.Columns.GridColumn colno_telp;
    }
}