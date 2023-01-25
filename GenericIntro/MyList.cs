using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericIntro
{
    internal class MyList<T>
    {
        T[] items;
        //cotr == constructor bir yerde bu class'ı newlersen otomatik çalışır
        public MyList()
        {
            items= new T[0];    
        }
        public void Add(T item)
        {
            T[] tempArray = items;    // Yapıcı Metot.geçici dizi oluştururuz. Bunu da referans değerlerini tutturmak için yaparız
            items= new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length-1] = item;   
        }
        
    }

}
