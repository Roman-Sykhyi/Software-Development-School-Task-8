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

            Task task = new Task();

            Storage storage1 = new Storage();
            Storage storage2 = new Storage();

            storage2.products.RemoveAt(1);
            storage1.products.RemoveAt(0);

            task.PrintProducts(task.GetCommonProducts(storage1, storage2));
            task.PrintProducts(task.GetProductsLeftJoinIfNull(storage1, storage2));
            task.PrintProducts(task.GetDifferentProducts(storage1, storage2));

            Console.ReadKey();
        }
       
    }
}
