namespace OgrenciOtomasyonSistemi
{
    partial class adminlogin
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
            this.btngiris = new System.Windows.Forms.Button();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.btncks = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labeldate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(131, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ogrenci Otomasyon Sistemi Admin Giriş";
            // 
            // btngiris
            // 
            this.btngiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngiris.Location = new System.Drawing.Point(299, 294);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(133, 48);
            this.btngiris.TabIndex = 8;
            this.btngiris.Text = "GİRİS";
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(374, 229);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '*';
            this.txtsifre.Size = new System.Drawing.Size(237, 20);
            this.txtsifre.TabIndex = 9;
            this.txtsifre.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // btncks
            // 
            this.btncks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncks.Location = new System.Drawing.Point(602, 385);
            this.btncks.Name = "btncks";
            this.btncks.Size = new System.Drawing.Size(108, 47);
            this.btncks.TabIndex = 10;
            this.btncks.Text = "CIKIŞ";
            this.btncks.UseVisualStyleBackColor = true;
            this.btncks.Click += new System.EventHandler(this.btnback_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sifre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labeldate
            // 
            this.labeldate.Location = new System.Drawing.Point(0, 0);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(100, 23);
            this.labeldate.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(197, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kullanıcı Adı:";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(374, 179);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(237, 20);
            this.txtad.TabIndex = 15;
            // 
            // adminlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(741, 441);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labeldate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncks);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.label1);
            this.Name = "adminlogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.adminlogin_FormClosing_1);
            this.Load += new System.EventHandler(this.adminlogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Button btncks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labeldate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtad;
    }
}