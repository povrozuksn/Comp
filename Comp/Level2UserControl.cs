using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp
{
    public partial class Level2UserControl : UserControl
    {
        public Level2UserControl(string id_level1)
        {
            InitializeComponent();

            List<string> lev2 = SQLClass.Select("SELECT ID, id_main, id_level1, Name, Image, Specs, Quantity, Price FROM level2 WHERE ID = '" + id_level1 + "'");

            try
            {
                Text = lev2[3];
                label1.Text = lev2[3];
                pictureBox1.Load("../../Pictures/" + lev2[4]);
            }
            catch (Exception) { };

            DesignUserControl.ApplyDesign(this);
        }



        private void Level2UserControl_Load(object sender, EventArgs e)
        {
            DesignUserControl.ApplyDesign(this);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
