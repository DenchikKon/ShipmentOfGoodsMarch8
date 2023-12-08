using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipmentOfGoodsMarch_8Diplom
{
    public partial class addProduct : Form
    {
        string query;
        public addProduct()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (entryName.Text != string.Empty && chooseTypeOfProduct.SelectedIndex != -1 && chooseSize.SelectedIndex != -1 &&
                double.TryParse(entryPrice.Text.Replace('.', ','), out double price) && int.TryParse(entryCount.Text, out int count))
            {
                MainForm mainForm = (MainForm)this.Owner;
                if (addOrChangeProduct.Text == "Добавить")
                    query = $"Insert Into Product Values({chooseTypeOfProduct.SelectedValue},N'{entryName.Text}',{count},{price.ToString().Replace(',', '.')},N'{chooseSize.Text}')";
                else if (addOrChangeProduct.Text == "Изменить")
                    query = $"Update Product Set idTypeOfProduct = {chooseTypeOfProduct.SelectedValue}, Title = N'{entryName.Text}', Price = {entryPrice.Text}, " +
                        $"Count = {entryCount.Text}, Size = '{chooseSize.Text}' Where Id = {mainForm.dataGridProduct.CurrentRow.Cells[0].Value}";
                DBManager.ExecuteQuery(query);
                DBManager.LoadData(mainForm.dataGridProduct, DBManager.mainProductQuery);
                Hide();
            }
            else
                MessageBox.Show("Требуется верно заполнить все поля");
        }

        private void addProduct_Load(object sender, EventArgs e)
        {
			string query = "Select * From TypeOfProduct";
            DBManager.LoadComboBox(chooseTypeOfProduct, query, "Id", "Title");
        }

		private void addProduct_Shown(object sender, EventArgs e)
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
		}
	}
}
