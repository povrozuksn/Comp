using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Comp
{
    public partial class RedLeve0UserControl : UserControl
    {
        public RedLeve0UserControl()
        {
            InitializeComponent();
            DesignUserControl.ApplyDesign(this);
            DesignUserControl.ApplyMenu(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           SQLClass.Update("INSERT INTO level1 (Name, Image)" +
                              "VALUES('" + NameTextBox.Text + "', '" + adress + "')");

            MessageBox.Show("Сохранено");
            RedLeve0UserControl_Load(sender, e);
            return;
        }

        private void RedLeve0UserControl_Load(object sender, EventArgs e)
        {
            List<string> list = SQLClass.Select("SELECT ID, Name FROM main");

            panel1.Controls.Clear();
            int y = 10;
            for (int i = 0; i < list.Count; i += 2)
            {
                Label lbl0 = new Label();
                lbl0.Location = new Point(50, y);
                lbl0.Size = new Size(50, 30);
                lbl0.Font = new Font("Microsoft Sans Serif", 12);
                lbl0.Text = list[i];
                panel1.Controls.Add(lbl0);

                Label lbl1 = new Label();
                lbl1.Location = new Point(225, y);
                lbl1.Size = new Size(250, 30);
                lbl1.Font = new Font("Microsoft Sans Serif", 12);
                lbl1.Text = list[i + 1];
                panel1.Controls.Add(lbl1);

                y += 35;
            }
            DesignUserControl.ApplyDesign(this);
            DesignUserControl.ApplyMenu(this);
        }


        string adress = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                adress = openFileDialog1.FileName;
                pictureBox1.Load(adress);
                System.IO.File.Copy(adress, "../../Pictures/" + System.IO.Path.GetFileName(adress));
                adress = System.IO.Path.GetFileName(adress);
            }
        }
    }
}