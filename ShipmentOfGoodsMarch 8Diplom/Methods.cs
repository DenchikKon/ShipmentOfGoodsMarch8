using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipmentOfGoodsMarch_8Diplom
{
    internal class Methods
    {
        public static void SearchData(DataGridView dataGrid,TextBox textBox)
        {
            for (int i = 0; i < dataGrid.RowCount; i++)
            {
                for (int j = 1; j < dataGrid.ColumnCount; j++)
                {
                    if (dataGrid[j, i].Value.ToString().IndexOf(textBox.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        dataGrid.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(193, 199, 206);
                        break;
                    }
                    else
                    dataGrid.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
            if (textBox.Text == "")
                for (int i = 0; i < dataGrid.RowCount; i++)
                    dataGrid.Rows[i].DefaultCellStyle.BackColor = Color.White;
        }
    }
}
