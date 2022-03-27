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
    public partial class Yönetici_Menüsü : Form
    {
        public Yönetici_Menüsü()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel_Bilgileri personel_Bilgileri = new Personel_Bilgileri();
            personel_Bilgileri.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ürün_HareketleriYG ürün_HareketleriYG = new Ürün_HareketleriYG();
            ürün_HareketleriYG.ShowDialog();
        }
    }
}
