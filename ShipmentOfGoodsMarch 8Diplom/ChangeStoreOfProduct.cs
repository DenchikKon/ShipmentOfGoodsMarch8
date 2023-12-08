using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipmentOfGoodsMarch_8Diplom
{
    public partial class ChangeStoreOfProduct : Form
    {
        public ChangeStoreOfProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(entryCount.Text, out int count))
            {
                MainForm mainForm = (MainForm)this.Owner;
                string query = $"Update ListOfStoreProduct Set Count = {entryCount.Text} where Id={mainForm.dataGridListOfStoreProduct.CurrentRow.Cells[0].Value}";
                DBManager.ExecuteQuery(query);
                Hide();
            }
            else
                MessageBox.Show("Требуется ввести числовое значение");
        }

        private void entryCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

		private void ChangeStoreOfProduct_Load(object sender, EventArgs e)
		{

		}
	}
}
