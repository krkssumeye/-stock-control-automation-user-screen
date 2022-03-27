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
    public partial class Ürün_İşlemleri : Form
    {
        public Ürün_İşlemleri()
        {
            InitializeComponent();
        }
        SqlConnection con;
        
        private void Ürün_İşlemleri_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-II2OE29\SQLEXPRESS;Initial Catalog=C#_Stok_Kontrol;Integrated Security=True");
            con.Open();
            
        }
        
        
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                string sorgu = "insert into ÜRÜN_İŞLEMLERİ (ürün_adı,ürün_barkod,ürün_fiyat,ürün_cinsiyet,ürün_adeti,ürün_kategorisi,ürün_sezonu,ürün_acıklaması,ürün_depo_id ) values (@ürün_adı,@ürün_barkod,@ürün_fiyat,@ürün_cinsiyet,@ürün_adeti,@ürün_kategorisi,@ürün_sezonu,@ürün_acıklaması,@ürün_depo_id)";
                SqlCommand cmd  = new SqlCommand( sorgu,con);
                cmd.Parameters.AddWithValue("@ürün_adı", textBox3.Text);
                cmd.Parameters.AddWithValue("@ürün_barkod", textBox2.Text);
                cmd.Parameters.AddWithValue("@ürün_fiyat", textBox7.Text);
                cmd.Parameters.AddWithValue("@ürün_cinsiyet", comboBox3.Text);
                cmd.Parameters.AddWithValue("@ürün_adeti", textBox6.Text);
                cmd.Parameters.AddWithValue("@ürün_kategorisi", comboBox1.Text);
                cmd.Parameters.AddWithValue("@ürün_sezonu", comboBox2.Text);
                cmd.Parameters.AddWithValue("@ürün_acıklaması", textBox8.Text);
                cmd.Parameters.AddWithValue("@ürün_depo_id", comboBox4.Text);
           
                cmd.ExecuteNonQuery();
               
                MessageBox.Show("Ürün Eklendi.");
          
        }



        public void Listele()
        {
            string select = "select* from ÜRÜN_İŞLEMLERİ";
            SqlDataAdapter sqlData = new SqlDataAdapter(select, con);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
           
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Listele();
        }
        public void verisil(string gfiyat)
        {
            string del = "delete from ÜRÜN_İŞLEMLERİ where ürün_adı=@ürün_adı";
            SqlCommand cmd = new SqlCommand(del, con);
          
            cmd.Parameters.AddWithValue("@ürün_adı ", gfiyat);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)

            {
                foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
                {
                    string gfiyat = Convert.ToString(drow.Cells["ürün_adı"].Value.ToString());
                    verisil(gfiyat);
                    Listele();
                    MessageBox.Show("SEÇİLEN ÜRÜN SİLİNDİ");
                
                }
            

            }
        
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
