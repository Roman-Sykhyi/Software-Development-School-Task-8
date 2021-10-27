using System;
using System.Collections.Generic;
using System.Text;

namespace Задача_8._3
{
    public class Task
    {
        private string filePath = @"E:\Sigma Pract\Завдання 8\Задача 8.3\text.txt";
        private Test test;

        public Task()
        {
            test = new Test(filePath);
            test.FindSentences();
        }

        public void PrintHighestParenthesesDepthSentence()
        {
            Console.WriteLine("\nРечення з найбільшою глибиною вкладень дужок:\n" + test.GetHighestParenthesesDepthSentence());
        }

        public void SortSentences()
        {
            test.SortSentences((x, y) => x.Length.CompareTo(y.Length));
        }

        public void PrintText()
        {
            foreach (string line in test.Strings)
            {
                Console.Write(line);
            }
        }

        public void PrintSentences()
        {
            int n = 1;
            foreach (string sentence in test.Sentences)
            {
                Console.WriteLine(n + ". " + sentence);
                n++;
            }
        }
    }
}
