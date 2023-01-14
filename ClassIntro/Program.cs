using System;
namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad = "Engin";
            int yas = 25;

            Kurs kurs1=new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Tunahan Yazıcı";
            kurs1.izlenmeOrani = 69;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "JAVA";
            kurs2.Egitmen = "Ahmet Yazıcı";
            kurs2.izlenmeOrani = 35;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "PYTHON";
            kurs3.Egitmen = "Ahmet Tunahan Yazıcı";
            kurs3.izlenmeOrani = 102;

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }
            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int izlenmeOrani { get; set; }
    }

}

