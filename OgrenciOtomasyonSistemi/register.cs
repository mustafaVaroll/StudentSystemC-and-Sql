using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace OgrenciOtomasyonSistemi
{
    public partial class kayit : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        public kayit()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            server = "localhost";
            database = "ogrenci";
            uid = "root";
            password = "mustafa44";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {

                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Servere bağlanmadı!!!");
                        break;
                    case 1045:
                        MessageBox.Show("Gecersiz kullanıcı adı yada şifre. Lütfen tekrar deneyin");
                        break;
                }
                return false;
            }
        }
        private bool closeConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;

        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtoname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {            
            student st = new student();
            st.Show();
            this.Hide();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            
            

            string query = "INSERT INTO ogrencikayit(ad, soyad, cinsiyet, ogrencino, bolum,kullaniciadi) VALUES('" + txtad.Text + "','" + txtsoyad.Text + "', '" + gender + "','" + txttc.Text + "','" + cmbbolum.SelectedItem + "','" + txtkulanadi.Text + "')";
            if ((txtad.Text.Length > 0) && (txtsoyad.Text.Length > 0) && (txtkulanadi.Text.Length >= 4)  &&   (txttc.Text.Length >= 7))
            {
                try
                {
                    if (this.OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kaydınız başarıyla oluştu. Şifre belirlemek için tamam a basınız","KAYIT TAMAMLANDI!!", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                        this.closeConnection();                                                              
                        txtad.Text = "";                    
                        txtsoyad.Text = "";
                        txttc.Text = "";                       
                       
                        cmbbolum.SelectedItem = "";                       
                        password ps = new password(txtkulanadi.Text);
                        ps.Show();
                        this.Hide();
                        
                    }
                    else
                    {
                        MessageBox.Show("Bağlantınızı kontrol ederek yeniden deneyiniz.", "BAĞLANTI HATASI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk
                            );


                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    this.closeConnection();
                }

            }
            else
            {
                MessageBox.Show("Gecerli bilgi giriniz!");

            }
            
        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Erkek";
        }

        public string gender { get; set; }

        private void Female_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Kadın";
        }

        private void register_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult closestatus = MessageBox.Show(" Bu formdan cıkmakmı istiyorsunuz?", "Cıkıs", MessageBoxButtons.YesNo);
            if (closestatus == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txtreg_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Cmbcourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
