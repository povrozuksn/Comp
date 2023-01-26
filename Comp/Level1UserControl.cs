﻿using System;
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
        public Level1UserControl(string id_main)
        {
            InitializeComponent();

            List<string> lev1 = SQLClass.Select("SELECT ID, id_main, Name, Image, Specs, Quantity, Price FROM level1 WHERE id_main = '" + id_main + "'");

            Text = lev1[2];
            label1.Text = lev1[2];
            try
            {
                pictureBox1.Load("../../Pictures/" + lev1[3]);
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
                pb.Location = new Point(x, 50);
                pb.Size = new Size(100, 100);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Tag = lev1[i];
                pb.Click += new EventHandler(pictureBox_Click);
                Level1Panel.Controls.Add(pb);

                Label lbl = new Label();
                lbl.Location = new Point(x, 160);
                lbl.Size = new Size(200, 30);
                lbl.Font = new Font("Microsoft Sans Serif", 12);
                lbl.Text = lev1[i + 2];
                lbl.Tag = lev1[i];
                lbl.Click += new EventHandler(label_Click);
                Level1Panel.Controls.Add(lbl);

                x += 210;
            }
        }
        private void Level1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            Level2 level2 = new Level2(pb.Tag.ToString());
            level2.ShowDialog();
        }

        private void label_Click(object sender, EventArgs e)
        {
            Label pb = (Label)sender;
            Level2 level2 = new Level2(pb.Tag.ToString());
            level2.ShowDialog();
        }
    }
}
