// See https://aka.ms/new-console-template for more information
using System;
namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangı. için temel kurs";
            string kurs3 = "Java";


            //array=diziler
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", 
                                              "Programlamaya başlangı. için temel kurs", 
                                              "JAVA","Python","C#" };
            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu");
        }
    }
}


