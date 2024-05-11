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
    public partial class Информация_о_персонажах : Form
    {
        public Информация_о_персонажах()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Персонажи oldForm = new Персонажи();

            // Закрытие текущей формы
            this.Hide();

            // Отображение предыдущей формы как модальной
            oldForm.ShowDialog();
        }


    }
}
