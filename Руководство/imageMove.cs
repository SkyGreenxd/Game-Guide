using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Руководство
{
    internal class imageMove
    {
        private Point downPoint;
        private bool moved;
        private Dictionary<TableLayoutPanelCellPosition, Rectangle> dict = new Dictionary<TableLayoutPanelCellPosition, Rectangle>();
        private TableLayoutPanel tierListTable;
        private Control image_container;
        public imageMove(TableLayoutPanel tierListTable, Control image_container)
        {
            this.tierListTable = tierListTable;
            this.image_container = image_container;
        }
        public void AttachHandlers(PictureBox pictureBox)
        {
            pictureBox.MouseDown += Picture_MouseDown;
            pictureBox.MouseMove += Picture_MouseMove;
            pictureBox.MouseUp += Picture_MouseUp;
        }
        private void Picture_MouseDown(object sender, MouseEventArgs e)
        {
            Control picture = sender as Control;
            if (e.Button == MouseButtons.Right)
            {
                picture.Parent = image_container;
            }
            else
            {
                picture.Parent = image_container.Parent;
                picture.BringToFront();
                downPoint = e.Location;
            }
        }
        private void Picture_MouseMove(object sender, MouseEventArgs e)
        {
            Control picture = sender as Control;
            if (e.Button == MouseButtons.Left)
            {
                picture.Left += e.X - downPoint.X;
                picture.Top += e.Y - downPoint.Y;
                moved = true;
                tierListTable.Invalidate();
            }
        }
        private void Picture_MouseUp(object sender, MouseEventArgs e)
        {
            Control picture = sender as Control;
            if (e.Button == MouseButtons.Left)
            {
                Point currentLocation = tierListTable.PointToClient(Cursor.Position);
                int scrolledY = currentLocation.Y + tierListTable.VerticalScroll.Value;
                for (int row = 0; row < tierListTable.RowCount; row++)
                {
                    FlowLayoutPanel targetFlowLayoutPanel = FindFlowLayoutPanelInRow(row);
                    if (targetFlowLayoutPanel != null)
                    {
                        int top = targetFlowLayoutPanel.Top - tierListTable.VerticalScroll.Value;
                        int bottom = top + targetFlowLayoutPanel.Height;
                        if (scrolledY >= top && scrolledY <= bottom)
                        {
                            targetFlowLayoutPanel.Controls.Add(picture);
                            picture.Focus();
                            EnsurePictureFits(picture, targetFlowLayoutPanel);
                            break;
                        }
                    }
                }
            }
        }
        private FlowLayoutPanel FindFlowLayoutPanelInRow(int rowIndex)
        {
            string flowLayoutPanelName = "flowLayoutPanel" + rowIndex;
            Control[] controlsInRow = tierListTable.Controls.Find(flowLayoutPanelName, true);
            if (controlsInRow.Length > 0 && controlsInRow[0] is FlowLayoutPanel)
            {
                return (FlowLayoutPanel)controlsInRow[0];
            }
            return null;
        }
        private void EnsurePictureFits(Control picture, FlowLayoutPanel flowLayoutPanel)
        {
            int rowIndex = tierListTable.GetRow(flowLayoutPanel);
            if (rowIndex >= 0 && rowIndex < tierListTable.RowStyles.Count)
            {
                int requiredHeight = picture.Bottom + 10;
                if (requiredHeight > tierListTable.RowStyles[rowIndex].Height)
                {
                    tierListTable.RowStyles[rowIndex].Height = requiredHeight + 10;
                    flowLayoutPanel.Height = requiredHeight;
                    int newHeight = 0;
                    for (int i = 0; i < tierListTable.RowStyles.Count; i++)
                    {
                        newHeight += (int)tierListTable.RowStyles[i].Height;
                    }
                    tierListTable.Height = newHeight;
                }
            }
        }
    }
}
