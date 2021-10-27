using System;

namespace Задача_8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Task task = new Task();

            Console.WriteLine("Текст зчитаний з файлу:\n");
            task.PrintText();

            task.PrintHighestParenthesesDepthSentence();

            task.SortSentences();
            Console.WriteLine("\nСписок речень посортованих за довжиною:\n");
            task.PrintSentences();

            Console.ReadKey();
        }
    }
}
