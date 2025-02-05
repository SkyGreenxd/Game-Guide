using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Руководство
{
    public partial class choiceDay : Form
    {
        Database database = new Database();
        private CharacterRepository characterRepository;
        public choiceDay()
        {
            InitializeComponent();
            characterRepository = new CharacterRepository(database);
        }
        private void Назад_Click(object sender, EventArgs e)
        {
            Меню oldForm = new Меню();
            this.Hide();
            oldForm.ShowDialog();
        }
        protected void selectDay(string nameDay)
        {
            DataTable dayTable = characterRepository.GetResourcesByDay(nameDay);
            List<string> res = new List<string>();
            foreach (DataRow row in dayTable.Rows)
            {
                res.Add(row["name_resource"].ToString());
            }
            Ресурсы VInfo = new Ресурсы();
            Hide();
            string[] Images = characterRepository.InitializeArrayFromList(res);
            string[] dtextNames = characterRepository.InitializeArrayFromDataTable(dayTable, "name_resource1");
            VInfo.SetDay(nameDay, Images, dtextNames);
            VInfo.ShowDialog();
        }
        protected void selectVoskr(string nameDay)
        {
            DataTable voskrTable = characterRepository.GetResourcesBySunday(nameDay);
            List<string> v_res = new List<string>();
            foreach (DataRow row in voskrTable.Rows)
            {
                v_res.Add(row["name_resource"].ToString());
            }
            Ресурсы VInfo = new Ресурсы();
            Hide();
            string[] Images = characterRepository.InitializeArrayFromList(v_res);
            string[] dtextNames = characterRepository.InitializeArrayFromDataTable(voskrTable, "name_resource1");
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


    
