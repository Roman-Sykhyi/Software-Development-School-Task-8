using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Задача_8._2
{
    public class Task
    {
        public IReadOnlyList<Product> GetCommonProducts(Storage storage1, Storage storage2)
        {
            return storage1.products.Intersect(storage2.products).ToList().AsReadOnly();
        }

        public IReadOnlyList<Product> GetProductsLeftJoinIfNull(Storage storage1, Storage storage2)
        {
            return storage1.products.Where(p => storage2.products.All(p2 => !p2.Equals(p))).ToList().AsReadOnly();
        }

        public IReadOnlyList<Product> GetDifferentProducts(Storage storage1, Storage storage2)
        {
            IReadOnlyList<Product> result1 = GetProductsLeftJoinIfNull(storage1, storage2);
            IReadOnlyList<Product> result2 =GetProductsLeftJoinIfNull(storage2, storage1);

            return result1.Concat(result2).ToList().AsReadOnly();
        }

        public void PrintProducts(IReadOnlyList<Product> products)
        {
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine(products[i]);
            }
            Console.WriteLine();
        }
    }
}
