using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class SepetManager
    
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler.Sepete eklendi: " + urun.Adi);

        }

        // Bu şekilde de methot oluşturabilirsin ama bu sefer yaptığın herhangi bir değişiklik için tüm sayfalarında işlem yapman gerekir
        public void Ekle2(string urunAdi, string aciklama, double fiyat) 
        
        {

            Console.WriteLine("Tebrikler.Sepete eklendi: " + urunAdi);

        }
    }
}
