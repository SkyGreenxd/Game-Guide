using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Руководство
{
    public partial class Персонажи : Form
    {

        Database database = new Database();

        public Персонажи()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Меню oldForm = new Меню();

            // Закрытие текущей формы
            this.Hide();

            // Отображение предыдущей формы как модальной
            oldForm.ShowDialog();
            
        }


        protected void selectChar(string nameCharacter)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            // Имя, фото и описание
            DataTable table = new DataTable();

            string querystring = $"select * from char_info_db where name = '{nameCharacter}'";
            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            // Элемент персонажа
            DataTable char_element_table = new DataTable();

            string querystring6 = $"SELECT element_db.name_element,element_db.image FROM char_element INNER JOIN element_db ON char_element.element_id = element_db.id WHERE char_element.name = '{nameCharacter}'";

            SqlCommand command6 = new SqlCommand(querystring6, database.getConnection());

            adapter.SelectCommand = command6;
            adapter.Fill(char_element_table);
            List<string> element = new List<string>();
            foreach (DataRow row in char_element_table.Rows)
            {
                element.Add(row["name_element"].ToString());
                element.Add(row["image"].ToString());
            }

            // Таланты
            DataTable ability_table = new DataTable();

            string querystring1 = $"select * from ability_info_db where name = '{nameCharacter}'";
            SqlCommand command1 = new SqlCommand(querystring1, database.getConnection());

            adapter.SelectCommand = command1;
            adapter.Fill(ability_table);


            // Пассивные таланты
            DataTable passive_table = new DataTable();

            string querystring2 = $"select * from passive_info_db where name = '{nameCharacter}'";
            SqlCommand command2 = new SqlCommand(querystring2, database.getConnection());

            adapter.SelectCommand = command2;
            adapter.Fill(passive_table);

            // Созвездия
            DataTable const_table = new DataTable();

            string querystring3 = $"select * from const_info_db where name = '{nameCharacter}'";
            SqlCommand command3 = new SqlCommand(querystring3, database.getConnection());

            adapter.SelectCommand = command3;
            adapter.Fill(const_table);


            // Рес-сы для талантов
            DataTable abil_lvlup_table = new DataTable();

            string querystring4 = $"SELECT resources.name_resource FROM ability_lvlup INNER JOIN resources ON ability_lvlup.resources_id = resources.id WHERE ability_lvlup.name = '{nameCharacter}'";

            SqlCommand command4 = new SqlCommand(querystring4, database.getConnection());

            adapter.SelectCommand = command4;
            adapter.Fill(abil_lvlup_table);

            List<string> imagePaths_abil_lvlup = new List<string>();
            foreach (DataRow row in abil_lvlup_table.Rows)
            {
                imagePaths_abil_lvlup.Add(row["name_resource"].ToString());
            }


            // Рес-сы для возвышения
            DataTable char_lvlup_table = new DataTable();

            string querystring5 = $"SELECT resources.name_resource FROM char_lvlup INNER JOIN resources ON char_lvlup.resources_id = resources.id WHERE char_lvlup.name = '{nameCharacter}'";

            SqlCommand command5 = new SqlCommand(querystring5, database.getConnection());

            adapter.SelectCommand = command5;
            adapter.Fill(char_lvlup_table);

            List<string> imagePaths_char_lvlup = new List<string>();
            foreach (DataRow row in char_lvlup_table.Rows)
            {
                imagePaths_char_lvlup.Add(row["name_resource"].ToString());
            }

            // Артефакты

            DataTable artifact_table = new DataTable();

            string querystring7 = $"select artifact_name, image, art_1_info, art_2_info, art_3_info from char_build where name_char = '{nameCharacter}'";
            SqlCommand command7 = new SqlCommand(querystring7, database.getConnection());

            adapter.SelectCommand = command7;
            adapter.Fill(artifact_table);

            // Оружие

            DataTable weapon_table = new DataTable();

            string querystring8 = $"select weapon1_name, weapon1_image, weapon2_name, weapon2_image, weapon3_name, weapon3_image, weapon4_name, weapon4_image from char_weapon where name_char = '{nameCharacter}'";
            SqlCommand command8 = new SqlCommand(querystring8, database.getConnection());

            adapter.SelectCommand = command8;
            adapter.Fill(weapon_table);



            Информация_о_персонажах characterDetailsForm = new Информация_о_персонажах();

            this.Hide();
                
            characterDetailsForm.SetCharacterData(table.Rows[0]["name"].ToString(), table.Rows[0]["info"].ToString(), table.Rows[0]["image"].ToString());

            characterDetailsForm.SetElement(nameCharacter, element[0], element[1]);

            characterDetailsForm.SetAbility(ability_table.Rows[0]["name"].ToString(), ability_table.Rows[0]["ability1_info"].ToString(), ability_table.Rows[0]["ability1_image"].ToString(), ability_table.Rows[0]["ability2_info"].ToString(), ability_table.Rows[0]["ability2_image"].ToString(), ability_table.Rows[0]["ability3_info"].ToString(), ability_table.Rows[0]["ability3_image"].ToString());

            characterDetailsForm.SetPassive(passive_table.Rows[0]["name"].ToString(), passive_table.Rows[0]["pas1_info"].ToString(), passive_table.Rows[0]["pas1_image"].ToString(), passive_table.Rows[0]["pas2_info"].ToString(), passive_table.Rows[0]["pas2_image"].ToString(), passive_table.Rows[0]["pas3_info"].ToString(), passive_table.Rows[0]["pas3_image"].ToString());

            characterDetailsForm.SetConst(const_table.Rows[0]["name"].ToString(), const_table.Rows[0]["const1_info"].ToString(), const_table.Rows[0]["const1_image"].ToString(), const_table.Rows[0]["const2_info"].ToString(), const_table.Rows[0]["const2_image"].ToString(), const_table.Rows[0]["const3_info"].ToString(), const_table.Rows[0]["const3_image"].ToString(), const_table.Rows[0]["const4_info"].ToString(), const_table.Rows[0]["const4_image"].ToString(), const_table.Rows[0]["const5_info"].ToString(), const_table.Rows[0]["const5_image"].ToString(), const_table.Rows[0]["const6_info"].ToString(), const_table.Rows[0]["const6_image"].ToString());

            characterDetailsForm.SetAbilitylvlup(nameCharacter, imagePaths_abil_lvlup[0], imagePaths_abil_lvlup[1], imagePaths_abil_lvlup[2], imagePaths_abil_lvlup[3], imagePaths_abil_lvlup[4], imagePaths_abil_lvlup[5], imagePaths_abil_lvlup[6]);

            characterDetailsForm.SetCharlvlup(nameCharacter, imagePaths_char_lvlup[0], imagePaths_char_lvlup[1], imagePaths_char_lvlup[2], imagePaths_char_lvlup[3], imagePaths_char_lvlup[4], imagePaths_char_lvlup[5], imagePaths_char_lvlup[6], imagePaths_char_lvlup[7], imagePaths_char_lvlup[8]);

            characterDetailsForm.SetArtifact(artifact_table.Rows[0]["artifact_name"].ToString(), artifact_table.Rows[0]["image"].ToString(), artifact_table.Rows[0]["art_1_info"].ToString(), artifact_table.Rows[0]["art_2_info"].ToString(), artifact_table.Rows[0]["art_3_info"].ToString());

            characterDetailsForm.SetWeapon(weapon_table.Rows[0]["weapon1_name"].ToString(), weapon_table.Rows[0]["weapon1_image"].ToString(), weapon_table.Rows[0]["weapon2_name"].ToString(), weapon_table.Rows[0]["weapon2_image"].ToString(), weapon_table.Rows[0]["weapon3_name"].ToString(), weapon_table.Rows[0]["weapon3_image"].ToString(), weapon_table.Rows[0]["weapon4_name"].ToString(), weapon_table.Rows[0]["weapon4_image"].ToString());

            characterDetailsForm.ShowDialog();

        }

        protected void Казуха_Click(object sender, EventArgs e)
        {
            selectChar(Кадзуха.Text);
        }

        private void Сяо_Click(object sender, EventArgs e)
        {
            selectChar(Сяо.Text);
        }

    }
}
