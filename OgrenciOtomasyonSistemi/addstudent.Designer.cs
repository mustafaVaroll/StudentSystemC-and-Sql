namespace OgrenciOtomasyonSistemi
{
    partial class addstudent
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
            this.btnkaydet = new System.Windows.Forms.Button();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnkapa = new System.Windows.Forms.Button();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtogno = new System.Windows.Forms.TextBox();
            this.txtidno = new System.Windows.Forms.TextBox();
            this.txtsinif = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.cmbbolum = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.radioButton1male = new System.Windows.Forms.RadioButton();
            this.radioButton2female = new System.Windows.Forms.RadioButton();
            this.labeltime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnkaydet
            // 
            this.btnkaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkaydet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnkaydet.Location = new System.Drawing.Point(751, 243);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(164, 74);
            this.btnkaydet.TabIndex = 0;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(358, 138);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(275, 20);
            this.txtad.TabIndex = 1;
            this.txtad.TextChanged += new System.EventHandler(this.Txtad_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(303, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Öğrenci Otomasyon Sistemi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ogrenci No:";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "TC:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(97, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sınıf:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(97, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Bolum:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(97, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Email:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(303, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(377, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "Bilgilerinizi yazın ve kaydete basın";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(97, 407);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Cep Telefon:";
            this.label11.Click += new System.EventHandler(this.Label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(97, 444);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Adres:";
            // 
            // btnkapa
            // 
            this.btnkapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkapa.ForeColor = System.Drawing.Color.Red;
            this.btnkapa.Location = new System.Drawing.Point(806, 510);
            this.btnkapa.Name = "btnkapa";
            this.btnkapa.Size = new System.Drawing.Size(109, 32);
            this.btnkapa.TabIndex = 16;
            this.btnkapa.Text = "KAPAT";
            this.btnkapa.UseVisualStyleBackColor = true;
            this.btnkapa.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(358, 180);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(275, 20);
            this.txtsoyad.TabIndex = 18;
            // 
            // txtogno
            // 
            this.txtogno.Location = new System.Drawing.Point(358, 218);
            this.txtogno.Name = "txtogno";
            this.txtogno.Size = new System.Drawing.Size(275, 20);
            this.txtogno.TabIndex = 20;
            // 
            // txtidno
            // 
            this.txtidno.Location = new System.Drawing.Point(358, 257);
            this.txtidno.Name = "txtidno";
            this.txtidno.Size = new System.Drawing.Size(275, 20);
            this.txtidno.TabIndex = 21;
            // 
            // txtsinif
            // 
            this.txtsinif.Location = new System.Drawing.Point(358, 299);
            this.txtsinif.Name = "txtsinif";
            this.txtsinif.Size = new System.Drawing.Size(275, 20);
            this.txtsinif.TabIndex = 22;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(358, 373);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(275, 20);
            this.txtemail.TabIndex = 24;
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(358, 407);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(275, 20);
            this.txttel.TabIndex = 25;
            // 
            // txtadres
            // 
            this.txtadres.Location = new System.Drawing.Point(358, 444);
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(275, 20);
            this.txtadres.TabIndex = 26;
            // 
            // cmbbolum
            // 
            this.cmbbolum.FormattingEnabled = true;
            this.cmbbolum.Items.AddRange(new object[] {
            "Bilgisayar Mühendisliği",
            "Tıp",
            "Diş  Hekimliği",
            "Fizyoterapi ve Rehabilitasyon",
            "Matematik Öğretmenliği",
            "Resim Öğretmenliği",
            "İBB Fakültesi",
            "Besyo"});
            this.cmbbolum.Location = new System.Drawing.Point(358, 336);
            this.cmbbolum.Name = "cmbbolum";
            this.cmbbolum.Size = new System.Drawing.Size(275, 21);
            this.cmbbolum.TabIndex = 27;
            this.cmbbolum.SelectedIndexChanged += new System.EventHandler(this.cmbcourse_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(97, 478);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Cinsiyet";
            // 
            // radioButton1male
            // 
            this.radioButton1male.AutoSize = true;
            this.radioButton1male.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1male.Location = new System.Drawing.Point(358, 481);
            this.radioButton1male.Name = "radioButton1male";
            this.radioButton1male.Size = new System.Drawing.Size(81, 28);
            this.radioButton1male.TabIndex = 34;
            this.radioButton1male.TabStop = true;
            this.radioButton1male.Text = "Erkek";
            this.radioButton1male.UseVisualStyleBackColor = true;
            this.radioButton1male.CheckedChanged += new System.EventHandler(this.radioButton1male_CheckedChanged);
            // 
            // radioButton2female
            // 
            this.radioButton2female.AutoSize = true;
            this.radioButton2female.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2female.Location = new System.Drawing.Point(505, 481);
            this.radioButton2female.Name = "radioButton2female";
            this.radioButton2female.Size = new System.Drawing.Size(81, 28);
            this.radioButton2female.TabIndex = 35;
            this.radioButton2female.TabStop = true;
            this.radioButton2female.Text = "Kadın";
            this.radioButton2female.UseVisualStyleBackColor = true;
            this.radioButton2female.CheckedChanged += new System.EventHandler(this.radioButton2female_CheckedChanged);
            // 
            // labeltime
            // 
            this.labeltime.Location = new System.Drawing.Point(0, 0);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(100, 23);
            this.labeltime.TabIndex = 0;
            // 
            // addstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(955, 554);
            this.Controls.Add(this.labeltime);
            this.Controls.Add(this.radioButton2female);
            this.Controls.Add(this.radioButton1male);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbbolum);
            this.Controls.Add(this.txtadres);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtsinif);
            this.Controls.Add(this.txtidno);
            this.Controls.Add(this.txtogno);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.btnkapa);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.btnkaydet);
            this.Name = "addstudent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.addstudent_FormClosing);
            this.Load += new System.EventHandler(this.addstudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnkapa;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtogno;
        private System.Windows.Forms.TextBox txtidno;
        private System.Windows.Forms.TextBox txtsinif;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtadres;
        private System.Windows.Forms.ComboBox cmbbolum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton radioButton1male;
        private System.Windows.Forms.RadioButton radioButton2female;
        private System.Windows.Forms.Label labeltime;
    }
}