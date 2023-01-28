// See https://aka.ms/new-console-template for more information
using System;
namespace ödev2
{
    class program
    {
        static void Main(string[] args)
        {
            Person person1= new Person();
            Person person2= new Person();
            person1.Firstname = "Tunahan";
            //person1 = person2;
            //person1.Firstname = "Ahmet";
            //Console.WriteLine(person2.Firstname);

            Customer customer= new Customer();
            customer.Firstname = "Doğaner";
            Employee employee= new Employee();
            employee.Firstname = "Ceyda";
            Person person3 = customer;
            customer.CreditCardNumber = "304930322";

            

            //Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager= new PersonManager();
            personManager.Add(person1);
            personManager.Add(customer);
            personManager.Add(employee);

        }

    }
    class Person
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

    }

    class Customer:Person
    {
        public string CreditCardNumber { get; set; }

    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.Firstname);
        }
    }

}
