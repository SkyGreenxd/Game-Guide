using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Руководство
{
    public partial class Воскресенье : Form
    {
        public Воскресенье()
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

        // Воскресенье
        public void SetVoskr(string day, string image1, string image2, string image3, string image4, string image5, string image6, string image7, string image8, string image9, string image10,
            string image11, string image12, string image13, string image14, string image15, string image16, string image17, string image18, string image19, string image20, string image21,
            string image22, string image23, string image24, string image25, string image26, string image27, string image28, string image29, string image30,
            string name1, string name2, string name3, string name4, string name5, string name6, string name7, string name8, string name9, string name10,
            string name11, string name12, string name13, string name14, string name15, string name16, string name17, string name18, string name19, string name20,
            string name21, string name22, string name23, string name24, string name25, string name26, string name27, string name28, string name29, string name30)
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
            SetImage(daychar6, image11);
            SetImage(daychar7, image12);
            SetImage(daychar8, image13);
            SetImage(daychar9, image14);
            SetImage(daychar10, image15);
            SetImage(dayw6, image16);
            SetImage(dayw7, image17);
            SetImage(dayw8, image18);
            SetImage(dayw9, image19);
            SetImage(dayw10, image20);
            SetImage(daychar11, image21);
            SetImage(daychar12, image22);
            SetImage(daychar13, image23);
            SetImage(daychar14, image24);
            SetImage(daychar15, image25);
            SetImage(dayw11, image26);
            SetImage(dayw12, image27);
            SetImage(dayw13, image28);
            SetImage(dayw14, image29);
            SetImage(dayw15, image30);

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
            dtext11.Text = name11;
            dtext12.Text = name12;
            dtext13.Text = name13;
            dtext14.Text = name14;
            dtext15.Text = name15;
            dtext16.Text = name16;
            dtext17.Text = name17;
            dtext18.Text = name18;
            dtext19.Text = name19;
            dtext20.Text = name20;
            dtext21.Text = name21;
            dtext22.Text = name22;
            dtext23.Text = name23;
            dtext24.Text = name24;
            dtext25.Text = name25;
            dtext26.Text = name26;
            dtext27.Text = name27;
            dtext28.Text = name28;
            dtext29.Text = name29;
            dtext30.Text = name30;
        }

        private void Назад_Click(object sender, EventArgs e)
        {
            ВыборДня oldForm = new ВыборДня();

            this.Hide();

            oldForm.ShowDialog();
        }
    }
}
