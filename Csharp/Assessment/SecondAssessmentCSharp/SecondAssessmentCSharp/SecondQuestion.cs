using System;

namespace SecondAssessmentCSharp
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public float Price { get; set; }
    }

    internal class SecondQuestion
    {
        static void Main(string[] args)
        {

            Product[] products = new Product[5];

            for (int i = 0; i < products.Length; i++)
            {
                products[i] = new Product();

                Console.WriteLine($"\nEnter details for Product {i + 1}");

                Console.Write("Product ID: ");
                products[i].ProductId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Product Name: ");
                products[i].ProductName = Console.ReadLine();

                Console.Write("Price: ");
                products[i].Price = float.Parse(Console.ReadLine());
            }
            Array.Sort(products, (a, b) => a.Price.CompareTo(b.Price));

            Console.WriteLine("\n--- Products Sorted by Price ---");
            Console.WriteLine("ID\tProduct Name\tPrice");

            foreach (Product p in products)
            {
                Console.WriteLine($"{p.ProductId}\t{p.ProductName}\t{p.Price}");
            }

            Console.ReadLine();
        }
    }
}