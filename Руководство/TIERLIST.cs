using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Руководство
{
    public partial class TIERLIST : Form
    {
        private imageMove imagemove;
        Database database = new Database();
        public TIERLIST()
        {
            InitializeComponent();
            imagemove = new imageMove(tierListTable, image_container);
            tierListTable.Focus();
            typeof(TableLayoutPanel).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(tierListTable, true, null);
            nazad.TabStop = false;
            addButton.TabStop = false;
            deleteButton.TabStop = false;
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
                string imagePath = row["image"].ToString(); // Получает путь к изображению из базы данных
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile(imagePath); // Устанавливает изображение в PictureBox
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Устанавливает режим отображения изображения
                pictureBox.Width = 118; // Устанавливает ширину PictureBox
                pictureBox.Height = 118; // Устанавливает высоту PictureBox
                pictureBox.BorderStyle = BorderStyle.FixedSingle;
                image_container.Controls.Add(pictureBox); // Добавляет PictureBox в FlowLayoutPanel
                imagemove.AttachHandlers(pictureBox);
            }
        }
        private void Назад(object sender, EventArgs e)
        {
            Меню oldForm = new Меню();
            this.Hide();
            oldForm.ShowDialog();
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (tierListTable.RowCount > 0)
            {
                int rowCount = tierListTable.RowCount;
                // Удаление содержимого последней строки
                for (int col = 0; col < tierListTable.ColumnCount; col++)
                {
                    Control controlToRemove = tierListTable.GetControlFromPosition(col, rowCount - 1);
                    if (controlToRemove is FlowLayoutPanel)
                    {
                        FlowLayoutPanel panel = controlToRemove as FlowLayoutPanel;
                        foreach (Control item in panel.Controls)
                        {
                            if (item is PictureBox)
                            {
                                PictureBox picture = item as PictureBox;
                                // Возврат PictureBox в image_container
                                image_container.Controls.Add(picture);
                            }
                        }
                    }
                    tierListTable.Controls.Remove(controlToRemove);
                }
                // Удаление последней строки
                tierListTable.RowStyles.RemoveAt(rowCount - 1);
                tierListTable.RowCount--;
                // Пересчитывает размеры строк в таблице
                for (int i = 0; i < tierListTable.RowCount; i++)
                {
                    tierListTable.RowStyles[i].SizeType = SizeType.Absolute;
                    tierListTable.RowStyles[i].Height = 130; // Устанавливаем желаемую высоту строки
                }
                // Обновление размеров контейнера
                tierListTable.AutoScrollMinSize = new Size(0, tierListTable.RowCount * 130); // Учитываем новое количество строк
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            tierListTable.Height += 130;
            // Создание новой строки с ячейками
            int rowCount = tierListTable.RowCount;
            tierListTable.RowCount++;
            tierListTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 130));
            // Создаем новый RichTextBox и настраиваем ее
            var richTextBox = new RichTextBox();
            RichTextBoxInst(richTextBox);
            // Добавляем новую RichTextBox в ячейку и добавляем ячейку в строку
            tierListTable.Controls.Add(richTextBox, 0, rowCount);
            var flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel.WrapContents = true;
            flowLayoutPanel.Size = new Size(501, 124);
            string flowLayoutPanelName = "flowLayoutPanel" + rowCount; // rowCount - индекс новой строки
            // Присваиваем имя
            flowLayoutPanel.Name = flowLayoutPanelName;
            // Добавляем новый FlowLayoutPanel во второй столбец последней строки
            tierListTable.Controls.Add(flowLayoutPanel, 1, rowCount);
        }
        public void RichTextBoxInst(RichTextBox richTextBox)
        {
            richTextBox.Size = new Size(118, 124);
            richTextBox.ReadOnly = false;
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox.ForeColor = SystemColors.Window;
            richTextBox.BackColor = SystemColors.ActiveCaption;
            richTextBox.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            richTextBox.Text = "Введите новое название";
            richTextBox.KeyPress += new KeyPressEventHandler(richTextBox_KeyPress);
            richTextBox.BorderStyle = BorderStyle.None;
        }
        private void richTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            RichTextBox richTextBox = (RichTextBox)sender;
            // Проверка, что длина текста не превышает 25 символов
            if (richTextBox.Text.Length >= 25 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Отмена ввода символа, если длина превышает 25 символов
            }
        }
        private void Reboot_Click(object sender, EventArgs e)
        {
            List<PictureBox> pictureBoxesToMove = new List<PictureBox>();
            foreach (Control control in tierListTable.Controls)
            {
                if (control is FlowLayoutPanel)
                {
                    foreach (Control subControl in control.Controls)
                    {
                        if (subControl is PictureBox)
                        {
                            pictureBoxesToMove.Add((PictureBox)subControl);
                        }
                    }
                }
            }
            foreach (PictureBox pictureBox in pictureBoxesToMove)
            {
                image_container.Controls.Add(pictureBox); // Перемещаем все PictureBox обратно в image_container
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG файлы (*.png)|*.png|Все файлы (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(tierListTable.Width, tierListTable.Height);
                tierListTable.DrawToBitmap(bmp, new Rectangle(0, 0, tierListTable.Width, tierListTable.Height));
                bmp.Save(saveFileDialog.FileName, ImageFormat.Png);
                bmp.Dispose();
                MessageBox.Show("Изображение успешно сохранено.", "Сохранение завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
