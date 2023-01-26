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
    public partial class Level2 : Form
    {
        public Level2(string id_level1)
        {
            InitializeComponent();

            
            List<string> lev2 = SQLClass.Select("SELECT ID, id_main, id_level1, Name, Image, Specs, Quantity, Price FROM level2 WHERE id_level1 = '" + id_level1 + "'");
           
            if(lev2[1] == "1")
            {
                Text = lev2[3];
                label1.Text = lev2[3];
                try
                {
                    pictureBox1.Load("../../Pictures/" + lev2[4]);
                }
                catch (Exception) { };

            }
            
            
        }

        private void Level2_Load(object sender, EventArgs e)
        {

        }
    }
}
