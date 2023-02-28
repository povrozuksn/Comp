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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Образец";
            // 
            // ButtonColorButton
            // 
            this.ButtonColorButton.Location = new System.Drawing.Point(32, 162);
            this.ButtonColorButton.Name = "ButtonColorButton";
            this.ButtonColorButton.Size = new System.Drawing.Size(160, 50);
            this.ButtonColorButton.TabIndex = 10;
            this.ButtonColorButton.Text = "Цвет";
            this.ButtonColorButton.UseVisualStyleBackColor = true;
            this.ButtonColorButton.Click += new System.EventHandler(this.ButtonColorButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(270, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 55);
            this.button3.TabIndex = 9;
            this.button3.Text = "Образец";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ButtonFontButton
            // 
            this.ButtonFontButton.Location = new System.Drawing.Point(30, 81);
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
            // UniqueDesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 317);
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
    }
}