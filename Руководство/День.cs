using System;
using System.Windows.Forms;

namespace Руководство
{
    public partial class День : Form
    {
        public День()
        {
            InitializeComponent();
        }

        public void SetImage(PictureBox pictureBox, string image)
        {
            if (!string.IsNullOrEmpty(image))
            {
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Image = System.Drawing.Image.FromFile(image); // установка изображения персонажа в PictureBox
            }
        }

        // Выбор дня
        public void SetDay(string day, string[] images, string[] names)
        {
            PictureBox[] daycharImages = { daychar1, daychar2, daychar3, daychar4, daychar5 };
            PictureBox[] daywImages = { dayw1, dayw2, dayw3, dayw4, dayw5 };
            RichTextBox[] dtextNames = { dtext1, dtext2, dtext3, dtext4, dtext5, dtext6, dtext7, dtext8, dtext9, dtext10 };

            for (int i = 0; i < Math.Min(images.Length, daycharImages.Length); i++)
            {
                SetImage(daycharImages[i], images[i]);
            }

            for (int i = 0; i < Math.Min(images.Length - 5, daywImages.Length); i++)
            {
                SetImage(daywImages[i], images[i + 5]);
            }

            day_text.Text = day;

            for (int i = 0; i < Math.Min(names.Length, dtextNames.Length); i++)
            {
                dtextNames[i].Text = names[i];
            }
        }

        private void Назад_Click(object sender, EventArgs e)
        {
            choiceDay oldForm = new choiceDay();

            this.Hide();

            oldForm.ShowDialog();

        }
    }
}
