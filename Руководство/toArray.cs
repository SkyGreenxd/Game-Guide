using System.Collections.Generic;
using System.Data;

namespace Руководство
{
    internal class toArray
    {
        public string[] InitializeArrayFromList(List<string> list)
        {
            string[] array = new string[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                array[i] = list[i];
            }
            return array;
        }
        public string[] InitializeArrayFromDataTable(DataTable table, string columnName)
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
