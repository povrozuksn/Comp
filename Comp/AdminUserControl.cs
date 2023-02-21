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
            DesignUserControl.ApplyDesign(this);
        }

        private void AdminUserControl_Load(object sender, EventArgs e)
        {
            DesignUserControl.ApplyDesign(this);
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
            RedLeve0UserControl redlevel0UC = new RedLeve0UserControl();
            Controls.Clear();
            Controls.Add(redlevel0UC);
            redlevel0UC.Dock = DockStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RedLeve1UserControl redlevel1UC = new RedLeve1UserControl();
            Controls.Clear();
            Controls.Add(redlevel1UC);
            redlevel1UC.Dock = DockStyle.None;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RedLeve2UserControl redlevel2UC = new RedLeve2UserControl();
            Controls.Clear();
            Controls.Add(redlevel2UC);
            redlevel2UC.Dock = DockStyle.None;
        }
    }
}
