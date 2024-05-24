using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void SetCharacterData(string name, string image, string abilitylvlup1_image, string abilitylvlup2_image, string abilitylvlup3_image, string abilitylvlup4_image, string abilitylvlup5_image, string abilitylvlup6_image, string abilitylvlup7_image, string charlvlup4_image, string charlvlup5_image, string charlvlup6_image, string charlvlup7_image, string charlvlup8_image, string charlvlup9_image)
        {
            NameCh.Text = name;
            NameCh.SelectionAlignment = HorizontalAlignment.Center;

            SetImage(char_image, image);
            SetImage(alvlup1_image, abilitylvlup1_image);
            SetImage(alvlup2_image, abilitylvlup2_image);
            SetImage(alvlup3_image, abilitylvlup3_image);
            SetImage(alvlup4_image, abilitylvlup4_image);
            SetImage(alvlup5_image, abilitylvlup5_image);
            SetImage(alvlup6_image, abilitylvlup6_image);
            SetImage(alvlup7_image, abilitylvlup7_image);
            SetImage(clvlup4_image, charlvlup4_image);
            SetImage(clvlup5_image, charlvlup5_image);
            SetImage(clvlup6_image, charlvlup6_image);
            SetImage(clvlup7_image, charlvlup7_image);
            SetImage(clvlup8_image, charlvlup8_image);
            SetImage(clvlup9_image, charlvlup9_image);
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
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Имя персонажа: " + NameCh.Text);
                writer.WriteLine("Опыт героя: " + exp1.Text);
                writer.WriteLine("Опыт искателя приключений: " + exp2.Text);
                writer.WriteLine("Опыт странника " + exp3.Text);
                writer.WriteLine("Необходимое кол-во моры: " + total_mora.Text);
                writer.WriteLine("Материал для повышения талантов 2*: " + tal1.Text);
                writer.WriteLine("Материал для повышения талантов 3*: " + tal2.Text);
                writer.WriteLine("Материал для повышения талантов 4*: " + tal3.Text);
                writer.WriteLine("Ресурсы с мобов 1*: " + res1.Text);
                writer.WriteLine("Ресурсы с мобов 2*: " + res2.Text);
                writer.WriteLine("Ресурсы с мобов 3*: " + res3.Text);
                writer.WriteLine("Ресурс с еженедельного босса: " + w_boss.Text);
                writer.WriteLine("Общее количество корон: " + total_crown.Text);
                writer.WriteLine("Материал для возвышения 2*: " + m1.Text);
                writer.WriteLine("Материал для возвышения 3*: " + m2.Text);
                writer.WriteLine("Материал для возвышения 4*: " + m3.Text);
                writer.WriteLine("Материал для возвышения 5*: " + m4.Text);
                writer.WriteLine("Материал с босса: " + b_material.Text);
                writer.WriteLine("Кол-во диковин: " + l_specialty.Text);
            }
        }


        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*"; // Фильтр для диалогового окна сохранения
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveCharacterDataToTxt(saveFileDialog.FileName);
                MessageBox.Show("Результат успешно сохранен.", "Сохранение завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
    
}
