using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd1_voroshilov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Ввод имени кота
                Console.Write($"Введите имя кота: ");
                Cat cat = new Cat(Console.ReadLine());

                //Ввод веса кота
                Console.Write($"Установите вес кота: ");
                cat.Weight = Convert.ToDouble(Console.ReadLine());

                cat.Meow();

                //Информация о коте
                cat.Info();
            }
            catch
            {
                Console.WriteLine("Неверные данные!");
            }
        }
    }
}
