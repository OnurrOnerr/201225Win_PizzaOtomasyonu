using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201225Win_PizzaOtomasyonu
{
    class KenarTip
    {
        public string Adi { get; set; }
        public int EkFiyat { get; set; }

        public override string ToString()
        {
            return Adi;
        }
    }
}
