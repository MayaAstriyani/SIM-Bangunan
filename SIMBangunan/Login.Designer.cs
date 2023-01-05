namespace SIMBangunan
{
    partial class Login
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnMasuk = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SIMBangunan.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 350);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBatal);
            this.panel1.Controls.Add(this.btnMasuk);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(351, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 350);
            this.panel1.TabIndex = 1;
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.ForeColor = System.Drawing.Color.White;
            this.btnBatal.Location = new System.Drawing.Point(188, 264);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(141, 33);
            this.btnBatal.TabIndex = 12;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            // 
            // btnMasuk
            // 
            this.btnMasuk.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasuk.ForeColor = System.Drawing.Color.White;
            this.btnMasuk.Location = new System.Drawing.Point(25, 264);
            this.btnMasuk.Name = "btnMasuk";
            this.btnMasuk.Size = new System.Drawing.Size(141, 33);
            this.btnMasuk.TabIndex = 11;
            this.btnMasuk.Text = "Masuk";
            this.btnMasuk.UseVisualStyleBackColor = false;
            this.btnMasuk.Click += new System.EventHandler(this.btnMasuk_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.64474F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.35526F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbPassword, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbUsername, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 163);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(318, 70);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.Control;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(87, 38);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(228, 29);
            this.tbPassword.TabIndex = 3;
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.SystemColors.Control;
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(87, 3);
            this.tbUsername.Multiline = true;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(228, 29);
            this.tbUsername.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "aplikasi.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Silahan login terlebih dahulu untuk bisa menggunakan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Selamat Datang";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 350);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnMasuk;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}