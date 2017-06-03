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
                var dePlaces = new int[count];                              // массив-карта для дешифровки

                for (var i = 0; i < count; i++)
                {
                    // заполнение массива-карты
                    places[i] = Ask.Num("Введите место для символа: ", 1, count) - 1;
                    dePlaces[places[i]] = i;
                }

                Console.WriteLine();

                string cur = Ask.Word("Введите слово: "),                   // хранение данного слова
                    crypting = "",                                          // зашифрованный вариант слова
                    decripting = "";                                        // расшифрованный вариант слова
                if (cur.Length % count > 0)                                 // заполнение пробелами справа
                    cur = cur.PadRight(cur.Length + (count - cur.Length % count));

                var blocks = cur.Length / count;                            // количество блоков

                for (var i = 0; i < blocks; i++)                            // по-блочно
                {
                    for (var j = 0; j < count; j++)                         // внутри блока - побуквенно
                    {
                        crypting += cur[places[j]];                         // шифровка по карте
                        decripting += cur[dePlaces[j]];
                    }
                    cur = cur.Remove(0, count);                             // удаление расшифрованных символов
                }

                Console.WriteLine("Шифрованное от исходного слово: " + crypting);
                Console.WriteLine("Дешифрованное от исходного слово: " + decripting);

                OC.Stay();
            }

        }
    }
}
