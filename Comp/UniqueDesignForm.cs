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
    public partial class UniqueDesignForm : Form
    {
        public UniqueDesignForm(Button btn)
        {
            InitializeComponent();

            button3.Text = btn.Text;
            button3.Font = btn.Font;
            button3.ForeColor = btn.ForeColor;
            button3.BackColor = btn.BackColor;

        }

        private void UniqueDesignForm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonFontButton_Click(object sender, EventArgs e)
        {

        }

        private void ButtonColorButton_Click(object sender, EventArgs e)
        {

        }
    }
}
