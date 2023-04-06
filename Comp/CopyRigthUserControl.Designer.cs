namespace Comp
{
    partial class CopyRigthUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CopyRigthUserControl));
            this.WWWPictureBox = new System.Windows.Forms.PictureBox();
            this.VKPictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WWWPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VKPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // WWWPictureBox
            // 
            this.WWWPictureBox.AccessibleDescription = "";
            this.WWWPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("WWWPictureBox.Image")));
            this.WWWPictureBox.Location = new System.Drawing.Point(268, 3);
            this.WWWPictureBox.Name = "WWWPictureBox";
            this.WWWPictureBox.Size = new System.Drawing.Size(37, 37);
            this.WWWPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WWWPictureBox.TabIndex = 7;
            this.WWWPictureBox.TabStop = false;
            this.WWWPictureBox.Click += new System.EventHandler(this.WWWPictureBox_Click);
            // 
            // VKPictureBox
            // 
            this.VKPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("VKPictureBox.Image")));
            this.VKPictureBox.Location = new System.Drawing.Point(214, 3);
            this.VKPictureBox.Name = "VKPictureBox";
            this.VKPictureBox.Size = new System.Drawing.Size(37, 37);
            this.VKPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VKPictureBox.TabIndex = 6;
            this.VKPictureBox.TabStop = false;
            this.VKPictureBox.Click += new System.EventHandler(this.VKPictureBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Наши соц.сети";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(821, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Все права защищены";
            // 
            // CopyRigthUserControl
            // 
            this.AccessibleDescription = "block";
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WWWPictureBox);
            this.Controls.Add(this.VKPictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CopyRigthUserControl";
            this.Size = new System.Drawing.Size(1046, 43);
            ((System.ComponentModel.ISupportInitialize)(this.WWWPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VKPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox VKPictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox WWWPictureBox;
    }
}
