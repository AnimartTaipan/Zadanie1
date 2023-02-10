namespace Currency_Panel
{
    partial class SpecificCurrencyPanel
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.favoriteCheckBox = new System.Windows.Forms.CheckBox();
            this.currencyChangePictureBox = new System.Windows.Forms.PictureBox();
            this.currencyChangeLabel = new System.Windows.Forms.Label();
            this.currencyChangePercLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.currencyValueLabel = new System.Windows.Forms.Label();
            this.сcurrencyNameLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyChangePictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.favoriteCheckBox);
            this.panel2.Controls.Add(this.currencyChangePictureBox);
            this.panel2.Controls.Add(this.currencyChangeLabel);
            this.panel2.Controls.Add(this.currencyChangePercLabel);
            this.panel2.Location = new System.Drawing.Point(190, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 100);
            this.panel2.TabIndex = 6;
            // 
            // favoriteCheckBox
            // 
            this.favoriteCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.favoriteCheckBox.BackgroundImage = global::Currency_Panel.Properties.Resources.unfavorite_star;
            this.favoriteCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.favoriteCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.favoriteCheckBox.FlatAppearance.BorderSize = 0;
            this.favoriteCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.favoriteCheckBox.Location = new System.Drawing.Point(161, 7);
            this.favoriteCheckBox.Name = "favoriteCheckBox";
            this.favoriteCheckBox.Size = new System.Drawing.Size(17, 17);
            this.favoriteCheckBox.TabIndex = 3;
            this.favoriteCheckBox.UseVisualStyleBackColor = true;
            this.favoriteCheckBox.CheckedChanged += new System.EventHandler(this.favoriteCheckBox_CheckedChanged);
            // 
            // currencyChangePictureBox
            // 
            this.currencyChangePictureBox.Image = global::Currency_Panel.Properties.Resources.Decline_image;
            this.currencyChangePictureBox.Location = new System.Drawing.Point(3, 13);
            this.currencyChangePictureBox.Name = "currencyChangePictureBox";
            this.currencyChangePictureBox.Size = new System.Drawing.Size(23, 23);
            this.currencyChangePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.currencyChangePictureBox.TabIndex = 2;
            this.currencyChangePictureBox.TabStop = false;
            // 
            // currencyChangeLabel
            // 
            this.currencyChangeLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currencyChangeLabel.Location = new System.Drawing.Point(5, 35);
            this.currencyChangeLabel.Name = "currencyChangeLabel";
            this.currencyChangeLabel.Size = new System.Drawing.Size(180, 65);
            this.currencyChangeLabel.TabIndex = 1;
            this.currencyChangeLabel.Text = "[Разн]";
            this.currencyChangeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // currencyChangePercLabel
            // 
            this.currencyChangePercLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currencyChangePercLabel.Location = new System.Drawing.Point(32, 13);
            this.currencyChangePercLabel.Name = "currencyChangePercLabel";
            this.currencyChangePercLabel.Size = new System.Drawing.Size(125, 23);
            this.currencyChangePercLabel.TabIndex = 0;
            this.currencyChangePercLabel.Text = "[Разница в %]";
            this.currencyChangePercLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.currencyValueLabel);
            this.panel1.Controls.Add(this.сcurrencyNameLabel);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 100);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.pictureBox1.Location = new System.Drawing.Point(183, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(3, 90);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // currencyValueLabel
            // 
            this.currencyValueLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currencyValueLabel.Location = new System.Drawing.Point(0, 35);
            this.currencyValueLabel.Name = "currencyValueLabel";
            this.currencyValueLabel.Size = new System.Drawing.Size(180, 65);
            this.currencyValueLabel.TabIndex = 1;
            this.currencyValueLabel.Text = "[Знач]";
            this.currencyValueLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // сcurrencyNameLabel
            // 
            this.сcurrencyNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.сcurrencyNameLabel.Location = new System.Drawing.Point(0, 13);
            this.сcurrencyNameLabel.Name = "сcurrencyNameLabel";
            this.сcurrencyNameLabel.Size = new System.Drawing.Size(190, 23);
            this.сcurrencyNameLabel.TabIndex = 0;
            this.сcurrencyNameLabel.Text = "[Название валюты]";
            this.сcurrencyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SpecificCurrencyPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SpecificCurrencyPanel";
            this.Size = new System.Drawing.Size(380, 110);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.currencyChangePictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel2;
        private PictureBox currencyChangePictureBox;
        private Label currencyChangePercLabel;
        private Panel panel1;
        private Label currencyValueLabel;
        private Label сcurrencyNameLabel;
        private Label currencyChangeLabel;
        private CheckBox favoriteCheckBox;
        private PictureBox pictureBox1;
    }
}
