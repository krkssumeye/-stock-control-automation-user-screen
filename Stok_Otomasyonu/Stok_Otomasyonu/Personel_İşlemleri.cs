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
    public partial class Personel_İşlemleri : Form
    {
        public Personel_İşlemleri()
        {
            InitializeComponent();
            
        }
        SqlConnection con;

        private void Personel_İşlemleri_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-II2OE29\SQLEXPRESS;Initial Catalog=C#_Stok_Kontrol;Integrated Security=True");
            con.Open();
        }



        private void button3_Click(object sender, EventArgs e)
        {
           
            string sorgu = "insert into PERSONEL_ISLEMLERI(ad,soyad,telefon_no,eposta,dogum_tarihi,kullanici_adi,parola,depo_adı_id) values (@ad,@soyad,@telefon_no,@eposta,@dogum_tarihi,@kullanici_adi,@parola,@depo_adı_id)";
            SqlCommand cmd = new SqlCommand(sorgu, con);
           
            cmd.Parameters.AddWithValue("@ad", textBox5.Text);
            cmd.Parameters.AddWithValue("@soyad", textBox1.Text);
            cmd.Parameters.AddWithValue("@telefon_no", textBox2.Text);
            cmd.Parameters.AddWithValue("@eposta", textBox3.Text);
            cmd.Parameters.AddWithValue("@dogum_tarihi", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@kullanici_adi", textBox6.Text);
            cmd.Parameters.AddWithValue("@parola", textBox9.Text);
            cmd.Parameters.AddWithValue("@depo_adı_id", textBox10.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Personel Eklendi.");
            
        }

       
        public void Listele()
        {
            string select = "select* from PERSONEL_ISLEMLERI";
            SqlDataAdapter sqlData = new SqlDataAdapter(select, con);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

        }
        private void button4_Click(object sender, EventArgs e)
        {
            Listele();
            
        }

        public void verisil(string gpersonel)
        {
            string del = "delete from PERSONEL_ISLEMLERI where ad=@ad";
            SqlCommand cmd = new SqlCommand(del, con);

            cmd.Parameters.AddWithValue("@ad ", gpersonel);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                string gpersonel = Convert.ToString(drow.Cells["ad"].Value.ToString());
                verisil(gpersonel);
                Listele();
                MessageBox.Show("SEÇİLEN PERSONEL SİLİNDİ");

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
