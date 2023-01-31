using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string id_main;
            string id_level1;

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
                        node1.Nodes.Add(node2);
                    }
                }
            }
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            List<string> user_data = SQLClass.Select(
            "SELECT Login, Name, Surname, admin_id FROM users WHERE Login = '" + LoginTextBox.Text + "' and Password = '" + PaswTextBox.Text + "'");

            if (AuthButton.Text == "Выйти")
            {
                Login = "";
                AuthPanel.Controls.Clear();
                AuthButton.Text = "Войти";
                AuthPanel.Controls.Add(AuthButton);
                AdminPanelButton.Visible = false;
                AccountButton.Visible = false;
                AuthPanel.Controls.Add(label4);
                LoginTextBox.Text = "";
                AuthPanel.Controls.Add(label5);
                AuthPanel.Controls.Add(LoginTextBox);
                PaswTextBox.Text = "";
                AuthPanel.Controls.Add(PaswTextBox);

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
                    AuthPanel.Controls.Add(AdminPanelButton);
                    AuthPanel.Controls.Add(HelloLabel);
                    HelloLabel.Text = "Приветствуем, " + NameSurname;
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
            if(e.Node.Level == 0)
            {
                MainUserControl mainUC = new MainUserControl();
                mainUC.Dock = DockStyle.Fill;
                ViewPanel.Controls.Clear();
                ViewPanel.Controls.Add(mainUC);
            }

            else if(e.Node.Level == 1)
            {
                Level1UserControl level1UC = new Level1UserControl(e.Node.Tag.ToString());
                ViewPanel.Controls.Clear();
                ViewPanel.Controls.Add(level1UC);
                level1UC.Dock = DockStyle.None;
            }

            else if (e.Node.Level == 2)
            {
                Level2UserControl level2UC = new Level2UserControl(e.Node.Tag.ToString());
                ViewPanel.Controls.Clear();
                ViewPanel.Controls.Add(level2UC);
                level2UC.Dock = DockStyle.None;
            }



            //e.Node.Parent
        }

        private void AdminPanelButton_Click(object sender, EventArgs e)
        {
            AdminUserControl adminUC = new AdminUserControl();
            ViewPanel.Controls.Clear();
            ViewPanel.Controls.Add(adminUC);
            adminUC.Dock = DockStyle.None;
        }
    }
}
