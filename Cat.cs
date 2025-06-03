using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace zd1_voroshilov
{
    internal class Cat
    {
        //Имя кота
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            // установка значения - используем проверку
            set
            {
                bool onlyLetters = true;
                // ключ. слово value - это то, что хотят свойству присвоить
                foreach (var ch in value)
                {
                    if (!char.IsLetter(ch))
                    {
                        onlyLetters = false;
                    }
                }

                if (value == "") onlyLetters = false;

                if (onlyLetters)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine($"{value} - неправильное имя!!!");
                }
            }
        }

        private double weight; // в кг
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                //проверка на то, что кот не весит меньше 1кг или больше 22 кг
                if (value < 1 || value >= 22)
                {
                    Console.WriteLine($"{value} - неправильный вес!!!");
                }
                else
                {
                    weight = value;
                }
            }
        }

        //Конструктор
        public Cat(string catName)
        {
            Name = catName;
        }

        //Мяуканье кота
        public void Meow()
        {
            if (name != null && weight != 0)
            Console.WriteLine($"{name}: МЯЯЯЯЯЯЯЯЯУУУ!!");
        }

        //Информация о коте
        public void Info()
        {
            if (name != null && weight != 0)
                Console.WriteLine($"Имя кота: {name}, вес кота: {weight}");
        }
    }
}
