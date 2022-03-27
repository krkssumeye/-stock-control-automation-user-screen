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
    public partial class Depo_Bilgileri : Form
    {
        public Depo_Bilgileri()
        {
            InitializeComponent();

        }
        SqlConnection con;
        private void Depo_Bilgileri_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-II2OE29\SQLEXPRESS;Initial Catalog=C#_Stok_Kontrol;Integrated Security=True");
            con.Open();
        }
        public void Listele()
        {
            string select = "select*from ÜRÜN_İŞLEMLERİ where  ürün_depo_id = 1 ";
            SqlDataAdapter sqlData = new SqlDataAdapter(select, con);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Listele();
        }

        public void Listele1()
        {
            string select = "select*from ÜRÜN_İŞLEMLERİ where  ürün_depo_id = 2 ";
            SqlDataAdapter sqlData = new SqlDataAdapter(select, con);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);
            dataGridView2.DataSource = dataTable;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Listele1();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
