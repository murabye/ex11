using System;
using MyLib;

namespace ex11
{
    internal class Program
    {
        private static void Main()
        {
            while (true)
            {
                var count = Ask.Num("Введите число k: ");       
                var places = new int[count];                                // инициализация массива-карты

                for (var i = 0; i < count; i++)                             // заполнение массива-карты
                    places[i] = Ask.Num("Введите место для символа: ");
                
                Console.WriteLine();

                string cur = Ask.Word("Введите слово: "),                   // хранение данного слова
                    crypting,                                               // зашифрованный вариант слова
                    decripting;                                             // расшифрованный вариант слова
                if (cur.Length % count > 0)                                 // заполнение пробелами справа
                    cur = cur.PadRight(cur.Length + (count - cur.Length % count));
                


                OC.Stay();
            }

        }
    }
}
