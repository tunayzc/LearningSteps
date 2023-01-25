// See https://aka.ms/new-console-template for more information
using System;
namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1= new Product();
            product1.Id= 1;
            product1.CategoryId = 1;
            product1.ProductName = "i5-12400f";
            product1.UnitPrice = 3000;    
            product1.UnitsInStock = 10; 

            Product product2= new Product {Id = 2, CategoryId=2,UnitsInStock=3,
                UnitPrice=8500,ProductName="3070"}; 
            
            //PascalCase   //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
              
        }

    }

}
