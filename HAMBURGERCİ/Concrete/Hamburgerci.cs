using HAMBURGERCİ.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAMBURGERCİ.Concrete
{
    public class Hamburgerci : IEkstraMalzeme,IMenuler
    {
        public Hamburgerci()
        {
            _ektstraMalzeme = new List<IEkstraMalzeme>();
            _Menuler = new List<IMenuler>();
            eklenenSiparis = new List<EklenenMenu>();
            
        }
        public string MalzemeAdi { get; set; }
        public double MalzemeFiyati { get; set; }
        public List<IEkstraMalzeme> _ektstraMalzeme { get; set; }
        public string MenuAdi { get; set; }
        public double MenuFiyati { get; set; }
        public List<IMenuler> _Menuler { get; set; }

        public List<EklenenMenu> eklenenSiparis { get; set; }
    }
}
