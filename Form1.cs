namespace zd2_voroshilov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Shop shop;

        //Кнопка добавления товара
        private void AddToShop(object sender, EventArgs e)
        {
            if (nameProduct.Text.Trim(' ') != "")//проверка на пустое поле в названии товара
            {
                shop.CreateProduct(nameProduct.Text.Trim(' '), priceProduct.Value, Convert.ToInt32(countProduct.Value));
                shop.WriteAllProducts(dataGridView1);
            }
            else
            {
                MessageBox.Show("Введите название товара!");
            }
        }

        //Стартовая загрузка данных
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("1", "Название продукта");
            dataGridView1.Columns.Add("2", "Цена");
            dataGridView1.Columns.Add("3", "Количество");
            shop = new();

            dataGridView2.Columns.Add("1", "Название");
            dataGridView2.Columns.Add("2", "Кол-во");
        }

        //Кнопка добавления в корзину
        private void AddToBasket(object sender, EventArgs e)
        {
            try
            {
                if (toBasket.Text.Trim(' ') != "") //проверка на пустое поле в названии товара
                {
                    shop.AddBasket(toBasket.Text, Convert.ToInt32(toBasketCount.Value), dataGridView2);
                }
                else
                {
                    MessageBox.Show("Введите название товара!");
                }
            }
            catch
            {
                MessageBox.Show("Такой товар добавлен");
            }
        }

        private void заданиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void заданиеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        //Покупка корзины
        private void BuyBasketProducts(object sender, EventArgs e)
        {
            //Выполнение функции продажи из корзины
            shop.BuyBasket();
            //Обновление списка товаров
            shop.WriteAllProducts(dataGridView1);
            //Вывод прибыли
            label7.Text = $"Прибыль = {shop.GetProfit()}";
        }
    }
}