using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplicationManager
    {
        public void Application(ICreditManager creditManager, ILoggerService loggerService)
        {
            //ICreditManager tüm kredi türlerini içerdiği için hangi türü yollarsak onun hesaplası çalışır.
            //Burada method Injection yapıyoruz.
            //Birden fazla logger yollamak için aşağıdaki gibi hareket ederiz
                    //public void Application(ICreditManager creditManager, list<ILoggerService> loggerService);
                        //foreach (var loggerService in loggerServices)
                        //{
                            //    loggerService.Log();
                        //}
                    
            creditManager.Hesapla();
            loggerService.Log();
        }

        public void CreditPreBriefing(List<ICreditManager> credits)
        {
            foreach (ICreditManager credit in credits) 
            {
                credit.Hesapla();
            }
        }

    }

}
