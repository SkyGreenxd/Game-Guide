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

namespace Руководство
{
    public partial class тирлистдемо : Form
    {
        Database database = new Database();

        public тирлистдемо()
        {
            InitializeComponent();


            typeof(TableLayoutPanel).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(tierListTable, true, null);
            tierListTable.CellPaint += tierListTable_CellPaint;



            foreach (Control control in tierListTable.Controls) // создает ограничение 25 симв
            {
                if (control is RichTextBox)
                {
                    ((RichTextBox)control).KeyPress += new KeyPressEventHandler(richTextBox_KeyPress);
                }
            }
            selectChar();
        }


        protected void selectChar()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            // Фото
            DataTable table = new DataTable();

            string querystring = $"select image from char_icon_db";
            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                string imagePath = row["image"].ToString(); // Получаем путь к изображению из базы данных

                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile(imagePath); // Устанавливаем изображение в PictureBox
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Устанавливаем режим отображения изображения
                pictureBox.Width = 118; // Устанавливаем ширину PictureBox (можете выбрать подходящее значение)
                pictureBox.Height = 118; // Устанавливаем высоту PictureBox (можете выбрать подходящее значение)
                pictureBox.BorderStyle = BorderStyle.FixedSingle;

                image_container.Controls.Add(pictureBox); // Добавляем PictureBox в FlowLayoutPanel

