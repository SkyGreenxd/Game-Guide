namespace Руководство
{
    partial class choiceDay
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
            this.Ponedelnik = new System.Windows.Forms.Button();
            this.Sreda = new System.Windows.Forms.Button();
            this.Vtornik = new System.Windows.Forms.Button();
            this.Chetverg = new System.Windows.Forms.Button();
            this.Pyatnica = new System.Windows.Forms.Button();
            this.Subbota = new System.Windows.Forms.Button();
            this.Voskresenye = new System.Windows.Forms.Button();
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
            // Ponedelnik
            // 
            this.Ponedelnik.Location = new System.Drawing.Point(87, 104);
            this.Ponedelnik.Name = "Ponedelnik";
            this.Ponedelnik.Size = new System.Drawing.Size(132, 51);
            this.Ponedelnik.TabIndex = 1;
            this.Ponedelnik.Text = "Понедельник";
            this.Ponedelnik.UseVisualStyleBackColor = true;
            this.Ponedelnik.Click += new System.EventHandler(this.Ponedelnik_Click);
            // 
            // Sreda
            // 
            this.Sreda.Location = new System.Drawing.Point(87, 238);
            this.Sreda.Name = "Sreda";
            this.Sreda.Size = new System.Drawing.Size(132, 51);
            this.Sreda.TabIndex = 2;
            this.Sreda.Text = "Среда";
            this.Sreda.UseVisualStyleBackColor = true;
            this.Sreda.Click += new System.EventHandler(this.Sreda_Click);
            // 
            // Vtornik
            // 
            this.Vtornik.Location = new System.Drawing.Point(87, 167);
            this.Vtornik.Name = "Vtornik";
            this.Vtornik.Size = new System.Drawing.Size(132, 51);
            this.Vtornik.TabIndex = 3;
            this.Vtornik.Text = "Вторник";
            this.Vtornik.UseVisualStyleBackColor = true;
            this.Vtornik.Click += new System.EventHandler(this.Vtornik_Click);
            // 
            // Chetverg
            // 
            this.Chetverg.Location = new System.Drawing.Point(87, 310);
            this.Chetverg.Name = "Chetverg";
            this.Chetverg.Size = new System.Drawing.Size(132, 51);
            this.Chetverg.TabIndex = 4;
            this.Chetverg.Text = "Четверг";
            this.Chetverg.UseVisualStyleBackColor = true;
            this.Chetverg.Click += new System.EventHandler(this.Chetverg_Click);
            // 
            // Pyatnica
            // 
            this.Pyatnica.Location = new System.Drawing.Point(87, 382);
            this.Pyatnica.Name = "Pyatnica";
            this.Pyatnica.Size = new System.Drawing.Size(132, 51);
            this.Pyatnica.TabIndex = 5;
            this.Pyatnica.Text = "Пятница";
            this.Pyatnica.UseVisualStyleBackColor = true;
            this.Pyatnica.Click += new System.EventHandler(this.Pyatnica_Click);
            // 
            // Subbota
            // 
            this.Subbota.Location = new System.Drawing.Point(87, 449);
            this.Subbota.Name = "Subbota";
            this.Subbota.Size = new System.Drawing.Size(132, 51);
            this.Subbota.TabIndex = 6;
            this.Subbota.Text = "Суббота";
            this.Subbota.UseVisualStyleBackColor = true;
            this.Subbota.Click += new System.EventHandler(this.Subbota_Click);
            // 
            // Voskresenye
            // 
            this.Voskresenye.Location = new System.Drawing.Point(87, 515);
            this.Voskresenye.Name = "Voskresenye";
            this.Voskresenye.Size = new System.Drawing.Size(132, 51);
            this.Voskresenye.TabIndex = 7;
            this.Voskresenye.Text = "Воскресенье";
            this.Voskresenye.UseVisualStyleBackColor = true;
            this.Voskresenye.Click += new System.EventHandler(this.Voskresenye_Click);
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
            // choiceDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 573);
            this.Controls.Add(this.Назад);
            this.Controls.Add(this.Voskresenye);
            this.Controls.Add(this.Subbota);
            this.Controls.Add(this.Pyatnica);
            this.Controls.Add(this.Chetverg);
            this.Controls.Add(this.Vtornik);
            this.Controls.Add(this.Sreda);
            this.Controls.Add(this.Ponedelnik);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "choiceDay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор Дня";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Ponedelnik;
        private System.Windows.Forms.Button Sreda;
        private System.Windows.Forms.Button Vtornik;
        private System.Windows.Forms.Button Chetverg;
        private System.Windows.Forms.Button Pyatnica;
        private System.Windows.Forms.Button Subbota;
        private System.Windows.Forms.Button Voskresenye;
        private System.Windows.Forms.Button Назад;
    }
}