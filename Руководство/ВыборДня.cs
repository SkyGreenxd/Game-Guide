using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Руководство
{
    public partial class ВыборДня : Form
    {
        Database database = new Database();

        public ВыборДня()
        {
            InitializeComponent();
        }

        private void Назад_Click(object sender, EventArgs e)
        {
            Меню oldForm = new Меню();

            // Закрытие текущей формы
            this.Hide();

            // Отображение предыдущей формы как модальной
            oldForm.ShowDialog();
        }


        protected void selectDay(string nameDay)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            // Выбор дня
            DataTable table = new DataTable();

            string querystring = $"SELECT resources.name_resource, day_resources.name_resource FROM day_resources INNER JOIN resources ON day_resources.resources_id = resources.id WHERE day_resources.day = '{nameDay}'";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = command;

            adapter.Fill(table);
            List<string> res = new List<string>();
            foreach (DataRow row in table.Rows)
            {
                res.Add(row["name_resource"].ToString());
            }

            

            // Применение
            День DayInfo = new День();
            
            this.Hide();

            DayInfo.SetDay(nameDay, res[0], res[1], res[2], res[3], res[4], res[5], res[6], res[7], res[8], res[9], table.Rows[0]["name_resource1"].ToString(), table.Rows[1]["name_resource1"].ToString(), table.Rows[2]["name_resource1"].ToString(), table.Rows[3]["name_resource1"].ToString(), table.Rows[4]["name_resource1"].ToString(), table.Rows[5]["name_resource1"].ToString(), table.Rows[6]["name_resource1"].ToString(), table.Rows[7]["name_resource1"].ToString(), table.Rows[8]["name_resource1"].ToString(), table.Rows[9]["name_resource1"].ToString());

            DayInfo.ShowDialog();
            
        }
        protected void selectVoskr(string nameDay)
        {
            // Воскресенье
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable voskr_table = new DataTable();

            string querystring2 = $"SELECT resources.name_resource, day_resources.name_resource FROM day_resources INNER JOIN resources ON day_resources.resources_id = resources.id WHERE day_resources.day = '{nameDay}'";

            SqlCommand command2 = new SqlCommand(querystring2, database.getConnection());

            adapter.SelectCommand = command2;

            adapter.Fill(voskr_table);
            List<string> v_res = new List<string>();
            foreach (DataRow row in voskr_table.Rows)
            {
                v_res.Add(row["name_resource"].ToString());
            }

            Воскресенье VInfo = new Воскресенье();
            this.Hide();

            VInfo.SetVoskr(nameDay, v_res[0], v_res[1], v_res[2], v_res[3], v_res[4], v_res[5], v_res[6], v_res[7], v_res[8], v_res[9],
                v_res[10], v_res[11], v_res[12], v_res[13], v_res[14], v_res[15], v_res[16], v_res[17], v_res[18], v_res[19],
                v_res[20], v_res[21], v_res[22], v_res[23], v_res[24], v_res[25], v_res[26], v_res[27], v_res[28], v_res[29],
                voskr_table.Rows[0]["name_resource1"].ToString(), voskr_table.Rows[1]["name_resource1"].ToString(), voskr_table.Rows[2]["name_resource1"].ToString(), voskr_table.Rows[3]["name_resource1"].ToString(), voskr_table.Rows[4]["name_resource1"].ToString(), voskr_table.Rows[5]["name_resource1"].ToString(), voskr_table.Rows[6]["name_resource1"].ToString(), voskr_table.Rows[7]["name_resource1"].ToString(), voskr_table.Rows[8]["name_resource1"].ToString(), voskr_table.Rows[9]["name_resource1"].ToString(),
                voskr_table.Rows[10]["name_resource1"].ToString(), voskr_table.Rows[11]["name_resource1"].ToString(), voskr_table.Rows[12]["name_resource1"].ToString(), voskr_table.Rows[13]["name_resource1"].ToString(), voskr_table.Rows[14]["name_resource1"].ToString(), voskr_table.Rows[15]["name_resource1"].ToString(), voskr_table.Rows[16]["name_resource1"].ToString(), voskr_table.Rows[17]["name_resource1"].ToString(), voskr_table.Rows[8]["name_resource1"].ToString(), voskr_table.Rows[19]["name_resource1"].ToString(),
                voskr_table.Rows[20]["name_resource1"].ToString(), voskr_table.Rows[21]["name_resource1"].ToString(), voskr_table.Rows[22]["name_resource1"].ToString(), voskr_table.Rows[23]["name_resource1"].ToString(), voskr_table.Rows[24]["name_resource1"].ToString(), voskr_table.Rows[25]["name_resource1"].ToString(), voskr_table.Rows[26]["name_resource1"].ToString(), voskr_table.Rows[27]["name_resource1"].ToString(), voskr_table.Rows[28]["name_resource1"].ToString(), voskr_table.Rows[29]["name_resource1"].ToString());
            
            VInfo.ShowDialog();
        }
        private void Ponedelnik_Click(object sender, EventArgs e)
        {
            selectDay(Ponedelnik.Text);
        }
        private void Vtornik_Click(object sender, EventArgs e)
        {
            selectDay(Vtornik.Text);
        }
        private void Sreda_Click(object sender, EventArgs e)
        {
            selectDay(Sreda.Text);
        }
        private void Chetverg_Click(object sender, EventArgs e)
        {
            selectDay(Chetverg.Text);
        }
        private void Pyatnica_Click(object sender, EventArgs e)
        {
            selectDay(Pyatnica.Text);
        }

        private void Subbota_Click(object sender, EventArgs e)
        {
            selectDay(Subbota.Text);
        }

        private void Voskresenye_Click(object sender, EventArgs e)
        {
            selectVoskr(Voskresenye.Text);
        }
    }
}


    
