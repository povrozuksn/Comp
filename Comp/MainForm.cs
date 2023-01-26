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
    }
}
