using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipmentOfGoodsMarch_8Diplom
{
    public partial class AcceptedOrder : Form
    {
        public AcceptedOrder()
        {
            InitializeComponent();
        }

        private void AcceptOrder_Click(object sender, EventArgs e)
        {
            if (entryDriverName.Text != "" && entryTrailer.Text != "" && entryCarNumber.Text != "" && entryNumberOfPackages.Text != "")
            {
                MainForm mainForm = (MainForm)this.Owner;
                DBManager.OpenConnect();
                string query = $"Select ListOfOrder.IdProduct,ListOfOrder.Count  from ListOfOrder " +
                    $"inner join Orders on Orders.Id = ListOfOrder.IdOrder where Orders.Id = {mainForm.dataGridOrder.CurrentRow.Cells[0].Value}";
                SqlDataAdapter adapter = new SqlDataAdapter(query, DBManager.dataShipmentOfDoods);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DBManager.CloseConnect();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    DataRow row = table.Rows[i];
                    query = $"Select Count(Id) From ListOfStoreProduct where IdProduct = {row[0]} and IdShop = {mainForm.dataGridOrder.CurrentRow.Cells[1].Value}";
                    DBManager.OpenConnect();
                    SqlCommand command = new SqlCommand(query, DBManager.dataShipmentOfDoods);
                    int have = Convert.ToInt32(command.ExecuteScalar());
                    DBManager.CloseConnect();
                    if (have <= 0)
                    {
                        query = $"Insert into ListOfStoreProduct Values({row[0]},{mainForm.dataGridOrder.CurrentRow.Cells[1].Value},{row[1]})";
                        DBManager.ExecuteQuery(query);
                    }
                    else
                    {
                        query = $"Update ListOfStoreProduct Set Count = (Count + {row[1]}) where IdProduct = {row[0]} and IdShop = {mainForm.dataGridOrder.CurrentRow.Cells[1].Value}";
                        DBManager.ExecuteQuery(query);
                    }
                }
                query = $"Update Orders Set DriverName = N'{entryDriverName.Text}', CarNumber = N'{entryCarNumber.Text}'," +
                    $" Trailer = N'{entryTrailer.Text}',NumberOfPackages = '{entryNumberOfPackages.Text}', isCompleted = 'True'  Where Id = {mainForm.dataGridOrder.CurrentRow.Cells[0].Value}";
                DBManager.ExecuteQuery(query);
                Hide();
            }
            else
                MessageBox.Show("Требуется заполнить все поля");
        }

        private void entryNumberOfPackages_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

		private void AcceptedOrder_Load(object sender, EventArgs e)
		{

		}
	}
}
