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
    public partial class CopyRightUserControl : UserControl
    {
        public CopyRightUserControl()
        {
            InitializeComponent();
        }

        private void VKPictureBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/ingenerka_73");
        }

        private void WWWPictureBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://dtci.ru/");
        }

        private void CopyRigthUserControl_Load(object sender, EventArgs e)
        {
            ContextMenuStrip = DesignUserControl.BLOCK_CM;
        }

        private void CopyRightUserControl_Resize(object sender, EventArgs e)
        {
            VKPictureBox.Size = new Size(this.Size.Height, this.Size.Height);
            WWWPictureBox.Size = VKPictureBox.Size;
        }
    }
}
