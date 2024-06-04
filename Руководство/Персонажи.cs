using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Руководство
{
    public partial class Персонажи : Form
    {
        Database database = new Database();
        characterFilter filter = new characterFilter();
        toArray toarray = new toArray();
        public Персонажи()
        {
            InitializeComponent();
            
            
            //List<string> uniqueElements = filter.GetUniqueElements();
            //elements.Items.AddRange(uniqueElements.ToArray());
            //elements.SelectedIndexChanged += elements_SelectedIndexChanged;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Меню oldForm = new Меню();
            this.Hide();
            oldForm.ShowDialog();
        }


        //private void elements_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string selectedElement = elements.SelectedItem.ToString();

        //    // Получаем список персонажей для выбранной стихии
        //    List<string> characters = filter.GetCharactersByElement(selectedElement);

        //    // Перебираем все кнопки и устанавливаем их видимость в соответствии с фильтром
        //    foreach (Control control in Controls)
        //    {
        //        if (control is Button button)
        //        {
        //            // Если название кнопки присутствует в списке персонажей, делаем кнопку видимой
        //            button.Visible = characters.Contains(button.Text);
        //        }
        //    }
        //}

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

            List<string> abilityInfo = new List<string>();
            List<string> abilityImage = new List<string>();

            for (int i = 1; i <= 3; i++)
            {
                abilityInfo.Add(ability_table.Rows[0][$"ability{i}_info"].ToString());
                abilityImage.Add(ability_table.Rows[0][$"ability{i}_image"].ToString());
            }


            // Пассивные таланты
            DataTable passive_table = new DataTable();

            string querystring2 = $"select * from passive_info_db where name = '{nameCharacter}'";
            SqlCommand command2 = new SqlCommand(querystring2, database.getConnection());

            adapter.SelectCommand = command2;
            adapter.Fill(passive_table);

            List<string> pasInfo = new List<string>();
            List<string> pasImage = new List<string>();

            for (int i = 1; i <= 3; i++)
            {
                pasInfo.Add(passive_table.Rows[0][$"pas{i}_info"].ToString());
                pasImage.Add(passive_table.Rows[0][$"pas{i}_image"].ToString());
            }

            // Созвездия
            DataTable const_table = new DataTable();

            string querystring3 = $"select * from const_info_db where name = '{nameCharacter}'";
            SqlCommand command3 = new SqlCommand(querystring3, database.getConnection());

            adapter.SelectCommand = command3;
            adapter.Fill(const_table);

            List<string> cInfo = new List<string>();
            List<string> cImage = new List<string>();

            for (int i = 1; i <= 6; i++)
            {
                cInfo.Add(const_table.Rows[0][$"const{i}_info"].ToString());
                cImage.Add(const_table.Rows[0][$"const{i}_image"].ToString());
            }

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

            string[] abillvlup = toarray.InitializeArrayFromList(imagePaths_abil_lvlup);


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
            
            string[] charlvlup = toarray.InitializeArrayFromList(imagePaths_char_lvlup);

            // Артефакты
            DataTable artifact_table = new DataTable();

            string querystring7 = $"select artifact_name, image, art_1_info, art_2_info, art_3_info from char_build where name_char = '{nameCharacter}'";
            SqlCommand command7 = new SqlCommand(querystring7, database.getConnection());

            adapter.SelectCommand = command7;
            adapter.Fill(artifact_table);

            List<string> artInfo = new List<string>();
            List<string> artImage = new List<string>();
            artInfo.Add(artifact_table.Rows[0]["artifact_name"].ToString());
            artImage.Add(artifact_table.Rows[0]["image"].ToString());
            for (int i = 1; i <= 3; i++)
            {
                artInfo.Add(artifact_table.Rows[0][$"art_{i}_info"].ToString());
            }

            // Оружие
            DataTable weapon_table = new DataTable();

            string querystring8 = $"select weapon1_name, weapon1_image, weapon2_name, weapon2_image, weapon3_name, weapon3_image, weapon4_name, weapon4_image from char_weapon where name_char = '{nameCharacter}'";
            SqlCommand command8 = new SqlCommand(querystring8, database.getConnection());

            adapter.SelectCommand = command8;
            adapter.Fill(weapon_table);

            List<string> weaponInfo = new List<string>();
            List<string> weaponImage = new List<string>();

            for (int i = 1; i <= 4; i++)
            {
                weaponInfo.Add(weapon_table.Rows[0][$"weapon{i}_name"].ToString());
                weaponImage.Add(weapon_table.Rows[0][$"weapon{i}_image"].ToString());
            }


            Информация_о_персонажах characterDetailsForm = new Информация_о_персонажах();
            this.Hide();
                
            characterDetailsForm.SetCharacterData(table.Rows[0]["name"].ToString(), table.Rows[0]["info"].ToString(), table.Rows[0]["image"].ToString());
            characterDetailsForm.SetElement(element[0], element[1]);
            characterDetailsForm.SetAbility(abilityInfo, abilityImage);
            characterDetailsForm.SetPassive(pasInfo, pasImage);
            characterDetailsForm.SetConst(cInfo, cImage);
            characterDetailsForm.SetAbilitylvlup(abillvlup);
            characterDetailsForm.SetCharlvlup(charlvlup);
            // characterDetailsForm.SetArtifact(artifact_table.Rows[0]["artifact_name"].ToString(), artifact_table.Rows[0]["image"].ToString(), artifact_table.Rows[0]["art_1_info"].ToString(), artifact_table.Rows[0]["art_2_info"].ToString(), artifact_table.Rows[0]["art_3_info"].ToString());
            characterDetailsForm.SetArtifact(artInfo, artImage);
            characterDetailsForm.SetWeapon(weaponInfo, weaponImage);
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
