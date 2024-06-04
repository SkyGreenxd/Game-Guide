using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Руководство;

namespace Руководство
{
    internal class characterFilter
    {
        Database database = new Database();
        public List<string> GetUniqueElements()
        {
            List<string> elements = new List<string>();

            string query = "SELECT DISTINCT name_element FROM element_db";

            using (SqlConnection connection = database.getConnection())
            {
                connection.Open(); // Открываем соединение
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            elements.Add(reader.GetString(0));
                        }
                    }
                }
            }

            return elements;
        }

        public List<string> GetCharactersByElement(string element)
        {
            List<string> characters = new List<string>();

            string query = $"SELECT name FROM char_element WHERE element_id = (SELECT id FROM element_db WHERE name_element = '{element}')";

            using (SqlConnection connection = database.getConnection())
            {
                connection.Open(); // Открываем соединение
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            characters.Add(reader.GetString(0));
                        }
                    }
                }
            }

            return characters;
        }
    }
}

