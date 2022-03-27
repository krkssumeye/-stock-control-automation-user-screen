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
    public partial class Personel_Bilgileri : Form
    {
        public Personel_Bilgileri()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private void Personel_Bilgileri_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-II2OE29\SQLEXPRESS;Initial Catalog=C#_Stok_Kontrol;Integrated Security=True");
            con.Open();
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void Listele()
        {
            string select = "select* from PERSONEL_ISLEMLERI";
            SqlDataAdapter sqlData = new SqlDataAdapter(select, con);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Listele();
        }

       
    }
}
