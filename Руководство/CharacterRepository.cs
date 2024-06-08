using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        // Форма с калькулятором


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
    }
}
