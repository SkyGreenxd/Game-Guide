namespace Руководство
{
    partial class ВыборДня
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
            this.label1 = new System.Windows.Forms.Label();
            this.Понедельник = new System.Windows.Forms.Button();
            this.Среда = new System.Windows.Forms.Button();
            this.Вторник = new System.Windows.Forms.Button();
            this.Четверг = new System.Windows.Forms.Button();
            this.Пятница = new System.Windows.Forms.Button();
            this.Суббота = new System.Windows.Forms.Button();
            this.Воскресенье = new System.Windows.Forms.Button();
            this.Назад = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите день";
            // 
            // Понедельник
            // 
            this.Понедельник.Location = new System.Drawing.Point(87, 104);
            this.Понедельник.Name = "Понедельник";
            this.Понедельник.Size = new System.Drawing.Size(132, 51);
            this.Понедельник.TabIndex = 1;
            this.Понедельник.Text = "Понедельник";
            this.Понедельник.UseVisualStyleBackColor = true;
            // 
            // Среда
            // 
            this.Среда.Location = new System.Drawing.Point(87, 238);
            this.Среда.Name = "Среда";
            this.Среда.Size = new System.Drawing.Size(132, 51);
            this.Среда.TabIndex = 2;
            this.Среда.Text = "Среда";
            this.Среда.UseVisualStyleBackColor = true;
            // 
            // Вторник
            // 
            this.Вторник.Location = new System.Drawing.Point(87, 167);
            this.Вторник.Name = "Вторник";
            this.Вторник.Size = new System.Drawing.Size(132, 51);
            this.Вторник.TabIndex = 3;
            this.Вторник.Text = "Вторник";
            this.Вторник.UseVisualStyleBackColor = true;
            // 
            // Четверг
            // 
            this.Четверг.Location = new System.Drawing.Point(87, 310);
            this.Четверг.Name = "Четверг";
            this.Четверг.Size = new System.Drawing.Size(132, 51);
            this.Четверг.TabIndex = 4;
            this.Четверг.Text = "Четверг";
            this.Четверг.UseVisualStyleBackColor = true;
            // 
            // Пятница
            // 
            this.Пятница.Location = new System.Drawing.Point(87, 382);
            this.Пятница.Name = "Пятница";
            this.Пятница.Size = new System.Drawing.Size(132, 51);
            this.Пятница.TabIndex = 5;
            this.Пятница.Text = "Пятница";
            this.Пятница.UseVisualStyleBackColor = true;
            // 
            // Суббота
            // 
            this.Суббота.Location = new System.Drawing.Point(87, 449);
            this.Суббота.Name = "Суббота";
            this.Суббота.Size = new System.Drawing.Size(132, 51);
            this.Суббота.TabIndex = 6;
            this.Суббота.Text = "Суббота";
            this.Суббота.UseVisualStyleBackColor = true;
            // 
            // Воскресенье
            // 
            this.Воскресенье.Location = new System.Drawing.Point(87, 515);
            this.Воскресенье.Name = "Воскресенье";
            this.Воскресенье.Size = new System.Drawing.Size(132, 51);
            this.Воскресенье.TabIndex = 7;
            this.Воскресенье.Text = "Воскресенье";
            this.Воскресенье.UseVisualStyleBackColor = true;
            // 
            // Назад
            // 
            this.Назад.Location = new System.Drawing.Point(12, 12);
            this.Назад.Name = "Назад";
            this.Назад.Size = new System.Drawing.Size(75, 41);
            this.Назад.TabIndex = 8;
            this.Назад.Text = "Назад";
            this.Назад.UseVisualStyleBackColor = true;
            this.Назад.Click += new System.EventHandler(this.Назад_Click);
            // 
            // ВыборДня
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 573);
            this.Controls.Add(this.Назад);
            this.Controls.Add(this.Воскресенье);
            this.Controls.Add(this.Суббота);
            this.Controls.Add(this.Пятница);
            this.Controls.Add(this.Четверг);
            this.Controls.Add(this.Вторник);
            this.Controls.Add(this.Среда);
            this.Controls.Add(this.Понедельник);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ВыборДня";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ВыборДня";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Понедельник;
        private System.Windows.Forms.Button Среда;
        private System.Windows.Forms.Button Вторник;
        private System.Windows.Forms.Button Четверг;
        private System.Windows.Forms.Button Пятница;
        private System.Windows.Forms.Button Суббота;
        private System.Windows.Forms.Button Воскресенье;
        private System.Windows.Forms.Button Назад;
    }
}