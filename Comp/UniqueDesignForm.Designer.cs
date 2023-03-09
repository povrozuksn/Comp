namespace Comp
{
    partial class UniqueDesignForm
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
            this.ButtonColorButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ButtonFontButton = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonCoordsTextBox = new System.Windows.Forms.TextBox();
            this.ButtonSizeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveCoordButton = new System.Windows.Forms.Button();
            this.ButtonCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Образец";
            // 
            // ButtonColorButton
            // 
            this.ButtonColorButton.Location = new System.Drawing.Point(46, 118);
            this.ButtonColorButton.Name = "ButtonColorButton";
            this.ButtonColorButton.Size = new System.Drawing.Size(163, 50);
            this.ButtonColorButton.TabIndex = 10;
            this.ButtonColorButton.Text = "Цвет";
            this.ButtonColorButton.UseVisualStyleBackColor = true;
            this.ButtonColorButton.Click += new System.EventHandler(this.ButtonColorButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(286, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 55);
            this.button3.TabIndex = 9;
            this.button3.Text = "Образец";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ButtonFontButton
            // 
            this.ButtonFontButton.Location = new System.Drawing.Point(46, 56);
            this.ButtonFontButton.Name = "ButtonFontButton";
            this.ButtonFontButton.Size = new System.Drawing.Size(163, 56);
            this.ButtonFontButton.TabIndex = 8;
            this.ButtonFontButton.Text = "Шрифт";
            this.ButtonFontButton.UseVisualStyleBackColor = true;
            this.ButtonFontButton.Click += new System.EventHandler(this.ButtonFontButton_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Координаты";
            // 
            // ButtonCoordsTextBox
            // 
            this.ButtonCoordsTextBox.Location = new System.Drawing.Point(215, 180);
            this.ButtonCoordsTextBox.Name = "ButtonCoordsTextBox";
            this.ButtonCoordsTextBox.Size = new System.Drawing.Size(189, 30);
            this.ButtonCoordsTextBox.TabIndex = 13;
            // 
            // ButtonSizeTextBox
            // 
            this.ButtonSizeTextBox.Location = new System.Drawing.Point(215, 216);
            this.ButtonSizeTextBox.Name = "ButtonSizeTextBox";
            this.ButtonSizeTextBox.Size = new System.Drawing.Size(189, 30);
            this.ButtonSizeTextBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Размер";
            // 
            // SaveCoordButton
            // 
            this.SaveCoordButton.Location = new System.Drawing.Point(75, 315);
            this.SaveCoordButton.Name = "SaveCoordButton";
            this.SaveCoordButton.Size = new System.Drawing.Size(347, 34);
            this.SaveCoordButton.TabIndex = 16;
            this.SaveCoordButton.Text = "Сохранить";
            this.SaveCoordButton.UseVisualStyleBackColor = true;
            this.SaveCoordButton.Click += new System.EventHandler(this.SaveCoordButton_Click);
            // 
            // ButtonCheckBox
            // 
            this.ButtonCheckBox.AutoSize = true;
            this.ButtonCheckBox.Location = new System.Drawing.Point(64, 268);
            this.ButtonCheckBox.Name = "ButtonCheckBox";
            this.ButtonCheckBox.Size = new System.Drawing.Size(216, 29);
            this.ButtonCheckBox.TabIndex = 17;
            this.ButtonCheckBox.Text = "Только для админа";
            this.ButtonCheckBox.UseVisualStyleBackColor = true;
            this.ButtonCheckBox.CheckedChanged += new System.EventHandler(this.ButtonCheckBox_CheckedChanged);
            // 
            // UniqueDesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 361);
            this.Controls.Add(this.ButtonCheckBox);
            this.Controls.Add(this.SaveCoordButton);
            this.Controls.Add(this.ButtonSizeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ButtonCoordsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonColorButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ButtonFontButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UniqueDesignForm";
            this.Text = "UniqueDesignForm";
            this.Load += new System.EventHandler(this.UniqueDesignForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonColorButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ButtonFontButton;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ButtonCoordsTextBox;
        private System.Windows.Forms.TextBox ButtonSizeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveCoordButton;
        private System.Windows.Forms.CheckBox ButtonCheckBox;
    }
}