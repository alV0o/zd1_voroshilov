using System.DirectoryServices.ActiveDirectory;
using System.Dynamic;

namespace zd2_voroshilov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Shop shop;
        Playlist playlist;

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
            //Формирование таблиц магазина
            dataGridView1.Columns.Add("1", "Название продукта");
            dataGridView1.Columns.Add("2", "Цена");
            dataGridView1.Columns.Add("3", "Количество");
            shop = new();

            dataGridView2.Columns.Add("1", "Название");
            dataGridView2.Columns.Add("2", "Кол-во");


            //Формирование таблиц плейлиста
            dataGridView3.Columns.Add("0", "№");
            dataGridView3.Columns.Add("1", "Название");
            dataGridView3.Columns.Add("2", "Автор");
            playlist = new();
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
            panel2.Visible = false;
        }

        private void заданиеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
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

        //========================================


        //Проверка на добавление второго автора
        private void CheckTwoAuthors(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox3.Visible = true;
            }
            else
            {
                textBox3.Visible = false;
            }
        }

        //Добавление трека
        private void AddSongButton(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim(' ') != "" && textBox4.Text.Trim(' ') != "")
            {
                if (checkBox2.Checked)//проверка на отсутствие автора
                {
                    //добавление без автора
                    playlist.AddSong(textBox1.Text, textBox4.Text);
                    playlist.WriteSongs(dataGridView3);

                    playlist.FillComboBox(comboBox1);
                    playlist.FillComboBox(comboBox2);

                    //включение кнопок переключения
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;

                    label11.Text = $"Сейчас играет: {playlist.CurrentSong().Title} - {playlist.CurrentSong().Author}";
                }
                else if (checkBox1.Checked)//проверка на второго автора
                {
                    if (textBox2.Text.Trim(' ') != "" && textBox3.Text.Trim(' ') != "")
                    {
                        //добавление с двумя авторами
                        playlist.AddSong(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                        playlist.WriteSongs(dataGridView3);

                        playlist.FillComboBox(comboBox1);
                        playlist.FillComboBox(comboBox2);

                        //включение кнопок переключения
                        button2.Enabled = true;
                        button3.Enabled = true;
                        button4.Enabled = true;

                        label11.Text = $"Сейчас играет: {playlist.CurrentSong().Title} - {playlist.CurrentSong().Author}";
                    }
                    else
                    {
                        MessageBox.Show("Заполните все поля!");
                    }
                }
                else
                {
                    //добавление с одним автором
                    if (textBox2.Text.Trim(' ') != "")
                    {
                        playlist.AddSong(textBox1.Text, textBox2.Text, textBox4.Text);
                        playlist.WriteSongs(dataGridView3);

                        playlist.FillComboBox(comboBox1);
                        playlist.FillComboBox(comboBox2);

                        //включение кнопок переключения
                        button2.Enabled = true;
                        button3.Enabled = true;
                        button4.Enabled = true;

                        label11.Text = $"Сейчас играет: {playlist.CurrentSong().Title} - {playlist.CurrentSong().Author}";
                    }
                    else
                    {
                        MessageBox.Show("Заполните все поля!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }

        //Проверка на отсутствие автора
        private void CheckEmptyAuthor(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox2.Enabled = false;
                checkBox1.Checked = false;
                checkBox1.Visible = false;
            }
            else
            {
                textBox2.Enabled = true;
                checkBox1.Visible = true;
            }
        }

        //переключение песни вперед
        private void NextSongButton(object sender, EventArgs e)
        {
            if (playlist.NextSong())
            {
                label11.Text = $"Сейчас играет: {playlist.CurrentSong().Title} - {playlist.CurrentSong().Author}";
            }
            else
            {
                MessageBox.Show("Дальше песен нет");
            }
        }

        //переключение песни назад
        private void BackSongButton(object sender, EventArgs e)
        {
            if (playlist.BackSong())
            {
                label11.Text = $"Сейчас играет: {playlist.CurrentSong().Title} - {playlist.CurrentSong().Author}";
            }
            else
            {
                MessageBox.Show("Это первая песня!");
            }
        }

        //переключение песни по индексу
        private void CheckIndexToTrack(object sender, EventArgs e)
        {
            playlist.SetIndexTrack(comboBox1.SelectedIndex);
            label11.Text = $"Сейчас играет: {playlist.CurrentSong().Title} - {playlist.CurrentSong().Author}";
        }

        //возвращение к началу списка
        private void ToFirstSong(object sender, EventArgs e)
        {
            playlist.SetIndexTrack(0);
            label11.Text = $"Сейчас играет: {playlist.CurrentSong().Title} - {playlist.CurrentSong().Author}";
        }

        //удаление по названию или автору
        private void DeleteByName(object sender, EventArgs e)
        {
            if (textBox5.Text.Trim(' ') != "")
            {
                if (checkBox3.Checked) //проверка на нажатие автора
                {
                    if (textBox6.Text.Trim(' ') != "")
                    {
                        if (playlist.Delete(textBox5.Text, textBox6.Text) == -1) //удаление по названию и автору
                        {
                            MessageBox.Show("Название и автор не найдены!");
                        }
                        else
                        {
                            playlist.WriteSongs(dataGridView3);

                            playlist.FillComboBox(comboBox1);
                            playlist.FillComboBox(comboBox2);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите название и автора!");
                    }
                }
                else if (playlist.Delete(textBox5.Text) == -1)//удаление только по названию
                {
                    MessageBox.Show("Название не найдено!");
                }
                else
                {
                    playlist.WriteSongs(dataGridView3);

                    playlist.FillComboBox(comboBox1);
                    playlist.FillComboBox(comboBox2);
                }
            }
            else
            {
                MessageBox.Show("Введите название!");
            }
        }

        //удаление по индексу
        private void DeleteByIndex(object sender, EventArgs e)
        {
            playlist.Delete(comboBox2.SelectedIndex);

            playlist.WriteSongs(dataGridView3);

            playlist.FillComboBox(comboBox1);
            playlist.FillComboBox(comboBox2);
        }

        //очистка плейлиста
        private void ClearPlaylist(object sender, EventArgs e)
        {
            playlist.ClearPlaylist();

            playlist.WriteSongs(dataGridView3);

            playlist.FillComboBox(comboBox1);
            playlist.FillComboBox(comboBox2);

            //отключение кнопок переключения
            
        }

        //Проверка на добавление автора для удаления
        private void CheckDeleteByAuthor(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox6.Visible = true;
            }
            else
            {
                textBox6.Visible = false;
            }
        }
    }
}