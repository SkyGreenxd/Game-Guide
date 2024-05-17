using System.Windows.Forms;

namespace Руководство
{
    partial class ТирЛист
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
            this.button1 = new System.Windows.Forms.Button();
            this.tierListTable = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tier_4 = new System.Windows.Forms.RichTextBox();
            this.tier_3 = new System.Windows.Forms.RichTextBox();
            this.tier_2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.tier_1 = new System.Windows.Forms.RichTextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.image_container = new System.Windows.Forms.FlowLayoutPanel();
            this.tierListTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Назад);
            // 
            // tierListTable
            // 
            this.tierListTable.AutoScroll = true;
            this.tierListTable.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tierListTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tierListTable.ColumnCount = 5;
            this.tierListTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tierListTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tierListTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tierListTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tierListTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tierListTable.Controls.Add(this.richTextBox2, 0, 5);
            this.tierListTable.Controls.Add(this.richTextBox1, 0, 4);
            this.tierListTable.Controls.Add(this.tier_4, 0, 3);
            this.tierListTable.Controls.Add(this.tier_3, 0, 2);
            this.tierListTable.Controls.Add(this.tier_2, 0, 1);
            this.tierListTable.Controls.Add(this.richTextBox3, 0, 6);
            this.tierListTable.Controls.Add(this.tier_1, 0, 0);
            this.tierListTable.Location = new System.Drawing.Point(119, 105);
            this.tierListTable.Name = "tierListTable";
            this.tierListTable.RowCount = 7;
            this.tierListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tierListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tierListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tierListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tierListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tierListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tierListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tierListTable.Size = new System.Drawing.Size(650, 507);
            this.tierListTable.TabIndex = 4;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox2.AutoSize = true;
            this.richTextBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox2.Location = new System.Drawing.Point(5, 635);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(118, 118);
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
            this.richTextBox1.Location = new System.Drawing.Point(5, 509);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(118, 118);
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
            this.tier_4.Location = new System.Drawing.Point(5, 383);
            this.tier_4.Name = "tier_4";
            this.tier_4.Size = new System.Drawing.Size(118, 118);
            this.tier_4.TabIndex = 22;
            this.tier_4.Text = "Удовлетворительно";
            // 
            // tier_3
            // 
            this.tier_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tier_3.AutoSize = true;
            this.tier_3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tier_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tier_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tier_3.ForeColor = System.Drawing.SystemColors.Window;
            this.tier_3.Location = new System.Drawing.Point(5, 257);
            this.tier_3.Name = "tier_3";
            this.tier_3.Size = new System.Drawing.Size(118, 118);
            this.tier_3.TabIndex = 21;
            this.tier_3.Text = "Хорошо";
            // 
            // tier_2
            // 
            this.tier_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tier_2.AutoSize = true;
            this.tier_2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tier_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tier_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tier_2.ForeColor = System.Drawing.SystemColors.Window;
            this.tier_2.Location = new System.Drawing.Point(5, 131);
            this.tier_2.Name = "tier_2";
            this.tier_2.Size = new System.Drawing.Size(118, 118);
            this.tier_2.TabIndex = 20;
            this.tier_2.Text = "Отлично";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox3.AutoSize = true;
            this.richTextBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox3.Location = new System.Drawing.Point(5, 761);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(118, 118);
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
            this.tier_1.Size = new System.Drawing.Size(118, 118);
            this.tier_1.TabIndex = 19;
            this.tier_1.Text = "Лучший";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(954, 12);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(147, 63);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Удалить строку";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(779, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(147, 63);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Добавить строку";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // pic5
            // 
            this.pic5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic5.Location = new System.Drawing.Point(799, 110);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(118, 118);
            this.pic5.TabIndex = 5;
            this.pic5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // image_container
            // 
            this.image_container.AutoScroll = true;
            this.image_container.Location = new System.Drawing.Point(799, 253);
            this.image_container.Name = "image_container";
            this.image_container.Size = new System.Drawing.Size(285, 327);
            this.image_container.TabIndex = 9;
            // 
            // ТирЛист
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1113, 624);
            this.Controls.Add(this.image_container);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic5);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.tierListTable);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ТирЛист";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ТирЛист";
            this.tierListTable.ResumeLayout(false);
            this.tierListTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tierListTable;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.RichTextBox tier_1;
        private RichTextBox tier_4;
        private RichTextBox tier_3;
        private RichTextBox tier_2;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox3;
        private Label label1;
        private FlowLayoutPanel image_container;
    }
}