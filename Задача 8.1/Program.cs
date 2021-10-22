using System;
using System.Collections.Generic;

namespace Задача_8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Product> productsList = new List<Product>() 
            { 
                new Product("Bread", 10, 0.3f, 7, DateTime.Now),
                new Product("Milk", 28, 0.8f, 5, DateTime.Now),
                new Product("Meat", 100, 1f, 14, DateTime.Now),
                new Product("Tea", 20, 0.1f, 90, DateTime.Now),
                new Product("Tomato", 32, 0.5f, 10, DateTime.Now),
            };

            Product[] productsArr = productsList.ToArray();

            Sorter.Sort(productsArr, (x, y) => (x as Product).Price.CompareTo((y as Product).Price));
            PrintProducts(productsArr);

            Console.WriteLine();

            Sorter.Sort(productsArr, (x, y) => (x as Product).Weight.CompareTo((y as Product).Weight));
            PrintProducts(productsArr);
        }

        private static void PrintProducts(Product[] products)
        {
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i]);
            }
        }
    }
}
