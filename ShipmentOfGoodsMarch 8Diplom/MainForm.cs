using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace ShipmentOfGoodsMarch_8Diplom
{
    public partial class MainForm : Form
    {
        public static string productQuery;
        public static int idUser;
        public static bool isAdmin;
        string query;
        public static string queryProduct;
        public void LoadDataInMainForm()
        {
            if (isAdmin)
            {
                DBManager.LoadData(dataGridShop, DBManager.mainShopQuery);
                DBManager.LoadData(dataGridProduct, DBManager.mainProductQuery);
                dataGridShop.Columns[0].Visible = false;
                dataGridProduct.Columns[0].Visible = false;
                deleteOrder.Visible= false;
                CompletedOrder.Visible= false;
            }
            queryProduct = DBManager.mainOrderQuery;
            if (!isAdmin)
            {
                tabStatistic.Parent = null;
                acceptOrder.Visible = false;
                productQuery = $"Select ListOfStoreProduct.Id, Product.Title as 'Наименование', TypeOfProduct.Title as 'Вид продукции', Product.Size 'Размер', Product.Price 'Цена'," +
                    $" ListOfStoreProduct.Count 'Количество' From ListOfStoreProduct " +
                    $"inner join Product on Product.Id = ListOfStoreProduct.IdProduct " +
                    $"inner join Shop on Shop.Id = ListOfStoreProduct.IdShop " +
                    $"inner join TypeOfProduct on TypeOfProduct.Id = Product.IdTypeOfProduct " +
                    $"where ListOfStoreProduct.IdShop = {idUser}";
                DBManager.LoadData(dataGridListOfStoreProduct, productQuery);
                dataGridListOfStoreProduct.Columns[0].Visible = false;
                queryProduct += $" where IdShop = {idUser}";                
            }
            DBManager.LoadData(dataGridOrder, queryProduct);
            dataGridOrder.Columns[0].Visible = false;
            dataGridOrder.Columns[1].Visible = false;
            if (!isAdmin)
            {
                dataGridOrder.Columns[2].Visible = false;
                dataGridOrder.Columns[3].Visible = false;
                dataGridOrder.Columns[4].Visible = false;
            }
            query = "Select Id, Title From TypeOfProduct";
            DBManager.LoadComboBox(chooseProductfilterTypeOfProduct, query, "Id", "Title");
            chooseProductfilterTypeOfProduct.SelectedIndex = -1;
            DBManager.LoadComboBox(chooseTypeOfProductStoreProduct, query, "Id", "Title");
            chooseTypeOfProductStoreProduct.SelectedIndex = -1;
            checkMaxDateFilterOrder.Checked = true;
            checkMinDateFilterOrder.Checked = true;
            
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddShop addShop = new AddShop();
            addShop.Owner = this;
            Enabled= false;
            addShop.addOrChangeShop.Text = "Добавить";
            addShop.ShowDialog();
            Enabled= true;
            LoadDataInMainForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Order addOrder = new Order();
            addOrder.Owner = this;
            Enabled= false;
            addOrder.ShowDialog();
            Enabled = true;
            LoadDataInMainForm();
            
        }

        private void formAddProduct_Click(object sender, EventArgs e)
        {
            addProduct addProduct = new addProduct();
            addProduct.Owner = this;
            Enabled= false;
            addProduct.addOrChangeProduct.Text = "Добавить";
            addProduct.ShowDialog();
            Enabled= true;
            LoadDataInMainForm();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridShop.CurrentRow != null)
            {
                AddShop addShop = new AddShop();
                addShop.Owner = this;
                Enabled = false;
                addShop.entryName.Text = dataGridShop[1, dataGridShop.CurrentRow.Index].Value.ToString();
                addShop.entryAddress.Text = dataGridShop[2, dataGridShop.CurrentRow.Index].Value.ToString();
                addShop.entryDirector.Text = dataGridShop[3, dataGridShop.CurrentRow.Index].Value.ToString();
                addShop.entryUNP.Text = dataGridShop[4, dataGridShop.CurrentRow.Index].Value.ToString();
                addShop.entryLogin.Text = dataGridShop[5, dataGridShop.CurrentRow.Index].Value.ToString();
                addShop.entryPassword.Text = dataGridShop[6, dataGridShop.CurrentRow.Index].Value.ToString();
                addShop.addOrChangeShop.Text = "Изменить";
                addShop.ShowDialog();
                Enabled = true;
            }
            else
                MessageBox.Show("Требуется выбрать строку");
        }


        private void dataGridOrder_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex != -1)
                {
                    dataGridOrder.ClearSelection();
                    dataGridOrder[e.ColumnIndex, e.RowIndex].Selected = true;
                }
            }
        }

        private void dataGridProduct_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex != -1)
                {
                    dataGridProduct.ClearSelection();
                    dataGridProduct[e.ColumnIndex, e.RowIndex].Selected = true;
                }
            }
        }

        private void dataGridShop_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex != -1)
                {
                    dataGridShop.ClearSelection();
                    dataGridShop[e.ColumnIndex, e.RowIndex].Selected = true;
                }
            }
        }

        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
				if (dataGridShop.CurrentRow != null)
				{
					query = $"Delete From Shop Where id = {dataGridShop.CurrentRow.Cells[0].Value}";
					DBManager.ExecuteQuery(query);
					DBManager.LoadData(dataGridShop, DBManager.mainShopQuery);
				}
				else
					MessageBox.Show("Требуется выбрать строку");
			}
            catch (Exception)
            {
                MessageBox.Show("Нельзя удалить данный магазин в нём имеется продукция");
                DBManager.dataShipmentOfDoods.Close();
            }
            
           
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridProduct.SelectedRows != null)
            {
                addProduct addProduct = new addProduct();
                addProduct.Owner = this;
                Enabled = false;
                addProduct.addOrChangeProduct.Text = "Изменить";
                addProduct.entryName.Text = dataGridProduct.CurrentRow.Cells[1].Value.ToString().Trim();
                addProduct.chooseTypeOfProduct.Text = dataGridProduct.CurrentRow.Cells[2].Value.ToString().Trim();
                addProduct.chooseSize.Text = dataGridProduct.CurrentRow.Cells[3].Value.ToString().Trim();
                addProduct.entryPrice.Text = dataGridProduct.CurrentRow.Cells[4].Value.ToString().Trim();
                addProduct.entryCount.Text = dataGridProduct.CurrentRow.Cells[5].Value.ToString().Trim();
                addProduct.addOrChangeProduct.Text = "Изменить";
                addProduct.ShowDialog();
                Enabled = true;
            }
            else
                MessageBox.Show("Требуется выбрать строку");
        }

        private void удалитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
				if (dataGridProduct.CurrentRow != null)
				{
					query = $"Delete From Product Where id = {dataGridProduct.CurrentRow.Cells[0].Value}";
					DBManager.ExecuteQuery(query);
					DBManager.LoadData(dataGridProduct, DBManager.mainProductQuery);
				}
				else
					MessageBox.Show("Требуется выбрать строку");
			}
            catch (Exception)
            {
                MessageBox.Show("Нельзя удалить данный продукт есть в магазинах");
                DBManager.dataShipmentOfDoods.Close();
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Methods.SearchData(dataGridShop, searchShop);
        }

        private void searchProduct_TextChanged(object sender, EventArgs e)
        {
            Methods.SearchData(dataGridProduct, searchProduct);
        }

        private void searchOrder_TextChanged(object sender, EventArgs e)
        {
            Methods.SearchData(dataGridOrder, searchOrder);
        }

        private void cancelFiters_Click(object sender, EventArgs e)
        {
            entryProductMaxCount.Text = "";
            entryProductMaxPrice.Text = "";
            entryProductMinCount.Text = "";
            entryProductMinPrice.Text = "";
            entryProductTitle.Text = "";
            chooseProductfilterTypeOfProduct.SelectedIndex = -1;
            chooseProductfiterSize.SelectedIndex = -1;
            chooseProductfiterSize.Text = "";
            chooseProductfilterTypeOfProduct.Text = "";
            DBManager.LoadData(dataGridProduct, DBManager.mainProductQuery);
        }

        private void applyProductFilters_Click(object sender, EventArgs e)
        {
            string minPrice = entryProductMinPrice.Text == "" ? "0" : entryProductMinPrice.Text;
            string maxPrice = entryProductMaxPrice.Text == "" ? "9999999999" : entryProductMaxPrice.Text;
            string minCount = entryProductMinCount.Text == "" ? "0" : entryProductMinCount.Text;
            string maxCount = entryProductMaxCount.Text == "" ? int.MaxValue.ToString() : entryProductMaxCount.Text;
            if (double.TryParse(minPrice, out double priceMin) && double.TryParse(maxPrice, out double priceMax) &&
                int.TryParse(minCount, out int countMin) && int.TryParse(maxCount, out int countMax))
            {
                query = DBManager.mainProductQuery + $" where Product.Title Like N'%{entryProductTitle.Text}%' and Product.Price between {minPrice} and {maxPrice} " +
                    $"and Product.Count between {minCount} and {maxCount}";
                if (chooseProductfilterTypeOfProduct.SelectedIndex != -1)
                    query += $" and Product.IdTypeOfProduct = {chooseProductfilterTypeOfProduct.SelectedValue}";
                if (chooseProductfiterSize.SelectedIndex != -1)
                    query += $"and Product.Size = '{chooseProductfiterSize.Text}'";
                DBManager.LoadData(dataGridProduct, query);
            }
            else
                MessageBox.Show("в поля цена и количество  требуется ввести числовые значения(только требуемые)");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            entryShopFilterName.Text = "";
            entryShopFilterAddress.Text = "";
            entryShopFilterDirector.Text = "";
            entryShopFilterUNP.Text = "";
            entryShopFilterLogin.Text = "";
            entryShopFilterPassword.Text = "";
            DBManager.LoadData(dataGridShop, DBManager.mainShopQuery);
        }

        private void applyShopFilters_Click(object sender, EventArgs e)
        {
            query = DBManager.mainShopQuery + $" where Name Like N'%{entryShopFilterName.Text}%' and Address Like N'%{entryShopFilterAddress.Text}%'" +
                $" and Director Like N'%{entryShopFilterDirector.Text}%' and UNP Like N'%{entryShopFilterUNP.Text}%' " +
                $"and Login Like N'%{entryShopFilterLogin.Text}%' and Password Like N'%{entryShopFilterPassword.Text}%'";
            DBManager.LoadData(dataGridShop, query);
        }

        private void SearchStoreProduct_TextChanged(object sender, EventArgs e)
        {
            Methods.SearchData(dataGridListOfStoreProduct, SearchStoreProduct);
        }

        private void deleteOrder_Click(object sender, EventArgs e)
        {
            if (dataGridOrder.CurrentRow != null)
            {
                query = $"Delete From ListOfOrder Where IdOrder = {dataGridOrder.CurrentRow.Cells[0].Value}";
                DBManager.ExecuteQuery(query);
                query = $"Delete From Orders Where Id = {dataGridOrder.CurrentRow.Cells[0].Value}";
                DBManager.ExecuteQuery(query);
                LoadDataInMainForm();
            }
            else
                MessageBox.Show("Требуется выбрать строку");
        }

        private void acceptOrder_Click(object sender, EventArgs e)
        {
            if (dataGridOrder.CurrentRow != null)
            {

                query = $"Select IsCompleted From Orders Where Id = {dataGridOrder.CurrentRow.Cells[0].Value}";
                DBManager.OpenConnect();
                SqlCommand command = new SqlCommand(query, DBManager.dataShipmentOfDoods);
                bool isCompleted = Convert.IsDBNull(command.ExecuteScalar());
                DBManager.CloseConnect();
                if (isCompleted)
                {
                    AcceptedOrder acceptedOrder = new AcceptedOrder();
                    acceptedOrder.Owner = this;
                    Enabled = false;
                    acceptedOrder.ShowDialog();
                    Enabled = true;
                    LoadDataInMainForm();
                }
                else
                    MessageBox.Show("Данная заявка уже подтверждена");
            }
            else
                MessageBox.Show("Требуется выбрать строку");
        }

        private void applyFilterStoreProduct_Click(object sender, EventArgs e)
        {
            string minPrice = entryMinPriceStoreProduct.Text == "" ? "0" : entryMinPriceStoreProduct.Text;
            string maxPrice = entryMaxPriceStoreProduct.Text == "" ? "9999999999" : entryMaxPriceStoreProduct.Text;
            string minCount = entryMinCountStoreProduct.Text == "" ? "0" : entryMinCountStoreProduct.Text;
            string maxCount = entryMaxCountStoreProduct.Text == "" ? int.MaxValue.ToString() : entryMaxCountStoreProduct.Text;
            if (double.TryParse(minPrice, out double priceMin) && double.TryParse(maxPrice, out double priceMax) &&
               int.TryParse(minCount, out int countMin) && int.TryParse(maxCount, out int countMax))
            {
                query = productQuery + $" and Product.Title Like N'%{entryNameStoreProduct.Text}%' and Product.Price between {minPrice} and {maxPrice} " +
                    $"and ListOfStoreProduct.Count between {minCount} and {maxCount}";
                if (chooseTypeOfProductStoreProduct.SelectedIndex != -1)
                    query += $" and Product.IdTypeOfProduct = {chooseTypeOfProductStoreProduct.SelectedValue}";
                if (chooseSizeStoreProduct.SelectedIndex != -1)
                    query += $"and Product.Size = '{chooseSizeStoreProduct.Text}'";
                DBManager.LoadData(dataGridListOfStoreProduct,query);
            }
            else
                MessageBox.Show("в поля цена и количество  требуется ввести числовые значения(только требуемые)");
        }

        private void cancelFilterStoreProduct_Click(object sender, EventArgs e)
        {
            entryMinCountStoreProduct.Text = "";
            entryMaxPriceStoreProduct.Text = "";
            entryMinCountStoreProduct.Text = "";
            entryMinPriceStoreProduct.Text = "";
            entryNameStoreProduct.Text = "";
            chooseTypeOfProductStoreProduct.SelectedIndex = -1;
            chooseSizeStoreProduct.SelectedIndex = -1;
            chooseSizeStoreProduct.Text = "";
            chooseTypeOfProductStoreProduct.Text = "";
            DBManager.LoadData(dataGridListOfStoreProduct, productQuery);
        }

        private void CompletedOrder_Click(object sender, EventArgs e)
        {
            if (dataGridOrder.CurrentRow != null)
            {
                query = $"Select IsCompleted From Orders Where Id = {dataGridOrder.CurrentRow.Cells[0].Value}";
                DBManager.OpenConnect();
                SqlCommand command = new SqlCommand(query, DBManager.dataShipmentOfDoods);
                bool isCompleted = Convert.IsDBNull(command.ExecuteScalar());
                DBManager.CloseConnect();
                if (!isCompleted)
                {
                    query = $"Select DateOfDelivery From Orders Where Id = {dataGridOrder.CurrentRow.Cells[0].Value}";
                    DBManager.OpenConnect();
                    command = new SqlCommand(query, DBManager.dataShipmentOfDoods);
                    bool isDelivery = Convert.IsDBNull(command.ExecuteScalar());
                    DBManager.CloseConnect();
                    if (isDelivery)
                    {
                        //тут был код на добавление продукции в магазин
                        query = $"Update Orders Set DateOfDelivery = '{DateTime.Now.ToString("yyyy/MM/dd", CultureInfo.CurrentCulture)}' where Id = {dataGridOrder.CurrentRow.Cells[0].Value}";
                        DBManager.ExecuteQuery(query);
                        LoadDataInMainForm();
                    }
                    else
                        MessageBox.Show("Данная заявка уже доставлена");
                }
                else
                    MessageBox.Show("Данная заявка ещё не одобрена");
            }
            else
                MessageBox.Show("Требуется выбрать заявку");
        }

        private void exportTTN_Click(object sender, EventArgs e)
        {
            if (dataGridOrder.CurrentRow != null)
            {
                query = $"Select IsCompleted From Orders Where Id = {dataGridOrder.CurrentRow.Cells[0].Value}";
                DBManager.OpenConnect();
                SqlCommand command = new SqlCommand(query, DBManager.dataShipmentOfDoods);
                bool isCompleted = Convert.IsDBNull(command.ExecuteScalar());
                DBManager.CloseConnect();
                if (!isCompleted)
                {
                    Word.Application wordApp = new Word.Application();
                    //вот тут надо подставить свой путь !!!
                    var doc = wordApp.Documents.Open(@"D:\Diplom\ShipmentOfGoodsMarch 8Diplom\ShipmentOfGoodsMarch 8Diplom\ТТН1.docx");
                    //замена данных
                    doc.Content.Find.Execute(FindText: "{unp1}", ReplaceWith: dataGridOrder.CurrentRow.Cells[4].Value.ToString().Trim());
                    doc.Content.Find.Execute(FindText: "{unp1}", ReplaceWith: dataGridOrder.CurrentRow.Cells[4].Value.ToString().Trim());
                    doc.Content.Find.Execute(FindText: "{avto}", ReplaceWith: dataGridOrder.CurrentRow.Cells[9].Value.ToString().Trim());
                    doc.Content.Find.Execute(FindText: "{pr}", ReplaceWith: dataGridOrder.CurrentRow.Cells[10].Value.ToString().Trim());
                    doc.Content.Find.Execute(FindText: "{vod}", ReplaceWith: dataGridOrder.CurrentRow.Cells[8].Value.ToString().Trim());
                    doc.Content.Find.Execute(FindText: "{name}", ReplaceWith: dataGridOrder.CurrentRow.Cells[2].Value.ToString().Trim());
                    doc.Content.Find.Execute(FindText: "{adres}", ReplaceWith: dataGridOrder.CurrentRow.Cells[3].Value.ToString().Trim());
                    doc.Content.Find.Execute(FindText: "{nom}", ReplaceWith: dataGridOrder.CurrentRow.Cells[0].Value.ToString().Trim());
                    doc.Content.Find.Execute(FindText: "{date}", ReplaceWith: Convert.ToDateTime(dataGridOrder.CurrentRow.Cells[5].Value).ToShortDateString());
                    doc.Content.Find.Execute(FindText: "{adres1}", ReplaceWith: dataGridOrder.CurrentRow.Cells[3].Value.ToString().Trim());
                    decimal nds = (Convert.ToDecimal(dataGridOrder.CurrentRow.Cells[12].Value) / 100);
                    decimal priceNDS = Convert.ToDecimal(dataGridOrder.CurrentRow.Cells[7].Value) * nds;
                    doc.Content.Find.Execute(FindText: "{sum}", ReplaceWith: (priceNDS).ToString("#.##"));
                    doc.Content.Find.Execute(FindText: "{sum1}", ReplaceWith: (priceNDS + Convert.ToDecimal(dataGridOrder.CurrentRow.Cells[7].Value)).ToString("#.##"));
                    doc.Content.Find.Execute(FindText: "{col}", ReplaceWith: dataGridOrder.CurrentRow.Cells[11].Value.ToString().Trim());
                    doc.Content.Find.Execute(FindText: "{vod1}", ReplaceWith: dataGridOrder.CurrentRow.Cells[8].Value.ToString().Trim());
                    doc.Content.Find.Execute(FindText: "{TTN}", ReplaceWith: dataGridOrder.CurrentRow.Cells[0].Value.ToString().Trim());
                    doc.Content.Find.Execute(FindText: "{name2}", ReplaceWith: dataGridOrder.CurrentRow.Cells[2].Value.ToString().Trim());
                    doc.Content.Find.Execute(FindText: "{sum11}", ReplaceWith: (priceNDS).ToString("#.##"));
                    doc.Content.Find.Execute(FindText: "{sum12}", ReplaceWith: (priceNDS + Convert.ToDecimal(dataGridOrder.CurrentRow.Cells[7].Value)).ToString("#.##"));
                    doc.Content.Find.Execute(FindText: "{col1}", ReplaceWith: dataGridOrder.CurrentRow.Cells[11].Value.ToString().Trim());
                    doc.Content.Find.Execute(FindText: "{vod2}", ReplaceWith: dataGridOrder.CurrentRow.Cells[8].Value.ToString().Trim());
                    DataTable dataTable = new DataTable();
                    query = $"Select Product.Title, ListOfOrder.Count,Product.Price, Orders.NDS,Orders.NumberOfPackages From ListOfOrder " +
                        $"inner join Product on Product.Id = ListOfOrder.IdProduct " +
                        $"inner Join Orders on Orders.Id = ListOfOrder.IdOrder " +
                        $"where Orders.Id = {dataGridOrder.CurrentRow.Cells[0].Value}";
                    command = new SqlCommand(query, DBManager.dataShipmentOfDoods);
                    DBManager.OpenConnect();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        object objMissing = System.Reflection.Missing.Value;
                        int rowIndex = 3;
                        int a = doc.Tables[4].Rows.Count;
                        while (reader.Read())
                        {
                            // Добавляем строки в таблицу
                            string countName = "шт";
                            int count = reader.GetInt32(1);
                            decimal price = reader.GetDecimal(2);
                            int nDS = reader.GetInt32(3);
                            decimal fullPrice = count * price;
                            decimal priceWithNDS = fullPrice * (nDS / (decimal)100);
                            decimal fullPriceWithNDS = fullPrice + priceWithNDS;
                            doc.Tables[5].Rows.Add();
                            doc.Tables[5].Cell(rowIndex, 1).Range.Text = reader.GetString(0);
                            doc.Tables[5].Cell(rowIndex, 2).Range.Text = countName;
                            doc.Tables[5].Cell(rowIndex, 3).Range.Text = count.ToString();
                            doc.Tables[5].Cell(rowIndex, 4).Range.Text = price.ToString();
                            doc.Tables[5].Cell(rowIndex, 5).Range.Text = fullPrice.ToString();
                            doc.Tables[5].Cell(rowIndex, 6).Range.Text = nDS.ToString();
                            doc.Tables[5].Cell(rowIndex, 7).Range.Text = priceWithNDS.ToString();
                            doc.Tables[5].Cell(rowIndex, 8).Range.Text = fullPriceWithNDS.ToString();
                            doc.Tables[5].Cell(rowIndex, 9).Range.Text = reader.GetInt32(4).ToString();

                            rowIndex++;
                        }
                    }
                    doc.Tables[5].Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                    doc.Tables[5].Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                    DBManager.CloseConnect();

                    wordApp.Visible = true;
                }
                else
                    MessageBox.Show("ТТН по данной заявки ещё не создано");
            }
            else
                MessageBox.Show("Требует выбрать заявку по которой будет составлена ТТН");
        }

        private void удалитьToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (dataGridListOfStoreProduct.CurrentRow != null)
            {
                query = $"Delete from ListOfStoreProduct where id= {dataGridListOfStoreProduct.CurrentRow.Cells[0].Value}";
                DBManager.ExecuteQuery(query);
                LoadDataInMainForm();
            }
            else
                MessageBox.Show("Требуется выбрать строку");
        }

        private void dataGridListOfStoreProduct_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex != -1)
                {
                    dataGridListOfStoreProduct.ClearSelection();
                    dataGridListOfStoreProduct[e.ColumnIndex, e.RowIndex].Selected = true;
                }
            }
        }

        private void изменитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(dataGridListOfStoreProduct.CurrentRow != null)
            {
                ChangeStoreOfProduct changeStoreOfProduct = new ChangeStoreOfProduct();
                changeStoreOfProduct.Owner= this;
                Enabled= false;
                changeStoreOfProduct.entryCount.Text = dataGridListOfStoreProduct.CurrentRow.Cells[5].Value.ToString();
                changeStoreOfProduct.ShowDialog();
                Enabled= true;
                DBManager.LoadData(dataGridListOfStoreProduct,productQuery);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMinDateFilterOrder.Checked)
                chooseMinDateFIlterOrder.Enabled = true;
            else
                chooseMinDateFIlterOrder.Enabled = false;
        }

        private void checkMaxDateFilterOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMaxDateFilterOrder.Checked)
                chooseMaxDateFIlterOrder.Enabled = true;
            else
                chooseMaxDateFIlterOrder.Enabled= false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkMinDateFilterOrder.Checked = false;
            checkMaxDateFilterOrder.Checked = false;
            entryMaxPriceFilterOrder.Text = "";
            entryMinPriceFilterOrder.Text = "";
            LoadDataInMainForm();
        }

        private void applyFilterOrder_Click(object sender, EventArgs e)
        {
            query = queryProduct;
            string minPrice = entryMinPriceFilterOrder.Text == "" ? "0" : entryMinPriceFilterOrder.Text;
            string maxPrice = entryMaxPriceFilterOrder.Text == "" ? "9999999999" : entryMaxPriceFilterOrder.Text;
            string minDate = checkMinDateFilterOrder.Checked ? chooseMinDateFIlterOrder.Value.ToString("yyyy/MM/dd") : DateTime.MinValue.ToString("yyyy/MM/dd");
            string maxDate = checkMaxDateFilterOrder.Checked ? chooseMaxDateFIlterOrder.Value.ToString("yyyy/MM/dd") : DateTime.MaxValue.ToString("yyyy/MM/dd");
            if (decimal.TryParse(minPrice, out decimal minPriced) && decimal.TryParse(maxPrice, out decimal maxPriced))
            {
                if (isAdmin)
                    query += $" where fullPrice between {minPrice} and {maxPrice} and DateOrder between '{minDate}' and '{maxDate}'";
                else
                    query += $" and fullPrice between {minPrice} and {maxPrice} and DateOrder between '{minDate}' and '{maxDate}'";
                DBManager.LoadData(dataGridOrder, query);
            }
            else
                MessageBox.Show("Поля стоимость должны быть числовым значением");

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            idUser = Registration.idUser;
            isAdmin = Registration.isAdmin;
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            LoadDataInMainForm();   
        }
         
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart.Series.Clear();
            query = "Select Id,Name from shop";
            DBManager.OpenConnect();
            SqlCommand command = new SqlCommand(query,DBManager.dataShipmentOfDoods);
            SqlDataReader reader = command.ExecuteReader();
            List<int> ids = new List<int>();
            List<string> names = new List<string>();
            while (reader.Read())
            {
                ids.Add(reader.GetInt32(0));
                names.Add(reader.GetString(1)); 
            }
            DBManager.CloseConnect();
            for (int i = 0; i < ids.Count; i++)
            {
                query = $"Select Sum(fullPrice) from Orders where IdShop = {ids[i]}";
                DBManager.OpenConnect();
                SqlCommand commandPrice = new SqlCommand(query, DBManager.dataShipmentOfDoods);
                double.TryParse(commandPrice.ExecuteScalar().ToString(),out double price);
                DBManager.CloseConnect();
                chart.Series.Add(names[i] + $"{price}");
                chart.Series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                chart.Series[i].Points.AddY(price);
            }

        }

        private void entryShopFilterUNP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void entryProductMinCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void entryProductMaxCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void entryMinCountStoreProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void entryMaxCountStoreProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
