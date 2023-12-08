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
    public partial class Registration : Form
    {
        public static bool isAdmin =false;
        public static int idUser = -1;
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (entryLogin.Text != "" && entryPassword.Text != "")
            {
                MainForm mainForm = new MainForm();
                mainForm.Owner = this;
                string query = $"Select Count(Id) FROM Shop where Login= N'{entryLogin.Text}' and Password = N'{entryPassword.Text}'";
                DBManager.OpenConnect();
                SqlCommand command = new SqlCommand(query, DBManager.dataShipmentOfDoods);
                int count = Convert.ToInt32(command.ExecuteScalar().ToString());
                DBManager.CloseConnect();
                if (count > 0)
                {
                    DBManager.CloseConnect();
                    query = $"Select Id FROM Shop where Login= N'{entryLogin.Text}' and Password = N'{entryPassword.Text}'";
                    DBManager.OpenConnect();
                    command = new SqlCommand(query, DBManager.dataShipmentOfDoods); 
                    idUser = Convert.ToInt32(command.ExecuteScalar().ToString());
                    DBManager.CloseConnect();
                    if (idUser != -1)
                    {
                        if (entryLogin.Text == "admin" && entryPassword.Text == "admin")
                        {
                            isAdmin = true;
                            mainForm.tabStoreProduct.Parent = null;
                            mainForm.openOrder.Visible = false;
                        }
                        else
                        {
                            isAdmin = false;
                            mainForm.tabShop.Parent = null;
                            mainForm.tabProduct.Parent = null;
                        }
                        Hide();
                        mainForm.Show();
                    }
                }
                else
                    MessageBox.Show("Данного пользователя не существует в системе");

            }
            else
                MessageBox.Show("Требуется заполнить все поля");
           

        }

        private void Registration_Load(object sender, EventArgs e)
        {
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
