using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd2_voroshilov
{
    internal class Shop
    {
        private Dictionary<Product, int> products;
        private Dictionary<string, int> basket = new Dictionary<string, int>();

        //Конструктор
        public Shop()
        {
            products = new Dictionary<Product, int>();
        }

        //прибыль
        private double profit = 0;
        
        //получения прибыли
        public double GetProfit()
        {
            return Math.Round(profit, 2);
        }

        //добавление продукта в список
        public void CreateProduct(string name, decimal price, int count)
        {
            if (FindByName(name) == null)
            {
                products.Add(new Product(name, price), count);
            }
            else
            {
                MessageBox.Show("Такой товар существует");
            }
        }

        //вывод всех продуктов из списка
        public void WriteAllProducts(DataGridView dgv)
        {
            dgv.Rows.Clear();

            foreach (var product in products)
            {
                string info = $"{product.Key.GetInfo()} {product.Value}";
                dgv.Rows.Add(info.Split(' '));
            }
        }

        //функция продажи товаров
        public void Sell(Product product, int count, ref double price)
        {
            if (products[product] == 0)
            {
                MessageBox.Show("Нет в наличии!");
            }
            else
            {
                if (count > products[product])
                {
                    MessageBox.Show("Выбранное количество больше, чем есть!");
                }
                else
                {
                    //Проверка на скидку за покупку оптом
                    if (count >= 10 && count < 30) SetProfit(product, count, 0.1, ref price); //за покупку от 10 товаров 10% скидка
                    else if (count >= 30 && count < 50) SetProfit(product, count, 0.3, ref price); //за покупку от 30 товаров 30% скидка
                    else if (count >= 50) SetProfit(product, count, 0.5, ref price); //за покупку от 30 товаров 30% скидка
                    else SetProfit(product, count, ref price); //за покупку товаров < 10 скидка отсутствует
                }
            }
        }

        //установка прибыли
        private void SetProfit(Product product, int count, ref double price)
        {
            products[product] -= count;
            price += Convert.ToInt32(product.Price) * count;//Цена всей покупки
            profit += Convert.ToInt32(product.Price) * count;
            
        }

        //перегрузка установки прибыли
        private void SetProfit(Product product, int count, double discount, ref double price)
        {
            products[product] -= count;
            double pr = Convert.ToDouble(product.Price) * count;
            price += pr - pr * discount;//Цена всей покупки
            profit += pr - pr * discount;
        }

        //поиск по названию товара
        public Product FindByName(string name)
        {
            foreach (Product product in products.Keys)
            {
                if (product.Name == name)
                {
                    return product;
                }
            }
            return null;
        }

        //Перегрузка продажи товаров
        public void Sell (string productName, int count, ref double price)
        {
            Product toSell = FindByName(productName);
            if (toSell != null)
            {
                this.Sell(toSell, count, ref price);
            }
            else
            {
                MessageBox.Show("Товар не найден!");
            }
        }


        //Добавление в корзину
        public void AddBasket(string name, int count, DataGridView dgv)
        {
            if (FindByName(name) != null)
            {
                basket.Add(name, count);
                dgv.Rows.Clear();

                foreach (var product in basket)
                {
                    dgv.Rows.Add(product.Key, product.Value);
                }
            }
            else
            {
                MessageBox.Show("Такого товара нет");
            }
        }

        //покупка из корзины
        public void BuyBasket()
        {
            double price = 0;
            foreach(var product in basket)
            {
                Sell(product.Key, product.Value, ref price);
            }
            MessageBox.Show($"Потрачено {Math.Round(price)}");
            basket.Clear();
        }
    }
}
