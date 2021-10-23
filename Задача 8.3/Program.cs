using System;

namespace Задача_8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Test test = new Test(@"E:\Sigma Pract\Завдання 8\Задача 8.3\text.txt");

            Console.WriteLine("Текст зчитаний з файлу:\n");
            test.PrintText();

            Console.WriteLine("\nРечення з найбільшою глибиною вкладень дужок:\n" + test.GetHighestParenthesesDepthSentence());

            test.sentences.Sort((x, y) => x.Length.CompareTo(y.Length));
            Console.WriteLine("\nСписок речень посортованих за довжиною:\n");
            test.PrintSentences();

            Console.ReadKey();
        }
    }
}
