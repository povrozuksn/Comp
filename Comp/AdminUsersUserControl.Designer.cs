namespace Comp
{
    partial class AdminUsersUserControl
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
            this.FindButton = new System.Windows.Forms.Button();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CityComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UsersPanel = new System.Windows.Forms.Panel();
            this.FiltrPanel = new System.Windows.Forms.Panel();
            this.FiltrPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FindButton
            // 
            this.FindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindButton.Location = new System.Drawing.Point(530, 102);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(224, 33);
            this.FindButton.TabIndex = 5;
            this.FindButton.Text = "Выбрать";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgeTextBox.Location = new System.Drawing.Point(315, 105);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(169, 30);
            this.AgeTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(310, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Выберите возраст";
            // 
            // CityComboBox
            // 
            this.CityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CityComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityComboBox.FormattingEnabled = true;
            this.CityComboBox.Location = new System.Drawing.Point(29, 102);
            this.CityComboBox.Name = "CityComboBox";
            this.CityComboBox.Size = new System.Drawing.Size(240, 33);
            this.CityComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фильтр пользователей";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите город";
            // 
            // UsersPanel
            // 
            this.UsersPanel.Location = new System.Drawing.Point(15, 238);
            this.UsersPanel.Name = "UsersPanel";
            this.UsersPanel.Size = new System.Drawing.Size(931, 343);
            this.UsersPanel.TabIndex = 3;
            // 
            // FiltrPanel
            // 
            this.FiltrPanel.Controls.Add(this.FindButton);
            this.FiltrPanel.Controls.Add(this.AgeTextBox);
            this.FiltrPanel.Controls.Add(this.label3);
            this.FiltrPanel.Controls.Add(this.CityComboBox);
            this.FiltrPanel.Controls.Add(this.label2);
            this.FiltrPanel.Controls.Add(this.label1);
            this.FiltrPanel.Location = new System.Drawing.Point(15, 33);
            this.FiltrPanel.Name = "FiltrPanel";
            this.FiltrPanel.Size = new System.Drawing.Size(931, 199);
            this.FiltrPanel.TabIndex = 2;
            // 
            // AdminUsersUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UsersPanel);
            this.Controls.Add(this.FiltrPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminUsersUserControl";
            this.Size = new System.Drawing.Size(960, 615);
            this.Load += new System.EventHandler(this.AdminUsersUserControl_Load);
            this.FiltrPanel.ResumeLayout(false);
            this.FiltrPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CityComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel UsersPanel;
        private System.Windows.Forms.Panel FiltrPanel;
    }
}
