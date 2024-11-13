using System;
using System.Windows.Forms;

namespace Руководство
{
    public partial class TIERLIST : Form
    {
        private TierlistManager tierlistManager;

        public TIERLIST()
        {
            InitializeComponent();
            Database database = new Database();
            tierlistManager = new TierlistManager(database);
            tierlistManager.InitializeTierList(tierListTable, image_container);
        }
        private void Назад(object sender, EventArgs e)
        {
            Меню oldForm = new Меню();
            this.Hide();
            oldForm.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            tierlistManager.DeleteRow(tierListTable, image_container);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            tierlistManager.AddRow(tierListTable);
        }

        private void Reboot_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            tierlistManager.Reboot(tierListTable, image_container);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            tierlistManager.SaveTierList(tierListTable);
        }
    }
}
