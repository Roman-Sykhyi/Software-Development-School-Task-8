using System;
using System.Collections.Generic;
using System.Text;

namespace Задача_8._1
{
    public delegate int CompareDelegate(object item1, object item2);

   public class Sorter
    {
        public static void Sort(object[] items, CompareDelegate compareDelegate)
        {
            int n = items.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (compareDelegate(items[j], items[j+1]) == 1)
                    {
                        object temp = items[j];
                        items[j] = items[j + 1];
                        items[j + 1] = temp;
                    }
                }
            }
        }
    }
}
