using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        //naming convention
        //syntax 
        public void  Ekle(Urun urun)

        {
            Console.WriteLine("Sepete eklendi  :  " + urun.Adi +"  Fiyat  :  "  + urun.Fiyati);

        }
        public void Ekle2(string urunAdi, string aciklama,double fiyati)

        {
            Console.WriteLine("Sepete eklendi  :  " + urunAdi + "  Fiyat  :  " + fiyati);

        }
    }
}
