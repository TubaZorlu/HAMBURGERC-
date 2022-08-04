
using HAMBURGERCİ.Abstract;
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
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
            
        }

        double[] KucukMenuFiyat = new double[0];
        double[] OrtaMenuFiyat = new double[0];
        double[] BuyukMenuFiyat = new double[0];
        double ToplamFiyat;
        string[] SecilenEkstra;

        public static Hamburgerci hamburgerci;
        CheckBox chk;

        private void Form2_Load(object sender, EventArgs e)
        {
           
            hamburgerci = new Hamburgerci();
        
            EkstraMalzeme ekstraMalzemeler1 = new EkstraMalzeme()
            {
                MalzemeAdi = "Ketçap",
                MalzemeFiyati = 1,
            };
            EkstraMalzeme ekstraMalzemeler2 = new EkstraMalzeme()
            {
                MalzemeAdi = "Mayonez",
                MalzemeFiyati = 1,
            };
            EkstraMalzeme ekstraMalzemeler3 = new EkstraMalzeme()
            {
                MalzemeAdi = "Hardal",
                MalzemeFiyati = 1,
            };
            EkstraMalzeme ekstraMalzemeler4 = new EkstraMalzeme()
            {
                MalzemeAdi = "BBQ",
                MalzemeFiyati = 1,
            };

            EkstraMalzeme ekstraMalzemeler5 = new EkstraMalzeme()
            {
                MalzemeAdi = "Chedar",
                MalzemeFiyati = 8,
            };
            EkstraMalzeme ekstraMalzemeler6 = new EkstraMalzeme()
            {
                MalzemeAdi = "Turşu",
                MalzemeFiyati = 5,
            };

          
            hamburgerci._ektstraMalzeme.Add(ekstraMalzemeler1);
            hamburgerci._ektstraMalzeme.Add(ekstraMalzemeler2);
            hamburgerci._ektstraMalzeme.Add(ekstraMalzemeler3);
            hamburgerci._ektstraMalzeme.Add(ekstraMalzemeler4);
            hamburgerci._ektstraMalzeme.Add(ekstraMalzemeler5);
            hamburgerci._ektstraMalzeme.Add(ekstraMalzemeler6);

            foreach (var item in hamburgerci._ektstraMalzeme)
            {
                chk = new CheckBox();
                flpEkstraMalzemeler.Controls.Add(chk);
                chk.Text = item.MalzemeAdi;

            }

            rdbKucuk.Checked = true;

        }
        private void rdbKucuk_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbKucuk.Checked==true)
            {
               
                Menuler yeniMenu = new Menuler()
                {
                    MenuAdi = "Whopper Jr.",
                    MenuFiyati = 60,

                };

                Menuler yeniMenu1 = new Menuler
                {
                    MenuAdi = "Big King",
                    MenuFiyati = 70
                };

                Menuler yeniMenu2 = new Menuler
                {
                    MenuAdi = "Texsas Smokehouse",
                    MenuFiyati = 110
                };

                Menuler yeniMenu3 = new Menuler
                {
                    MenuAdi = "Chicken Royale",
                    MenuFiyati = 60
                };
                Menuler yeniMenu4 = new Menuler
                {
                    MenuAdi = "Steakhouse",
                    MenuFiyati = 90
                };

                hamburgerci._Menuler.Clear();

                hamburgerci._Menuler.Add(yeniMenu);
                hamburgerci._Menuler.Add(yeniMenu1);
                hamburgerci._Menuler.Add(yeniMenu2);
                hamburgerci._Menuler.Add(yeniMenu3);
                hamburgerci._Menuler.Add(yeniMenu4);

                foreach (var item in hamburgerci._Menuler)
                {
                    cmbMenuler.Items.Add(item.MenuAdi);
                    Array.Resize(ref KucukMenuFiyat, KucukMenuFiyat.Length + 1);
                    KucukMenuFiyat[KucukMenuFiyat.Length - 1] = item.MenuFiyati;
                }

                

            }

        }

        private void rdbOrta_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbOrta.Checked==true)
            {
         
                Menuler yeniMenu = new Menuler()
                {
                    MenuAdi = "Whopper Jr.",
                    MenuFiyati = 72,

                };

                Menuler yeniMenu1 = new Menuler
                {
                    MenuAdi = "Big King",
                    MenuFiyati = 84
                };

                Menuler yeniMenu2 = new Menuler
                {
                    MenuAdi = "Texsas Smokehouse",
                    MenuFiyati = 132
                };

                Menuler yeniMenu3 = new Menuler
                {
                    MenuAdi = "Chicken Royale",
                    MenuFiyati = 72
                };
                Menuler yeniMenu4 = new Menuler
                {
                    MenuAdi = "Steakhouse",
                    MenuFiyati = 108
                };

                hamburgerci._Menuler.Clear();
          
                hamburgerci._Menuler.Add(yeniMenu);
                hamburgerci._Menuler.Add(yeniMenu1);
                hamburgerci._Menuler.Add(yeniMenu2);
                hamburgerci._Menuler.Add(yeniMenu3);
                hamburgerci._Menuler.Add(yeniMenu4);

                foreach (var item in hamburgerci._Menuler)
                {
                  
                    Array.Resize(ref OrtaMenuFiyat, OrtaMenuFiyat.Length + 1);
                    OrtaMenuFiyat[OrtaMenuFiyat.Length - 1] = item.MenuFiyati;
                }
            }

        }

        private void rdbBuyuk_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBuyuk.Checked==true)
            {
                Menuler yeniMenu = new Menuler()
                {
                    MenuAdi = "Whopper Jr.",
                    MenuFiyati = 70,

                };

                Menuler yeniMenu1 = new Menuler
                {
                    MenuAdi = "Big King",
                    MenuFiyati = 87
                };

                Menuler yeniMenu2 = new Menuler
                {
                    MenuAdi = "Texsas Smokehouse",
                    MenuFiyati = 135
                };

                Menuler yeniMenu3 = new Menuler
                {
                    MenuAdi = "Chicken Royale",
                    MenuFiyati = 80
                };
                Menuler yeniMenu4 = new Menuler
                {
                    MenuAdi = "Steakhouse",
                    MenuFiyati = 112
                };

                hamburgerci._Menuler.Clear();
                
                hamburgerci._Menuler.Add(yeniMenu);
                hamburgerci._Menuler.Add(yeniMenu1);
                hamburgerci._Menuler.Add(yeniMenu2);
                hamburgerci._Menuler.Add(yeniMenu3);
                hamburgerci._Menuler.Add(yeniMenu4);

                foreach (var item in hamburgerci._Menuler)
                {
                   
                    Array.Resize(ref BuyukMenuFiyat, BuyukMenuFiyat.Length + 1);
                    BuyukMenuFiyat[BuyukMenuFiyat.Length - 1] = item.MenuFiyati;
                }
            }
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
          

            ToplamFiyat = 0;
            SecilenEkstra = new string[0];
            foreach (var item in flpEkstraMalzemeler.Controls)
            {                

                if (((CheckBox)item).Checked == true)
                {

                    foreach (var item1 in hamburgerci._ektstraMalzeme)
                    {
                        if (((CheckBox)item).Text == item1.MalzemeAdi)
                        {
                            ToplamFiyat = ToplamFiyat + item1.MalzemeFiyati;
                            Array.Resize(ref SecilenEkstra, SecilenEkstra.Length + 1);
                            SecilenEkstra[SecilenEkstra.Length - 1] = item1.MalzemeAdi;
                        }
                    }

                }

                  ((CheckBox)item).Checked = false;

            }

            if (rdbKucuk.Checked == true)
            {
                kucukSiparisEkleme();            
            }

            else if (rdbOrta.Checked==true)
            {
                ortaSiparisEkleme();
            }

            else if (rdbBuyuk.Checked==true)
            {
                buyuksiparisEkleme();
            }

        }

        EklenenMenu eklenenMenu = new EklenenMenu();
        public void kucukSiparisEkleme()
        {
           
            double siparis = 0;
            
            siparis = (double)nmrAdet.Value * KucukMenuFiyat[cmbMenuler.SelectedIndex] + (double)nmrAdet.Value * ToplamFiyat;



            eklenenMenu.SiparisToplamTutari = siparis;
            eklenenMenu.SiparisAdedi = (int)nmrAdet.Value;
            eklenenMenu.SatilanToplamUrun = SecilenEkstra.Length + (int)nmrAdet.Value;
            eklenenMenu.EkstraMalzemeTutari = ToplamFiyat;

            hamburgerci.eklenenSiparis.Add(eklenenMenu);

            lbxSiparisler.Items.Add($"Küçük boy {nmrAdet.Value} Adet {cmbMenuler.SelectedItem.ToString()}  Toplam Fiyat : {siparis} TL ");
            lbxSiparisler.Items.Add("Secilen Ekstra Malzemeler :");

            foreach (var item in SecilenEkstra)
            {
                lbxSiparisler.Items.Add(item);
            }

            for (int i = 0; i < SecilenEkstra.Length; i++)
            {
                SecilenEkstra[i] = " ";
               
            }

         
        }

        public void ortaSiparisEkleme()
        {
            double siparis = 0;
         
            siparis = (double)nmrAdet.Value * OrtaMenuFiyat[cmbMenuler.SelectedIndex] + (double)nmrAdet.Value * ToplamFiyat;


            eklenenMenu.SiparisToplamTutari = siparis;
            eklenenMenu.SiparisAdedi = (int)nmrAdet.Value;
            eklenenMenu.SatilanToplamUrun = SecilenEkstra.Length + (int)nmrAdet.Value;
            eklenenMenu.EkstraMalzemeTutari = ToplamFiyat;

            hamburgerci.eklenenSiparis.Add(eklenenMenu);

            lbxSiparisler.Items.Add($"Orta Boy {nmrAdet.Value} Adet {cmbMenuler.SelectedItem.ToString()} Toplam Fiyat : {siparis} TL ");
            lbxSiparisler.Items.Add("Secilen Ekstra Malzemeler :");

            foreach (var item in SecilenEkstra)
            {
                lbxSiparisler.Items.Add(item);
            }

            for (int i = 0; i < SecilenEkstra.Length; i++)
            {
                SecilenEkstra[i] = " ";
            }

        }

        public void buyuksiparisEkleme() 
        {

            double siparis = 0;

            siparis = (double)nmrAdet.Value * BuyukMenuFiyat[cmbMenuler.SelectedIndex] + (double)nmrAdet.Value * ToplamFiyat;


            eklenenMenu.SiparisToplamTutari = siparis;
            eklenenMenu.SiparisAdedi = (int)nmrAdet.Value;
            eklenenMenu.SatilanToplamUrun = SecilenEkstra.Length + (int)nmrAdet.Value;
            eklenenMenu.EkstraMalzemeTutari = ToplamFiyat;

            hamburgerci.eklenenSiparis.Add(eklenenMenu);

            lbxSiparisler.Items.Add($"Buyuk Boy {nmrAdet.Value} Adet {cmbMenuler.SelectedItem.ToString()} Toplam Fiyat : {siparis} TL ");
            lbxSiparisler.Items.Add("Secilen Ekstra Malzemeler :");

            foreach (var item in SecilenEkstra)
            {
                lbxSiparisler.Items.Add(item);
            }

            for (int i = 0; i < SecilenEkstra.Length; i++)
            {
                SecilenEkstra[i] = " ";
            }
        }

       
        private void btnSiparisTamamla_Click(object sender, EventArgs e)
        {
          
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Siparişinizi tamamlamak istiyormusunuz","Bilgi",MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                for (int i = 0; i < hamburgerci.eklenenSiparis.Count-1; i++)
                {
                    eklenenMenu.SiparisToplamTutari += eklenenMenu.SiparisToplamTutari;
                    eklenenMenu.SiparisAdedi += eklenenMenu.SiparisAdedi;
                    eklenenMenu.SatilanToplamUrun += eklenenMenu.SatilanToplamUrun;
                    eklenenMenu.EkstraMalzemeTutari += eklenenMenu.EkstraMalzemeTutari;

                }
                
                Form5 frm5 = new Form5();
                frm5.Show();
                this.Close();
            }
            else            
                MessageBox.Show("Lütfen yeni sipariş girişi yapınız");
            
        }

        private void cmbMenuler_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
