using System;
using System.Collections;
namespace message_2_
{
    class Program
    {
        static void Main()
        {
            MessageClass.PrintNMes("Я ломал дубиной летнее окошко осеннего домика", 6);//а) Вывести только те слова сообщения, которые содержат не более n букв.
            MessageClass.RemoveFWords("Я ломал дубиной летнее окошко осеннего домика", "а");//б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
            MessageClass.PrintString(MessageClass.buildString(MessageClass.MostLongWord("Я ломал дубиной летнее окошко осеннего оооооооо ( моя обороона ) домика")));//в) Найти самое длинное слово сообщения.//г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
        }


    }

}
