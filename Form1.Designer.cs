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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countProduct).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)toBasketCount).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            panel1.Location = new Point(0, 23);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}