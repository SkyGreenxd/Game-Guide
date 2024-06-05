using System.Windows.Forms;

namespace Руководство
{
    partial class TIERLIST
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TIERLIST));
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.image_container = new System.Windows.Forms.FlowLayoutPanel();
            this.tierListTable = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tier_4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.tier_1 = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel0 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tier_2 = new System.Windows.Forms.RichTextBox();
            this.tier_3 = new System.Windows.Forms.RichTextBox();
            this.nazad = new System.Windows.Forms.Button();
            this.Reboot = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.tierListTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(787, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(147, 63);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Добавить строку";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(962, 12);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(147, 63);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Удалить строку";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // image_container
            // 
            this.image_container.AutoScroll = true;
            this.image_container.Location = new System.Drawing.Point(787, 93);
            this.image_container.Name = "image_container";
            this.image_container.Size = new System.Drawing.Size(285, 921);
            this.image_container.TabIndex = 13;
            // 
            // tierListTable
            // 
            this.tierListTable.AutoScroll = true;
            this.tierListTable.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tierListTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tierListTable.ColumnCount = 2;
            this.tierListTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tierListTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 580F));
            this.tierListTable.Controls.Add(this.flowLayoutPanel4, 1, 4);
            this.tierListTable.Controls.Add(this.richTextBox2, 0, 5);
            this.tierListTable.Controls.Add(this.richTextBox1, 0, 4);
            this.tierListTable.Controls.Add(this.tier_4, 0, 3);
            this.tierListTable.Controls.Add(this.richTextBox3, 0, 6);
            this.tierListTable.Controls.Add(this.tier_1, 0, 0);
            this.tierListTable.Controls.Add(this.flowLayoutPanel0, 1, 0);
            this.tierListTable.Controls.Add(this.flowLayoutPanel2, 1, 2);
            this.tierListTable.Controls.Add(this.flowLayoutPanel3, 1, 3);
            this.tierListTable.Controls.Add(this.flowLayoutPanel5, 1, 5);
            this.tierListTable.Controls.Add(this.flowLayoutPanel6, 1, 6);
            this.tierListTable.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tierListTable.Controls.Add(this.tier_2, 0, 1);
            this.tierListTable.Controls.Add(this.tier_3, 0, 2);
            this.tierListTable.Location = new System.Drawing.Point(42, 93);
            this.tierListTable.Name = "tierListTable";
            this.tierListTable.RowCount = 7;
            this.tierListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tierListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tierListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tierListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tierListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tierListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tierListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tierListTable.Size = new System.Drawing.Size(700, 933);
            this.tierListTable.TabIndex = 14;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Location = new System.Drawing.Point(131, 533);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(501, 124);
            this.flowLayoutPanel4.TabIndex = 32;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox2.AutoSize = true;
            this.richTextBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox2.Location = new System.Drawing.Point(5, 665);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(118, 124);
            this.richTextBox2.TabIndex = 20;
            this.richTextBox2.Text = "Плохо";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox1.AutoSize = true;
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(5, 533);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(118, 124);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "Не очень";
            // 
            // tier_4
            // 
            this.tier_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tier_4.AutoSize = true;
            this.tier_4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tier_4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tier_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tier_4.ForeColor = System.Drawing.SystemColors.Window;
            this.tier_4.Location = new System.Drawing.Point(5, 401);
            this.tier_4.Name = "tier_4";
            this.tier_4.Size = new System.Drawing.Size(118, 124);
            this.tier_4.TabIndex = 22;
            this.tier_4.Text = "Удовлетворительно";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox3.AutoSize = true;
            this.richTextBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox3.Location = new System.Drawing.Point(5, 797);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(118, 124);
            this.richTextBox3.TabIndex = 23;
            this.richTextBox3.Text = "Ужасно";
            // 
            // tier_1
            // 
            this.tier_1.AutoSize = true;
            this.tier_1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tier_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tier_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tier_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tier_1.ForeColor = System.Drawing.SystemColors.Window;
            this.tier_1.Location = new System.Drawing.Point(5, 5);
            this.tier_1.Name = "tier_1";
            this.tier_1.Size = new System.Drawing.Size(118, 124);
            this.tier_1.TabIndex = 19;
            this.tier_1.Text = "Лучший";
            // 
            // flowLayoutPanel0
            // 
            this.flowLayoutPanel0.Location = new System.Drawing.Point(131, 5);
            this.flowLayoutPanel0.Name = "flowLayoutPanel0";
            this.flowLayoutPanel0.Size = new System.Drawing.Size(501, 124);
            this.flowLayoutPanel0.TabIndex = 24;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(131, 269);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(501, 124);
            this.flowLayoutPanel2.TabIndex = 26;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Location = new System.Drawing.Point(131, 401);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(501, 124);
            this.flowLayoutPanel3.TabIndex = 27;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Location = new System.Drawing.Point(131, 665);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(501, 124);
            this.flowLayoutPanel5.TabIndex = 29;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Location = new System.Drawing.Point(131, 797);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(501, 124);
            this.flowLayoutPanel6.TabIndex = 30;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(131, 137);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(501, 124);
            this.flowLayoutPanel1.TabIndex = 31;
            // 
            // tier_2
            // 
            this.tier_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tier_2.AutoSize = true;
            this.tier_2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tier_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tier_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tier_2.ForeColor = System.Drawing.SystemColors.Window;
            this.tier_2.Location = new System.Drawing.Point(5, 137);
            this.tier_2.Name = "tier_2";
            this.tier_2.Size = new System.Drawing.Size(118, 124);
            this.tier_2.TabIndex = 20;
            this.tier_2.Text = "Отлично";
            // 
            // tier_3
            // 
            this.tier_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tier_3.AutoSize = true;
            this.tier_3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tier_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tier_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tier_3.ForeColor = System.Drawing.SystemColors.Window;
            this.tier_3.Location = new System.Drawing.Point(5, 269);
            this.tier_3.Name = "tier_3";
            this.tier_3.Size = new System.Drawing.Size(118, 124);
            this.tier_3.TabIndex = 21;
            this.tier_3.Text = "Хорошо";
            // 
            // nazad
            // 
            this.nazad.Location = new System.Drawing.Point(20, 12);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(75, 41);
            this.nazad.TabIndex = 10;
            this.nazad.Text = "Назад";
            this.nazad.UseVisualStyleBackColor = true;
            this.nazad.Click += new System.EventHandler(this.Назад);
            // 
            // Reboot
            // 
            this.Reboot.BackColor = System.Drawing.SystemColors.Window;
            this.Reboot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Reboot.BackgroundImage")));
            this.Reboot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Reboot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reboot.ForeColor = System.Drawing.SystemColors.Window;
            this.Reboot.Location = new System.Drawing.Point(513, 12);
            this.Reboot.Name = "Reboot";
            this.Reboot.Size = new System.Drawing.Size(64, 63);
            this.Reboot.TabIndex = 15;
            this.Reboot.UseVisualStyleBackColor = false;
            this.Reboot.Click += new System.EventHandler(this.Reboot_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(614, 12);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(145, 63);
            this.Save.TabIndex = 16;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // TIERLIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1165, 788);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Reboot);
            this.Controls.Add(this.tierListTable);
            this.Controls.Add(this.image_container);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.nazad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TIERLIST";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Создание собственного Тир-Листа";
            this.tierListTable.ResumeLayout(false);
            this.tierListTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.FlowLayoutPanel image_container;
        private System.Windows.Forms.TableLayoutPanel tierListTable;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox tier_4;
        private System.Windows.Forms.RichTextBox tier_3;
        private System.Windows.Forms.RichTextBox tier_2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox tier_1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel0;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private Button Reboot;
        private Button Save;
    }
}