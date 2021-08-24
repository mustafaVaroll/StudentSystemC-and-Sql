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
    public partial class deletestudent : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        public deletestudent()
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

        private void btnclose_Click(object sender, EventArgs e)
        {
            administrator adm = new administrator();
            adm.Show();
            this.Hide();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            try
            {
                if(this.OpenConnection()==true)
                {
                if (txtogno.Text.Length > 0)
                {                                     
                    string query = "DELETE FROM ogrenciekle WHERE ogrencino='" + txtogno.Text + "'";

                    if (MessageBox.Show("Silmek istediğinize eminmisiniz?", "Sime isteği", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        cmd = new MySqlCommand(query, connection);

                        int RowsAffected = cmd.ExecuteNonQuery();
                        if (RowsAffected > 0)
                        {
                            MessageBox.Show("Başarıyla silindi!", "Kayıt Silindi");
                            txtogno.Text = "";
                            this.closeConnection();
                           
                        }
                      
                    }
                    else
                    {
                        MessageBox.Show("Silme iptal edildi");
                      this.closeConnection();
                    }
                }
                else
                {
                    MessageBox.Show("Eksik bilgi", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.closeConnection();
                }
                }
                    else
                    {
                        MessageBox.Show("Bağlantınızı kontrol ediniz!!");
        
                    }
            

            }

            catch (Exception ex)
            {
                MessageBox.Show( "Silinemiyor " + ex.Message);
                this.closeConnection();
            }

          
          

        }

        private void deletestudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult closestatus = MessageBox.Show("Bu formdan cıkmakmı istiyorsunuz?", "Cıkıs", MessageBoxButtons.YesNo);
            if (closestatus == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Deletestudent_Load(object sender, EventArgs e)
        {

        }
    }
}
