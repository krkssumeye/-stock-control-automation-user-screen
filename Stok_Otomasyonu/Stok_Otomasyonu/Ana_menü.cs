using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Otomasyonu
{
    public partial class Ana_menü : Form
    {
        public Ana_menü()
        {
            InitializeComponent();
        }
        private void Ana_menü_Load(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Ürün_İşlemleri ürün_İşlemleri = new Ürün_İşlemleri();
            ürün_İşlemleri.ShowDialog(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Personel_İşlemleri personel_İşlemleri = new Personel_İşlemleri();
            personel_İşlemleri.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Depo_Bilgileri depo_Bilgileri = new Depo_Bilgileri();
            depo_Bilgileri.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ürün_Hareketleri ürün_Hareketleri = new Ürün_Hareketleri();
            ürün_Hareketleri.ShowDialog();

        }
    }
}
