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
    public partial class RedLeve2UserControl : UserControl
    {
        public RedLeve2UserControl()
        {
            InitializeComponent();

            List<string> level1_list = SQLClass.Select("SELECT ID, id_main, Name FROM level1");

            comboBox1.Items.Clear();
            for(int i=0; i< level1_list.Count; i+=3)
            {
                comboBox1.Items.Add(level1_list[i] + "," + level1_list[i+1] + "," + level1_list[i + 2]);
            }
            DesignUserControl.ApplyDesign(this);
            DesignUserControl.ApplyMenu(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] parts = comboBox1.Text.Split(new char[] { ',' });

            SQLClass.Update("INSERT INTO level2 (id_main, id_level1, Name, Image, Quantity, Price)" +
                              "VALUES('" + parts[1] + "', '" + parts[0] + "', '" +  NameTextBox.Text + "', '" + adress + "', '" + QuantityTextBox.Text +  "', '" + PriceTextBox.Text + "')");

            MessageBox.Show("Сохранено");
            RedLeve2UserControl_Load(sender, e);
            return;
        }

        private void RedLeve2UserControl_Load(object sender, EventArgs e)
        {
            List<string> list = SQLClass.Select("SELECT ID, id_main, id_level1, Name, kod FROM level2");

            panel1.Controls.Clear();
            int y = 10;
            for (int i = 0; i < list.Count; i += 5)
            {
                Label lbl0 = new Label();
                lbl0.Location = new Point(50, y);
                lbl0.Size = new Size(170, 30);
                lbl0.Font = new Font("Microsoft Sans Serif", 12);
                lbl0.Text = list[i+1];
                lbl0.Tag = list[i];
                panel1.Controls.Add(lbl0);

                Label lbl1 = new Label();
                lbl1.Location = new Point(225, y);
                lbl1.Size = new Size(50, 30);
                lbl1.Font = new Font("Microsoft Sans Serif", 12);
                lbl1.Text = list[i + 2];
                panel1.Controls.Add(lbl1);

                Label lbl2 = new Label();
                lbl2.Location = new Point(280, y);
                lbl2.Size = new Size(250, 30);
                lbl2.Font = new Font("Microsoft Sans Serif", 12);
                lbl2.Text = list[i + 3];
                panel1.Controls.Add(lbl2);

                Button btn = new Button();
                btn.Location = new Point(540, y);
                btn.Size = new Size(100, 30);
                btn.Font = new Font("Microsoft Sans Serif", 12);
                btn.Click += new EventHandler(DeleteRoomClick);
                btn.Text = "Удалить";
                panel1.Controls.Add(btn);

                Button btn1 = new Button();
                btn1.Location = new Point(650, y);
                btn1.Size = new Size(100, 30);
                btn1.Font = new Font("Microsoft Sans Serif", 12);
                btn1.Click += new EventHandler(Refresh);
                btn1.Text = "Обновить";
                btn1.Tag = list[i+4];
                panel1.Controls.Add(btn1);

                y += 35;
            }
            //DesignUserControl.ApplyDesign(this);
            //DesignUserControl.ApplyMenu(this);
        }


        private void DeleteRoomClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;

            foreach (Control control in panel1.Controls)
            {
                if (control.Location == new Point(50, y))
                {
                    SQLClass.Update("DELETE FROM level2 WHERE ID = '" + control.Tag + "'");
                    RedLeve2UserControl_Load(sender, e);
                    return;
                }
            }
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

        #region Поиск и обновление цены
        public static void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser webbrowser = (WebBrowser)sender;
            string sReadData = webbrowser.Document.Body.InnerHtml;

            //Поиск имени
            string[] parts = sReadData.Split(new char[] { '\n' });
            string name = parts[1].Substring(4);

            //Поиск цены
            for(int i=0; i<parts.Length; i++)
            {
                string[] parts1 = parts[i].Split(new string[] { "meta content" }, StringSplitOptions.None);
            }
            /*
            string price = parts[93].Substring(1);
            int pos1 = price.IndexOf(" ");
            int pos2 = price.IndexOf(" ", pos1 + 1);
            price = price.Substring(0, pos2);
            int currentprice = Convert.ToInt32(price.Replace(" ", ""));

            SQLClass.Update("UPDATE level2 SET Name = '" + name + "', Price = " + currentprice + " WHERE kod = '" + kod + "'");
            */
            MessageBox.Show("OK");
        }

        /// <summary>
        /// Поиск цены
        /// </summary>
        public static void Prices(string kod)
        {
            string link = SQLClass.Select("SELECT link FROM level2 WHERE kod = '" + kod + "'")[0];

            if (link != "")
            {
                WebBrowser wb = new WebBrowser();
                wb.DocumentCompleted += webBrowser1_DocumentCompleted;
                wb.Navigate(link);
            }
        }

        private void Refresh(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Prices(button.Tag.ToString());
        }

        #endregion
    }
}
