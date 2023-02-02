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
    public partial class AdminUserControl : UserControl
    {
        public AdminUserControl()
        {
            InitializeComponent();
        }

        private void AdminUserControl_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminUsersUserControl adminusersUC = new AdminUsersUserControl();
            Controls.Clear();
            Controls.Add(adminusersUC);
            adminusersUC.Dock = DockStyle.None;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Управление таблицей готовых комплектов
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Управление таблицей Level1
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Управление таблицей Level2
        }
    }
}
