namespace zd2_voroshilov
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            addToShop = new Button();
            nameProduct = new TextBox();
            priceProduct = new NumericUpDown();
            countProduct = new NumericUpDown();
            menuStrip1 = new MenuStrip();
            заданиеToolStripMenuItem = new ToolStripMenuItem();
            заданиеToolStripMenuItem1 = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            addBasket = new Button();
            toBasket = new TextBox();
            label6 = new Label();
            toBasketCount = new NumericUpDown();
            label7 = new Label();
            panel1 = new Panel();
            dataGridView2 = new DataGridView();
            buyBasket = new Button();
            panel2 = new Panel();
            textBox6 = new TextBox();
            checkBox3 = new CheckBox();
            button6 = new Button();
            comboBox2 = new ComboBox();
            label14 = new Label();
            button5 = new Button();
            textBox5 = new TextBox();
            label13 = new Label();
            button4 = new Button();
            label12 = new Label();
            comboBox1 = new ComboBox();
            button3 = new Button();
            button2 = new Button();
            checkBox2 = new CheckBox();
            label11 = new Label();
            textBox4 = new TextBox();
            label10 = new Label();
            button1 = new Button();
            textBox3 = new TextBox();
            checkBox1 = new CheckBox();
            label9 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label8 = new Label();
            dataGridView3 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countProduct).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)toBasketCount).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(320, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(468, 393);
            dataGridView1.TabIndex = 0;
            // 
            // addToShop
            // 
            addToShop.Location = new Point(12, 157);
            addToShop.Name = "addToShop";
            addToShop.Size = new Size(143, 23);
            addToShop.TabIndex = 1;
            addToShop.Text = "Добавить";
            addToShop.UseVisualStyleBackColor = true;
            addToShop.Click += AddToShop;
            // 
            // nameProduct
            // 
            nameProduct.Location = new Point(12, 40);
            nameProduct.Name = "nameProduct";
            nameProduct.Size = new Size(143, 23);
            nameProduct.TabIndex = 2;
            // 
            // priceProduct
            // 
            priceProduct.Location = new Point(12, 84);
            priceProduct.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            priceProduct.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            priceProduct.Name = "priceProduct";
            priceProduct.Size = new Size(143, 23);
            priceProduct.TabIndex = 3;
            priceProduct.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // countProduct
            // 
            countProduct.Location = new Point(12, 128);
            countProduct.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            countProduct.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            countProduct.Name = "countProduct";
            countProduct.Size = new Size(143, 23);
            countProduct.TabIndex = 4;
            countProduct.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { заданиеToolStripMenuItem, заданиеToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // заданиеToolStripMenuItem
            // 
            заданиеToolStripMenuItem.Name = "заданиеToolStripMenuItem";
            заданиеToolStripMenuItem.Size = new Size(71, 20);
            заданиеToolStripMenuItem.Text = "2 задание";
            заданиеToolStripMenuItem.Click += заданиеToolStripMenuItem_Click;
            // 
            // заданиеToolStripMenuItem1
            // 
            заданиеToolStripMenuItem1.Name = "заданиеToolStripMenuItem1";
            заданиеToolStripMenuItem1.Size = new Size(71, 20);
            заданиеToolStripMenuItem1.Text = "3 задание";
            заданиеToolStripMenuItem1.Click += заданиеToolStripMenuItem1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 6;
            label1.Text = "Введите название товара";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 7;
            label2.Text = "Введите цену товара";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 110);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 8;
            label3.Text = "Введите количество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(320, 1);
            label4.Name = "label4";
            label4.Size = new Size(158, 15);
            label4.TabIndex = 9;
            label4.Text = "Список товаров в магазине";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 257);
            label5.Name = "label5";
            label5.Size = new Size(143, 15);
            label5.TabIndex = 10;
            label5.Text = "Введите название товара";
            // 
            // addBasket
            // 
            addBasket.Location = new Point(12, 348);
            addBasket.Name = "addBasket";
            addBasket.Size = new Size(143, 23);
            addBasket.TabIndex = 11;
            addBasket.Text = "Добавить в корзину";
            addBasket.UseVisualStyleBackColor = true;
            addBasket.Click += AddToBasket;
            // 
            // toBasket
            // 
            toBasket.Location = new Point(12, 275);
            toBasket.Name = "toBasket";
            toBasket.Size = new Size(143, 23);
            toBasket.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 301);
            label6.Name = "label6";
            label6.Size = new Size(117, 15);
            label6.TabIndex = 14;
            label6.Text = "Введите количество";
            // 
            // toBasketCount
            // 
            toBasketCount.Location = new Point(12, 319);
            toBasketCount.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            toBasketCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            toBasketCount.Name = "toBasketCount";
            toBasketCount.Size = new Size(143, 23);
            toBasketCount.TabIndex = 13;
            toBasketCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(601, 4);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 15;
            label7.Text = "Прибыль = 0";
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(buyBasket);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(toBasketCount);
            panel1.Controls.Add(toBasket);
            panel1.Controls.Add(addBasket);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(countProduct);
            panel1.Controls.Add(priceProduct);
            panel1.Controls.Add(nameProduct);
            panel1.Controls.Add(addToShop);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(806, 429);
            panel1.TabIndex = 16;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(188, 265);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(126, 150);
            dataGridView2.TabIndex = 17;
            // 
            // buyBasket
            // 
            buyBasket.Location = new Point(12, 377);
            buyBasket.Name = "buyBasket";
            buyBasket.Size = new Size(143, 23);
            buyBasket.TabIndex = 16;
            buyBasket.Text = "Купить";
            buyBasket.UseVisualStyleBackColor = true;
            buyBasket.Click += BuyBasketProducts;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(checkBox3);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(checkBox2);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(dataGridView3);
            panel2.Location = new Point(0, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 426);
            panel2.TabIndex = 18;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(504, 79);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(147, 23);
            textBox6.TabIndex = 23;
            textBox6.Visible = false;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(504, 54);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(130, 19);
            checkBox3.TabIndex = 22;
            checkBox3.Text = "Выбрать по автору";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += CheckDeleteByAuthor;
            // 
            // button6
            // 
            button6.Location = new Point(504, 249);
            button6.Name = "button6";
            button6.Size = new Size(147, 23);
            button6.TabIndex = 21;
            button6.Text = "Очистить плейлист";
            button6.UseVisualStyleBackColor = true;
            button6.Click += ClearPlaylist;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(504, 193);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(147, 23);
            comboBox2.TabIndex = 20;
            comboBox2.SelectedIndexChanged += DeleteByIndex;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(526, 160);
            label14.Name = "label14";
            label14.Size = new Size(100, 30);
            label14.TabIndex = 19;
            label14.Text = "Выберите номер\r\nдля удаления";
            // 
            // button5
            // 
            button5.Location = new Point(504, 108);
            button5.Name = "button5";
            button5.Size = new Size(147, 23);
            button5.TabIndex = 18;
            button5.Text = "Удалить";
            button5.UseVisualStyleBackColor = true;
            button5.Click += DeleteByName;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(504, 25);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(147, 23);
            textBox5.TabIndex = 17;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(523, 7);
            label13.Name = "label13";
            label13.Size = new Size(103, 15);
            label13.TabIndex = 16;
            label13.Text = "Введите название";
            // 
            // button4
            // 
            button4.Location = new Point(211, 249);
            button4.Name = "button4";
            button4.Size = new Size(68, 23);
            button4.TabIndex = 15;
            button4.Text = "<<";
            button4.UseVisualStyleBackColor = true;
            button4.Click += ToFirstSong;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(211, 278);
            label12.Name = "label12";
            label12.Size = new Size(136, 15);
            label12.TabIndex = 14;
            label12.Text = "Выберите номер песни";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(353, 275);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 23);
            comboBox1.TabIndex = 13;
            comboBox1.SelectedIndexChanged += CheckIndexToTrack;
            // 
            // button3
            // 
            button3.Location = new Point(410, 249);
            button3.Name = "button3";
            button3.Size = new Size(68, 23);
            button3.TabIndex = 12;
            button3.Text = "-->";
            button3.UseVisualStyleBackColor = true;
            button3.Click += NextSongButton;
            // 
            // button2
            // 
            button2.Location = new Point(336, 249);
            button2.Name = "button2";
            button2.Size = new Size(68, 23);
            button2.TabIndex = 11;
            button2.Text = "<--";
            button2.UseVisualStyleBackColor = true;
            button2.Click += BackSongButton;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(12, 98);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(125, 19);
            checkBox2.TabIndex = 10;
            checkBox2.Text = "Автор отсутствует";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += CheckEmptyAuthor;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(211, 222);
            label11.Name = "label11";
            label11.Size = new Size(154, 15);
            label11.TabIndex = 0;
            label11.Text = "Сейчас ничего не играет :(";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 187);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(165, 23);
            textBox4.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 169);
            label10.Name = "label10";
            label10.Size = new Size(113, 15);
            label10.TabIndex = 8;
            label10.Text = "Введите имя файла";
            // 
            // button1
            // 
            button1.Location = new Point(12, 216);
            button1.Name = "button1";
            button1.Size = new Size(165, 23);
            button1.TabIndex = 7;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AddSongButton;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 143);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(165, 23);
            textBox3.TabIndex = 6;
            textBox3.Visible = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 118);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(165, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Добавить второго автора";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += CheckTwoAuthors;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 51);
            label9.Name = "label9";
            label9.Size = new Size(90, 15);
            label9.TabIndex = 4;
            label9.Text = "Введите автора";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 69);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 23);
            textBox1.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 7);
            label8.Name = "label8";
            label8.Size = new Size(139, 15);
            label8.TabIndex = 1;
            label8.Text = "Введите название песни";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(211, 7);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(267, 212);
            dataGridView3.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)countProduct).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)toBasketCount).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button addToShop;
        private TextBox nameProduct;
        private NumericUpDown priceProduct;
        private NumericUpDown countProduct;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem заданиеToolStripMenuItem;
        private ToolStripMenuItem заданиеToolStripMenuItem1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button addBasket;
        private TextBox toBasket;
        private Label label6;
        private NumericUpDown toBasketCount;
        private Label label7;
        private Panel panel1;
        private Button buyBasket;
        private DataGridView dataGridView2;
        private Panel panel2;
        private DataGridView dataGridView3;
        private TextBox textBox1;
        private Label label8;
        private CheckBox checkBox1;
        private Label label9;
        private TextBox textBox2;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label10;
        private CheckBox checkBox2;
        private Label label11;
        private Button button3;
        private Button button2;
        private ComboBox comboBox1;
        private Button button4;
        private Label label12;
        private ComboBox comboBox2;
        private Label label14;
        private Button button5;
        private TextBox textBox5;
        private Label label13;
        private Button button6;
        private TextBox textBox6;
        private CheckBox checkBox3;
    }
}