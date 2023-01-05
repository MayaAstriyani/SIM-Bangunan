namespace SIMBangunan.master
{
    partial class Jenis
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
            this.tbJenis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKodejenis = new System.Windows.Forms.TextBox();
            this.gbAksi2 = new System.Windows.Forms.GroupBox();
            this.btnUbah = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tbJenisupdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbKodeupdate = new System.Windows.Forms.TextBox();
            this.gbDatajenis = new System.Windows.Forms.GroupBox();
            this.gcDatajenis = new DevExpress.XtraGrid.GridControl();
            this.ljenisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_jenis = new SIMBangunan.ds_jenis();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_jenis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnama_jenis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.l_jenisTableAdapter = new SIMBangunan.ds_jenisTableAdapters.l_jenisTableAdapter();
            this.gbAksi1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbAksi2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbDatajenis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatajenis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ljenisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_jenis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.gbAksi1.Size = new System.Drawing.Size(386, 178);
            this.gbAksi1.TabIndex = 2;
            this.gbAksi1.TabStop = false;
            this.gbAksi1.Text = "Aksi";
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(288, 140);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 4;
            this.btnBatal.Text = "Batal";
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(194, 140);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(104, 140);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 2;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(11, 140);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 1;
            this.btnTambah.Text = "Tambah Baru";
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel1.Controls.Add(this.tbJenis, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbKodejenis, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 34);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.38095F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.61905F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(352, 84);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbJenis
            // 
            this.tbJenis.Location = new System.Drawing.Point(115, 46);
            this.tbJenis.Multiline = true;
            this.tbJenis.Name = "tbJenis";
            this.tbJenis.Size = new System.Drawing.Size(234, 35);
            this.tbJenis.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Jenis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jenis";
            // 
            // tbKodejenis
            // 
            this.tbKodejenis.Location = new System.Drawing.Point(115, 3);
            this.tbKodejenis.Multiline = true;
            this.tbKodejenis.Name = "tbKodejenis";
            this.tbKodejenis.Size = new System.Drawing.Size(234, 37);
            this.tbKodejenis.TabIndex = 4;
            // 
            // gbAksi2
            // 
            this.gbAksi2.Controls.Add(this.btnUbah);
            this.gbAksi2.Controls.Add(this.tableLayoutPanel2);
            this.gbAksi2.Location = new System.Drawing.Point(12, 224);
            this.gbAksi2.Name = "gbAksi2";
            this.gbAksi2.Size = new System.Drawing.Size(386, 187);
            this.gbAksi2.TabIndex = 6;
            this.gbAksi2.TabStop = false;
            this.gbAksi2.Text = "Aksi Ubah";
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(11, 138);
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
            this.tableLayoutPanel2.Controls.Add(this.tbJenisupdate, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbKodeupdate, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(11, 34);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.38095F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.61905F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(352, 84);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tbJenisupdate
            // 
            this.tbJenisupdate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ljenisBindingSource, "nama_jenis", true));
            this.tbJenisupdate.Location = new System.Drawing.Point(115, 46);
            this.tbJenisupdate.Multiline = true;
            this.tbJenisupdate.Name = "tbJenisupdate";
            this.tbJenisupdate.Size = new System.Drawing.Size(234, 35);
            this.tbJenisupdate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kode Jenis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Jenis";
            // 
            // tbKodeupdate
            // 
            this.tbKodeupdate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ljenisBindingSource, "id_jenis", true));
            this.tbKodeupdate.Enabled = false;
            this.tbKodeupdate.Location = new System.Drawing.Point(115, 3);
            this.tbKodeupdate.Multiline = true;
            this.tbKodeupdate.Name = "tbKodeupdate";
            this.tbKodeupdate.Size = new System.Drawing.Size(234, 37);
            this.tbKodeupdate.TabIndex = 4;
            // 
            // gbDatajenis
            // 
            this.gbDatajenis.Controls.Add(this.gcDatajenis);
            this.gbDatajenis.Location = new System.Drawing.Point(404, 12);
            this.gbDatajenis.Name = "gbDatajenis";
            this.gbDatajenis.Size = new System.Drawing.Size(390, 526);
            this.gbDatajenis.TabIndex = 7;
            this.gbDatajenis.TabStop = false;
            this.gbDatajenis.Text = "Data Jenis";
            // 
            // gcDatajenis
            // 
            this.gcDatajenis.DataSource = this.ljenisBindingSource;
            this.gcDatajenis.Location = new System.Drawing.Point(6, 19);
            this.gcDatajenis.MainView = this.gridView1;
            this.gcDatajenis.Name = "gcDatajenis";
            this.gcDatajenis.Size = new System.Drawing.Size(378, 501);
            this.gcDatajenis.TabIndex = 0;
            this.gcDatajenis.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcDatajenis.DoubleClick += new System.EventHandler(this.gcDatajenis_DoubleClick);
            // 
            // ljenisBindingSource
            // 
            this.ljenisBindingSource.DataMember = "l_jenis";
            this.ljenisBindingSource.DataSource = this.ds_jenis;
            // 
            // ds_jenis
            // 
            this.ds_jenis.DataSetName = "ds_jenis";
            this.ds_jenis.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_jenis,
            this.colnama_jenis});
            this.gridView1.GridControl = this.gcDatajenis;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colid_jenis
            // 
            this.colid_jenis.Caption = "Kode Jenis";
            this.colid_jenis.FieldName = "id_jenis";
            this.colid_jenis.Name = "colid_jenis";
            this.colid_jenis.OptionsColumn.AllowEdit = false;
            this.colid_jenis.Visible = true;
            this.colid_jenis.VisibleIndex = 0;
            // 
            // colnama_jenis
            // 
            this.colnama_jenis.Caption = "Jenis";
            this.colnama_jenis.FieldName = "nama_jenis";
            this.colnama_jenis.Name = "colnama_jenis";
            this.colnama_jenis.OptionsColumn.AllowEdit = false;
            this.colnama_jenis.Visible = true;
            this.colnama_jenis.VisibleIndex = 1;
            // 
            // l_jenisTableAdapter
            // 
            this.l_jenisTableAdapter.ClearBeforeFill = true;
            // 
            // Jenis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 550);
            this.Controls.Add(this.gbDatajenis);
            this.Controls.Add(this.gbAksi2);
            this.Controls.Add(this.gbAksi1);
            this.Name = "Jenis";
            this.Text = "Jenis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Jenis_Load);
            this.gbAksi1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gbAksi2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.gbDatajenis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDatajenis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ljenisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_jenis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAksi1;
        private DevExpress.XtraEditors.SimpleButton btnBatal;
        private DevExpress.XtraEditors.SimpleButton btnHapus;
        private DevExpress.XtraEditors.SimpleButton btnSimpan;
        private DevExpress.XtraEditors.SimpleButton btnTambah;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbJenis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbKodejenis;
        private System.Windows.Forms.GroupBox gbAksi2;
        private DevExpress.XtraEditors.SimpleButton btnUbah;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tbJenisupdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbKodeupdate;
        private System.Windows.Forms.GroupBox gbDatajenis;
        private DevExpress.XtraGrid.GridControl gcDatajenis;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_jenis;
        private DevExpress.XtraGrid.Columns.GridColumn colnama_jenis;
        private ds_jenis ds_jenis;
        private System.Windows.Forms.BindingSource ljenisBindingSource;
        private ds_jenisTableAdapters.l_jenisTableAdapter l_jenisTableAdapter;
    }
}