using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                var places = new int[count];

                for (var i = 0; i < count; i++)
                    places[i] = Ask.Num("Введите место для символа: ");

                var choise = new Menu("Что вы хотели бы сделать: ", "Зашифровать", "Дешифровать");


                OC.Stay();
            }

        }
    }
}
