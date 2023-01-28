using System;
using System.Drawing;

namespace ödev3
{
    class Program
    {
        static void Main(String[] args)
        {
            Customer customer= new Customer {Id=1, FirstName="Tunahan",LastName="Yazıcı",City="Samsun" };
            // Yukarıdaki gibi değil de aşağıdaki gibi kullanmak istiyorsan constructor'a gidip tanımlaman lazım.Ama tanımlarsan aşağıdaki çalışır,yukaridaki çalışmaz
            //İki şekilde de kullanmak istersen overloading yaparsın. Yani bir constructor daha oluşturursun
            Customer customer2 = new Customer(2,"Ceyda","Karakaya","Ankara");
            //customer1 ve customer3 aslında aynı şeylerdir ama farklı yöntem kullanılmıştır.
            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Ahmet";
            customer3.LastName = "Yazıcı";
            customer3.City = "Bafra";
            Console.WriteLine(customer2.FirstName);



        }
      
    }
    class Customer
    {
        public Customer()
        {

        }
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id=id;
            FirstName= firstName;
            LastName= lastName;
            City= city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }

}
