namespace Comp
{
    partial class MainUserControl
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
            this.CompsPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CompsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CompsPanel
            // 
            this.CompsPanel.Controls.Add(this.label1);
            this.CompsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompsPanel.Location = new System.Drawing.Point(0, 0);
            this.CompsPanel.Name = "CompsPanel";
            this.CompsPanel.Size = new System.Drawing.Size(1197, 469);
            this.CompsPanel.TabIndex = 2;
            this.CompsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CompsPanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Собери свой компьютер";
            // 
            // MainUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CompsPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainUserControl";
            this.Size = new System.Drawing.Size(1197, 469);
            this.CompsPanel.ResumeLayout(false);
            this.CompsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CompsPanel;
        private System.Windows.Forms.Label label1;
    }
}
