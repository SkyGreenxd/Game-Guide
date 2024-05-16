using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Руководство
{
    public partial class ТирЛист : Form
    {
        public ТирЛист()
        {
            InitializeComponent();
            InitializeTierList();
        }

        private void Назад(object sender, EventArgs e)
        {
            Меню oldForm = new Меню();

            // Закрытие текущей формы
            this.Hide();

            // Отображение предыдущей формы как модальной
            oldForm.ShowDialog();
        }

        private void InitializeTierList()
        {
            // Добавление строк в таблицу
            for (int i = 0; i < 7; i++)
            {
                tierListTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                Label label = new Label();
                label.Text = "Row " + (i + 1);
                tierListTable.Controls.Add(label, 0, i);
            }

            this.Controls.Add(tierListTable);

            // Добавление кнопок для добавления и удаления строк
            addButton.Text = "Add Row";
            this.Controls.Add(addButton);

            deleteButton.Text = "Delete Row";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (tierListTable.RowCount > 0)
            {
                int rowCount = tierListTable.RowCount;
                Control controlToRemove = tierListTable.GetControlFromPosition(0, rowCount - 1);
                tierListTable.Controls.Remove(controlToRemove);
                tierListTable.RowStyles.RemoveAt(rowCount - 1);
                tierListTable.RowCount--;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int rowCount = tierListTable.RowCount;
            tierListTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            Label label = new Label();
            label.Text = "Row " + rowCount;
            tierListTable.Controls.Add(label, 0, rowCount - 1);
        }
    }
}
