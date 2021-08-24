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
    public partial class main : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public main()
        {
            InitializeComponent();
            timer1.Start();
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

        private void button1_Click(object sender, EventArgs e)
        {
            adminlogin ad = new adminlogin();
            ad.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cıkmak istediğinize eminmisiniz", "Cıkıs", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {

                MessageBox.Show("Teşekürler!", "",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                this.Hide();

            }
           

        }
        private void btnstudent_Click(object sender, EventArgs e)
        {
            student st = new student();
            st.Show();
            this.Hide();
        }

        private void btnabout_Click(object sender, EventArgs e)
        {
            about ab = new about();
            ab.Show();
            this.Hide();
        }

       

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult closestatus = MessageBox.Show("Cıkmak istediğinize eminmisiniz ?", "cıkıs" ,MessageBoxButtons.YesNo);
            if (closestatus == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
          label3saat.Text = DateTime.Now.ToLongTimeString();
          timer1.Start();
        }

        private void label3time_Click(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbltarih.Text = DateTime.Now.ToLongDateString();
            label3saat.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
