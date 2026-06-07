using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Product ID   : {ProductId}");
            Console.WriteLine($"Product Name : {ProductName}");
            Console.WriteLine($"Price        : {Price}");
        }
    }

    public class ElectronicsProduct : Product
    {
        public string Brand { get; set; }
        public int WarrantyInYears { get; set; }

        public override void DisplayInfo()
        {
            base.DisplayInfo();

            Console.WriteLine($"Brand            : {Brand}");
            Console.WriteLine($"Warranty (Years) : {WarrantyInYears}");
        }
    }
    public class Program2
    {
        static void Main()
        {
            Product p = new Product
            {
                ProductId = 101,
                ProductName = "Notebook",
                Price = 50
            };

            ElectronicsProduct ep = new ElectronicsProduct
            {
                ProductId = 201,
                ProductName = "Laptop",
                Price = 65000,
                Brand = "Dell",
                WarrantyInYears = 2
            };

            Console.WriteLine("=== Product Information ===");
            p.DisplayInfo();

            Console.WriteLine("\n=== Electronics Product Information ===");
            ep.DisplayInfo();
        }
    }
}

