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
    public partial class MainUserControl : UserControl
    {
        public MainUserControl()
        {
            InitializeComponent();

            List<string> comps = SQLClass.Select("SELECT ID, Name, Image FROM " + SQLClass.MAIN);
            CompsPanel.Controls.Clear();
            CompsPanel.Controls.Add(label1);
            int x = 40;
            for (int i = 0; i < comps.Count; i += 3)
            {
                PictureBox pb = new PictureBox();
                pb = new PictureBox();
                try
                {
                    pb.Load("../../Pictures/" + comps[i + 2]);
                }
                catch (Exception) { }
                pb.Location = new Point(x, 50);
                pb.Size = new Size(180, 180);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Tag = comps[i];
                pb.Click += new EventHandler(pictureBox_Click);
                CompsPanel.Controls.Add(pb);

                Label lbl = new Label();
                lbl.Location = new Point(x, 240);
                lbl.Size = new Size(180, 30);
                lbl.Font = new Font("Microsoft Sans Serif", 12);
                lbl.Text = comps[i + 1];
                lbl.Tag = comps[i];
                lbl.Click += new EventHandler(label_Click);
                CompsPanel.Controls.Add(lbl);

                x += 190;
            }

            DesignUserControl.ApplyDesign(this);

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            Level0UserControl level1UC = new Level0UserControl(pb.Tag.ToString());
            Controls.Clear();
            Controls.Add(level1UC);
            level1UC.Dock = DockStyle.None;
        }

        private void label_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            Level0UserControl level1UC = new Level0UserControl(lbl.Tag.ToString());
            Controls.Clear();
            Controls.Add(level1UC);
            level1UC.Dock = DockStyle.None;
        }

        private void CompsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainUserControl_Load(object sender, EventArgs e)
        {
            DesignUserControl.ApplyDesign(this);
        }
    }    
}
