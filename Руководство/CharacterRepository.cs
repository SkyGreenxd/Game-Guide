using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace Руководство
{
    internal class CharacterRepository
    {
        private Database database;
        public CharacterRepository(Database database)
        {
            this.database = database;
        }
        // Форма с персонажами
        public DataTable GetCharacterInfo(string nameCharacter)
        {
            string query = $"select * from char_info_db where name = '{nameCharacter}'";
            return ExecuteQuery(query);
        }
        public DataTable GetCharacterElement(string nameCharacter)
        {
            string query = $"SELECT element_db.name_element,element_db.image FROM char_element INNER JOIN element_db ON char_element.element_id = element_db.id WHERE char_element.name = '{nameCharacter}'";
            return ExecuteQuery(query);
        }
        public DataTable GetCharacterAbilities(string nameCharacter)
        {
            string query = $"select * from ability_info_db where name = '{nameCharacter}'";
            return ExecuteQuery(query);
        }
        public DataTable GetCharacterPassiveAbilities(string nameCharacter)
        {
            string query = $"select * from passive_info_db where name = '{nameCharacter}'";
            return ExecuteQuery(query);
        }
        public DataTable GetCharacterConstellations(string nameCharacter)
        {
            string query = $"select * from const_info_db where name = '{nameCharacter}'";
            return ExecuteQuery(query);
        }
        public DataTable GetCharacterAbilityLevelUpResources(string nameCharacter)
        {
            string query = $"SELECT resources.name_resource FROM ability_lvlup INNER JOIN resources ON ability_lvlup.resources_id = resources.id WHERE ability_lvlup.name = '{nameCharacter}'";
            return ExecuteQuery(query);
        }
        public DataTable GetCharacterLevelUpResources(string nameCharacter)
        {
            string query = $"SELECT resources.name_resource FROM char_lvlup INNER JOIN resources ON char_lvlup.resources_id = resources.id WHERE char_lvlup.name = '{nameCharacter}'";
            return ExecuteQuery(query);
        }
        public DataTable GetCharacterArtifacts(string nameCharacter)
        {
            string query = $"select artifact_name, image, art_1_info, art_2_info, art_3_info from char_build where name_char = '{nameCharacter}'";
            return ExecuteQuery(query);
        }
        public DataTable GetCharacterWeapons(string nameCharacter)
        {
            string query = $"select weapon1_name, weapon1_image, weapon2_name, weapon2_image, weapon3_name, weapon3_image, weapon4_name, weapon4_image from char_weapon where name_char = '{nameCharacter}'";
            return ExecuteQuery(query);
        }

        // Форма с выбором дня
        public DataTable GetResourcesByDay(string nameDay)
        {
            string query = $"SELECT resources.name_resource, day_resources.name_resource FROM day_resources INNER JOIN resources ON day_resources.resources_id = resources.id WHERE day_resources.day = '{nameDay}'";
            return ExecuteQuery(query);
        }
        public DataTable GetResourcesBySunday(string nameDay)
        {
            string query = $"SELECT resources.name_resource, day_resources.name_resource FROM day_resources INNER JOIN resources ON day_resources.resources_id = resources.id WHERE day_resources.day = '{nameDay}'";
            return ExecuteQuery(query);
        }

        // Калькулятор 
        public DataTable GetLevelData(int lvl1, int lvl2)
        {
            string query;
            if (lvl1 != lvl2)
            {
                query = $"select * from lvl_db where lvl = '{lvl1}' or lvl = '{lvl2}'";
            }
            else
            {
                query = $"select * from lvl_db where lvl = '{lvl1}'";
            }
            return ExecuteQuery(query);
        }
        public DataTable GetTalentLevelData(int tal1, int tal2)
        {
            string query;
            if (tal1 != tal2)
            {
                query = $"SELECT SUM(tal_book1) AS total_tal_book1, SUM(tal_book2) AS total_tal_book2, SUM(tal_book3) AS total_tal_book3, SUM(tal_res1) AS total_tal_res1, SUM(tal_res2) AS total_tal_res2, SUM(tal_res3) AS total_tal_res3, SUM(weekly_boss) AS total_weekly_boss, SUM(mora) AS total_mora, SUM(crown) AS total_crown FROM tal_lvl WHERE lvl > '{tal1}' AND lvl <= '{tal2}'";
            }
            else
            {
                query = $"SELECT tal_book1, tal_book2, tal_book3, tal_res1, tal_res2, tal_res3, weekly_boss, mora, crown FROM tal_lvl WHERE lvl = '{tal1}'";
            }
            return ExecuteQuery(query);
        }
        public DataTable GetEvolutionData(int evol1, int evol2)
        {
            string query;
            if (evol1 != evol2)
            {
                query = $"SELECT SUM(material1) AS total_material1, SUM(material2) AS total_material2, SUM(material3) AS total_material3, SUM(material4) AS total_material4, SUM(boss_material) AS total_boss_material, SUM(local_specialty) AS total_local_specialty, SUM(mora) AS total_mora FROM evolution_phase_db WHERE lvl > '{evol1}' AND lvl <= '{evol2}'";
            }
            else
            {
                query = $"SELECT material1, material2, material3, material4, boss_material, local_specialty, mora FROM evolution_phase_db WHERE lvl = '{evol1}'";
            }
            return ExecuteQuery(query);
        }
        // Фильтр
        public DataTable GetLoadElement()
        {
            string query = "SELECT DISTINCT element_db.name_element FROM element_db";
            return ExecuteQuery(query);
        }
        public DataTable GetFilterCharacters(string selectedElement)
        {
            string query = $"SELECT char_element.name FROM char_element INNER JOIN element_db ON char_element.element_id = element_db.id WHERE element_db.name_element = '{selectedElement}'";
            return ExecuteQuery(query);
        }
        // Тир_Лист
        public DataTable Getpic()
        {
            string query = $"select image from char_icon_db";
            return ExecuteQuery(query);
        }


        private DataTable ExecuteQuery(string query)
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                using (SqlCommand command = new SqlCommand(query, database.getConnection()))
                {
                    DataTable table = new DataTable();
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    return table;
                }
            }
        }
        public string[] InitializeArrayFromList(List<string> list) // из листа в массив
        {
            string[] array = new string[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                array[i] = list[i];
            }
            return array;
        }
        public string[] InitializeArrayFromDataTable(DataTable table, string columnName) // из бд таблицы в массив
        {
            string[] array = new string[table.Rows.Count];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                array[i] = table.Rows[i][columnName].ToString();
            }
            return array;
        }
    }
}
