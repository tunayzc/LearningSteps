// See https://aka.ms/new-console-template for more information
using methods;
using System;
namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyatı = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyatı = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };
            foreach (var urun in urunler)
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyatı);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------");


            }
            Console.WriteLine("--------Metotlar--------");
            //instance-class örneği oluşturuyoruz burda
            SepetManager sepetManager= new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 80);
            sepetManager.Ekle2("Elma", "Yeşil elma", 10);


        }

    }

}


// Metotların amacı Do not repeat your self!