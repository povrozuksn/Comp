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
    public partial class CopyRigthUserControl : UserControl
    {
        public CopyRigthUserControl()
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

        private void CopyRightPanel_Resize(object sender, EventArgs e)
        {
            //VKPictureBox.Size = new Size(CopyRightPanel.Height, CopyRightPanel.Height);
            //WWWPictureBox.Size = VKPictureBox.Size;
        }
    }
}