                ImageManager(pictureBox);
            }
        }


        public void ImageManager(PictureBox pictureBox)
        {
            pictureBox.MouseDown += Picture_MouseDown;
            pictureBox.MouseMove += Picture_MouseMove;
            pictureBox.MouseUp += Picture_MouseUp;
        }




        Point downPoint;
        bool moved;

        Dictionary<TableLayoutPanelCellPosition, Rectangle> dict = new Dictionary<TableLayoutPanelCellPosition, Rectangle>();


        private void Picture_MouseDown(object sender, MouseEventArgs e)
        {
            Control picture = sender as Control;
            if (e.Button == MouseButtons.Right)
            {
                picture.Parent = image_container;  // Возвращаем PictureBox в image_container при нажатии правой кнопки мыши
            }
            else
            {
                picture.Parent = this;
                picture.BringToFront();
                downPoint = e.Location;
            }
        }

        private void Picture_MouseMove(object sender, MouseEventArgs e)
        {
            Control picture = sender as Control;
            if (e.Button == MouseButtons.Left)
            {
                picture.Left += e.X - downPoint.X;
                picture.Top += e.Y - downPoint.Y;
                moved = true;
                tierListTable.Invalidate();
            }


        }

        private void Picture_MouseUp(object sender, MouseEventArgs e)
        {
            Control picture = sender as Control;
            if (moved)
            {
                SetControl(picture, e.Location);

                //Получение ячейки TableLayoutPanel, в которой находится flowLayoutPanel1
                TableLayoutPanelCellPosition cellPosition = tierListTable.GetPositionFromControl(flowLayoutPanel1);

                //Добавление pictureBox во flowLayoutPanel1
                flowLayoutPanel1.Controls.Add(picture);

                //Убеждаемся, что картинка помещается в flowLayoutPanel1
                EnsurePictureFits(picture);

                //Обновление отображения
                tierListTable.Invalidate();

                if (!tierListTable.ClientRectangle.Contains(tierListTable.PointToClient(Cursor.Position)))
                {
                    picture.Parent = image_container; // проверка на позицию курсора после перемещения PictureBox.
                }

                moved = false;
            }
        }


        private void EnsurePictureFits(Control picture)
        {
            // Получаем индекс строки, в которой находится flowLayoutPanel1
            int rowIndex = tierListTable.GetRow(flowLayoutPanel1);

            if (rowIndex >= 0 && rowIndex < tierListTable.RowStyles.Count)
            {
                int requiredHeight = picture.Bottom + 10; // 10 - отступ между изображениями
                if (requiredHeight > tierListTable.RowStyles[rowIndex].Height)
                {
                    // Увеличиваем высоту строки и flowLayoutPanel1, чтобы картинка поместилась
                    tierListTable.RowStyles[rowIndex].Height = requiredHeight + 10; // Дополнительный отступ
                    flowLayoutPanel1.Height = requiredHeight;
                }
            }
        }

        private void SetControl(Control c, Point position)
        {
            Point localPoint = tierListTable.PointToClient(c.PointToScreen(position));
            var keyValue = dict.FirstOrDefault(e => e.Value.Contains(localPoint));
            if (!keyValue.Equals(default(KeyValuePair<TableLayoutPanelCellPosition, Rectangle>)))
            {
                tierListTable.SetCellPosition(c, keyValue.Key);
            }
        }

        private void tierListTable_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            dict[new TableLayoutPanelCellPosition(e.Column, e.Row)] = e.CellBounds;
            if (moved)
            {
                if (e.CellBounds.Contains(tierListTable.PointToClient(MousePosition)))
                {
                    e.Graphics.FillRectangle(Brushes.Yellow, e.CellBounds);
                }
            }
        }





        private void Назад(object sender, EventArgs e)
        {
            Меню oldForm = new Меню();

            // Закрытие текущей формы
            this.Hide();

            // Отображение предыдущей формы как модальной
            oldForm.ShowDialog();
        }

        //private void deleteButton_Click(object sender, EventArgs e)
        //{
        //    if (tierListTable.RowCount > 0)
        //    {
        //        int rowCount = tierListTable.RowCount;
        //        Control controlToRemove = tierListTable.GetControlFromPosition(0, rowCount - 1);
        //        tierListTable.Controls.Remove(controlToRemove);
        //        tierListTable.RowStyles.RemoveAt(rowCount - 1);
        //        tierListTable.RowCount--;

        //        for (int i = 0; i < tierListTable.RowCount; i++)
        //        {
        //            tierListTable.RowStyles[i] = new RowStyle(SizeType.Absolute, 124);
        //        }
        //    }
        //}
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (tierListTable.RowCount > 0)
            {
                int rowCount = tierListTable.RowCount;
                Control controlToRemove = tierListTable.GetControlFromPosition(0, rowCount - 1);
                tierListTable.Controls.Remove(controlToRemove);
                tierListTable.RowStyles.RemoveAt(rowCount - 1);
                tierListTable.RowCount--;


                // Пересчитывает размеры строк в таблице
                for (int i = 0; i < tierListTable.RowCount; i++)
                {
                    tierListTable.RowStyles[i].SizeType = SizeType.Percent;
                    tierListTable.RowStyles[i].Height = 124;
                }

                // Обнова размеров контейнера
                tierListTable.AutoScrollMinSize = new Size(0, tierListTable.Height);
            }
        }




        private void addButton_Click(object sender, EventArgs e)
        {
            // Создаем новую строку с ячейками
            int rowCount = tierListTable.RowCount;
            tierListTable.RowCount++;
            tierListTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 124));

            // Создаем новую RichTextBox и настраиваем ее
            var richTextBox = new RichTextBox();
            richTextBox.Size = new Size(118, 118);
            richTextBox.ReadOnly = false;
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox.ForeColor = SystemColors.Window;
            richTextBox.BackColor = SystemColors.ActiveCaption;
            richTextBox.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            richTextBox.Text = "Введите новое название";
            richTextBox.KeyPress += new KeyPressEventHandler(richTextBox_KeyPress);
            richTextBox.BorderStyle = BorderStyle.None;
            // Добавляем новую RichTextBox в ячейку и добавляем ячейку в строку
            tierListTable.Controls.Add(richTextBox, 0, rowCount);
        }

        private void richTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            RichTextBox richTextBox = (RichTextBox)sender;

            // Проверяем, что длина текста не превышает 25 символов
            if (richTextBox.Text.Length >= 25 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Отменяем ввод символа, если длина превышает 25 символов
            }
        }




        //private void deleteButton_Click(object sender, EventArgs e)
        //{
        //    if (tierListTable.RowCount > 0)
        //    {
        //        int rowCount = tierListTable.RowCount - 1;
        //        // Удаляем последнюю строку с ячейками
        //        tierListTable.RowCount--;

        //        for (int i = 0; i < tierListTable.ColumnCount; i++)
        //        {
        //            // Удаляем последнюю ячейку из каждой строки
        //            Control cell = tierListTable.GetControlFromPosition(i, rowCount);
        //            tierListTable.Controls.Remove(cell);
        //            // cell.Dispose();
        //        }

        //        for (int i = 0; i < tierListTable.RowCount; i++)
        //        {
        //            tierListTable.RowStyles[i] = new RowStyle(SizeType.Absolute, 124);
        //        }
        //    }
        //}

    }
}
