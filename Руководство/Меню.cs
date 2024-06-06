using System;
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

            newForm.Show();

            this.Hide();
        }
        private void Калькулятор(object sender, EventArgs e)
        {
            Калькулятор newForm = new Калькулятор();
            newForm.Show();
            this.Hide();
        }
        private void Выход_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Ресурсы(object sender, EventArgs e)
        {
            choiceDay newForm = new choiceDay();
            newForm.Show();
            this.Hide();
        }
        private void ТирЛист(object sender, EventArgs e)
        {
            TIERLIST newForm = new TIERLIST();
            newForm.Show();
            this.Hide();
        }
    }
}