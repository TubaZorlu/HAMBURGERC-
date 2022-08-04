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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnEkstraMalzeme_Click(object sender, EventArgs e)
        {
            EkstraMalzeme yeniEkstraMalzemeEkle = new EkstraMalzeme()
            {
                MalzemeAdi = txtEkstraMalzeme.Text,
                MalzemeFiyati=(double)nmrEkstraMalzemeFiyat.Value,

            };

            Form2.hamburgerci._ektstraMalzeme.Add(yeniEkstraMalzemeEkle);

          
        }
    }
}
