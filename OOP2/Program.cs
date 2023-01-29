using System;
                                      
namespace OOP2
{
    class program
    {
        static void Main(string[] args)
        {
           IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.Name = "Tunahan";
            customer1.LastName = "Yazıcı";
            customer1.TcNo = "123123123";
            customer1.CustomerNo = "123";

            CoorpCustomer customer2 = new CoorpCustomer();  
            customer2.Id = 2;
            customer2.CompanyName = "Electi";
            customer2.TaxNo = "0188";
            customer2.CustomerNo = "124";
            

            Customer customer3= new IndividualCustomer();
            Customer customer4 = new CoorpCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

        }

    }

}
