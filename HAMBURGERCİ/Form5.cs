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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

        }

       
   

        private void Form5_Load(object sender, EventArgs e)
        {

            

            if (Form2.hamburgerci.eklenenSiparis.Count>0)
            {


                foreach (var item in Form2.hamburgerci.eklenenSiparis)
                {
             
                    lbxTümSiparisler.Items.Add($"Satılan toplam ürün : {item.SatilanToplamUrun}");
                    lblSatilanToplamUrun.Text = item.SatilanToplamUrun.ToString();
                    lbxTümSiparisler.Items.Add($"Sipariş edilen menü adedi : {item.SiparisAdedi}");
                    LblToplamAdet.Text = item.SiparisAdedi.ToString();
                    lbxTümSiparisler.Items.Add($"Sipariş edilen esktra malzeme tutarı  : {item.EkstraMalzemeTutari} TL");
                    lblEkstaMalzeme.Text = item.EkstraMalzemeTutari.ToString();
                    lbxTümSiparisler.Items.Add($"Toplam Sipariş tutarı  : {item.SiparisToplamTutari} TL");
                    lblCiro.Text = item.SiparisToplamTutari.ToString();
                }
            }
            else
            {
                MessageBox.Show("Gösterecek bir sipariş yok");
            }
            
            
        }
    }
}
