using System;
using System.IO;
using System.Windows.Forms;

namespace Руководство
{
    public partial class Расчёт : Form
    {
        public Расчёт()
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
        public void SetCharacterData(string[] charResult)
        {
            NameCh.Text = charResult[0];
            NameCh.SelectionAlignment = HorizontalAlignment.Center;

            SetImage(char_image, charResult[1]);
            PictureBox[] abilImages = { alvlup1_image, alvlup2_image, alvlup3_image, alvlup4_image, alvlup5_image, alvlup6_image, alvlup7_image, clvlup4_image, clvlup5_image, clvlup6_image, clvlup7_image, clvlup8_image, clvlup9_image };
            for (int i = 0; i < abilImages.Length; i++)
            {
                SetImage(abilImages[i], charResult[i+2]);
            }
        }
        public void SetEXP(int lvl1, int lvl2, int mora_lvl1, int mora_lvl2)
        {
            int totalexp = lvl2 - lvl1;
            int book1 = totalexp / 20000;
            int book2 = (totalexp - (book1 * 20000)) / 5000;
            int book3 = (int)Math.Ceiling((double)(totalexp - (book1 * 20000) - (book2 * 5000)) / 1000);
            exp1.Text = book1.ToString();
            exp2.Text = book2.ToString();
            exp3.Text = book3.ToString();
            total_mora.Text = (Convert.ToInt32(total_mora.Text) + (mora_lvl2 - mora_lvl1)).ToString();
        }
        public void SetTalent(int tal_book1, int tal_book2, int tal_book3, int tal_res1, int tal_res2, int tal_res3, int weekly_boss, int mora, int crown)
        {
            tal1.Text = tal_book1.ToString();
            tal2.Text = tal_book2.ToString();
            tal3.Text = tal_book3.ToString();
            res1.Text = tal_res1.ToString();
            res2.Text = tal_res2.ToString();
            res3.Text = tal_res3.ToString();
            w_boss.Text = weekly_boss.ToString();
            total_mora.Text = (Convert.ToInt32(total_mora.Text) + mora).ToString();
            total_crown.Text = crown.ToString();
        }
        public void SetEvolution(int material1, int material2, int material3, int material4, int boss_material, int local_specialty, int mora)
        {
            m1.Text = material1.ToString();
            m2.Text = material2.ToString();
            m3.Text = material3.ToString();
            m4.Text = material4.ToString();
            b_material.Text = boss_material.ToString();
            l_specialty.Text = local_specialty.ToString();
            total_mora.Text = (Convert.ToInt32(total_mora.Text) + mora).ToString();
            total_mora.ReadOnly = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Калькулятор newForm = new Калькулятор();
            this.Hide();
            newForm.ShowDialog();
        }
        public void SaveCharacterDataToTxt(string filePath)
        {
            var data = new (string Label, string Value)[]
            {
                ("Имя персонажа: ", NameCh.Text),
                ("Опыт героя: ", exp1.Text),
                ("Опыт искателя приключений: ", exp2.Text),
                ("Опыт странника ", exp3.Text),
                ("Необходимое кол-во моры: ", total_mora.Text),
                ("Материал для повышения талантов 2*: ", tal1.Text),
                ("Материал для повышения талантов 3*: ", tal2.Text),
                ("Материал для повышения талантов 4*: ", tal3.Text),
                ("Ресурсы с мобов 1*: ", res1.Text),
                ("Ресурсы с мобов 2*: ", res2.Text),
                ("Ресурсы с мобов 3*: ", res3.Text),
                ("Ресурс с еженедельного босса: ", w_boss.Text),
                ("Общее количество корон: ", total_crown.Text),
                ("Материал для возвышения 2*: ", m1.Text),
                ("Материал для возвышения 3*: ", m2.Text),
                ("Материал для возвышения 4*: ", m3.Text),
                ("Материал для возвышения 5*: ", m4.Text),
                ("Материал с босса: ", b_material.Text),
                ("Кол-во диковин: ", l_specialty.Text)
            };
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var (label, value) in data)
                {
                    writer.WriteLine(label + value);
                }
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveCharacterDataToTxt(saveFileDialog.FileName);
                MessageBox.Show("Результат успешно сохранен.", "Сохранение завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
