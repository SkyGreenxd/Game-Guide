using System;
using System.Windows.Forms;

namespace Руководство
{
    public partial class Меню : Form
    {
        public Меню()
        {
            InitializeComponent();
        }

        private void Персонажи(object sender, EventArgs e)
        {
            Персонажи newForm = new Персонажи();

            newForm.Show();

            this.Hide();
        }

        private void Калькулятор(object sender, EventArgs e)
        {
            Калькулятор newForm = new Калькулятор();

            // Показ новой формы
            newForm.Show();

            // Закрытие текущей формы
            this.Hide();
        }

        private void Выход_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Ресурсы(object sender, EventArgs e)
        {
            choiceDay newForm = new choiceDay();

            // Показ новой формы
            newForm.Show();

            // Закрытие текущей формы
            this.Hide();
        }

        private void ТирЛист(object sender, EventArgs e)
        {
            TIERLIST newForm = new TIERLIST();

            // Показ новой формы
            newForm.Show();

            // Закрытие текущей формы
            this.Hide();
        }
    }
}

//string[] Images = { v_res[0], v_res[1], v_res[2], v_res[3], v_res[4], v_res[5], v_res[6], v_res[7], v_res[8], v_res[9],
//                v_res[10], v_res[11], v_res[12], v_res[13], v_res[14], v_res[15], v_res[16], v_res[17], v_res[18], v_res[19],
//                v_res[20], v_res[21], v_res[22], v_res[23], v_res[24], v_res[25], v_res[26], v_res[27], v_res[28], v_res[29] };

//string[] dtextNames = { voskr_table.Rows[0]["name_resource1"].ToString(), voskr_table.Rows[1]["name_resource1"].ToString(), voskr_table.Rows[2]["name_resource1"].ToString(), voskr_table.Rows[3]["name_resource1"].ToString(), voskr_table.Rows[4]["name_resource1"].ToString(), voskr_table.Rows[5]["name_resource1"].ToString(), voskr_table.Rows[6]["name_resource1"].ToString(), voskr_table.Rows[7]["name_resource1"].ToString(), voskr_table.Rows[8]["name_resource1"].ToString(), voskr_table.Rows[9]["name_resource1"].ToString(),
//                voskr_table.Rows[10]["name_resource1"].ToString(), voskr_table.Rows[11]["name_resource1"].ToString(), voskr_table.Rows[12]["name_resource1"].ToString(), voskr_table.Rows[13]["name_resource1"].ToString(), voskr_table.Rows[14]["name_resource1"].ToString(), voskr_table.Rows[15]["name_resource1"].ToString(), voskr_table.Rows[16]["name_resource1"].ToString(), voskr_table.Rows[17]["name_resource1"].ToString(), voskr_table.Rows[8]["name_resource1"].ToString(), voskr_table.Rows[19]["name_resource1"].ToString(),
//                voskr_table.Rows[20]["name_resource1"].ToString(), voskr_table.Rows[21]["name_resource1"].ToString(), voskr_table.Rows[22]["name_resource1"].ToString(), voskr_table.Rows[23]["name_resource1"].ToString(), voskr_table.Rows[24]["name_resource1"].ToString(), voskr_table.Rows[25]["name_resource1"].ToString(), voskr_table.Rows[26]["name_resource1"].ToString(), voskr_table.Rows[27]["name_resource1"].ToString(), voskr_table.Rows[28]["name_resource1"].ToString(), voskr_table.Rows[29]["name_resource1"].ToString() };

//VInfo.SetVoskr(nameDay, Images, dtextNames);
//public void SetVoskr(string day, string[] images, string[] names)
//{
//    PictureBox[] daycharImages = { daychar1, daychar2, daychar3, daychar4, daychar5, daychar6, daychar7, daychar8, daychar9, daychar10, daychar11, daychar12, daychar13, daychar14, daychar15 };
//    PictureBox[] daywImages = { dayw1, dayw2, dayw3, dayw4, dayw5, dayw6, dayw7, dayw8, dayw9, dayw10, dayw11, dayw12, dayw13, dayw14, dayw15 };
//    RichTextBox[] dtextNames = { dtext1, dtext2, dtext3, dtext4, dtext5, dtext6, dtext7, dtext8, dtext9, dtext10, dtext11, dtext12, dtext13, dtext14, dtext15, dtext16, dtext17, dtext18, dtext19, dtext20, dtext21, dtext22, dtext23, dtext24, dtext25, dtext26, dtext27, dtext28, dtext29, dtext30 };

//    for (int i = 0; i < Math.Min(images.Length, daycharImages.Length); i++)
//    {
//        SetImage(daycharImages[i], images[i]);
//    }

//    for (int i = 0; i < Math.Min(images.Length - 15, daywImages.Length); i++)
//    {
//        SetImage(daywImages[i], images[i + 15]);
//    }

//    for (int i = 0; i < Math.Min(names.Length, dtextNames.Length); i++)
//    {
//        dtextNames[i].Text = names[i];
//    }

//    day_text.Text = day;
//}