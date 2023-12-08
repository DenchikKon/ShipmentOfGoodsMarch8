namespace ShipmentOfGoodsMarch_8Diplom
{
    partial class Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridCreateOrder = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ChooseProduct = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.infoCount = new System.Windows.Forms.Label();
            this.addCount = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.entryCountAdd = new System.Windows.Forms.TextBox();
            this.DeleteCount = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.entryCountDelete = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.infoFullPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.infoPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.infoPriceNDS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCreateOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCreateOrder
            // 
            this.dataGridCreateOrder.AllowUserToAddRows = false;
            this.dataGridCreateOrder.AllowUserToDeleteRows = false;
            this.dataGridCreateOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCreateOrder.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridCreateOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCreateOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.Size,
            this.Count,
            this.Price});
            this.dataGridCreateOrder.Location = new System.Drawing.Point(13, 98);
            this.dataGridCreateOrder.Name = "dataGridCreateOrder";
            this.dataGridCreateOrder.ReadOnly = true;
            this.dataGridCreateOrder.RowHeadersVisible = false;
            this.dataGridCreateOrder.Size = new System.Drawing.Size(712, 278);
            this.dataGridCreateOrder.TabIndex = 33;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.HeaderText = "Наименование";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Size
            // 
            this.Size.HeaderText = "Размер";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.HeaderText = "Количество";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // CreateOrder
            // 
            this.CreateOrder.BackColor = System.Drawing.Color.Chartreuse;
            this.CreateOrder.Location = new System.Drawing.Point(610, 382);
            this.CreateOrder.Name = "CreateOrder";
            this.CreateOrder.Size = new System.Drawing.Size(115, 23);
            this.CreateOrder.TabIndex = 34;
            this.CreateOrder.Text = "Подать заявку";
            this.CreateOrder.UseVisualStyleBackColor = false;
            this.CreateOrder.Click += new System.EventHandler(this.CreateOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Выберите товар:";
            // 
            // ChooseProduct
            // 
            this.ChooseProduct.FormattingEnabled = true;
            this.ChooseProduct.Location = new System.Drawing.Point(109, 42);
            this.ChooseProduct.Name = "ChooseProduct";
            this.ChooseProduct.Size = new System.Drawing.Size(154, 21);
            this.ChooseProduct.TabIndex = 24;
            this.ChooseProduct.SelectedValueChanged += new System.EventHandler(this.ChooseProduct_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Кол-во на складе:";
            // 
            // infoCount
            // 
            this.infoCount.AutoSize = true;
            this.infoCount.Location = new System.Drawing.Point(115, 17);
            this.infoCount.Name = "infoCount";
            this.infoCount.Size = new System.Drawing.Size(0, 13);
            this.infoCount.TabIndex = 26;
            // 
            // addCount
            // 
            this.addCount.BackColor = System.Drawing.Color.Chartreuse;
            this.addCount.Location = new System.Drawing.Point(397, 12);
            this.addCount.Name = "addCount";
            this.addCount.Size = new System.Drawing.Size(75, 23);
            this.addCount.TabIndex = 27;
            this.addCount.Text = "Добавить";
            this.addCount.UseVisualStyleBackColor = false;
            this.addCount.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = " Кол-во на добавление:";
            // 
            // entryCountAdd
            // 
            this.entryCountAdd.Location = new System.Drawing.Point(609, 14);
            this.entryCountAdd.Name = "entryCountAdd";
            this.entryCountAdd.Size = new System.Drawing.Size(116, 20);
            this.entryCountAdd.TabIndex = 29;
            this.entryCountAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.entryCountAdd_KeyPress);
            // 
            // DeleteCount
            // 
            this.DeleteCount.BackColor = System.Drawing.Color.LightCoral;
            this.DeleteCount.Location = new System.Drawing.Point(397, 42);
            this.DeleteCount.Name = "DeleteCount";
            this.DeleteCount.Size = new System.Drawing.Size(75, 23);
            this.DeleteCount.TabIndex = 30;
            this.DeleteCount.Text = "Удалить";
            this.DeleteCount.UseVisualStyleBackColor = false;
            this.DeleteCount.Click += new System.EventHandler(this.DeleteCount_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = " Кол-во на удаление:";
            // 
            // entryCountDelete
            // 
            this.entryCountDelete.Location = new System.Drawing.Point(609, 45);
            this.entryCountDelete.Name = "entryCountDelete";
            this.entryCountDelete.Size = new System.Drawing.Size(116, 20);
            this.entryCountDelete.TabIndex = 32;
            this.entryCountDelete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.entryCountDelete_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Общая стоимость:";
            // 
            // infoFullPrice
            // 
            this.infoFullPrice.AutoSize = true;
            this.infoFullPrice.Location = new System.Drawing.Point(522, 387);
            this.infoFullPrice.Name = "infoFullPrice";
            this.infoFullPrice.Size = new System.Drawing.Size(13, 13);
            this.infoFullPrice.TabIndex = 36;
            this.infoFullPrice.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Стоимость:";
            // 
            // infoPrice
            // 
            this.infoPrice.AutoSize = true;
            this.infoPrice.Location = new System.Drawing.Point(269, 17);
            this.infoPrice.Name = "infoPrice";
            this.infoPrice.Size = new System.Drawing.Size(35, 13);
            this.infoPrice.TabIndex = 38;
            this.infoPrice.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "НДС: 20%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Цена с НДС:";
            // 
            // infoPriceNDS
            // 
            this.infoPriceNDS.AutoSize = true;
            this.infoPriceNDS.Location = new System.Drawing.Point(90, 392);
            this.infoPriceNDS.Name = "infoPriceNDS";
            this.infoPriceNDS.Size = new System.Drawing.Size(13, 13);
            this.infoPriceNDS.TabIndex = 41;
            this.infoPriceNDS.Text = "0";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(731, 417);
            this.Controls.Add(this.infoPriceNDS);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.infoPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.infoFullPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CreateOrder);
            this.Controls.Add(this.dataGridCreateOrder);
            this.Controls.Add(this.entryCountDelete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DeleteCount);
            this.Controls.Add(this.entryCountAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addCount);
            this.Controls.Add(this.infoCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChooseProduct);
            this.Controls.Add(this.label1);
            this.Name = "Order";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание заявки";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCreateOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridCreateOrder;
        private System.Windows.Forms.Button CreateOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label infoCount;
        private System.Windows.Forms.Button addCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox entryCountAdd;
        private System.Windows.Forms.Button DeleteCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox entryCountDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label infoFullPrice;
        public System.Windows.Forms.ComboBox ChooseProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label infoPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label infoPriceNDS;
    }
}