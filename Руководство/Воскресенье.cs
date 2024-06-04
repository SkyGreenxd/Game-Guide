using System;
using System.Windows.Forms;

namespace Руководство
{
    public partial class Воскресенье : Form
    {
        public Воскресенье()
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
            PictureBox[] daycharImages = { daychar1, daychar2, daychar3, daychar4, daychar5, daychar6, daychar7, daychar8, daychar9, daychar10, daychar11, daychar12, daychar13, daychar14, daychar15 };
            PictureBox[] daywImages = { dayw1, dayw2, dayw3, dayw4, dayw5, dayw6, dayw7, dayw8, dayw9, dayw10, dayw11, dayw12, dayw13, dayw14, dayw15 };
            RichTextBox[] dtextNames = { dtext1, dtext2, dtext3, dtext4, dtext5, dtext6, dtext7, dtext8, dtext9, dtext10, dtext11, dtext12, dtext13, dtext14, dtext15, dtext16, dtext17, dtext18, dtext19, dtext20, dtext21, dtext22, dtext23, dtext24, dtext25, dtext26, dtext27, dtext28, dtext29, dtext30 };

            for (int i = 0; i < daycharImages.Length; i++)
            {
                SetImage(daycharImages[i], images[i]);
            }

            for (int i = 0; i < daywImages.Length; i++)
            {
                SetImage(daywImages[i], images[i + 15]);
            }

            for (int i = 0; i < dtextNames.Length; i++)
            {
                dtextNames[i].Text = names[i];
            }

            day_text.Text = day;
        }

        private void Назад_Click(object sender, EventArgs e)
        {
            choiceDay oldForm = new choiceDay();
            this.Hide();
            oldForm.ShowDialog();
        }
    }
}
