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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Комплекты");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AuthPanel = new System.Windows.Forms.Panel();
            this.DesignButton = new System.Windows.Forms.Button();
            this.HelloLabel = new System.Windows.Forms.Label();
            this.AccountButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.AuthButton = new System.Windows.Forms.Button();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PaswTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AdminPanelButton = new System.Windows.Forms.Button();
            this.ViewPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.BlockCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BlocksDesignMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.уникальныйДизайнКнопкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.уникальныйДизайнНадписиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyRightPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.дизайнПанелиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VKPictureBox = new System.Windows.Forms.PictureBox();
            this.WWWPictureBox = new System.Windows.Forms.PictureBox();
            this.AuthPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.BlockCMS.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.CopyRightPanel.SuspendLayout();
            this.PanelCMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VKPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WWWPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AuthPanel
            // 
            this.AuthPanel.ContextMenuStrip = this.PanelCMS;
            this.AuthPanel.Controls.Add(this.DesignButton);
            this.AuthPanel.Controls.Add(this.HelloLabel);
            this.AuthPanel.Controls.Add(this.AccountButton);
            this.AuthPanel.Controls.Add(this.label5);
            this.AuthPanel.Controls.Add(this.AuthButton);
            this.AuthPanel.Controls.Add(this.LoginTextBox);
            this.AuthPanel.Controls.Add(this.PaswTextBox);
            this.AuthPanel.Controls.Add(this.label4);
            this.AuthPanel.Controls.Add(this.AdminPanelButton);
            this.AuthPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AuthPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthPanel.Location = new System.Drawing.Point(0, 0);
            this.AuthPanel.Name = "AuthPanel";
            this.AuthPanel.Size = new System.Drawing.Size(1924, 68);
            this.AuthPanel.TabIndex = 0;
            // 
            // DesignButton
            // 
            this.DesignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DesignButton.Location = new System.Drawing.Point(1487, 17);
            this.DesignButton.Name = "DesignButton";
            this.DesignButton.Size = new System.Drawing.Size(155, 33);
            this.DesignButton.TabIndex = 23;
            this.DesignButton.Text = "Дизайн";
            this.DesignButton.UseVisualStyleBackColor = true;
            this.DesignButton.Click += new System.EventHandler(this.DesignButton_Click);
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
            // ViewPanel
            // 
            this.ViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewPanel.Location = new System.Drawing.Point(303, 3);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Size = new System.Drawing.Size(1618, 605);
            this.ViewPanel.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ViewPanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.treeView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 68);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1924, 611);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.BlockCMS;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел0";
            treeNode1.Text = "Комплекты";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView1.Size = new System.Drawing.Size(294, 605);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
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
            this.CopyRightPanel.ContextMenuStrip = this.PanelCMS;
            this.CopyRightPanel.Controls.Add(this.WWWPictureBox);
            this.CopyRightPanel.Controls.Add(this.VKPictureBox);
            this.CopyRightPanel.Controls.Add(this.label2);
            this.CopyRightPanel.Controls.Add(this.label1);
            this.CopyRightPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CopyRightPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CopyRightPanel.Location = new System.Drawing.Point(0, 636);
            this.CopyRightPanel.Name = "CopyRightPanel";
            this.CopyRightPanel.Size = new System.Drawing.Size(1924, 43);
            this.CopyRightPanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1076, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Все права защищены";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Наши соц.сети";
            // 
            // PanelCMS
            // 
            this.PanelCMS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.PanelCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.дизайнПанелиToolStripMenuItem});
            this.PanelCMS.Name = "PanelCMS";
            this.PanelCMS.Size = new System.Drawing.Size(186, 28);
            // 
            // дизайнПанелиToolStripMenuItem
            // 
            this.дизайнПанелиToolStripMenuItem.Name = "дизайнПанелиToolStripMenuItem";
            this.дизайнПанелиToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.дизайнПанелиToolStripMenuItem.Text = "Дизайн панели";
            this.дизайнПанелиToolStripMenuItem.Click += new System.EventHandler(this.дизайнПанелиToolStripMenuItem_Click);
            // 
            // VKPictureBox
            // 
            this.VKPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("VKPictureBox.Image")));
            this.VKPictureBox.Location = new System.Drawing.Point(225, 4);
            this.VKPictureBox.Name = "VKPictureBox";
            this.VKPictureBox.Size = new System.Drawing.Size(37, 37);
            this.VKPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VKPictureBox.TabIndex = 2;
            this.VKPictureBox.TabStop = false;
            this.VKPictureBox.Click += new System.EventHandler(this.VKPictureBox_Click);
            // 
            // WWWPictureBox
            // 
            this.WWWPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("WWWPictureBox.Image")));
            this.WWWPictureBox.Location = new System.Drawing.Point(306, 4);
            this.WWWPictureBox.Name = "WWWPictureBox";
            this.WWWPictureBox.Size = new System.Drawing.Size(37, 37);
            this.WWWPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WWWPictureBox.TabIndex = 3;
            this.WWWPictureBox.TabStop = false;
            this.WWWPictureBox.Click += new System.EventHandler(this.WWWPictureBox_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 679);
            this.Controls.Add(this.CopyRightPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.AuthPanel);
            this.Name = "MainForm";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.AuthPanel.ResumeLayout(false);
            this.AuthPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.BlockCMS.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.CopyRightPanel.ResumeLayout(false);
            this.CopyRightPanel.PerformLayout();
            this.PanelCMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VKPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WWWPictureBox)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ContextMenuStrip PanelCMS;
        private System.Windows.Forms.ToolStripMenuItem дизайнПанелиToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox VKPictureBox;
        private System.Windows.Forms.PictureBox WWWPictureBox;
    }
}

