using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Руководство
{
    public partial class Меню : Form
    {
        public Меню()
        {
            InitializeComponent();
        }

        private void Персонажи(object sender, EventArgs e)
        {
            Персонажи newForm = new Персонажи();

            // Показ новой формы
            newForm.Show();

            // Закрытие текущей формы
            this.Hide();
        }

        private void Калькулятор(object sender, EventArgs e)
        {
            Калькулятор newForm = new Калькулятор();

            // Показ новой формы
            newForm.Show();

            // Закрытие текущей формы
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Календарь(object sender, EventArgs e)
        {
            ВыборДня newForm = new ВыборДня();

            // Показ новой формы
            newForm.Show();

            // Закрытие текущей формы
            this.Hide();
        }

        private void ТирЛист(object sender, EventArgs e)
        {
            // ТирЛист newForm = new ТирЛист();
            //тирлистдемо newForm = new тирлистдемо();
            лист_из_flow newForm = new лист_из_flow();

            // Показ новой формы
            newForm.Show();

            // Закрытие текущей формы
            this.Hide();
        }
    }
}
