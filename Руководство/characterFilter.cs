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
        private Database database;
        private ComboBox comboBoxElements;
        private Panel charPanel;

        public characterFilter(Database db, ComboBox comboBox, FlowLayoutPanel panel)
        {
            database = db;
            comboBoxElements = comboBox;
            charPanel = panel;
            LoadElements();
        }

        private void LoadElements()
        {
            string query = "SELECT DISTINCT element_db.name_element FROM element_db";
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable elementsTable = new DataTable();

            SqlCommand command = new SqlCommand(query, database.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(elementsTable);

            comboBoxElements.Items.Clear();
            foreach (DataRow row in elementsTable.Rows)
            {
                comboBoxElements.Items.Add(row["name_element"].ToString());
            }
        }

        public void FilterCharacters(string selectedElement)
        {
            string query = $"SELECT char_element.name FROM char_element INNER JOIN element_db ON char_element.element_id = element_db.id WHERE element_db.name_element = '{selectedElement}'";
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable charactersTable = new DataTable();

            SqlCommand command = new SqlCommand(query, database.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(charactersTable);

            HashSet<string> characters = new HashSet<string>();
            foreach (DataRow row in charactersTable.Rows)
            {
                characters.Add(row["name"].ToString());
            }

            foreach (Control control in charPanel.Controls)
            {
                if (control is Button)
                {
                    control.Visible = characters.Contains(control.Text);
                }
            }
        }


        //Database database = new Database();
        //public List<string> GetUniqueElements()
        //{
        //    List<string> elements = new List<string>();

        //    string query = "SELECT DISTINCT name_element FROM element_db";

        //    using (SqlConnection connection = database.getConnection())
        //    {
        //        connection.Open(); // Открываем соединение
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    elements.Add(reader.GetString(0));
        //                }
        //            }
        //        }
        //    }

        //    return elements;
        //}

        //public List<string> GetCharactersByElement(string element)
        //{
        //    List<string> characters = new List<string>();

        //    string query = $"SELECT name FROM char_element WHERE element_id = (SELECT id FROM element_db WHERE name_element = '{element}')";

        //    using (SqlConnection connection = database.getConnection())
        //    {
        //        connection.Open(); // Открываем соединение
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    characters.Add(reader.GetString(0));
        //                }
        //            }
        //        }
        //    }

        //    return characters;
        //}
    }
}

