namespace SIMBangunan.master
{
    partial class User
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
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbKodeuser = new System.Windows.Forms.TextBox();
            this.gbAksi2 = new System.Windows.Forms.GroupBox();
            this.btnUbah = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tbPassupdate = new System.Windows.Forms.TextBox();
            this.luserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_user = new SIMBangunan.ds_user();
            this.tbUserupdate = new System.Windows.Forms.TextBox();
            this.tbNamaupdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbKodeupdate = new System.Windows.Forms.TextBox();
            this.gbDatauser = new System.Windows.Forms.GroupBox();
            this.gcDatauser = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_user = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.l_userTableAdapter = new SIMBangunan.ds_userTableAdapters.l_userTableAdapter();
            this.gbAksi1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbAksi2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_user)).BeginInit();
            this.gbDatauser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatauser)).BeginInit();
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
            this.gbAksi1.Location = new System.Drawing.Point(7, 12);
            this.gbAksi1.Name = "gbAksi1";
            this.gbAksi1.Size = new System.Drawing.Size(386, 253);
            this.gbAksi1.TabIndex = 0;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel1.Controls.Add(this.tbPassword, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbUsername, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbNama, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbKodeuser, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 34);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.36709F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.63291F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(352, 157);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(115, 120);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(234, 34);
            this.tbPassword.TabIndex = 7;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(115, 82);
            this.tbUsername.Multiline = true;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(234, 32);
            this.tbUsername.TabIndex = 6;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(115, 42);
            this.tbNama.Multiline = true;
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(234, 34);
            this.tbNama.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // tbKodeuser
            // 
            this.tbKodeuser.Enabled = false;
            this.tbKodeuser.Location = new System.Drawing.Point(115, 3);
            this.tbKodeuser.Multiline = true;
            this.tbKodeuser.Name = "tbKodeuser";
            this.tbKodeuser.Size = new System.Drawing.Size(234, 33);
            this.tbKodeuser.TabIndex = 4;
            // 
            // gbAksi2
            // 
            this.gbAksi2.Controls.Add(this.btnUbah);
            this.gbAksi2.Controls.Add(this.tableLayoutPanel2);
            this.gbAksi2.Location = new System.Drawing.Point(7, 12);
            this.gbAksi2.Name = "gbAksi2";
            this.gbAksi2.Size = new System.Drawing.Size(386, 253);
            this.gbAksi2.TabIndex = 5;
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
            this.tableLayoutPanel2.Controls.Add(this.tbPassupdate, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.tbUserupdate, 1, 2);
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
            // tbPassupdate
            // 
            this.tbPassupdate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.luserBindingSource, "password", true));
            this.tbPassupdate.Location = new System.Drawing.Point(115, 120);
            this.tbPassupdate.Multiline = true;
            this.tbPassupdate.Name = "tbPassupdate";
            this.tbPassupdate.Size = new System.Drawing.Size(234, 34);
            this.tbPassupdate.TabIndex = 7;
            // 
            // luserBindingSource
            // 
            this.luserBindingSource.DataMember = "l_user";
            this.luserBindingSource.DataSource = this.ds_user;
            // 
            // ds_user
            // 
            this.ds_user.DataSetName = "ds_user";
            this.ds_user.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbUserupdate
            // 
            this.tbUserupdate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.luserBindingSource, "username", true));
            this.tbUserupdate.Location = new System.Drawing.Point(115, 82);
            this.tbUserupdate.Multiline = true;
            this.tbUserupdate.Name = "tbUserupdate";
            this.tbUserupdate.Size = new System.Drawing.Size(234, 32);
            this.tbUserupdate.TabIndex = 6;
            // 
            // tbNamaupdate
            // 
            this.tbNamaupdate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.luserBindingSource, "nama", true));
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
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kode User";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nama";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Password";
            // 
            // tbKodeupdate
            // 
            this.tbKodeupdate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.luserBindingSource, "id_user", true));
            this.tbKodeupdate.Enabled = false;
            this.tbKodeupdate.Location = new System.Drawing.Point(115, 3);
            this.tbKodeupdate.Multiline = true;
            this.tbKodeupdate.Name = "tbKodeupdate";
            this.tbKodeupdate.Size = new System.Drawing.Size(234, 33);
            this.tbKodeupdate.TabIndex = 4;
            // 
            // gbDatauser
            // 
            this.gbDatauser.Controls.Add(this.gcDatauser);
            this.gbDatauser.Location = new System.Drawing.Point(399, 12);
            this.gbDatauser.Name = "gbDatauser";
            this.gbDatauser.Size = new System.Drawing.Size(547, 526);
            this.gbDatauser.TabIndex = 1;
            this.gbDatauser.TabStop = false;
            this.gbDatauser.Text = "Data User";
            // 
            // gcDatauser
            // 
            this.gcDatauser.DataSource = this.luserBindingSource;
            this.gcDatauser.Location = new System.Drawing.Point(6, 19);
            this.gcDatauser.MainView = this.gridView1;
            this.gcDatauser.Name = "gcDatauser";
            this.gcDatauser.Size = new System.Drawing.Size(535, 492);
            this.gcDatauser.TabIndex = 0;
            this.gcDatauser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcDatauser.DoubleClick += new System.EventHandler(this.gcDatauser_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_user,
            this.colnama,
            this.colusername,
            this.colpassword});
            this.gridView1.GridControl = this.gcDatauser;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colid_user
            // 
            this.colid_user.Caption = "Kode User";
            this.colid_user.FieldName = "id_user";
            this.colid_user.Name = "colid_user";
            this.colid_user.OptionsColumn.AllowEdit = false;
            this.colid_user.Visible = true;
            this.colid_user.VisibleIndex = 0;
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
            // colusername
            // 
            this.colusername.Caption = "Username";
            this.colusername.FieldName = "username";
            this.colusername.Name = "colusername";
            this.colusername.OptionsColumn.AllowEdit = false;
            this.colusername.Visible = true;
            this.colusername.VisibleIndex = 2;
            // 
            // colpassword
            // 
            this.colpassword.Caption = "Password";
            this.colpassword.FieldName = "password";
            this.colpassword.Name = "colpassword";
            this.colpassword.OptionsColumn.AllowEdit = false;
            this.colpassword.Visible = true;
            this.colpassword.VisibleIndex = 3;
            // 
            // l_userTableAdapter
            // 
            this.l_userTableAdapter.ClearBeforeFill = true;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.gbAksi2);
            this.Controls.Add(this.gbDatauser);
            this.Controls.Add(this.gbAksi1);
            this.Name = "User";
            this.Text = "User";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.User_Load);
            this.gbAksi1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gbAksi2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_user)).EndInit();
            this.gbDatauser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDatauser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAksi1;
        private System.Windows.Forms.GroupBox gbDatauser;
        private DevExpress.XtraEditors.SimpleButton btnTambah;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnBatal;
        private DevExpress.XtraEditors.SimpleButton btnHapus;
        private DevExpress.XtraEditors.SimpleButton btnSimpan;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbKodeuser;
        private ds_user ds_user;
        private System.Windows.Forms.BindingSource luserBindingSource;
        private ds_userTableAdapters.l_userTableAdapter l_userTableAdapter;
        private DevExpress.XtraGrid.GridControl gcDatauser;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_user;
        private DevExpress.XtraGrid.Columns.GridColumn colnama;
        private DevExpress.XtraGrid.Columns.GridColumn colusername;
        private DevExpress.XtraGrid.Columns.GridColumn colpassword;
        private System.Windows.Forms.GroupBox gbAksi2;
        private DevExpress.XtraEditors.SimpleButton btnUbah;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tbPassupdate;
        private System.Windows.Forms.TextBox tbUserupdate;
        private System.Windows.Forms.TextBox tbNamaupdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbKodeupdate;
    }
}