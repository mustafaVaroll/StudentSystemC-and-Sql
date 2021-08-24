namespace OgrenciOtomasyonSistemi
{
    partial class main
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnadmin = new System.Windows.Forms.Button();
            this.btnstudent = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.btnabout = new System.Windows.Forms.Button();
            this.lbltarih = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3saat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(111, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(684, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "OGRENCİ OTOMASYON SİSTEMİNE HOŞGELDİNİZ";
            // 
            // btnadmin
            // 
            this.btnadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnadmin.Location = new System.Drawing.Point(33, 137);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(334, 119);
            this.btnadmin.TabIndex = 1;
            this.btnadmin.Text = "ADMIN GİRİŞİ";
            this.btnadmin.UseVisualStyleBackColor = true;
            this.btnadmin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnstudent
            // 
            this.btnstudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnstudent.Location = new System.Drawing.Point(528, 137);
            this.btnstudent.Name = "btnstudent";
            this.btnstudent.Size = new System.Drawing.Size(379, 119);
            this.btnstudent.TabIndex = 2;
            this.btnstudent.Text = "ÖĞRENCİ GİRİŞİ";
            this.btnstudent.UseVisualStyleBackColor = true;
            this.btnstudent.Click += new System.EventHandler(this.btnstudent_Click);
            // 
            // btncikis
            // 
            this.btncikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncikis.ForeColor = System.Drawing.Color.Fuchsia;
            this.btncikis.Location = new System.Drawing.Point(819, 428);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(88, 53);
            this.btncikis.TabIndex = 3;
            this.btncikis.Text = "CIKIŞ";
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnabout
            // 
            this.btnabout.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnabout.ForeColor = System.Drawing.Color.Red;
            this.btnabout.Location = new System.Drawing.Point(12, 434);
            this.btnabout.Name = "btnabout";
            this.btnabout.Size = new System.Drawing.Size(162, 44);
            this.btnabout.TabIndex = 5;
            this.btnabout.Text = "About";
            this.btnabout.UseVisualStyleBackColor = true;
            this.btnabout.Click += new System.EventHandler(this.btnabout_Click);
            // 
            // lbltarih
            // 
            this.lbltarih.AutoSize = true;
            this.lbltarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltarih.Location = new System.Drawing.Point(65, 87);
            this.lbltarih.Name = "lbltarih";
            this.lbltarih.Size = new System.Drawing.Size(50, 24);
            this.lbltarih.TabIndex = 7;
            this.lbltarih.Text = "tarih";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3saat
            // 
            this.label3saat.AutoSize = true;
            this.label3saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3saat.Location = new System.Drawing.Point(676, 87);
            this.label3saat.Name = "label3saat";
            this.label3saat.Size = new System.Drawing.Size(47, 24);
            this.label3saat.TabIndex = 8;
            this.label3saat.Text = "saat";
            this.label3saat.Click += new System.EventHandler(this.label3time_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(919, 490);
            this.Controls.Add(this.label3saat);
            this.Controls.Add(this.lbltarih);
            this.Controls.Add(this.btnabout);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btnstudent);
            this.Controls.Add(this.btnadmin);
            this.Controls.Add(this.label1);
            this.Name = "main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadmin;
        private System.Windows.Forms.Button btnstudent;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Button btnabout;
        private System.Windows.Forms.Label lbltarih;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3saat;
    }
}