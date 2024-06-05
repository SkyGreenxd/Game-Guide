using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Руководство
{
    public partial class choiceDay : Form
    {
        private toArray toarray;
        Database database = new Database();
        public choiceDay()
        {
            InitializeComponent();
            toarray = new toArray();
        }
        private void Назад_Click(object sender, EventArgs e)
        {
            Меню oldForm = new Меню();
            this.Hide();
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
            //День DayInfo = new День();
            //this.Hide();

            Ресурсы VInfo = new Ресурсы();
            this.Hide();

            string[] Images = toarray.InitializeArrayFromList(res);
            string[] dtextNames = toarray.InitializeArrayFromDataTable(table, "name_resource1");

            VInfo.SetDay(nameDay, Images, dtextNames);
            VInfo.ShowDialog();
            
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

            Ресурсы VInfo = new Ресурсы();
            this.Hide();

            string[] Images = toarray.InitializeArrayFromList(v_res);
            string[] dtextNames = toarray.InitializeArrayFromDataTable(voskr_table, "name_resource1");

            VInfo.SetVoskr(nameDay, Images, dtextNames);
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


    
