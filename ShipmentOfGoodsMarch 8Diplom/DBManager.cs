using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
using System.Globalization;

namespace ShipmentOfGoodsMarch_8Diplom
{
    internal class DBManager
    {
        public static string mainOrderQuery = @"Select Orders.Id,Shop.Id as 'shopId', Shop.Name as 'Название',Shop.Address as 'Адрес',Shop.UNP as 'УНП', DateOrder as 'Дата подачи',Orders.isCompleted as 'Статус', Orders.fullPrice as 'Полная стоимост',
        Orders.DriverName as 'Водитель',Orders.CarNumber as 'Номер машины', Orders.Trailer as 'Прицеп', NumberOfPackages as 'Кол-во груз. мест',Orders.NDS as 'НДС', DateOfDelivery as 'Дата поступления'
        From Orders inner join Shop on Shop.Id = Orders.IdShop";
        public static string mainProductQuery = "Select Product.Id,Product.Title as 'Продукция',TypeOfProduct.Title as 'Вид продукции',Product.Size as 'Размер', Product.Price as 'Цена', Product.Count as 'Количество' From Product inner join TypeOfProduct on Product.IdTypeOfProduct = TypeOfProduct.Id";
        public static string mainShopQuery = "Select id, Name as 'Наименование', Address as 'Адрес', Director as 'Директор', UNP as 'УНП', Login as 'Логин',Password as 'Пароль'  from Shop";
        public static SqlConnection dataShipmentOfDoods = new SqlConnection(ConfigurationManager.ConnectionStrings["ShipmentOfGoods"].ConnectionString);
        public static void OpenConnect()
        {
            dataShipmentOfDoods.Open();
        }
        public static void CloseConnect()
        {
            dataShipmentOfDoods.Close();
        }
        public static void LoadData(DataGridView data, string query)
        {
            dataShipmentOfDoods.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, dataShipmentOfDoods);
            dataShipmentOfDoods.Close();
            System.Data.DataTable table = new System.Data.DataTable();
            adapter.Fill(table);
            data.DataSource = table;
        }
        public static void ExecuteQuery(string query)
        {
                CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
                dataShipmentOfDoods.Open();
                SqlCommand command = new SqlCommand(query, dataShipmentOfDoods);
                command.ExecuteNonQuery();
                dataShipmentOfDoods.Close();

        }
        public static void LoadComboBox(ComboBox comboBox,string query, string valueMember,string displayMember)
        {
            comboBox.DisplayMember = $"{displayMember}";
            comboBox.ValueMember = $"{valueMember}";
            dataShipmentOfDoods.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, dataShipmentOfDoods);
            dataShipmentOfDoods.Close();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            comboBox.DataSource = dataTable;
        }
    }
}
