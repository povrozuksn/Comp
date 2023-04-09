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
    public partial class PanelDesignForm : Form
    {
        public Control ctrl;
        public PanelDesignForm(Control _ctrl)
        {
            ctrl = new Control();
            ctrl.Size = _ctrl.Size;
            ctrl.Name = _ctrl.Name;
            InitializeComponent();

            textBox1.Text = ctrl.Size.Height.ToString();
        }

        private void PanelDesignForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ctrl.Size = new Size(ctrl.Size.Width, Convert.ToInt32(textBox1.Text));
        }
    }
}
