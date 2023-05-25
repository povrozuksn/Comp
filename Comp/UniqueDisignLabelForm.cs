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
    public partial class UniqueDisignLabelForm : Form
    {
        Label lbl;
        public UniqueDisignLabelForm(Label _lbl)
        {
            InitializeComponent();

            lbl = _lbl;

            label1.Text = lbl.Text;
            label1.Font = lbl.Font;
            label1.ForeColor = lbl.ForeColor;
        }

        private void UniqueDisignLabelForm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonFontButton_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = label1.Font;
            fontDialog1.Color = label1.ForeColor;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Font = fontDialog1.Font;
                label1.ForeColor = fontDialog1.Color;

                UniqueDisignLabelForm_Load(null, null);

                SQLClass.Update("DELETE FROM " + SQLClass.UNIQUE_DESIGN + " WHERE type = '" + label1.GetType() + "' AND name = '" + lbl.Name + "' AND form = '" + lbl.FindForm().Name + "' AND parameter = 'FONT'");
                SQLClass.Update("DELETE FROM " + SQLClass.UNIQUE_DESIGN + " WHERE type = '" + label1.GetType() + "' AND name = '" + lbl.Name + "' AND form = '" + lbl.FindForm().Name + "' AND parameter = 'FONT_COLOR'");

                SQLClass.Update("INSERT INTO " + SQLClass.UNIQUE_DESIGN + " (type, name, form, parameter, value) VALUES ('" + label1.GetType() + "', '" + lbl.Name + "', '" + lbl.FindForm().Name + "', 'FONT', '" + label1.Font.Name + ";" + label1.Font.Size.ToString() + "')");
                SQLClass.Update("INSERT INTO " + SQLClass.UNIQUE_DESIGN + " (type, name, form, parameter, value) VALUES ('" + label1.GetType() + "', '" + lbl.Name + "', '" + lbl.FindForm().Name + "', 'FONT_COLOR', '" + label1.ForeColor.ToArgb() + "')");
            }
        }
    }
}
