using System;
using System.Linq;
using System.Collections.Generic;

namespace Задача_8._2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Storage storage1 = new Storage();
            Storage storage2 = new Storage();

            storage2.products.RemoveAt(1);
            storage1.products.RemoveAt(0);

            PrintProducts(GetCommonProducts(storage1, storage2));
            PrintProducts(GetProductsLeftJoinIfNull(storage1, storage2));
            PrintProducts(GetDifferentProducts(storage1, storage2));

            Console.ReadKey();
        }

        private static List<Product> GetCommonProducts(Storage storage1, Storage storage2)
        {
            return storage1.products.Intersect(storage2.products).ToList();
        }

        private static List<Product> GetProductsLeftJoinIfNull(Storage storage1, Storage storage2)
        {
            return storage1.products.Where(p => storage2.products.All(p2 => !p2.Equals(p))).ToList();
        }

        private static List<Product> GetDifferentProducts(Storage storage1, Storage storage2)
        {
            List<Product> result = GetProductsLeftJoinIfNull(storage1, storage2);
            result.AddRange(GetProductsLeftJoinIfNull(storage2, storage1));
            return result;
        }

        private static void PrintProducts(List<Product> products)
        {
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine(products[i]);
            }
            Console.WriteLine();
        }
    }
}
