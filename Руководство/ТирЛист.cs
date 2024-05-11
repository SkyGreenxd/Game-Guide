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
    public partial class ТирЛист : Form
    {
        public ТирЛист()
        {
            InitializeComponent();
        }

        private void Назад(object sender, EventArgs e)
        {
            Меню oldForm = new Меню();

            // Закрытие текущей формы
            this.Hide();

            // Отображение предыдущей формы как модальной
            oldForm.ShowDialog();
        }
    }
}
