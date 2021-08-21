using System;
using System.Collections;
using System.Text;
namespace message_2_
{
    static class MessageClass
    {
        public static void PrintNMes(string message, int chars)//а) Вывести только те слова сообщения, которые содержат не более n букв.
        {
            Console.WriteLine();
            string[] words = message.Split();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > chars)
                    words[i] = "";
            }
            foreach (string word in words)
            {
                if (word != "")
               
                Console.Write($"{word} ");
            }
        }

        public static void RemoveFWords(string message, string f)//б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        {
            string[] words = message.Split();
            Console.WriteLine();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i][words[i].Length - 1] == Convert.ToChar(f))//если это тупо, но это работает, то это не тупо (шутка)
                    words[i] = "";
            }
            foreach (string word in words)
            {
                if (word != "")
                
                Console.Write($"{word} ");
            }
        }

        public static ArrayList MostLongWord(string message)//в) Найти самое длинное слово сообщения.
        {
            string[] words = message.Split();
            ArrayList mostlongwords = new ArrayList();
            mostlongwords.Add(words[0]);
            for (int i = 0; i < words.Length; i++)
            {

                if (words[i].Length > Convert.ToString(mostlongwords[0]).Length)
                {
                    mostlongwords.Clear();
                    mostlongwords.Add(words[i]);
                }
                else if (words[i].Length == Convert.ToString(mostlongwords[0]).Length)
                {
                    mostlongwords.Add(words[i]);
                }
            }
            return mostlongwords; //возвращает массив на тот случай, если слов с максимальной длиной множество
        }

        public static StringBuilder buildString(ArrayList longwords)// г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
        {
            StringBuilder strib = new StringBuilder();
            foreach (string word in longwords)
            {
                strib.Append(word + " ");
            }
            return strib;
        }

        public static void PrintString(StringBuilder a)
        {
            Console.WriteLine();
            Console.WriteLine("Самые длинные слова: " + a);
        }

    }
}