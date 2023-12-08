using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipmentOfGoodsMarch_8Diplom
{
    public partial class AddShop : Form
    {
        static string query;
        public AddShop()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (entryName.Text != string.Empty && entryAddress.Text != string.Empty && entryDirector.Text != string.Empty &&
                entryUNP.Text != string.Empty && entryLogin.Text != string.Empty && entryPassword.Text != string.Empty)
            {
                MainForm mainForm = (MainForm)this.Owner;
                if (addOrChangeShop.Text == "Добавить")
                {
                    query = $"if(select count(Login) from Shop where Login=N'{entryLogin.Text}')=0 " +
                        $"And (select count(Password) from Shop where Password=N'{entryPassword.Text}')=0 " +
                        $"Insert Into Shop Values(N'{entryLogin.Text}',N'{entryPassword.Text}',N'{entryAddress.Text}',N'{entryName.Text}',N'{entryDirector.Text}',{entryUNP.Text})";
                }
                else if (addOrChangeShop.Text == "Изменить")
                {
                    query = $"if(select count(Login) from Shop where Login = N'{entryLogin.Text}' and Id != {mainForm.dataGridShop.CurrentRow.Cells[0].Value})=0 " +
                        $"And (select count(Password) from Shop where Password = N'{entryPassword.Text}' and Id != {mainForm.dataGridShop.CurrentRow.Cells[0].Value})=0 " +
                        $"Update Shop Set Login = N'{entryLogin.Text}',Password = N'{entryPassword.Text}', " +
                        $"Address = N'{entryAddress.Text}', Name = N'{entryName.Text}', Director = N'{entryDirector.Text}', UNP = {entryUNP.Text}" +
                        $"  Where Id = {mainForm.dataGridShop.CurrentRow.Cells[0].Value}";
                }
                DBManager.OpenConnect();
                SqlCommand command = new SqlCommand(query, DBManager.dataShipmentOfDoods);
                int count = command.ExecuteNonQuery();
                DBManager.CloseConnect();
                if (count == -1)
                    MessageBox.Show("Пользователь с данным логином или паролем уже зарегистрирован в системе");
                else
                {
                    DBManager.LoadData(mainForm.dataGridShop, DBManager.mainShopQuery);
                    Hide();
                }
            }
            else
                MessageBox.Show("Требуется верно заполнить все поля");
        }

        private void entryUNP_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void entryUNP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled= true;
            }
        }

        private void entryDirector_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ') 
            { 
                e.Handled= true;
            }
        }

		private void AddShop_Load(object sender, EventArgs e)
		{

		}
	}
}
