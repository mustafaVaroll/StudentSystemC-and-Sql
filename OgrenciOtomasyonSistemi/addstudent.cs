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
using MySql.Data.MySqlClient;

namespace OgrenciOtomasyonSistemi
{
    public partial class addstudent : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public addstudent()
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
                        MessageBox.Show("Gecersiz kullanaıcı adı yada şifre. Lütfen tekrar deneyin");
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
        private void addstudent_Load(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            txtadres.Text = "";
            txtemail.Text = "";
            txtad.Text = "";
            txtidno.Text = "";
            txtsoyad.Text = "";
            txttel.Text = "";
            txtogno.Text = "";
            txtsinif.Text = "";
            cmbbolum.Text = "";
            administrator adm = new administrator();
            adm.Show();
            this.Hide();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO ogrenciekle(ad, soyad, ogrencino, sinif, bolum, email, tel, adres , cinsiyet) VALUES('" + txtad.Text + "','" + txtsoyad.Text + "','" + txtogno.Text + "','"+txtidno.Text+"','"+txtsinif.Text+"','"+cmbbolum.SelectedItem+"','"+txtemail.Text+"','"+txttel.Text+"','"+txtadres.Text+"','"+gender+"')";
            if ((txtad.Text.Length > 0) && (txtsoyad.Text.Length > 0) && (txtogno.Text.Length >= 4) && (txtemail.Text.Contains("@")) && (txtsinif.Text.Length > 0) && (txttel.Text.Length >= 8) && (txtidno.Text.Length >= 7) && (txtadres.Text.Length >= 4) && (txtad.Text.Length > 0))
            {
                try
                {
                    if (this.OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Eklendi","BAŞARILI BİR ŞEKİLDE!!!", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                        this.closeConnection();
                        txtadres.Text = "";
                        txtemail.Text = "";
                        txtad.Text = "";
                        txtidno.Text = "";
                        txtsoyad.Text = "";
                        txttel.Text = "";
                        txtogno.Text = "";
                        txtsinif.Text = "";                     
                        cmbbolum.Text = "";
                        addstudent add = new addstudent();
                        add.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Eklenemedi bağlantınızı kontrol edin");
                       
                                             

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
                MessageBox.Show("Bütün bilgileri uygun formatta ve uzunlukta girmelisiniz!");
                
            }
        }

        private void radioButton1male_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Erkek";
         

        }

        public string gender { get; set; }

        private void radioButton2female_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Kadın";
        }

        private void dateTimePickerone_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void addstudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult closestatus = MessageBox.Show("Formu kapatmak istiyormusun?", "Cıkış", MessageBoxButtons.YesNo);
            if (closestatus == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txtdate_TextChanged(object sender, EventArgs e)
        {
          
           
        }

        private void cmbcourse_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Txtad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
