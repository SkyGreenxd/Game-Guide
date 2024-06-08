using System;
using System.Windows.Forms;

namespace Руководство
{
    public partial class Ресурсы : Form
    {
        private imageMove imagemove;
        public Ресурсы()
        {
            InitializeComponent();
        }
        private void SetImage(PictureBox pictureBox, string image)
        {
            if (!string.IsNullOrEmpty(image))
            {
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Image = System.Drawing.Image.FromFile(image); // установка изображения персонажа в PictureBox
            }
        }
        // Воскресенье
        public void SetVoskr(string day, string[] images, string[] names)
        {
            // Отображаем все элементы для воскресенья
            SetCommonElements(day, images, names, 15, 30, true);
        }
        public void SetDay(string day, string[] images, string[] names)
        {
            // Отображаем элементы для обычного дня
            SetCommonElements(day, images, names, 5, 10, false);
        }
        private void SetCommonElements(string day, string[] images, string[] names, int imageCount, int textCount, bool isVoskr)
        {
            // Массивы всех элементов управления
            PictureBox[] allDaycharImages = { daychar1, daychar2, daychar3, daychar4, daychar5, daychar6, daychar7, daychar8, daychar9, daychar10, daychar11, daychar12, daychar13, daychar14, daychar15 };
            PictureBox[] allDaywImages = { dayw1, dayw2, dayw3, dayw4, dayw5, dayw6, dayw7, dayw8, dayw9, dayw10, dayw11, dayw12, dayw13, dayw14, dayw15 };
            RichTextBox[] allDtextNames = { dtext1, dtext2, dtext3, dtext4, dtext5, dtext6, dtext7, dtext8, dtext9, dtext10, dtext11, dtext12, dtext13, dtext14, dtext15, dtext16, dtext17, dtext18, dtext19, dtext20, dtext21, dtext22, dtext23, dtext24, dtext25, dtext26, dtext27, dtext28, dtext29, dtext30 };
            // Скрываем все элементы
            HideAllElements(allDaycharImages, allDaywImages, allDtextNames);
            if (isVoskr)
            {
                // Отображаем необходимые элементы для воскресенья и задаем значения
                for (int i = 0; i < imageCount; i++)
                {
                    if (i < allDaycharImages.Length)
                    {
                        allDaycharImages[i].Visible = true;
                        SetImage(allDaycharImages[i], images[i]);
                    }
                    if (i < allDaywImages.Length)
                    {
                        allDaywImages[i].Visible = true;
                        SetImage(allDaywImages[i], images[i + imageCount]);
                    }
                }
                for (int i = 0; i < textCount; i++)
                {
                    if (i < allDtextNames.Length)
                    {
                        allDtextNames[i].Visible = true;
                        allDtextNames[i].Text = names[i];
                    }
                }
            }
            else
            {
                // Отображение необходимых элементов для обычного дня и задаем значения
                for (int i = 0; i < imageCount; i++)
                {
                    if (i < 5 && i + 5 < allDaycharImages.Length)
                    {
                        allDaycharImages[i].Visible = true;
                        SetImage(allDaycharImages[i], images[i]);
                        allDaycharImages[i + 5].Visible = true;
                        SetImage(allDaycharImages[i + 5], images[i + 5]);
                    }
                }
                for (int i = 0; i < textCount; i++)
                {
                    if (i < allDtextNames.Length)
                    {
                        allDtextNames[i].Visible = true;
                        allDtextNames[i].Text = names[i];
                    }
                }
            }

            day_text.Text = day;
        }
        private void HideAllElements(PictureBox[] daycharImages, PictureBox[] daywImages, RichTextBox[] dtextNames)
        {
            foreach (var pictureBox in daycharImages)
            {
                pictureBox.Visible = false;
            }
            foreach (var pictureBox in daywImages)
            {
                pictureBox.Visible = false;
            }
            foreach (var richTextBox in dtextNames)
            {
                richTextBox.Visible = false;
            }
        }
        private void Назад_Click(object sender, EventArgs e)
        {
            choiceDay oldForm = new choiceDay();
            Hide();
            oldForm.ShowDialog();
        }
    }
}
