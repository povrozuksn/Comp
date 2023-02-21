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
    public partial class Level1UserControl : UserControl
    {
        public Level1UserControl(string id_level1)
        {
            InitializeComponent();

            List<string> lev1 = SQLClass.Select("SELECT ID, Name, Image FROM level1 WHERE ID = '" + id_level1 + "'");
            List<string> lev2 = SQLClass.Select("SELECT ID, Name, Image, Specs, Quantity, Price FROM level2 WHERE id_level1 = '" + id_level1 + "'");

            Text = lev1[1];
            label1.Text = lev1[1];
            try
            {
                pictureBox1.Load("../../Pictures/" + lev1[2]);
            }
            catch (Exception) { };

            Level1Panel.Controls.Clear();

            int x = 40;
            for (int i = 0; i < lev2.Count; i += 6)
            {
                PictureBox pb = new PictureBox();
                pb = new PictureBox();
                try
                {
                    pb.Load("../../Pictures/" + lev2[i + 2]);
                }
                catch (Exception) { }
                pb.Location = new Point(x, 30);
                pb.Size = new Size(100, 100);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Tag = lev2[i];
                pb.Click += new EventHandler(pictureBox_Click);
                Level1Panel.Controls.Add(pb);

                Label lbl = new Label();
                lbl.Location = new Point(x, 140);
                lbl.Size = new Size(230, 30);
                lbl.Font = new Font("Microsoft Sans Serif", 12);
                lbl.Text = lev2[i + 1];
                lbl.Tag = lev2[i];
                lbl.Click += new EventHandler(label_Click);
                Level1Panel.Controls.Add(lbl);

                x += 240;
            }


            DesignUserControl.ApplyDesign(this);
        }
        private void Level1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            Level2UserControl level2UC = new Level2UserControl(pb.Tag.ToString());
            Controls.Clear();
            Controls.Add(level2UC);
            level2UC.Dock = DockStyle.None;
        }

        private void label_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            Level2UserControl level2UC = new Level2UserControl(lbl.Tag.ToString());
            Controls.Clear();
            Controls.Add(level2UC);
            level2UC.Dock = DockStyle.None;
        }

        private void Level0Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Level1UserControl_Load(object sender, EventArgs e)
        {
            DesignUserControl.ApplyDesign(this);
        }
    }
}
