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
        public Control parent;
        public BlocksDesignForm(Control _ctrl)
        {
            parent = _ctrl;
            while (!(parent is Panel || parent is UserControl || parent is Form))
            {
                parent = parent.Parent;
            }
            ctrl = new Control();
            ctrl.Size = _ctrl.Size;
            ctrl.Name = _ctrl.Name;
            InitializeComponent();            

            WidthTextBox.Text = ctrl.Size.Width.ToString();
            HeightTextBox.Text = ctrl.Size.Height.ToString();

            CopyRightCLB.Visible = (ctrl.Name == "CopyRightUserControl" || ctrl.Name == "CopyRightPanel");

            if(ctrl.Name == "CopyRightUserControl" || ctrl.Name == "CopyRightPanel")
            {
                try
                {
                    string vk = SQLClass.Select("SELECT value FROM " + SQLClass.BLOCK_DISIGN + " WHERE name = '" + ctrl.Name + "' AND form = '" + parent.Name + "' AND parameter = 'VK'")[0];
                    if(vk == "1")
                    {
                        CopyRightCLB.SetItemChecked(0, true);
                    }

                }
                catch (Exception) { }

                try
                {
                    string www = SQLClass.Select("SELECT value FROM blockdesign WHERE name = '" + ctrl.Name + "' AND form = '" + parent.Name + "' AND parameter = 'WWW'")[0];
                    if (www == "1")
                    {
                        CopyRightCLB.SetItemChecked(1, true);
                    }
                }
                catch (Exception) { }
            }


        }

        private void BlocksDesignForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ctrl.Size = new Size(Convert.ToInt32(WidthTextBox.Text), Convert.ToInt32(HeightTextBox.Text));

            SQLClass.Update("DELETE FROM blockdesign WHERE name = '" + ctrl.Name + "' AND form = '" + parent.Name + "' AND parameter = 'WIDTH'");
            SQLClass.Update("INSERT INTO blockdesign (name, form, parameter, value) VALUES ('" + ctrl.Name + "', '" + parent.Name + "', 'WIDTH', '" + WidthTextBox.Text + "')");

            SQLClass.Update("DELETE FROM blockdesign WHERE name = '" + ctrl.Name + "' AND form = '" + parent.Name + "' AND parameter = 'HEIGHT'");
            SQLClass.Update("INSERT INTO blockdesign (name, form, parameter, value) VALUES ('" + ctrl.Name + "', '" + parent.Name + "', 'HEIGHT', '" + HeightTextBox.Text + "')");

            SQLClass.Update("DELETE FROM blockdesign WHERE name = '" + ctrl.Name + "' AND form = '" + parent.Name + "' AND parameter = 'VK'");            
            SQLClass.Update("DELETE FROM blockdesign WHERE name = '" + ctrl.Name + "' AND form = '" + parent.Name + "' AND parameter = 'WWW'");
            
            foreach(object item in CopyRightCLB.CheckedItems)
            {
                if(item.ToString() == "VK")
                    SQLClass.Update("INSERT INTO blockdesign (name, form, parameter, value) VALUES ('" + ctrl.Name + "', '" + parent.Name + "', 'VK', '1')");
                if (item.ToString() == "WWW")
                    SQLClass.Update("INSERT INTO blockdesign (name, form, parameter, value) VALUES ('" + ctrl.Name + "', '" + parent.Name + "', 'WWW', '1')");
            }
            MessageBox.Show("Сохранено");
            Close();
        }
    }
}
