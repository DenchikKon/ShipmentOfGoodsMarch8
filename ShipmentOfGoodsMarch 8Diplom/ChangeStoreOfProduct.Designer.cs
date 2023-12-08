namespace ShipmentOfGoodsMarch_8Diplom
{
    partial class ChangeStoreOfProduct
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
			this.entryCount = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Количество:";
			// 
			// entryCount
			// 
			this.entryCount.Location = new System.Drawing.Point(87, 6);
			this.entryCount.Name = "entryCount";
			this.entryCount.Size = new System.Drawing.Size(91, 20);
			this.entryCount.TabIndex = 1;
			this.entryCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.entryCount_KeyPress);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Chartreuse;
			this.button1.Location = new System.Drawing.Point(87, 32);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(91, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Изменить";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// ChangeStoreOfProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(203, 63);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.entryCount);
			this.Controls.Add(this.label1);
			this.Name = "ChangeStoreOfProduct";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Продукция";
			this.Load += new System.EventHandler(this.ChangeStoreOfProduct_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox entryCount;
    }
}