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
    public partial class Ürün_Hareketleri : Form
    {
        public Ürün_Hareketleri()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private void Ürün_Hareketleri_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-II2OE29\SQLEXPRESS;Initial Catalog=C#_Stok_Kontrol;Integrated Security=True");
            con.Open();

        }
        
      

        private void button1_Click(object sender, EventArgs e)
        {
            string ekle = "insert into ÜRÜN_HAREKETLERİ (ürün_id,işlem_yapan_personel_id,giris_depo_id,cikis_depo_id) values (@ürün_id,@işlem_yapan_personel_id,@giris_depo_id,@cikis_depo_id)";
            SqlCommand cmd = new SqlCommand(ekle, con);
            cmd.Parameters.AddWithValue("@ürün_id", comboBox1.Text);
            cmd.Parameters.AddWithValue("@işlem_yapan_personel_id", comboBox2.Text);
            cmd.Parameters.AddWithValue("@giris_depo_id", comboBox3.Text);
            cmd.Parameters.AddWithValue("@cikis_depo_id", comboBox4.Text);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Ürün Hareket Bilgisi Eklendi.");
        }

        public void Listele()
        {
            string select = "select* from ÜRÜN_HAREKETLERİ";
            SqlDataAdapter sqlData = new SqlDataAdapter(select, con);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Listele();


        }
        public void verisil(string sil)
        {
            string del = "delete from ÜRÜN_HAREKETLERİ where ürün_adı=@ürün_id";
            SqlCommand cmd = new SqlCommand(del, con);

            cmd.Parameters.AddWithValue("@ürün_id ", sil);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                string sil = Convert.ToString(drow.Cells["ürün_id"].Value.ToString());
                verisil(sil);
                Listele();
                MessageBox.Show("SEÇİLEN VERİ SİLİNDİ");

            }
        }
    }
}
