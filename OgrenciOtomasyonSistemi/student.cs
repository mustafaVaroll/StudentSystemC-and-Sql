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
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlTypes;


namespace OgrenciOtomasyonSistemi
{
    public partial class student : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        public student()
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

        private void student_Load(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Her zaman bekleriz","",MessageBoxButtons.OK,MessageBoxIcon.None);
            this.Hide();
        }

        private void btnREGISTER_Click(object sender, EventArgs e)
        {
            kayit rs = new kayit();
            rs.Show();
            this.Hide();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string query = "SELECT ogrencino,sifre FROM ogrencikayit WHERE ogrencino= '"+txtkullanadi.Text+"' AND sifre = '"+txtsifre.Text+"'";                     
            if ((txtkullanadi.Text.Length > 0) &&(txtsifre.Text.Length>0)) 
            {
                try
                {
                    if (this.OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        MySqlDataReader rd = cmd.ExecuteReader();
                        if (rd.Read())
                        {
                            MessageBox.Show("Giriş başarılı bir şekilde gercekleşti", "GİRİŞ ONAYLANDI!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            rd.Close();
                            this.closeConnection();
                            txtkullanadi.Text = "";
                            txtsifre.Text = "";
                            studes rs = new studes();
                            rs.Show();
                            this.Hide();
                
                        }
                        else
                        {
                            MessageBox.Show("Bilgiler bulunamadı üye olup tekrar deneyiniz","ÜYELİK YOK",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                            this.closeConnection();
                            rd.Close();
                        }
                                                
                    }
                    else
                    {
                        MessageBox.Show("Bağlantınızı kontrol edip yeniden deneyiniz.","BAĞLANTI HATASI",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);


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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void student_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult closestatus = MessageBox.Show("Bu formdan cıkmakmı istiyorsunuz?", "Cıkıs", MessageBoxButtons.YesNo);
            if (closestatus == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
