using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Руководство
{
    internal class characterFilter
    {
        private Database database;
        private ComboBox comboBoxElements;
        private Panel charPanel;
        private CharacterRepository characterRepository;
        public characterFilter(Database db, ComboBox comboBox, FlowLayoutPanel panel)
        {
            database = db;
            comboBoxElements = comboBox;
            charPanel = panel;
            characterRepository = new CharacterRepository(database);
            LoadElements();
        }
        private void LoadElements()
        {
            DataTable elementsTable = characterRepository.GetLoadElement();

            comboBoxElements.Items.Clear();
            foreach (DataRow row in elementsTable.Rows)
            {
                comboBoxElements.Items.Add(row["name_element"].ToString());
            }
        }
        public void FilterCharacters(string selectedElement)
        {
            DataTable charactersTable = characterRepository.GetFilterCharacters(selectedElement);

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
    }
}

