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
        public void SetDay(string day, string image1, string image2, string image3, string image4, string image5, string image6, string image7, string image8, string image9, string image10, string name1, string name2, string name3, string name4, string name5, string name6, string name7, string name8, string name9, string name10)
        {
            SetImage(daychar1, image1);
            SetImage(daychar2, image2);
            SetImage(daychar3, image3);
            SetImage(daychar4, image4);
            SetImage(daychar5, image5);
            SetImage(dayw1, image6);
            SetImage(dayw2, image7);
            SetImage(dayw3, image8);
            SetImage(dayw4, image9);
            SetImage(dayw5, image10);

            day_text.Text = day;
            dtext1.Text = name1;
            dtext2.Text = name2;
            dtext3.Text = name3;
            dtext4.Text = name4;
            dtext5.Text = name5;
            dtext6.Text = name6;
            dtext7.Text = name7;
            dtext8.Text = name8;
            dtext9.Text = name9;
            dtext10.Text = name10;
        }

        private void Назад_Click(object sender, EventArgs e)
        {
            ВыборДня oldForm = new ВыборДня();

            this.Hide();

            oldForm.ShowDialog();

        }
    }
}
