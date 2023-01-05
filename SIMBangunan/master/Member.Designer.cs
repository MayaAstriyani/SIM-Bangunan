namespace SIMBangunan.master
{
    partial class Member
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
            this.gbDatasupplier = new System.Windows.Forms.GroupBox();
            this.gcDatamember = new DevExpress.XtraGrid.GridControl();
            this.lmemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_member = new SIMBangunan.ds_member();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_member = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltgl_daftar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coljenis_kelamin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colno_hp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colalamat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbAksi1 = new System.Windows.Forms.GroupBox();
            this.btnBatal = new DevExpress.XtraEditors.SimpleButton();
            this.btnHapus = new DevExpress.XtraEditors.SimpleButton();
            this.btnSimpan = new DevExpress.XtraEditors.SimpleButton();
            this.btnTambah = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbKodemember = new System.Windows.Forms.TextBox();
            this.tbNohp = new System.Windows.Forms.TextBox();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dpTgldaftar = new System.Windows.Forms.DateTimePicker();
            this.cbJk = new System.Windows.Forms.ComboBox();
            this.l_memberTableAdapter = new SIMBangunan.ds_memberTableAdapters.l_memberTableAdapter();
            this.gbAksi2 = new System.Windows.Forms.GroupBox();
            this.btnUbah = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbUnama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbUkodemember = new System.Windows.Forms.TextBox();
            this.tbUnohp = new System.Windows.Forms.TextBox();
            this.tbUalamat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dpUtgl = new System.Windows.Forms.DateTimePicker();
            this.cbUjk = new System.Windows.Forms.ComboBox();
            this.gbDatasupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatamember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lmemberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_member)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.gbAksi1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.gbAksi2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatasupplier
            // 
            this.gbDatasupplier.Controls.Add(this.gcDatamember);
            this.gbDatasupplier.Location = new System.Drawing.Point(404, 12);
            this.gbDatasupplier.Name = "gbDatasupplier";
            this.gbDatasupplier.Size = new System.Drawing.Size(786, 526);
            this.gbDatasupplier.TabIndex = 10;
            this.gbDatasupplier.TabStop = false;
            this.gbDatasupplier.Text = "Data Supplier";
            // 
            // gcDatamember
            // 
            this.gcDatamember.DataSource = this.lmemberBindingSource;
            this.gcDatamember.Location = new System.Drawing.Point(6, 19);
            this.gcDatamember.MainView = this.gridView1;
            this.gcDatamember.Name = "gcDatamember";
            this.gcDatamember.Size = new System.Drawing.Size(774, 501);
            this.gcDatamember.TabIndex = 0;
            this.gcDatamember.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcDatamember.DoubleClick += new System.EventHandler(this.gcDatamember_DoubleClick);
            // 
            // lmemberBindingSource
            // 
            this.lmemberBindingSource.DataMember = "l_member";
            this.lmemberBindingSource.DataSource = this.ds_member;
            // 
            // ds_member
            // 
            this.ds_member.DataSetName = "ds_member";
            this.ds_member.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_member,
            this.colnama,
            this.coltgl_daftar,
            this.coljenis_kelamin,
            this.colno_hp,
            this.colalamat});
            this.gridView1.GridControl = this.gcDatamember;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colid_member
            // 
            this.colid_member.Caption = "Id Member";
            this.colid_member.FieldName = "id_member";
            this.colid_member.Name = "colid_member";
            this.colid_member.OptionsColumn.AllowEdit = false;
            this.colid_member.Visible = true;
            this.colid_member.VisibleIndex = 0;
            // 
            // colnama
            // 
            this.colnama.Caption = "Nama";
            this.colnama.FieldName = "nama";
            this.colnama.Name = "colnama";
            this.colnama.OptionsColumn.AllowEdit = false;
            this.colnama.Visible = true;
            this.colnama.VisibleIndex = 1;
            // 
            // coltgl_daftar
            // 
            this.coltgl_daftar.Caption = "Tanggal Daftar";
            this.coltgl_daftar.FieldName = "tgl_daftar";
            this.coltgl_daftar.Name = "coltgl_daftar";
            this.coltgl_daftar.OptionsColumn.AllowEdit = false;
            this.coltgl_daftar.Visible = true;
            this.coltgl_daftar.VisibleIndex = 2;
            // 
            // coljenis_kelamin
            // 
            this.coljenis_kelamin.Caption = "Jenis Kelamin";
            this.coljenis_kelamin.FieldName = "jenis_kelamin";
            this.coljenis_kelamin.Name = "coljenis_kelamin";
            this.coljenis_kelamin.OptionsColumn.AllowEdit = false;
            this.coljenis_kelamin.Visible = true;
            this.coljenis_kelamin.VisibleIndex = 3;
            // 
            // colno_hp
            // 
            this.colno_hp.Caption = "No Hp";
            this.colno_hp.FieldName = "no_hp";
            this.colno_hp.Name = "colno_hp";
            this.colno_hp.OptionsColumn.AllowEdit = false;
            this.colno_hp.Visible = true;
            this.colno_hp.VisibleIndex = 4;
            // 
            // colalamat
            // 
            this.colalamat.Caption = "Alamat";
            this.colalamat.FieldName = "alamat";
            this.colalamat.Name = "colalamat";
            this.colalamat.OptionsColumn.AllowEdit = false;
            this.colalamat.Visible = true;
            this.colalamat.VisibleIndex = 5;
            // 
            // gbAksi1
            // 
            this.gbAksi1.Controls.Add(this.btnBatal);
            this.gbAksi1.Controls.Add(this.btnHapus);
            this.gbAksi1.Controls.Add(this.btnSimpan);
            this.gbAksi1.Controls.Add(this.btnTambah);
            this.gbAksi1.Controls.Add(this.tableLayoutPanel3);
            this.gbAksi1.Location = new System.Drawing.Point(12, 12);
            this.gbAksi1.Name = "gbAksi1";
            this.gbAksi1.Size = new System.Drawing.Size(386, 339);
            this.gbAksi1.TabIndex = 9;
            this.gbAksi1.TabStop = false;
            this.gbAksi1.Text = "Aksi";
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(285, 291);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 4;
            this.btnBatal.Text = "Batal";
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(191, 291);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(101, 291);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 2;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(8, 291);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 1;
            this.btnTambah.Text = "Tambah Baru";
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel3.Controls.Add(this.tbNama, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tbKodemember, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbNohp, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.tbAlamat, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.label12, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.dpTgldaftar, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.cbJk, 1, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(11, 34);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(352, 231);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(115, 41);
            this.tbNama.Multiline = true;
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(234, 32);
            this.tbNama.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Kode Member";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Nama";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tanggal Daftar";
            // 
            // tbKodemember
            // 
            this.tbKodemember.Location = new System.Drawing.Point(115, 3);
            this.tbKodemember.Multiline = true;
            this.tbKodemember.Name = "tbKodemember";
            this.tbKodemember.Size = new System.Drawing.Size(234, 32);
            this.tbKodemember.TabIndex = 4;
            // 
            // tbNohp
            // 
            this.tbNohp.Location = new System.Drawing.Point(115, 155);
            this.tbNohp.Multiline = true;
            this.tbNohp.Name = "tbNohp";
            this.tbNohp.Size = new System.Drawing.Size(234, 32);
            this.tbNohp.TabIndex = 8;
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(115, 193);
            this.tbAlamat.Multiline = true;
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(234, 32);
            this.tbAlamat.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Alamat";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Jenis Kelamin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nomor HP";
            // 
            // dpTgldaftar
            // 
            this.dpTgldaftar.Location = new System.Drawing.Point(115, 79);
            this.dpTgldaftar.Name = "dpTgldaftar";
            this.dpTgldaftar.Size = new System.Drawing.Size(234, 20);
            this.dpTgldaftar.TabIndex = 12;
            // 
            // cbJk
            // 
            this.cbJk.FormattingEnabled = true;
            this.cbJk.Items.AddRange(new object[] {
            "Perempuan",
            "Laki-laki"});
            this.cbJk.Location = new System.Drawing.Point(115, 117);
            this.cbJk.Name = "cbJk";
            this.cbJk.Size = new System.Drawing.Size(234, 21);
            this.cbJk.TabIndex = 13;
            // 
            // l_memberTableAdapter
            // 
            this.l_memberTableAdapter.ClearBeforeFill = true;
            // 
            // gbAksi2
            // 
            this.gbAksi2.Controls.Add(this.btnUbah);
            this.gbAksi2.Controls.Add(this.tableLayoutPanel1);
            this.gbAksi2.Location = new System.Drawing.Point(12, 12);
            this.gbAksi2.Name = "gbAksi2";
            this.gbAksi2.Size = new System.Drawing.Size(386, 339);
            this.gbAksi2.TabIndex = 10;
            this.gbAksi2.TabStop = false;
            this.gbAksi2.Text = "Aksi Ubah";
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(8, 291);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(75, 23);
            this.btnUbah.TabIndex = 1;
            this.btnUbah.Text = "Simpan Ubah";
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel1.Controls.Add(this.tbUnama, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbUkodemember, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbUnohp, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbUalamat, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dpUtgl, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbUjk, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 34);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(352, 231);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbUnama
            // 
            this.tbUnama.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lmemberBindingSource, "nama", true));
            this.tbUnama.Location = new System.Drawing.Point(115, 41);
            this.tbUnama.Multiline = true;
            this.tbUnama.Name = "tbUnama";
            this.tbUnama.Size = new System.Drawing.Size(234, 32);
            this.tbUnama.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kode Member";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nama";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tanggal Daftar";
            // 
            // tbUkodemember
            // 
            this.tbUkodemember.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lmemberBindingSource, "id_member", true));
            this.tbUkodemember.Enabled = false;
            this.tbUkodemember.Location = new System.Drawing.Point(115, 3);
            this.tbUkodemember.Multiline = true;
            this.tbUkodemember.Name = "tbUkodemember";
            this.tbUkodemember.Size = new System.Drawing.Size(234, 32);
            this.tbUkodemember.TabIndex = 4;
            // 
            // tbUnohp
            // 
            this.tbUnohp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lmemberBindingSource, "no_hp", true));
            this.tbUnohp.Location = new System.Drawing.Point(115, 155);
            this.tbUnohp.Multiline = true;
            this.tbUnohp.Name = "tbUnohp";
            this.tbUnohp.Size = new System.Drawing.Size(234, 32);
            this.tbUnohp.TabIndex = 8;
            // 
            // tbUalamat
            // 
            this.tbUalamat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lmemberBindingSource, "alamat", true));
            this.tbUalamat.Location = new System.Drawing.Point(115, 193);
            this.tbUalamat.Multiline = true;
            this.tbUalamat.Name = "tbUalamat";
            this.tbUalamat.Size = new System.Drawing.Size(234, 32);
            this.tbUalamat.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Alamat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Jenis Kelamin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Nomor HP";
            // 
            // dpUtgl
            // 
            this.dpUtgl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lmemberBindingSource, "tgl_daftar", true));
            this.dpUtgl.Location = new System.Drawing.Point(115, 79);
            this.dpUtgl.Name = "dpUtgl";
            this.dpUtgl.Size = new System.Drawing.Size(234, 20);
            this.dpUtgl.TabIndex = 12;
            // 
            // cbUjk
            // 
            this.cbUjk.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbUjk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lmemberBindingSource, "jenis_kelamin", true));
            this.cbUjk.FormattingEnabled = true;
            this.cbUjk.Items.AddRange(new object[] {
            "Perempuan",
            "Laki-laki"});
            this.cbUjk.Location = new System.Drawing.Point(115, 122);
            this.cbUjk.Name = "cbUjk";
            this.cbUjk.Size = new System.Drawing.Size(234, 21);
            this.cbUjk.TabIndex = 13;
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 550);
            this.Controls.Add(this.gbAksi2);
            this.Controls.Add(this.gbDatasupplier);
            this.Controls.Add(this.gbAksi1);
            this.Name = "Member";
            this.Text = "Member";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Member_Load);
            this.gbDatasupplier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDatamember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lmemberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_member)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.gbAksi1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.gbAksi2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatasupplier;
        private DevExpress.XtraGrid.GridControl gcDatamember;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox gbAksi1;
        private DevExpress.XtraEditors.SimpleButton btnBatal;
        private DevExpress.XtraEditors.SimpleButton btnHapus;
        private DevExpress.XtraEditors.SimpleButton btnSimpan;
        private DevExpress.XtraEditors.SimpleButton btnTambah;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbKodemember;
        private System.Windows.Forms.TextBox tbNohp;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dpTgldaftar;
        private ds_member ds_member;
        private System.Windows.Forms.BindingSource lmemberBindingSource;
        private ds_memberTableAdapters.l_memberTableAdapter l_memberTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colid_member;
        private DevExpress.XtraGrid.Columns.GridColumn colnama;
        private DevExpress.XtraGrid.Columns.GridColumn coltgl_daftar;
        private DevExpress.XtraGrid.Columns.GridColumn coljenis_kelamin;
        private DevExpress.XtraGrid.Columns.GridColumn colno_hp;
        private DevExpress.XtraGrid.Columns.GridColumn colalamat;
        private System.Windows.Forms.ComboBox cbJk;
        private System.Windows.Forms.GroupBox gbAksi2;
        private DevExpress.XtraEditors.SimpleButton btnUbah;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbUnama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbUkodemember;
        private System.Windows.Forms.TextBox tbUnohp;
        private System.Windows.Forms.TextBox tbUalamat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dpUtgl;
        private System.Windows.Forms.ComboBox cbUjk;
    }
}