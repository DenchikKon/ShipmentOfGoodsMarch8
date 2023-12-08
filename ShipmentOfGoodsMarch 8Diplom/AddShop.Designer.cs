namespace ShipmentOfGoodsMarch_8Diplom
{
    partial class AddShop
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
			this.addOrChangeShop = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.entryName = new System.Windows.Forms.TextBox();
			this.entryAddress = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.entryDirector = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.entryUNP = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.entryLogin = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.entryPassword = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// addOrChangeShop
			// 
			this.addOrChangeShop.BackColor = System.Drawing.Color.Chartreuse;
			this.addOrChangeShop.Location = new System.Drawing.Point(15, 165);
			this.addOrChangeShop.Name = "addOrChangeShop";
			this.addOrChangeShop.Size = new System.Drawing.Size(104, 23);
			this.addOrChangeShop.TabIndex = 0;
			this.addOrChangeShop.Text = "Добавить";
			this.addOrChangeShop.UseVisualStyleBackColor = false;
			this.addOrChangeShop.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.LightCoral;
			this.button2.Location = new System.Drawing.Point(125, 165);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Отмена";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Наименование:";
			// 
			// entryName
			// 
			this.entryName.Location = new System.Drawing.Point(101, 6);
			this.entryName.MaxLength = 50;
			this.entryName.Name = "entryName";
			this.entryName.Size = new System.Drawing.Size(100, 20);
			this.entryName.TabIndex = 3;
			// 
			// entryAddress
			// 
			this.entryAddress.Location = new System.Drawing.Point(101, 32);
			this.entryAddress.MaxLength = 50;
			this.entryAddress.Name = "entryAddress";
			this.entryAddress.Size = new System.Drawing.Size(100, 20);
			this.entryAddress.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Адрес:";
			// 
			// entryDirector
			// 
			this.entryDirector.Location = new System.Drawing.Point(101, 58);
			this.entryDirector.MaxLength = 50;
			this.entryDirector.Name = "entryDirector";
			this.entryDirector.Size = new System.Drawing.Size(100, 20);
			this.entryDirector.TabIndex = 7;
			this.entryDirector.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			this.entryDirector.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.entryDirector_KeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Директор:";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// entryUNP
			// 
			this.entryUNP.Location = new System.Drawing.Point(101, 84);
			this.entryUNP.MaxLength = 9;
			this.entryUNP.Name = "entryUNP";
			this.entryUNP.Size = new System.Drawing.Size(100, 20);
			this.entryUNP.TabIndex = 9;
			this.entryUNP.TextChanged += new System.EventHandler(this.entryUNP_TextChanged);
			this.entryUNP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.entryUNP_KeyPress);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 87);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "УНП:";
			// 
			// entryLogin
			// 
			this.entryLogin.Location = new System.Drawing.Point(101, 110);
			this.entryLogin.MaxLength = 15;
			this.entryLogin.Name = "entryLogin";
			this.entryLogin.Size = new System.Drawing.Size(100, 20);
			this.entryLogin.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 113);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Логин:";
			// 
			// entryPassword
			// 
			this.entryPassword.Location = new System.Drawing.Point(101, 136);
			this.entryPassword.MaxLength = 15;
			this.entryPassword.Name = "entryPassword";
			this.entryPassword.Size = new System.Drawing.Size(100, 20);
			this.entryPassword.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 139);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Пароль:";
			// 
			// AddShop
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(225, 209);
			this.Controls.Add(this.entryPassword);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.entryLogin);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.entryUNP);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.entryDirector);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.entryAddress);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.entryName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.addOrChangeShop);
			this.Name = "AddShop";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Магазин";
			this.Load += new System.EventHandler(this.AddShop_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button addOrChangeShop;
        public System.Windows.Forms.TextBox entryName;
        public System.Windows.Forms.TextBox entryAddress;
        public System.Windows.Forms.TextBox entryDirector;
        public System.Windows.Forms.TextBox entryUNP;
        public System.Windows.Forms.TextBox entryLogin;
        public System.Windows.Forms.TextBox entryPassword;
    }
}