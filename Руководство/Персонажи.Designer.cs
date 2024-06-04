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
            this.button2 = new System.Windows.Forms.Button();
            this.Сяо = new System.Windows.Forms.Button();
            this.Кадзуха = new System.Windows.Forms.Button();
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
            this.elements.FormattingEnabled = true;
            this.elements.Location = new System.Drawing.Point(127, 23);
            this.elements.Name = "elements";
            this.elements.Size = new System.Drawing.Size(170, 21);
            this.elements.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 174);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Сяо
            // 
            this.Сяо.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Сяо.BackgroundImage")));
            this.Сяо.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Сяо.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Сяо.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Сяо.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Сяо.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Сяо.Location = new System.Drawing.Point(158, 59);
            this.Сяо.Name = "Сяо";
            this.Сяо.Size = new System.Drawing.Size(139, 174);
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
            this.Кадзуха.Location = new System.Drawing.Point(11, 59);
            this.Кадзуха.Name = "Кадзуха";
            this.Кадзуха.Size = new System.Drawing.Size(141, 174);
            this.Кадзуха.TabIndex = 3;
            this.Кадзуха.Text = "Кадзуха";
            this.Кадзуха.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Кадзуха.UseVisualStyleBackColor = false;
            this.Кадзуха.Click += new System.EventHandler(this.Казуха_Click);
            // 
            // Персонажи
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(309, 573);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.elements);
            this.Controls.Add(this.Сяо);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Кадзуха);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Персонажи";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Персонажи";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Кадзуха;
        private System.Windows.Forms.Button Сяо;
        private System.Windows.Forms.ComboBox elements;
        private System.Windows.Forms.Button button2;
    }
}