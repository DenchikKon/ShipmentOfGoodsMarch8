namespace ShipmentOfGoodsMarch_8Diplom
{
    partial class AcceptedOrder
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
			this.entryDriverName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.entryCarNumber = new System.Windows.Forms.TextBox();
			this.entryTrailer = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.entryNumberOfPackages = new System.Windows.Forms.TextBox();
			this.AcceptOrder = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "ФИО Водителя:";
			// 
			// entryDriverName
			// 
			this.entryDriverName.Location = new System.Drawing.Point(140, 20);
			this.entryDriverName.Name = "entryDriverName";
			this.entryDriverName.Size = new System.Drawing.Size(162, 20);
			this.entryDriverName.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Номер машины:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(28, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Прицеп:";
			// 
			// entryCarNumber
			// 
			this.entryCarNumber.Location = new System.Drawing.Point(140, 51);
			this.entryCarNumber.Name = "entryCarNumber";
			this.entryCarNumber.Size = new System.Drawing.Size(162, 20);
			this.entryCarNumber.TabIndex = 4;
			// 
			// entryTrailer
			// 
			this.entryTrailer.Location = new System.Drawing.Point(140, 81);
			this.entryTrailer.Name = "entryTrailer";
			this.entryTrailer.Size = new System.Drawing.Size(162, 20);
			this.entryTrailer.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(4, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(122, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Кол-во грузовых мест:";
			// 
			// entryNumberOfPackages
			// 
			this.entryNumberOfPackages.Location = new System.Drawing.Point(140, 115);
			this.entryNumberOfPackages.Name = "entryNumberOfPackages";
			this.entryNumberOfPackages.Size = new System.Drawing.Size(162, 20);
			this.entryNumberOfPackages.TabIndex = 7;
			this.entryNumberOfPackages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.entryNumberOfPackages_KeyPress);
			// 
			// AcceptOrder
			// 
			this.AcceptOrder.BackColor = System.Drawing.Color.Chartreuse;
			this.AcceptOrder.Location = new System.Drawing.Point(174, 143);
			this.AcceptOrder.Name = "AcceptOrder";
			this.AcceptOrder.Size = new System.Drawing.Size(128, 31);
			this.AcceptOrder.TabIndex = 8;
			this.AcceptOrder.Text = "Подтвердить";
			this.AcceptOrder.UseVisualStyleBackColor = false;
			this.AcceptOrder.Click += new System.EventHandler(this.AcceptOrder_Click);
			// 
			// AcceptedOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(309, 181);
			this.Controls.Add(this.AcceptOrder);
			this.Controls.Add(this.entryNumberOfPackages);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.entryTrailer);
			this.Controls.Add(this.entryCarNumber);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.entryDriverName);
			this.Controls.Add(this.label1);
			this.Name = "AcceptedOrder";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Подтверждение заявки";
			this.Load += new System.EventHandler(this.AcceptedOrder_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox entryDriverName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox entryCarNumber;
        private System.Windows.Forms.TextBox entryTrailer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox entryNumberOfPackages;
        private System.Windows.Forms.Button AcceptOrder;
    }
}