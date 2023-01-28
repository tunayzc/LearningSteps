
using System;
using System.Collections.Concurrent;
using System.Drawing;

namespace odev4
{
    class program
    {
        static void Main(string[] args)
        {
            
            var ekranKartlari = new Dictionary<int,string>();
            Console.WriteLine("Top Seller Gpus");
            ekranKartlari.Add(1, "3060ti");
            ekranKartlari.Add(2, "3070");
            ekranKartlari.Add(3, "6700xt");
            ekranKartlari.Add(4, "3050");
            Console.WriteLine(ekranKartlari[1]);
        }       
    }
    
}
