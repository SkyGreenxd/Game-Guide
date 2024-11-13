using System.Drawing;

namespace Руководство
{
    partial class Персонажи
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Персонажи));
            this.button1 = new System.Windows.Forms.Button();
            this.elements = new System.Windows.Forms.ComboBox();
            this.Тома = new System.Windows.Forms.Button();
            this.Сяо = new System.Windows.Forms.Button();
            this.Кадзуха = new System.Windows.Forms.Button();
            this.Барбара = new System.Windows.Forms.Button();
            this.ЧжунЛи = new System.Windows.Forms.Button();
            this.ЯэМико = new System.Windows.Forms.Button();
            this.charPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Тигнари = new System.Windows.Forms.Button();
            this.charPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // elements
            // 
            this.elements.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.elements.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.elements.FormattingEnabled = true;
            this.elements.Location = new System.Drawing.Point(131, 19);
            this.elements.Name = "elements";
            this.elements.Size = new System.Drawing.Size(193, 26);
            this.elements.TabIndex = 5;
            // 
            // Тома
            // 
            this.Тома.BackColor = System.Drawing.SystemColors.Window;
            this.Тома.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Тома.BackgroundImage")));
            this.Тома.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Тома.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Тома.FlatAppearance.BorderSize = 3;
            this.Тома.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Тома.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Тома.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Тома.Location = new System.Drawing.Point(3, 199);
            this.Тома.Name = "Тома";
            this.Тома.Size = new System.Drawing.Size(158, 190);
            this.Тома.TabIndex = 6;
            this.Тома.Text = "Тома";
            this.Тома.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Тома.UseVisualStyleBackColor = false;
            this.Тома.Click += new System.EventHandler(this.Тома_Click);
            // 
            // Сяо
            // 
            this.Сяо.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Сяо.BackgroundImage")));
            this.Сяо.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Сяо.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Сяо.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Сяо.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Сяо.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Сяо.Location = new System.Drawing.Point(168, 3);
            this.Сяо.Name = "Сяо";
            this.Сяо.Size = new System.Drawing.Size(159, 190);
            this.Сяо.TabIndex = 4;
            this.Сяо.Text = "Сяо";
            this.Сяо.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Сяо.UseVisualStyleBackColor = false;
            this.Сяо.Click += new System.EventHandler(this.Сяо_Click);
            // 
            // Кадзуха
            // 
            this.Кадзуха.BackColor = System.Drawing.SystemColors.Window;
            this.Кадзуха.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Кадзуха.BackgroundImage")));
            this.Кадзуха.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Кадзуха.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Кадзуха.FlatAppearance.BorderSize = 3;
            this.Кадзуха.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Кадзуха.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Кадзуха.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Кадзуха.Location = new System.Drawing.Point(3, 3);
            this.Кадзуха.Name = "Кадзуха";
            this.Кадзуха.Size = new System.Drawing.Size(159, 190);
            this.Кадзуха.TabIndex = 3;
            this.Кадзуха.Text = "Кадзуха";
            this.Кадзуха.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Кадзуха.UseVisualStyleBackColor = false;
            this.Кадзуха.Click += new System.EventHandler(this.Казуха_Click);
            // 
            // Барбара
            // 
            this.Барбара.BackColor = System.Drawing.SystemColors.Window;
            this.Барбара.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Барбара.BackgroundImage")));
            this.Барбара.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Барбара.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Барбара.FlatAppearance.BorderSize = 3;
            this.Барбара.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Барбара.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Барбара.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Барбара.Location = new System.Drawing.Point(167, 199);
            this.Барбара.Name = "Барбара";
            this.Барбара.Size = new System.Drawing.Size(158, 190);
            this.Барбара.TabIndex = 7;
            this.Барбара.Text = "Барбара";
            this.Барбара.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Барбара.UseVisualStyleBackColor = false;
            this.Барбара.Click += new System.EventHandler(this.Барбара_Click);
            // 
            // ЧжунЛи
            // 
            this.ЧжунЛи.BackColor = System.Drawing.SystemColors.Window;
            this.ЧжунЛи.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ЧжунЛи.BackgroundImage")));
            this.ЧжунЛи.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ЧжунЛи.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ЧжунЛи.FlatAppearance.BorderSize = 3;
            this.ЧжунЛи.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ЧжунЛи.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ЧжунЛи.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ЧжунЛи.Location = new System.Drawing.Point(3, 395);
            this.ЧжунЛи.Name = "ЧжунЛи";
            this.ЧжунЛи.Size = new System.Drawing.Size(158, 190);
            this.ЧжунЛи.TabIndex = 8;
            this.ЧжунЛи.Text = "Чжун Ли";
            this.ЧжунЛи.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ЧжунЛи.UseVisualStyleBackColor = false;
            this.ЧжунЛи.Click += new System.EventHandler(this.ЧжунЛи_Click);
            // 
            // ЯэМико
            // 
            this.ЯэМико.BackColor = System.Drawing.SystemColors.Window;
            this.ЯэМико.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ЯэМико.BackgroundImage")));
            this.ЯэМико.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ЯэМико.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ЯэМико.FlatAppearance.BorderSize = 3;
            this.ЯэМико.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ЯэМико.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ЯэМико.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ЯэМико.Location = new System.Drawing.Point(167, 395);
            this.ЯэМико.Name = "ЯэМико";
            this.ЯэМико.Size = new System.Drawing.Size(158, 190);
            this.ЯэМико.TabIndex = 9;
            this.ЯэМико.Text = "Яэ Мико";
            this.ЯэМико.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ЯэМико.UseVisualStyleBackColor = false;
            this.ЯэМико.Click += new System.EventHandler(this.ЯэМико_Click);
            // 
            // charPanel
            // 
            this.charPanel.AutoScroll = true;
            this.charPanel.Controls.Add(this.Кадзуха);
            this.charPanel.Controls.Add(this.Сяо);
            this.charPanel.Controls.Add(this.Тома);
            this.charPanel.Controls.Add(this.Барбара);
            this.charPanel.Controls.Add(this.ЧжунЛи);
            this.charPanel.Controls.Add(this.ЯэМико);
            this.charPanel.Controls.Add(this.Тигнари);
            this.charPanel.Location = new System.Drawing.Point(12, 59);
            this.charPanel.Name = "charPanel";
            this.charPanel.Size = new System.Drawing.Size(349, 513);
            this.charPanel.TabIndex = 10;
            // 
            // Тигнари
            // 
            this.Тигнари.BackColor = System.Drawing.SystemColors.Window;
            this.Тигнари.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Тигнари.BackgroundImage")));
            this.Тигнари.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Тигнари.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Тигнари.FlatAppearance.BorderSize = 3;
            this.Тигнари.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Тигнари.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Тигнари.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Тигнари.Location = new System.Drawing.Point(3, 591);
            this.Тигнари.Name = "Тигнари";
            this.Тигнари.Size = new System.Drawing.Size(158, 190);
            this.Тигнари.TabIndex = 10;
            this.Тигнари.Text = "Тигнари";
            this.Тигнари.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Тигнари.UseVisualStyleBackColor = false;
            this.Тигнари.Click += new System.EventHandler(this.Тигнари_Click);
            // 
            // Персонажи
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(368, 573);
            this.Controls.Add(this.charPanel);
            this.Controls.Add(this.elements);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Персонажи";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Персонажи";
            this.charPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Кадзуха;
        private System.Windows.Forms.Button Сяо;
        private System.Windows.Forms.ComboBox elements;
        private System.Windows.Forms.Button Тома;
        private System.Windows.Forms.Button Барбара;
        private System.Windows.Forms.Button ЧжунЛи;
        private System.Windows.Forms.Button ЯэМико;
        private System.Windows.Forms.FlowLayoutPanel charPanel;
        private System.Windows.Forms.Button Тигнари;
    }
}