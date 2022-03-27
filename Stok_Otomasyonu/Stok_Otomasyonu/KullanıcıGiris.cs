using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Stok_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_load(Object sender, EventArgs e)
        {
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        private void button1_Click(object sender, EventArgs e)
        {

            con = new SqlConnection(@"Data Source=DESKTOP-II2OE29\SQLEXPRESS;Initial Catalog=C#_Stok_Kontrol;Integrated Security=True");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select * from  PERSONEL_GİRİS where Kullanıcı_adi='" + textBox1.Text + "' and parola='" + textBox2.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("GİRİŞ BAŞARILI.");

                Ana_menü ana_Menü = new Ana_menü();
                ana_Menü.ShowDialog();
            }
            else
            {
                MessageBox.Show("BİLGİLERİNİZİ KONTROL EDİNİZ.");

            }
            con.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-II2OE29\SQLEXPRESS;Initial Catalog=C#_Stok_Kontrol;Integrated Security=True");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select * from  YÖNETİCİ_GİRİS where Kullanıcı_adi='" + textBox3.Text + "' and parola='" + textBox4.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("GİRİŞ BAŞARILI.");

                Yönetici_Menüsü yönetici_Menüsü = new Yönetici_Menüsü();
                yönetici_Menüsü.ShowDialog();
            }
            else
            {
                MessageBox.Show("BİLGİLERİNİZİ KONTROL EDİNİZ.");

            }
            con.Close();}

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        private void label3_Click(object sender, EventArgs e) { }
        private void Form1_Load_1(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }

    }
}
