using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd2_voroshilov
{
    internal class Product
    {
        public decimal Price { get; set; }
        public string Name { get; set; }

        //Конструктор
        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        //Вывод информации о продукте
        public string GetInfo()
        {
            return $"{Name} {Price}";
        }


    }
}
