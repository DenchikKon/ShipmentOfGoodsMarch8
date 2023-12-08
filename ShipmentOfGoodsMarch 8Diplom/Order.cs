using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipmentOfGoodsMarch_8Diplom
{
    public partial class Order : Form
    {
        string query;
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            dataGridCreateOrder.Columns[0].Visible= false;
            query = " Select Id, Concat(Trim(Title), ' ', Trim(Size)) as 'Title' from Product";
            DBManager.LoadComboBox(ChooseProduct, query, "Id", "Title");

        }
        private void ChooseProduct_SelectedValueChanged(object sender, EventArgs e)
        {
            if(ChooseProduct.Items.Count != 0 && ChooseProduct.SelectedIndex != -1) 
            {
                DBManager.OpenConnect();
                string a = ChooseProduct.SelectedIndex.ToString();
                query = $"Select Count From Product Where Id = {ChooseProduct.SelectedValue}";
                SqlCommand sqlCommand = new SqlCommand(query, DBManager.dataShipmentOfDoods);
                infoCount.Text = sqlCommand.ExecuteScalar().ToString();
                query = $"Select Price From Product Where Id = {ChooseProduct.SelectedValue}";
                sqlCommand = new SqlCommand(query, DBManager.dataShipmentOfDoods);
                infoPrice.Text = sqlCommand.ExecuteScalar().ToString();
                DBManager.CloseConnect();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(entryCountAdd.Text) <= Convert.ToInt32(infoCount.Text))
                {
                    bool isHave = false;
                    int rowIndex = 0;
                    for (int i = 0; i < dataGridCreateOrder.RowCount; i++)
                    {
                        if (dataGridCreateOrder[0, i].Value.ToString() == ChooseProduct.SelectedValue.ToString())
                        {
                            isHave = true;
                            rowIndex = i;
                            break;
                        }
                    }
                    if (isHave)
                    {
                        int countProduct = Convert.ToInt32(dataGridCreateOrder.Rows[rowIndex].Cells[3].Value) + Convert.ToInt32(entryCountAdd.Text);
                        if (countProduct < Convert.ToInt32(infoCount.Text))
                        {
                            dataGridCreateOrder.Rows[rowIndex].Cells[3].Value = countProduct;
                            dataGridCreateOrder.Rows[rowIndex].Cells[4].Value = Convert.ToDecimal(infoPrice.Text) * Convert.ToInt32(dataGridCreateOrder.Rows[rowIndex].Cells[3].Value);
                        }
                        else
                            MessageBox.Show("На складе нет требуемого количества данного товара");
                    }
                    else
                    {
                        StringBuilder stringBuilder = new StringBuilder();
                        string[] nameAndSize = ChooseProduct.Text.Split(' ');
                        dataGridCreateOrder.Rows.Add();
                        dataGridCreateOrder.Rows[dataGridCreateOrder.RowCount - 1].Cells[0].Value = ChooseProduct.SelectedValue.ToString();
                        for (int i = 0; i <= nameAndSize.Length - 2; i++)
                            stringBuilder.Append(nameAndSize[i]);
                        dataGridCreateOrder.Rows[dataGridCreateOrder.RowCount - 1].Cells[1].Value = stringBuilder.ToString();
                        dataGridCreateOrder.Rows[dataGridCreateOrder.RowCount - 1].Cells[2].Value = nameAndSize[nameAndSize.Length - 1];
                        dataGridCreateOrder.Rows[dataGridCreateOrder.RowCount - 1].Cells[3].Value = entryCountAdd.Text;
                        dataGridCreateOrder.Rows[dataGridCreateOrder.RowCount - 1].Cells[4].Value = Convert.ToDecimal(infoPrice.Text) * Convert.ToInt32(entryCountAdd.Text);
                    }
                    decimal fullPrice = 0;
                    for (int i = 0; i < dataGridCreateOrder.RowCount; i++)
                    {
                        fullPrice += Convert.ToDecimal(dataGridCreateOrder.Rows[i].Cells[4].Value);
                    }
                    infoFullPrice.Text = fullPrice.ToString();
                    infoPriceNDS.Text = (fullPrice + (fullPrice * Convert.ToDecimal(0.2))).ToString();
                }
                else
                    MessageBox.Show("На складе нет требуемого количества данного товара");
            }
            catch (Exception)
            {
                MessageBox.Show("Введите числовое значение");
            }
           
        }

        private void DeleteCount_Click(object sender, EventArgs e)
        {
            try
            {
                bool isHave = false;
                int rowIndex = 0;
                for (int i = 0; i < dataGridCreateOrder.RowCount; i++)
                {
                    if (dataGridCreateOrder[0, i].Value.ToString() == ChooseProduct.SelectedValue.ToString())
                    {
                        isHave = true;
                        rowIndex = i;
                        break;
                    }
                }
                if (!isHave)
                {
                    MessageBox.Show("Данного продукта нет в списке");
                }
                else
                {
                    if (Convert.ToInt32(entryCountDelete.Text) <= Convert.ToInt32(dataGridCreateOrder.Rows[rowIndex].Cells[3].Value))
                    {
                        dataGridCreateOrder.Rows[rowIndex].Cells[3].Value =
                        (Convert.ToInt32(dataGridCreateOrder.Rows[rowIndex].Cells[3].Value) - Convert.ToInt32(entryCountDelete.Text)).ToString();
                        dataGridCreateOrder.Rows[rowIndex].Cells[4].Value = Convert.ToDecimal(infoPrice.Text) * Convert.ToInt32(dataGridCreateOrder.Rows[rowIndex].Cells[3].Value);
                        int countProduct = Convert.ToInt32(dataGridCreateOrder.Rows[rowIndex].Cells[3].Value);
                        decimal fullPrice = 0;
                        for (int i = 0; i < dataGridCreateOrder.RowCount; i++)
                        {
                            fullPrice += Convert.ToDecimal(dataGridCreateOrder.Rows[i].Cells[4].Value);
                        }
                        infoFullPrice.Text = fullPrice.ToString();
                        infoPriceNDS.Text = (fullPrice + (fullPrice * Convert.ToDecimal(0.2))).ToString();
                        if (countProduct <= 0)
                            dataGridCreateOrder.Rows.RemoveAt(rowIndex);
                    }
                    else MessageBox.Show("Невозможно удалить больше товара чем в заявке");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Введите числовое значение");
            }
           
        }

        private void CreateOrder_Click(object sender, EventArgs e)
        {
            if (dataGridCreateOrder.RowCount > 0)
            {
                    query = $"Insert into Orders (IdShop,DateOrder,fullPrice,NDS) " +
                        $"Values({MainForm.idUser},'{DateTime.Now.ToString("yyyy/MM/dd",CultureInfo.CurrentCulture)}',{infoFullPrice.Text.Replace(',', '.')},20)";
                    DBManager.ExecuteQuery(query);
                    for (int i = 0; i < dataGridCreateOrder.RowCount; i++)
                    {
                        query = $"Insert into ListOfOrder Values((Select Max(id) from Orders), " +
                            $"{dataGridCreateOrder.Rows[i].Cells[0].Value},{dataGridCreateOrder.Rows[i].Cells[3].Value});";
                        DBManager.ExecuteQuery(query);
                    }
                    Hide();
            }
            else
                MessageBox.Show("Требуется выбрать минимум 1 товар");
        }

        private void entryCountAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void entryCountDelete_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
