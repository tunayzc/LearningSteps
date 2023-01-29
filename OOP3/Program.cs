// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

namespace OOP3
{
    class program
    {
        static void Main(string[] args)
        {
            //PersonalCreditManager personalCredit = new PersonalCreditManager();
            //personalCredit.Hesapla();

            //VehicleCreditManager vehicleCredit = new VehicleCreditManager();    
            //vehicleCredit.Hesapla();    

            //MortgageCreditManager mortgageCredit= new MortgageCreditManager();
            //mortgageCredit.Hesapla();  

                                    //BU ŞEKİLDE YAZMAK YERİNE INTERFACE İLE DE YAZABİLİRİZ

            //ICreditManager personalCredit = new PersonalCreditManager();
            //personalCredit.Hesapla();

            //ICreditManager vehicleCredit = new VehicleCreditManager();    
            //vehicleCredit.Hesapla();

            //ICreditManager mortgageCredit = new MortgageCreditManager();
            //mortgageCredit.Hesapla(); 

            ICreditManager personalCredit = new PersonalCreditManager();            
            ICreditManager vehicleCredit = new VehicleCreditManager();            
            ICreditManager mortgageCredit = new MortgageCreditManager();

            //ApplicationManager applicationManager = new ApplicationManager();
            //applicationManager.Application(personalCredit);
            //applicationManager.Application(vehicleCredit);

                                        //YUKARIDAKİ KODU LOGLAMA YAPMAK İÇİN 

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Application(personalCredit, new DataBaseLoggerService());
            applicationManager.Application(vehicleCredit, new FileBaseLoggerService());

                                        //YA DA

            ILoggerService dataBaseLoggerService= new DataBaseLoggerService();
            ILoggerService fileBaseLoggerService= new FileBaseLoggerService();
                        
            applicationManager.Application(personalCredit,dataBaseLoggerService);
            applicationManager.Application(vehicleCredit, fileBaseLoggerService);

            List<ICreditManager> credits= new List<ICreditManager>() {personalCredit, vehicleCredit };
            //applicationManager.CreditPreBriefing(credits);  

                                    //Logger'ı list şeklinde yaparsak
            //applicationManager.Application(personalCredit, new List<ILoggerService> { new DataBaseLoggerService(), new FileBaseLoggerService() });

        }

    }

}
