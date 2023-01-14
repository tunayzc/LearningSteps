// See https://aka.ms/new-console-template for more information
using System;
namespace odev

{
    class Program
    {
        static void Main(string[] args)
        {
            Urun ekranKarti1= new Urun();
            ekranKarti1.UrunId = 1;
            ekranKarti1.UrunAd = "1080ti";
            ekranKarti1.UrunFiyati= 3000;
            ekranKarti1.UrunStogu = 10;

            Urun ekranKarti2= new Urun();
            ekranKarti2.UrunId = 2;
            ekranKarti2.UrunAd = "2080ti";
            ekranKarti2.UrunFiyati = 5000;
            ekranKarti2.UrunStogu = 5;

            Urun ekranKarti3 = new Urun();
            ekranKarti3.UrunId = 3;
            ekranKarti3.UrunAd = "3080ti";
            ekranKarti3.UrunFiyati = 8000;
            ekranKarti3.UrunStogu = 15;

            Urun ekranKarti4 = new Urun();
            ekranKarti4.UrunId = 4;
            ekranKarti4.UrunAd = "4080ti";
            ekranKarti4.UrunFiyati = 10000;
            ekranKarti4.UrunStogu = 4;

            Urun[] urunler = new Urun[] { ekranKarti1, ekranKarti2, ekranKarti3, ekranKarti4 };
            foreach (var Urun in urunler)
            {
                Console.WriteLine("Ekran karti" + " : " + Urun.UrunAd + " " + "Fiyat" + " : " + Urun.UrunFiyati + " " +  "Stok" +  " : " +  Urun.UrunStogu);
            }

            for (int i = 0; i < +urunler.Length; i++)
            {
                Console.WriteLine("Ekran karti" + " : " + urunler[i].UrunAd + " " + "Fiyat" + " : " + urunler[i].UrunFiyati + " " + "Stok" + " : " + urunler[i].UrunStogu);
            }

            int loopInt = 0;
            while (loopInt < urunler.Length)
            {
              Console.WriteLine("Ekran karti" + " : " + urunler[loopInt].UrunAd + " " + "Fiyat" + " : " + urunler[loopInt].UrunFiyati + " " + "Stok" + " : " + urunler[loopInt].UrunStogu);
                loopInt++;  
            }

            Console.WriteLine("Sayfa Sonu");

        }   


    }

    class Urun
    {
        public int UrunId { get; set; }
        public string UrunAd { get; set; }
        public float UrunFiyati { get; set; }
        public int UrunStogu { get; set; }
    }


}
