using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Руководство
{
    public partial class Информация_о_персонажах : Form
    {
        public Информация_о_персонажах()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Персонажи oldForm = new Персонажи();
            // Закрытие текущей формы
            this.Hide();
            // Отображение предыдущей формы как модальной
            oldForm.ShowDialog();
        }

        //метод SetImage устанавливает изображение в PictureBox
        public void SetImage(PictureBox pictureBox, string image)
        {
            if (!string.IsNullOrEmpty(image))
            {
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Image = System.Drawing.Image.FromFile(image);
            }
        }

        // Имя, фото и описание
        public void SetCharacterData(string name, string info, string image)
        {
            NameCh.Text = name;
            InfoCh.Text = info;
            InfoCh.SelectionAlignment = HorizontalAlignment.Center;

            SetImage(pictureBox1, image);
        }

        // Элемент персонажа
        public void SetElement(string name_element, string image)
        {
            el.Text = name_element;

            SetImage(el_image, image);
        }


        public void SetAbility(List<string> abilityInfos, List<string> abilityImages)
        {
            PictureBox[] wImages = { a1_image, a2_image, a3_image };
            RichTextBox[] wInfo = { a1_info, a2_info, a3_info };

            for (int i = 0; i < 3; i++)
            {
                wInfo[i].Text = abilityInfos[i];
                SetImage(wImages[i], abilityImages[i]);
            }
        }


        public void SetPassive(List<string> pasInfos, List<string> pasImages)
        {
            PictureBox[] pImages = { p1_image, p2_image, p3_image };
            RichTextBox[] pInfo = { p1_info, p2_info, p3_info };

            for (int i = 0; i < 3; i++)
            {
                pInfo[i].Text = pasInfos[i];
                SetImage(pImages[i], pasImages[i]);
            }
        }


        public void SetConst(List<string> constInfos, List<string> constImages)
        {
            PictureBox[] cImages = { c1_image, c2_image, c3_image, c4_image, c5_image, c6_image };
            RichTextBox[] cInfo = { c1_info, c2_info, c3_info, c4_info, c5_info, c6_info };

            for (int i = 0; i < 6; i++)
            {
                cInfo[i].Text = constInfos[i];
                SetImage(cImages[i], constImages[i]);
            }
        }


        public void SetAbilitylvlup(string[] abillvlup)
        {
            PictureBox[] abilImages = { alvlup1_image, alvlup2_image, alvlup3_image, alvlup4_image, alvlup5_image, alvlup6_image, alvlup7_image };

            for (int i = 0; i < abilImages.Length; i++)
            {
                SetImage(abilImages[i], abillvlup[i]);
            }
        }


        public void SetCharlvlup(string[] charlvlup)
        {
            PictureBox[] charImages = { clvlup1_image, clvlup2_image, clvlup3_image, clvlup4_image, clvlup5_image, clvlup6_image, clvlup7_image, clvlup8_image, clvlup9_image };

            for (int i = 0; i < charImages.Length; i++)
            {
                SetImage(charImages[i], charlvlup[i]);
            }
        }


        public void SetArtifact(List<string> artInfos, List<string> artImages)
        {
            RichTextBox[] aInfo = { art1_info, art2_info, art3_info };
            SetImage(art_image, artImages[0]);
            arti.Text = artInfos[0];

            for (int i = 0; i < 3; i++)
            {
                aInfo[i].Text = artInfos[i + 1];
            }
        }


        public void SetWeapon(List<string> weaponInfos, List<string> weaponImages)
        {
            PictureBox[] wImages = { w1_image, w2_image, w3_image, w4_image };
            RichTextBox[] wInfo = { w1_name, w2_name, w3_name, w4_name };

            for (int i = 0; i < wInfo.Length; i++)
            {
                wInfo[i].Text = weaponInfos[i];
                SetImage(wImages[i], weaponImages[i]);
            }
        }

    }
}
