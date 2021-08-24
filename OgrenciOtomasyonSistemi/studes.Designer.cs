namespace OgrenciOtomasyonSistemi
{
    partial class studes
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
            this.dview = new System.Windows.Forms.DataGridView();
            this.btncks = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtogrenno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnara = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dview)).BeginInit();
            this.SuspendLayout();
            // 
            // dview
            // 
            this.dview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dview.Location = new System.Drawing.Point(411, 87);
            this.dview.Name = "dview";
            this.dview.Size = new System.Drawing.Size(555, 358);
            this.dview.TabIndex = 0;
            // 
            // btncks
            // 
            this.btncks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncks.Location = new System.Drawing.Point(836, 451);
            this.btncks.Name = "btncks";
            this.btncks.Size = new System.Drawing.Size(130, 35);
            this.btncks.TabIndex = 1;
            this.btncks.Text = "CIKIŞ";
            this.btncks.UseVisualStyleBackColor = true;
            this.btncks.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(252, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ogrenci Otomasyon Sistemi";
            // 
            // txtogrenno
            // 
            this.txtogrenno.Location = new System.Drawing.Point(138, 138);
            this.txtogrenno.Multiline = true;
            this.txtogrenno.Name = "txtogrenno";
            this.txtogrenno.Size = new System.Drawing.Size(256, 31);
            this.txtogrenno.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ogrenci No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(651, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ogrenci numarası girip ara butonuna basarak sistemde olup olmadığına bakabilrsini" +
    "z::";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // btnara
            // 
            this.btnara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnara.Location = new System.Drawing.Point(222, 223);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(97, 29);
            this.btnara.TabIndex = 9;
            this.btnara.Text = "ARA";
            this.btnara.UseVisualStyleBackColor = true;
            this.btnara.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // studes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(978, 498);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtogrenno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncks);
            this.Controls.Add(this.dview);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "studes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.studes_FormClosing);
            this.Load += new System.EventHandler(this.studes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dview;
        private System.Windows.Forms.Button btncks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtogrenno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnara;
    }
}