using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp
{
    public partial class UniqueDesignForm : Form
    {
        Button btn;
        public UniqueDesignForm(Button _btn)
        {
            InitializeComponent();

            btn = _btn;

            button3.Text = btn.Text;
            button3.Font = btn.Font;
            button3.ForeColor = btn.ForeColor;
            button3.BackColor = btn.BackColor;
            button3.Size = btn.Size;

            ButtonCoordsTextBox.Text = btn.Location.X.ToString() + ", " + btn.Location.Y.ToString();
            ButtonSizeTextBox.Text = btn.Size.Width.ToString() + ", " + btn.Size.Height.ToString();
            ButtonCheckBox.Checked = Convert.ToBoolean(Convert.ToInt32(btn.AccessibleDescription));
        }

        private void UniqueDesignForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Шрифт кнопки
        /// </summary>
        private void ButtonFontButton_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = button3.Font;
            fontDialog1.Color = button3.ForeColor;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                button3.Font = fontDialog1.Font;
                button3.ForeColor = fontDialog1.Color;

                UniqueDesignForm_Load(null, null);

                SQLClass.Update("DELETE FROM uniqueDesign WHERE type = '" + button3.GetType() + "' AND name = '" + btn.Name + "' AND form = '" + btn.FindForm().Name + "' AND parameter = 'FONT'");
                SQLClass.Update("DELETE FROM uniqueDesign WHERE type = '" + button3.GetType() + "' AND name = '" + btn.Name + "' AND form = '" + btn.FindForm().Name + "' AND parameter = 'FONT_COLOR'");

                SQLClass.Update("INSERT INTO uniqueDesign (type, name, form, parameter, value) VALUES ('" + button3.GetType() + "', '" + btn.Name + "', '" + btn.FindForm().Name + "', 'FONT', '" + button3.Font.Name + ";" + button3.Font.Size.ToString() + "')");
                SQLClass.Update("INSERT INTO uniqueDesign (type, name, form, parameter, value) VALUES ('" + button3.GetType() + "', '" + btn.Name + "', '" + btn.FindForm().Name + "', 'FONT_COLOR', '" + button3.ForeColor.ToArgb() + "')");
            }
        }

        /// <summary>
        /// Цвет кнопки
        /// </summary>
        private void ButtonColorButton_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = button3.BackColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button3.BackColor = colorDialog1.Color;

                UniqueDesignForm_Load(null, null);

                SQLClass.Update("DELETE FROM uniqueDesign WHERE type = '" + button3.GetType() + "' AND name = '" + btn.Name + "' AND form = '" + btn.FindForm().Name + "' AND parameter = 'COLOR'");
                SQLClass.Update("INSERT INTO uniqueDesign (type, name, form, parameter, value) VALUES ('" + button3.GetType() + "', '" + btn.Name + "', '" + btn.FindForm().Name + "', 'COLOR', '" + button3.BackColor.ToArgb() + "')");
            }
        }

        private void SaveCoordButton_Click(object sender, EventArgs e)
        {
            SQLClass.Update("DELETE FROM uniqueDesign WHERE type = '" + button3.GetType() + "' AND name = '" + btn.Name + "' AND form = '" + btn.FindForm().Name + "' AND parameter = 'LOCATION'");
            SQLClass.Update("DELETE FROM uniqueDesign WHERE type = '" + button3.GetType() + "' AND name = '" + btn.Name + "' AND form = '" + btn.FindForm().Name + "' AND parameter = 'SIZE'");

            SQLClass.Update("INSERT INTO uniqueDesign (type, name, form, parameter, value) VALUES ('" + button3.GetType() + "', '" + btn.Name + "', '" + btn.FindForm().Name + "', 'LOCATION' , '" + ButtonCoordsTextBox.Text + "')");
            SQLClass.Update("INSERT INTO uniqueDesign (type, name, form, parameter, value) VALUES ('" + button3.GetType() + "', '" + btn.Name + "', '" + btn.FindForm().Name + "', 'SIZE' , '" + ButtonSizeTextBox.Text + "')");
        }

        private void ButtonCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SQLClass.Update("DELETE FROM uniqueDesign WHERE type = '" + button3.GetType() + "' AND name = '" + btn.Name + "' AND form = '" + btn.FindForm().Name + "' AND parameter = 'ADMIN'");
            SQLClass.Update("INSERT INTO uniqueDesign (type, name, form, parameter, value) VALUES ('" + button3.GetType() + "', '" + btn.Name + "', '" + btn.FindForm().Name + "', 'ADMIN' , '" + ((ButtonCheckBox.Checked) ? "1": "0") + "')");
        }
    }
}
