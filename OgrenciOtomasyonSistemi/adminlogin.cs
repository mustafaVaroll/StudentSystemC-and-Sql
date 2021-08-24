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
    public partial class adminlogin : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        public adminlogin()
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
        private void adminlogin_FormClosing(object sender, FormClosingEventArgs e)
        {
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

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string query = "SELECT ad,sifre FROM admingiris WHERE ad= '" + txtad.Text + "' AND sifre= '" + txtsifre.Text + "'";
            if ((txtad.Text.Length > 0) && (txtsifre.Text.Length > 0))
            {
                try
                {
                    if (this.OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        MySqlDataReader rd = cmd.ExecuteReader();
                        if (rd.Read())
                        {
                            MessageBox.Show("GİRİS ONAYLANDI", "YÖNETİCİ!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            rd.Close();
                            this.closeConnection();
                            txtad.Text = "";
                            txtsifre.Text = "";
                            administrator ad = new administrator();
                            ad.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("ADMIN BULUNAMADI \n BİLGİLERİN DOĞRULUĞUNDAN EMİN OLUNUZ!!! .", "KAYIT BULUNAMADI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            this.closeConnection();
                            rd.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Bağlantınızı kontrol ediniz", "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


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
              MessageBox.Show("Gecerli bir giriş yapınız!!!");

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


        private void btnback_Click(object sender, EventArgs e)
        {
            main mn = new main();
            mn.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickertwo_ValueChanged(object sender, EventArgs e)
        {

        }


        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminlogin_Load(object sender, EventArgs e)
        {

        }

        private void adminlogin_FormClosing_1(object sender, FormClosingEventArgs e)
        {


           DialogResult closestatus = MessageBox.Show("Bu formdan cıkmakmı istiyorsunuz?", "Cıkıs", MessageBoxButtons.YesNo);
            if (closestatus == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }
    }
}