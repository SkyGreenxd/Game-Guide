using System;
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

        // Таланты
        public void SetAbility(string ability1_info, string ability1_image, string ability2_info, string ability2_image, string ability3_info, string ability3_image)
        {
            this.a1_info.Text = ability1_info;
            this.a2_info.Text = ability2_info;
            this.a3_info.Text = ability3_info;

            SetImage(a1_image, ability1_image);
            SetImage(a2_image, ability2_image);
            SetImage(a3_image, ability3_image);
        }

        // Пассивные таланты
        public void SetPassive(string name, string pas1_info, string pas1_image, string pas2_info, string pas2_image, string pas3_info, string pas3_image)
        {
            this.p1_info.Text = pas1_info;
            this.p2_info.Text = pas2_info;
            this.p3_info.Text = pas3_info;

            SetImage(p1_image, pas1_image);
            SetImage(p2_image, pas2_image);
            SetImage(p3_image, pas3_image);
        }

        // Созвездия
        public void SetConst(string const1_info, string const1_image, string const2_info, string const2_image, string const3_info, string const3_image, string const4_info, string const4_image, string const5_info, string const5_image, string const6_info, string const6_image)
        {
            this.c1_info.Text = const1_info;
            this.c2_info.Text = const2_info;
            this.c3_info.Text = const3_info;
            this.c4_info.Text = const4_info;
            this.c5_info.Text = const5_info;
            this.c6_info.Text = const6_info;

            SetImage(c1_image, const1_image);
            SetImage(c2_image, const2_image);
            SetImage(c3_image, const3_image);
            SetImage(c4_image, const4_image);
            SetImage(c5_image, const5_image);
            SetImage(c6_image, const6_image);

            //for (int i = 0; i < Math.Min(images.Length, daycharImages.Length); i++)
            //{
            //    SetImage(daycharImages[i], images[i]);
            //}


        }

        // Рес-сы для талантов
        public void SetAbilitylvlup(string abilitylvlup1_image, string abilitylvlup2_image, string abilitylvlup3_image, string abilitylvlup4_image, string abilitylvlup5_image, string abilitylvlup6_image, string abilitylvlup7_image)
        {
            SetImage(alvlup1_image, abilitylvlup1_image);
            SetImage(alvlup2_image, abilitylvlup2_image);
            SetImage(alvlup3_image, abilitylvlup3_image);
            SetImage(alvlup4_image, abilitylvlup4_image);
            SetImage(alvlup5_image, abilitylvlup5_image);
            SetImage(alvlup6_image, abilitylvlup6_image);
            SetImage(alvlup7_image, abilitylvlup7_image);
        }

        // Рес-сы для возвышения
        public void SetCharlvlup(string charlvlup1_image, string charlvlup2_image, string charlvlup3_image, string charlvlup4_image, string charlvlup5_image, string charlvlup6_image, string charlvlup7_image, string charlvlup8_image, string charlvlup9_image)
        {
            SetImage(clvlup1_image, charlvlup1_image);
            SetImage(clvlup2_image, charlvlup2_image);
            SetImage(clvlup3_image, charlvlup3_image);
            SetImage(clvlup4_image, charlvlup4_image);
            SetImage(clvlup5_image, charlvlup5_image);
            SetImage(clvlup6_image, charlvlup6_image);
            SetImage(clvlup7_image, charlvlup7_image);
            SetImage(clvlup8_image, charlvlup8_image);
            SetImage(clvlup9_image, charlvlup9_image);
        }

        // Артефакты
        public void SetArtifact(string artifact_name, string image, string art_1_info, string art_2_info, string art_3_info)
        {
            arti.Text = artifact_name;
            art1_info.Text = art_1_info;
            art2_info.Text = art_2_info;
            art3_info.Text = art_3_info;

            SetImage(art_image, image);
        }

        public void SetWeapon(string weapon1_name, string weapon1_image, string weapon2_name, string weapon2_image, string weapon3_name, string weapon3_image, string weapon4_name, string weapon4_image)
        {
            w1_name.Text = weapon1_name;
            w2_name.Text = weapon2_name;
            w3_name.Text = weapon3_name;
            w4_name.Text = weapon4_name;

            SetImage(w1_image, weapon1_image);
            SetImage(w2_image, weapon2_image);
            SetImage(w3_image, weapon3_image);
            SetImage(w4_image, weapon4_image);
        }
    }
}
