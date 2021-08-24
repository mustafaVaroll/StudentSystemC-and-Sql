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
    public partial class password : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string conn;        
        public password(string value)
        {
            InitializeComponent();
            txtskuladi.Text = value;
            StartPosition = FormStartPosition.CenterScreen;
            server = "localhost";
            database = "ogrenci";
            uid = "root";
            conn = "mustafa44";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + conn+ ";";
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

        private void btnsubmitt_Click(object sender, EventArgs e)
        {
            string query = "UPDATE ogrencikayit SET sifre='"+txtsifre.Text+"' WHERE kullaniciadi ='"+ txtskuladi.Text +"'";
            if (txtsifre.Text.Contains(txtonay.Text))
            {
                try
                {
                    if (this.OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                          int RowsAffected=cmd.ExecuteNonQuery();

                        if (RowsAffected >0)
                        {                      
                           MessageBox.Show("Şifreniz başarıllı bir şekilde değiştirildi.", "SIFRE DEĞİŞTİ!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                           this.closeConnection();
                           txtskuladi.Text = "";
                           txtsifre.Text = "";
                           txtonay.Text = "";
                           student stu = new student();
                           stu.Show();
                           this.Hide();
                       }
                       else
                       {
                           MessageBox.Show("Hatalı kullanıcı adı Kontrol edip tekrar deneyiniz!!!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                           this.closeConnection();
                       }
                    }
                        else
                        {
                            MessageBox.Show("Bağlantınızı kontrol ediniz.","BAĞLANTI HATASI",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        
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
                MessageBox.Show("Tekrar deneyiniz Şifreler aynı olmak zorundadır!!!");

            }
            
            
        }

        private void password_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult closestatus = MessageBox.Show("Bu Formdan cıkmakmı istiyorsunuz?", ".cıkıs", MessageBoxButtons.YesNo);
            if (closestatus == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_Load(object sender, EventArgs e)
        {

        }
    }
}
