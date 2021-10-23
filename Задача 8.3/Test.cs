using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Задача_8._3
{
    public class Test
    {
        private List<string> strings;
        public List<string> sentences;

        public Test(string filePath)
        {
            strings = new List<string>();
            sentences = new List<string>();

            ReadFromFile(filePath);
            FindSentences();
        }
        private void ReadFromFile(string filePath)
        {
            #region Перевірки
            if (string.IsNullOrWhiteSpace(filePath))
            {
                throw new ArgumentException("Шлях до файлу не може бути пустим.", nameof(filePath));
            }

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Файлу за вказаним шляхом не знайдено.", nameof(filePath));
            }

            if (string.Compare(new FileInfo(filePath).Extension, ".txt") != 0)
            {
                throw new ArgumentOutOfRangeException(nameof(filePath), "Доступно тільки розширення файлу .txt .");
            }
            #endregion

            using (StreamReader file = new StreamReader(filePath))
            {
                string line;

                while ((line = file.ReadLine()) != null)
                {
                    line += '\n';
                    strings.Add(line);
                }
            }
        }

        private void FindSentences()
        {
            StringBuilder sentence = new StringBuilder();

            for(int i = 0; i < strings.Count; i++)
            {
                for (int j = 0; j < strings[i].Length; j++)
                {
                    if(strings[i][j] != '.')
                    {
                        if(sentence.Length == 0 && (strings[i][j] == ' ' || strings[i][j] == '\n'))
                        {
                            continue;
                        }

                        sentence.Append(strings[i][j]);
                    }
                    else
                    {
                        sentence.Append('.');
                        sentences.Add(sentence.ToString());
                        sentence = new StringBuilder();
                    }
                }

                if(sentence.Length != 0)
                {
                    sentence.Append(' ');
                }
            }
        }

        public string GetHighestParenthesesDepthSentence()
        {
            int greatestDepth = 0;
            int sentenceIndex = 0;

            for(int i = 0; i < sentences.Count; i++)
            {
                int depth = 0;

                for (int j = 0; j < sentences[i].Length; j++)
                {
                    if(sentences[i][j] == '(')
                    {
                        depth++;
                    }
                    else if(sentences[i][j] == ')')
                    {
                        if(depth > greatestDepth)
                        {
                            sentenceIndex = i;

                            greatestDepth = depth;
                            depth = 0;
                        }
                    }
                }
            }

            return sentences[sentenceIndex];
        }

        public void PrintSentences()
        {
            int n = 1;
            foreach(string sentence in sentences)
            {
                Console.WriteLine(n + ". " + sentence);
                n++;
            }
        }

        public void PrintText()
        {
            foreach(string line in strings)
            {
                Console.Write(line);
            }
        }
    }
}