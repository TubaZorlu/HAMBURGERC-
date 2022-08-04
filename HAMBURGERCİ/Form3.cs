using HAMBURGERCİ.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HAMBURGERCİ
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnMenuKaydet_Click(object sender, EventArgs e)
        {
            Menuler yeniMenuEkle = new Menuler()

            {
                MenuAdi = txtMenu.Text,
                MenuFiyati=(double)nmrMenuFiyat.Value
            
            };

            Form2.hamburgerci._Menuler.Add(yeniMenuEkle);

        }
    }
}
