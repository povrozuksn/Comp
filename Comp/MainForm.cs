using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp
{
    public partial class MainForm : Form
    {
        public static string nameConponent;
        public static string Login = "";
        public static string NameSurname = "";
        public static bool isAdmin = false;

        public MainForm()
        {
            InitializeComponent();

            MainUserControl mainUC = new MainUserControl();
            mainUC.Dock = DockStyle.Fill;
            ViewPanel.Controls.Clear();
            ViewPanel.Controls.Add(mainUC);

            DesignUserControl.ApplyDesign(this);
            DesignUserControl.ApplyMenu(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string id_main;
            string id_level1;

            DesignUserControl.BUTTON_CM = contextMenuStrip1;
            DesignUserControl.LABEL_CM = contextMenuStrip2;

            List<string> comps = SQLClass.Select("SELECT ID, Name FROM main");
            for(int i=0; i < comps.Count; i+=2)
            {
                id_main = comps[i];
                TreeNode node0 = new TreeNode(comps[i+1]);
                node0.Tag = comps[i];
                treeView1.Nodes[0].Nodes.Add(node0);

                List<string> level1 = SQLClass.Select("SELECT ID, Name FROM level1 WHERE id_main = '" + id_main + "'");
                for(int j=0; j < level1.Count; j+=2)
                {
                    id_level1 = level1[j];
                    TreeNode node1 = new TreeNode(level1[j+1]);
                    node1.Tag = level1[j];
                    node0.Nodes.Add(node1);

                    List<string> level2 = SQLClass.Select("SELECT ID, Name FROM level2 WHERE id_level1 = '" + id_level1 + "'");
                    for(int g=0; g<level2.Count; g+=2)
                    {
                        TreeNode node2 = new TreeNode(level2[g+1]);
                        node2.Tag = level2[g];
                        node1.Nodes.Add(node2);
                    }
                }
            }

            DesignUserControl.ApplyDesign(this);
            DesignUserControl.ApplyMenu(this);
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            List<string> user_data = SQLClass.Select(
            "SELECT Login, Name, Surname, admin_id FROM users WHERE Login = '" + LoginTextBox.Text + "' and Password = '" + PaswTextBox.Text + "'");

            if (AuthButton.Text == "Выйти")
            {
                Login = "";
                isAdmin = false;
                AuthPanel.Controls.Clear();
                AuthButton.Text = "Войти";
                AuthPanel.Controls.Add(AuthButton);
                AdminPanelButton.Visible = false;
                AccountButton.Visible = false;
                DesignButton.Visible = false;
                AuthPanel.Controls.Add(label4);
                LoginTextBox.Text = "";
                AuthPanel.Controls.Add(label5);
                AuthPanel.Controls.Add(LoginTextBox);
                PaswTextBox.Text = "";
                AuthPanel.Controls.Add(PaswTextBox);
                MainUserControl mainUC = new MainUserControl();
                mainUC.Dock = DockStyle.Fill;
                ViewPanel.Controls.Clear();
                ViewPanel.Controls.Add(mainUC); 
                DesignUserControl.ApplyDesign(this);
                DesignUserControl.ApplyMenu(this);
            }
            else
            {
                if (user_data.Count > 0)
                {
                    isAdmin = (user_data[3] == "1");
                    Login = user_data[0];
                    NameSurname = user_data[1] + " " + user_data[2];
                    AuthPanel.Controls.Clear();
                    AuthButton.Text = "Выйти";
                    AuthPanel.Controls.Add(AuthButton);
                    AdminPanelButton.Visible = isAdmin;
                    AuthPanel.Controls.Add(AccountButton);
                    AccountButton.Visible = true;
                    DesignButton.Visible = true;
                    AuthPanel.Controls.Add(AdminPanelButton);
                    AuthPanel.Controls.Add(DesignButton);
                    AuthPanel.Controls.Add(HelloLabel);
                    HelloLabel.Text = "Приветствуем, " + NameSurname;
                    DesignUserControl.ApplyDesign(this);
                    DesignUserControl.ApplyMenu(this);
                }
                else
                {
                    var result = MessageBox.Show("Вы указали неверный логин/пароль", "Зарегистрироваться", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        RegForm reg = new RegForm();
                        reg.ShowDialog();
                    }
                }
            }
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            AccountForm af = new AccountForm();
            af.ShowDialog();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node.Level == 0 && e.Node.Text == "Комплекты")
            {
                MainUserControl mainUC = new MainUserControl();
                mainUC.Dock = DockStyle.Fill;
                ViewPanel.Controls.Clear();
                ViewPanel.Controls.Add(mainUC);
            }

            else if(e.Node.Level == 1 && e.Node.Parent.Text == "Комплекты")
            {
                Level0UserControl level0UC = new Level0UserControl(e.Node.Tag.ToString());
                ViewPanel.Controls.Clear();
                ViewPanel.Controls.Add(level0UC);
                level0UC.Dock = DockStyle.None;
            }

            else if (e.Node.Level == 2 && e.Node.Parent.Parent.Text == "Комплекты")
            {
                Level1UserControl level1UC = new Level1UserControl(e.Node.Tag.ToString());
                ViewPanel.Controls.Clear();
                ViewPanel.Controls.Add(level1UC);
                level1UC.Dock = DockStyle.None;
            }

            else if (e.Node.Level == 3 && e.Node.Parent.Parent.Parent.Text == "Комплекты")
            {
                Level2UserControl level2UC = new Level2UserControl(e.Node.Tag.ToString());
                ViewPanel.Controls.Clear();
                ViewPanel.Controls.Add(level2UC);
                level2UC.Dock = DockStyle.None;
            }

            else if(e.Node.Level == 0 && e.Node.Text == "Вход админа")
            {
                AdminUserControl adminUC = new AdminUserControl();
                ViewPanel.Controls.Clear();
                ViewPanel.Controls.Add(adminUC);
                adminUC.Dock = DockStyle.None;
            }

            else if (e.Node.Level == 1 && e.Node.Parent.Text == "Вход админа" && e.Node.Text == "Управление пользователями")
            {
                AdminUsersUserControl admin_usersUC = new AdminUsersUserControl();
                ViewPanel.Controls.Clear();
                ViewPanel.Controls.Add(admin_usersUC);
                admin_usersUC.Dock = DockStyle.None;
            }

            else if (e.Node.Level == 1 && e.Node.Parent.Text == "Вход админа" && e.Node.Text == "Управление комплектами")
            {
                RedLeve0UserControl red_level0UC = new RedLeve0UserControl();
                ViewPanel.Controls.Clear();
                ViewPanel.Controls.Add(red_level0UC);
                red_level0UC.Dock = DockStyle.None;
            }


            else if (e.Node.Level == 1 && e.Node.Parent.Text == "Вход админа" && e.Node.Text == "Управление подкатегориями")
            {
                RedLeve1UserControl red_level1UC = new RedLeve1UserControl();
                ViewPanel.Controls.Clear();
                ViewPanel.Controls.Add(red_level1UC);
                red_level1UC.Dock = DockStyle.None;
            }

            else if (e.Node.Level == 1 && e.Node.Parent.Text == "Вход админа" && e.Node.Text == "Управление компонентами")
            {
                RedLeve2UserControl red_level2UC = new RedLeve2UserControl();
                ViewPanel.Controls.Clear();
                ViewPanel.Controls.Add(red_level2UC);
                red_level2UC.Dock = DockStyle.None;
            }
        }

        private void AdminPanelButton_Click(object sender, EventArgs e)
        {
            AdminUserControl adminUC = new AdminUserControl();
            ViewPanel.Controls.Clear();
            ViewPanel.Controls.Add(adminUC);
            adminUC.Dock = DockStyle.None;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isAdmin && treeView1.Nodes.Count == 1)
            {
                TreeNode node = new TreeNode("Вход админа");
                treeView1.Nodes.Add(node);

                TreeNode node1 = new TreeNode("Управление пользователями");
                node.Nodes.Add(node1);

                TreeNode node2 = new TreeNode("Управление комплектами");
                node.Nodes.Add(node2);

                TreeNode node3 = new TreeNode("Управление подкатегориями");
                node.Nodes.Add(node3);

                TreeNode node4 = new TreeNode("Управление компонентами");
                node.Nodes.Add(node4);
            }
            else if(!isAdmin && treeView1.Nodes.Count > 1)
            {
                treeView1.Nodes.RemoveAt(1);
            }
        }

        private void DesignButton_Click(object sender, EventArgs e)
        {
            DesignUserControl desUC = new DesignUserControl();
            ViewPanel.Controls.Clear();
            ViewPanel.Controls.Add(desUC);
            desUC.Dock = DockStyle.None;
        }

        private void уникальныйДизайнКнопкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem item = (ToolStripMenuItem)sender;
                ContextMenuStrip cm = (ContextMenuStrip)(item.GetCurrentParent());
                Button button = (Button)(cm.SourceControl);
                UniqueDesignForm designForm = new UniqueDesignForm(button);
                designForm.ShowDialog();
            }
            catch (Exception) { }
        }

        private void уникальныйДизайнНадписиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem item = (ToolStripMenuItem)sender;
                ContextMenuStrip cm = (ContextMenuStrip)(item.GetCurrentParent());
                Label lbl = (Label)(cm.SourceControl);
                UniqueDisignLabelForm designForm = new UniqueDisignLabelForm(lbl);
                designForm.ShowDialog();
            }
            catch (Exception) { }
        }

        private void BlocksDesignMenu_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem item = (ToolStripMenuItem)sender;
                ContextMenuStrip cm = (ContextMenuStrip)(item.GetCurrentParent());
                TreeView tv = (TreeView)(cm.SourceControl);
                TableLayoutPanel tp = (TableLayoutPanel)tv.Parent;

                TableLayoutPanelCellPosition pos = tp.GetPositionFromControl(tv);

                BlocksDesignForm bdf = new BlocksDesignForm(tv);
                bdf.ShowDialog();

                tp.ColumnStyles[pos.Column].Width = bdf.ctrl.Width;
            }
            catch (Exception) { }

            
        }

        private void дизайнПанелиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem item = (ToolStripMenuItem)sender;
                ContextMenuStrip cm = (ContextMenuStrip)(item.GetCurrentParent());
                Control ctrl = (cm.SourceControl);

                Control parent = ctrl;
                while (!(parent is Panel || parent is TableLayoutPanel ||
                        parent is UserControl || parent is Form))
                {
                    parent = parent.Parent;
                }
                
                PanelDesignForm pdf = new PanelDesignForm(ctrl);
                pdf.ShowDialog();

                ctrl.Size = pdf.ctrl.Size;
                VKPictureBox.Size = new Size(ctrl.Height, ctrl.Height);
                WWWPictureBox.Size = VKPictureBox.Size;
            }
            catch (Exception) { }
        }

        private void WWWPictureBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://dtci.ru/");
        }

        private void VKPictureBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/ingenerka_73");
        }
    }
}
