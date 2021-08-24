namespace OgrenciOtomasyonSistemi
{
    partial class kayit
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btngeri = new System.Windows.Forms.Button();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txttc = new System.Windows.Forms.TextBox();
            this.cmbbolum = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Erkek = new System.Windows.Forms.RadioButton();
            this.Kadın = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtkulanadi = new System.Windows.Forms.TextBox();
            this.labeldate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(240, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oğrenci Otomasyon Sistemi";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(417, 163);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(229, 20);
            this.txtad.TabIndex = 1;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkaydet.ForeColor = System.Drawing.Color.Lime;
            this.btnkaydet.Location = new System.Drawing.Point(471, 428);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(131, 41);
            this.btnkaydet.TabIndex = 4;
            this.btnkaydet.Text = "KAYDOL";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Soyad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cinsiyet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(99, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Bolum";
            // 
            // btngeri
            // 
            this.btngeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngeri.Location = new System.Drawing.Point(702, 461);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(124, 44);
            this.btngeri.TabIndex = 13;
            this.btngeri.Text = "GERİ";
            this.btngeri.UseVisualStyleBackColor = true;
            this.btngeri.Click += new System.EventHandler(this.btnback_Click);
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(417, 207);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(229, 20);
            this.txtsoyad.TabIndex = 14;
            this.txtsoyad.TextChanged += new System.EventHandler(this.txtoname_TextChanged);
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(416, 299);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(229, 20);
            this.txttc.TabIndex = 17;
            this.txttc.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // cmbbolum
            // 
            this.cmbbolum.FormattingEnabled = true;
            this.cmbbolum.Items.AddRange(new object[] {
            "Bilgisayar Mühendisliği",
            "Tıp",
            "Diş Hekimliği",
            "Fizyoterapi ve Rehabilitasyon",
            "Matematik Öğretmenliği",
            "Resim Öğretmenliği",
            "İBB Fakültesi",
            "Besyo"});
            this.cmbbolum.Location = new System.Drawing.Point(416, 341);
            this.cmbbolum.Name = "cmbbolum";
            this.cmbbolum.Size = new System.Drawing.Size(229, 21);
            this.cmbbolum.TabIndex = 19;
            this.cmbbolum.SelectedIndexChanged += new System.EventHandler(this.Cmbcourse_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(98, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(698, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "Kayıt için gerekli alanları doldurunuz ve kaydol butonuna basınız ";
            // 
            // Erkek
            // 
            this.Erkek.AutoSize = true;
            this.Erkek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Erkek.Location = new System.Drawing.Point(416, 249);
            this.Erkek.Name = "Erkek";
            this.Erkek.Size = new System.Drawing.Size(73, 24);
            this.Erkek.TabIndex = 23;
            this.Erkek.TabStop = true;
            this.Erkek.Text = "Erkek";
            this.Erkek.UseVisualStyleBackColor = true;
            this.Erkek.CheckedChanged += new System.EventHandler(this.Male_CheckedChanged);
            // 
            // Kadın
            // 
            this.Kadın.AutoSize = true;
            this.Kadın.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kadın.Location = new System.Drawing.Point(560, 249);
            this.Kadın.Name = "Kadın";
            this.Kadın.Size = new System.Drawing.Size(72, 24);
            this.Kadın.TabIndex = 24;
            this.Kadın.TabStop = true;
            this.Kadın.Text = "Kadın";
            this.Kadın.UseVisualStyleBackColor = true;
            this.Kadın.CheckedChanged += new System.EventHandler(this.Female_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(99, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 24);
            this.label8.TabIndex = 25;
            this.label8.Text = "Kullanıcı adı";
            // 
            // txtkulanadi
            // 
            this.txtkulanadi.Location = new System.Drawing.Point(417, 117);
            this.txtkulanadi.Name = "txtkulanadi";
            this.txtkulanadi.Size = new System.Drawing.Size(229, 20);
            this.txtkulanadi.TabIndex = 26;
            this.txtkulanadi.TextChanged += new System.EventHandler(this.txtreg_TextChanged);
            // 
            // labeldate
            // 
            this.labeldate.Location = new System.Drawing.Point(0, 0);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(100, 23);
            this.labeldate.TabIndex = 0;
            // 
            // kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(859, 517);
            this.Controls.Add(this.labeldate);
            this.Controls.Add(this.txtkulanadi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Kadın);
            this.Controls.Add(this.Erkek);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbbolum);
            this.Controls.Add(this.txttc);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label1);
            this.Name = "kayit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.register_FormClosing);
            this.Load += new System.EventHandler(this.register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.ComboBox cmbbolum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton Erkek;
        private System.Windows.Forms.RadioButton Kadın;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtkulanadi;
        private System.Windows.Forms.Label labeldate;
    }
}