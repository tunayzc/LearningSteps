using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //Okunurluğu arttırmak için interfaceleri "I" harfi ile başlatırız.
    //Interfaceleri, birbirinin alternatifi olan ama kod içeriği farklı olan durumlar için kullanırız

    interface ICreditManager
    {
        void Hesapla();
        void BiseyYap();
              
    }

}
