namespace ShipmentOfGoodsMarch_8Diplom
{
    partial class addProduct
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.entryName = new System.Windows.Forms.TextBox();
			this.chooseTypeOfProduct = new System.Windows.Forms.ComboBox();
			this.chooseSize = new System.Windows.Forms.ComboBox();
			this.entryPrice = new System.Windows.Forms.TextBox();
			this.entryCount = new System.Windows.Forms.TextBox();
			this.addOrChangeProduct = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Название:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Тип продукции:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 97);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Размер:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 130);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(36, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Цена:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 160);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Количество:";
			// 
			// entryName
			// 
			this.entryName.Location = new System.Drawing.Point(103, 22);
			this.entryName.Name = "entryName";
			this.entryName.Size = new System.Drawing.Size(121, 20);
			this.entryName.TabIndex = 5;
			// 
			// chooseTypeOfProduct
			// 
			this.chooseTypeOfProduct.FormattingEnabled = true;
			this.chooseTypeOfProduct.Location = new System.Drawing.Point(103, 58);
			this.chooseTypeOfProduct.Name = "chooseTypeOfProduct";
			this.chooseTypeOfProduct.Size = new System.Drawing.Size(121, 21);
			this.chooseTypeOfProduct.TabIndex = 6;
			// 
			// chooseSize
			// 
			this.chooseSize.FormattingEnabled = true;
			this.chooseSize.Items.AddRange(new object[] {
            "XS",
            "S",
            "M",
            "L",
            "XL",
            "XXL"});
			this.chooseSize.Location = new System.Drawing.Point(103, 94);
			this.chooseSize.Name = "chooseSize";
			this.chooseSize.Size = new System.Drawing.Size(121, 21);
			this.chooseSize.TabIndex = 7;
			// 
			// entryPrice
			// 
			this.entryPrice.Location = new System.Drawing.Point(103, 127);
			this.entryPrice.Name = "entryPrice";
			this.entryPrice.Size = new System.Drawing.Size(121, 20);
			this.entryPrice.TabIndex = 8;
			this.entryPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
			// 
			// entryCount
			// 
			this.entryCount.Location = new System.Drawing.Point(103, 157);
			this.entryCount.Name = "entryCount";
			this.entryCount.Size = new System.Drawing.Size(121, 20);
			this.entryCount.TabIndex = 9;
			this.entryCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
			// 
			// addOrChangeProduct
			// 
			this.addOrChangeProduct.BackColor = System.Drawing.Color.Chartreuse;
			this.addOrChangeProduct.Location = new System.Drawing.Point(15, 187);
			this.addOrChangeProduct.Name = "addOrChangeProduct";
			this.addOrChangeProduct.Size = new System.Drawing.Size(130, 23);
			this.addOrChangeProduct.TabIndex = 10;
			this.addOrChangeProduct.Text = "Добавить";
			this.addOrChangeProduct.UseVisualStyleBackColor = false;
			this.addOrChangeProduct.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.LightCoral;
			this.button2.Location = new System.Drawing.Point(151, 187);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(73, 23);
			this.button2.TabIndex = 11;
			this.button2.Text = "отмена";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// addProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(237, 226);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.addOrChangeProduct);
			this.Controls.Add(this.entryCount);
			this.Controls.Add(this.entryPrice);
			this.Controls.Add(this.chooseSize);
			this.Controls.Add(this.chooseTypeOfProduct);
			this.Controls.Add(this.entryName);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "addProduct";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Продукция";
			this.Load += new System.EventHandler(this.addProduct_Load);
			this.Shown += new System.EventHandler(this.addProduct_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button addOrChangeProduct;
        public System.Windows.Forms.TextBox entryName;
        public System.Windows.Forms.ComboBox chooseTypeOfProduct;
        public System.Windows.Forms.ComboBox chooseSize;
        public System.Windows.Forms.TextBox entryPrice;
        public System.Windows.Forms.TextBox entryCount;
    }
}