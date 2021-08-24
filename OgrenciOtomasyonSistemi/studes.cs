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
    public partial class studes : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        public studes()
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
                        MessageBox.Show("Gecersiz kullnaıcı adı yada şifre. Lütfen tekrar deneyin");
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


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {          
            student sta = new student();
            sta.Show();
            this.Hide();
        }        

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtogrenno.Text.Length > 0)
               {
            try
            {
               

                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    string query = "select * from  ogrenciekle where ogrencino='"+txtogrenno.Text+"'";
                    cmd.CommandText = query;
                    MySqlDataAdapter dsa = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dsa.Fill(dt);
                    dview.DataSource = dt;
                    txtogrenno.Text = "";
                    this.closeConnection();                                                                              
                }
                else
                {
                    MessageBox.Show("Hata oluştu bağlantınızı kontrol ediniz!");
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlanamıyor", ex.Message);
                this.closeConnection();
            }

            }
                else
                {
                    MessageBox.Show("ogrenci numaranızı girin lütfen!!!");
                }

        }

        private void studes_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult closestatus = MessageBox.Show("Bu formdan cıkmakmı istiyorsunuz?", "Cıkıs", MessageBoxButtons.YesNo);
            if (closestatus == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void studes_Load(object sender, EventArgs e)
        {

        }

       

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
    }

