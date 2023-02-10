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
    public partial class Level0UserControl : UserControl
    {
        public Level0UserControl(string id_main)
        {
            InitializeComponent();

            List<string> comps = SQLClass.Select("SELECT ID, Name, Image FROM main WHERE ID = '" + id_main + "'");
            List<string> lev1 = SQLClass.Select("SELECT ID, id_main, Name, Image, Specs, Quantity, Price FROM level1 WHERE id_main = '" + id_main + "'");

            Text = comps[1];
            label1.Text = comps[1];
            try
            {
                pictureBox1.Load("../../Pictures/" + comps[2]);
            }
            catch (Exception) { };

            Level1Panel.Controls.Clear();

            int x = 40;
            for (int i = 0; i < lev1.Count; i += 7)
            {
                PictureBox pb = new PictureBox();
                pb = new PictureBox();
                try
                {
                    pb.Load("../../Pictures/" + lev1[i + 3]);
                }
                catch (Exception) { }
                pb.Location = new Point(x, 30);
                pb.Size = new Size(100, 100);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Tag = lev1[i];
                pb.Click += new EventHandler(pictureBox_Click);
                Level1Panel.Controls.Add(pb);

                Label lbl = new Label();
                lbl.Location = new Point(x, 140);
                lbl.Size = new Size(230, 30);
                lbl.Font = new Font("Microsoft Sans Serif", 12);
                lbl.Text = lev1[i + 2];
                lbl.Tag = lev1[i];
                lbl.Click += new EventHandler(label_Click);
                Level1Panel.Controls.Add(lbl);

                x += 240;
            }
        }
        private void Level1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            Level1UserControl level1UC = new Level1UserControl(pb.Tag.ToString());
            Controls.Clear();
            Controls.Add(level1UC);
            level1UC.Dock = DockStyle.None;
        }

        private void label_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            Level1UserControl level1UC = new Level1UserControl(lbl.Tag.ToString());
            Controls.Clear();
            Controls.Add(level1UC);
            level1UC.Dock = DockStyle.None;
        }

        private void Level0Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
