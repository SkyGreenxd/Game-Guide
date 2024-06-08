using System.Data;
using System.Drawing.Imaging;
using System.Drawing;
using System.Windows.Forms;

namespace Руководство
{
    internal class TierlistManager
    {
        private CharacterRepository characterRepository;
        private imageMove imagemove;
        private Database database;

        public TierlistManager(Database database)
        {
            this.database = database;
            characterRepository = new CharacterRepository(database);
        }
        public void InitializeTierList(TableLayoutPanel tierListTable, FlowLayoutPanel imageContainer)
        {
            imagemove = new imageMove(tierListTable, imageContainer);
            tierListTable.Focus();
            typeof(TableLayoutPanel).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(tierListTable, true, null);
            Limitation(tierListTable);
            SelectChar(imageContainer);
        }

        public void SelectChar(FlowLayoutPanel imageContainer)
        {
            DataTable charImage = characterRepository.Getpic();

            foreach (DataRow row in charImage.Rows)
            {
                string imagePath = row["image"].ToString();
                PictureBox pictureBox = new PictureBox
                {
                    Image = Image.FromFile(imagePath),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Width = 118,
                    Height = 118,
                    BorderStyle = BorderStyle.FixedSingle
                };
                imageContainer.Controls.Add(pictureBox);
                imagemove.AttachHandlers(pictureBox);
            }
        }
        public void Limitation(TableLayoutPanel tierListTable)
        {
            foreach (Control control in tierListTable.Controls)
            {
                if (control is RichTextBox)
                {
                    ((RichTextBox)control).KeyPress += new KeyPressEventHandler(RichTextBox_KeyPress);
                }
            }
        }

        public void AddRow(TableLayoutPanel tierListTable)
        {
            tierListTable.Height += 130;
            int rowCount = tierListTable.RowCount;
            tierListTable.RowCount++;
            tierListTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 130));

            var richTextBox = new RichTextBox();
            RichTextBoxInst(richTextBox);
            tierListTable.Controls.Add(richTextBox, 0, rowCount);

            var flowLayoutPanel = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = true,
                Size = new Size(501, 124),
                Name = "flowLayoutPanel" + rowCount
            };
            tierListTable.Controls.Add(flowLayoutPanel, 1, rowCount);
        }

        public void DeleteRow(TableLayoutPanel tierListTable, FlowLayoutPanel imageContainer)
        {
            if (tierListTable.RowCount > 0)
            {
                int rowCount = tierListTable.RowCount;
                for (int col = 0; col < tierListTable.ColumnCount; col++)
                {
                    Control controlToRemove = tierListTable.GetControlFromPosition(col, rowCount - 1);
                    if (controlToRemove is FlowLayoutPanel panel)
                    {
                        foreach (Control item in panel.Controls)
                        {
                            if (item is PictureBox picture)
                            {
                                imageContainer.Controls.Add(picture);
                            }
                        }
                    }
                    tierListTable.Controls.Remove(controlToRemove);
                }
                tierListTable.RowStyles.RemoveAt(rowCount - 1);
                tierListTable.RowCount--;
                for (int i = 0; i < tierListTable.RowCount; i++)
                {
                    tierListTable.RowStyles[i].SizeType = SizeType.Absolute;
                    tierListTable.RowStyles[i].Height = 130;
                }
                tierListTable.AutoScrollMinSize = new Size(0, tierListTable.RowCount * 130);
            }
        }
        public void SaveTierList(TableLayoutPanel tierListTable)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PNG файлы (*.png)|*.png|Все файлы (*.*)|*.*"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(tierListTable.Width, tierListTable.Height);
                tierListTable.DrawToBitmap(bmp, new Rectangle(0, 0, tierListTable.Width, tierListTable.Height));
                bmp.Save(saveFileDialog.FileName, ImageFormat.Png);
                MessageBox.Show("Изображение успешно сохранено.", "Сохранение завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Reboot(TableLayoutPanel tierListTable, FlowLayoutPanel imageContainer)
        {
            InitializeTierList(tierListTable, imageContainer);
        }

        private void RichTextBoxInst(RichTextBox richTextBox)
        {
            richTextBox.Size = new Size(118, 124);
            richTextBox.ReadOnly = false;
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox.ForeColor = SystemColors.Window;
            richTextBox.BackColor = SystemColors.ActiveCaption;
            richTextBox.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            richTextBox.Text = "Введите новое название";
            richTextBox.KeyPress += new KeyPressEventHandler(RichTextBox_KeyPress);
            richTextBox.BorderStyle = BorderStyle.None;
        }

        private void RichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            RichTextBox richTextBox = (RichTextBox)sender;
            if (richTextBox.Text.Length >= 25 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
