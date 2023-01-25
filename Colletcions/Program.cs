// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace Collections
{
    class program
    {
        static void Main(string[] args)

        {
            //string[] names = new string[] {"Tunahan","Ceyda","Doğaner" };
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);                         

            List<string> names2 = new List<string> { "Tunahan", "Ceyda", "Doğaner" }; //List<string> names2 = new List<string>(); names2.Add("Tunahan"); şeklinde de yazılabilir
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            names2.Add("Ahmet");
            Console.WriteLine(names2[3]);
            Console.WriteLine(names2[0]); 

        }

    }

}

