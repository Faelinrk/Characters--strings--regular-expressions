using System;
using System.Linq;
namespace method_3_
{
    class Program
    {
        static void Main(string[] args)//Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой. Регистр можно не учитывать
        {
            if (comparemethod("abcd","abdc"))
                Console.WriteLine("Строка является перестановкой!");
            else
                Console.WriteLine("Строка не является перестановкойы");
        }
        static bool comparemethod(string str1, string str2)
        {
            char[] charstr1 = str1.ToCharArray();
            char[] charstr2 = str2.ToCharArray();

            var sortedarray1 = charstr1.OrderBy(a => a);
            var sortedarray2 = charstr2.OrderBy(a => a);

            str1 = ""; str2 = "";
            str1 = String.Join("", sortedarray1);
            str2 = String.Join("", sortedarray2);

            if (str1.Equals(str2)) return true; else return false;
        }
    }
}
