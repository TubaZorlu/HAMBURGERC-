using HAMBURGERCİ.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAMBURGERCİ.Concrete
{
    public class EkstraMalzeme : IEkstraMalzeme
    {
        public string MalzemeAdi { get ; set ; }
        public double MalzemeFiyati { get; set; }

    }
}
