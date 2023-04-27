namespace Comp
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Комплекты");
            this.AuthPanel = new System.Windows.Forms.Panel();
            this.BlockCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BlocksDesignMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelloLabel = new System.Windows.Forms.Label();
            this.AccountButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.AuthButton = new System.Windows.Forms.Button();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PaswTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AdminPanelButton = new System.Windows.Forms.Button();
            this.DesignButton = new System.Windows.Forms.Button();
            this.ViewPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.уникальныйДизайнКнопкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.уникальныйДизайнНадписиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyRightPanel = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.WeatherLabel = new System.Windows.Forms.Label();
            this.AuthPanel.SuspendLayout();
            this.BlockCMS.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AuthPanel
            // 
            this.AuthPanel.AccessibleDescription = "block";
            this.AuthPanel.ContextMenuStrip = this.BlockCMS;
            this.AuthPanel.Controls.Add(this.HelloLabel);
            this.AuthPanel.Controls.Add(this.AccountButton);
            this.AuthPanel.Controls.Add(this.label5);
            this.AuthPanel.Controls.Add(this.AuthButton);
            this.AuthPanel.Controls.Add(this.LoginTextBox);
            this.AuthPanel.Controls.Add(this.PaswTextBox);
            this.AuthPanel.Controls.Add(this.label4);
            this.AuthPanel.Controls.Add(this.AdminPanelButton);
            this.AuthPanel.Controls.Add(this.DesignButton);
            this.AuthPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AuthPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthPanel.Location = new System.Drawing.Point(0, 0);
            this.AuthPanel.Name = "AuthPanel";
            this.AuthPanel.Size = new System.Drawing.Size(1924, 68);
            this.AuthPanel.TabIndex = 0;
            // 
            // BlockCMS
            // 
            this.BlockCMS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BlockCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BlocksDesignMenu});
            this.BlockCMS.Name = "BlockCMS";
            this.BlockCMS.Size = new System.Drawing.Size(176, 28);
            // 
            // BlocksDesignMenu
            // 
            this.BlocksDesignMenu.Name = "BlocksDesignMenu";
            this.BlocksDesignMenu.Size = new System.Drawing.Size(175, 24);
            this.BlocksDesignMenu.Text = "Дизайн блока";
            this.BlocksDesignMenu.Click += new System.EventHandler(this.BlocksDesignMenu_Click);
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelloLabel.Location = new System.Drawing.Point(15, 22);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(0, 25);
            this.HelloLabel.TabIndex = 22;
            // 
            // AccountButton
            // 
            this.AccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccountButton.Location = new System.Drawing.Point(1281, 17);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(191, 33);
            this.AccountButton.TabIndex = 21;
            this.AccountButton.Text = "Личный кабинет";
            this.AccountButton.UseVisualStyleBackColor = true;
            this.AccountButton.Visible = false;
            this.AccountButton.Click += new System.EventHandler(this.AccountButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(409, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Введите пароль";
            // 
            // AuthButton
            // 
            this.AuthButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthButton.Location = new System.Drawing.Point(834, 17);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(111, 32);
            this.AuthButton.TabIndex = 20;
            this.AuthButton.Text = "Войти";
            this.AuthButton.UseVisualStyleBackColor = true;
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTextBox.Location = new System.Drawing.Point(182, 17);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(221, 30);
            this.LoginTextBox.TabIndex = 18;
            // 
            // PaswTextBox
            // 
            this.PaswTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PaswTextBox.Location = new System.Drawing.Point(590, 17);
            this.PaswTextBox.Name = "PaswTextBox";
            this.PaswTextBox.Size = new System.Drawing.Size(221, 30);
            this.PaswTextBox.TabIndex = 19;
            this.PaswTextBox.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Введите логин";
            // 
            // AdminPanelButton
            // 
            this.AdminPanelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminPanelButton.Location = new System.Drawing.Point(970, 17);
            this.AdminPanelButton.Name = "AdminPanelButton";
            this.AdminPanelButton.Size = new System.Drawing.Size(296, 33);
            this.AdminPanelButton.TabIndex = 15;
            this.AdminPanelButton.Text = "Панель администратора";
            this.AdminPanelButton.UseVisualStyleBackColor = true;
            this.AdminPanelButton.Visible = false;
            this.AdminPanelButton.Click += new System.EventHandler(this.AdminPanelButton_Click);
            // 
            // DesignButton
            // 
            this.DesignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DesignButton.Location = new System.Drawing.Point(415, 16);
            this.DesignButton.Name = "DesignButton";
            this.DesignButton.Size = new System.Drawing.Size(155, 33);
            this.DesignButton.TabIndex = 23;
            this.DesignButton.Text = "Дизайн";
            this.DesignButton.UseVisualStyleBackColor = true;
            this.DesignButton.Click += new System.EventHandler(this.DesignButton_Click);
            // 
            // ViewPanel
            // 
            this.ViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewPanel.Location = new System.Drawing.Point(303, 3);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Size = new System.Drawing.Size(1618, 525);
            this.ViewPanel.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ViewPanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.treeView1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 68);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1924, 531);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.AccessibleDescription = "block";
            this.treeView1.ContextMenuStrip = this.BlockCMS;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode2.Name = "Узел0";
            treeNode2.Text = "Комплекты";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeView1.Size = new System.Drawing.Size(294, 525);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.уникальныйДизайнКнопкиToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(274, 28);
            // 
            // уникальныйДизайнКнопкиToolStripMenuItem
            // 
            this.уникальныйДизайнКнопкиToolStripMenuItem.Name = "уникальныйДизайнКнопкиToolStripMenuItem";
            this.уникальныйДизайнКнопкиToolStripMenuItem.Size = new System.Drawing.Size(273, 24);
            this.уникальныйДизайнКнопкиToolStripMenuItem.Text = "Уникальный дизайн кнопки";
            this.уникальныйДизайнКнопкиToolStripMenuItem.Click += new System.EventHandler(this.уникальныйДизайнКнопкиToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.уникальныйДизайнНадписиToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(283, 28);
            // 
            // уникальныйДизайнНадписиToolStripMenuItem
            // 
            this.уникальныйДизайнНадписиToolStripMenuItem.Name = "уникальныйДизайнНадписиToolStripMenuItem";
            this.уникальныйДизайнНадписиToolStripMenuItem.Size = new System.Drawing.Size(282, 24);
            this.уникальныйДизайнНадписиToolStripMenuItem.Text = "Уникальный дизайн надписи";
            this.уникальныйДизайнНадписиToolStripMenuItem.Click += new System.EventHandler(this.уникальныйДизайнНадписиToolStripMenuItem_Click);
            // 
            // CopyRightPanel
            // 
            this.CopyRightPanel.AccessibleDescription = "block";
            this.CopyRightPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CopyRightPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CopyRightPanel.Location = new System.Drawing.Point(0, 644);
            this.CopyRightPanel.Name = "CopyRightPanel";
            this.CopyRightPanel.Size = new System.Drawing.Size(1924, 35);
            this.CopyRightPanel.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Рубли",
            "Доллары",
            "Евро",
            "Юани"});
            this.comboBox1.Location = new System.Drawing.Point(349, 605);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 33);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // WeatherLabel
            // 
            this.WeatherLabel.AutoSize = true;
            this.WeatherLabel.Location = new System.Drawing.Point(15, 611);
            this.WeatherLabel.Name = "WeatherLabel";
            this.WeatherLabel.Size = new System.Drawing.Size(44, 16);
            this.WeatherLabel.TabIndex = 5;
            this.WeatherLabel.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 679);
            this.Controls.Add(this.WeatherLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CopyRightPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.AuthPanel);
            this.Name = "MainForm";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.AuthPanel.ResumeLayout(false);
            this.AuthPanel.PerformLayout();
            this.BlockCMS.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel AuthPanel;
        private System.Windows.Forms.Panel ViewPanel;
        private System.Windows.Forms.Button AccountButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AuthButton;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PaswTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AdminPanelButton;
        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button DesignButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem уникальныйДизайнКнопкиToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem уникальныйДизайнНадписиToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip BlockCMS;
        private System.Windows.Forms.ToolStripMenuItem BlocksDesignMenu;
        private System.Windows.Forms.Panel CopyRightPanel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label WeatherLabel;
    }
}

