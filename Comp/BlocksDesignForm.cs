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
    public partial class BlocksDesignForm : Form
    {
        public Control ctrl;
        public BlocksDesignForm(Control _ctrl)
        {
            InitializeComponent();
            ctrl = new Control();
            ctrl.Size = _ctrl.Size;
            ctrl.Name = _ctrl.Name;

            textBox1.Text = ctrl.Size.Width.ToString();
        }

        private void BlocksDesignForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ctrl.Size = new Size(Convert.ToInt32(textBox1.Text), ctrl.Size.Height);
        }
    }
}
