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
    public partial class DesignUserControl : UserControl
    {
        #region textbox
        public static Font TEXTBOX_FONT;
        public static Color TEXTBOX_FONT_COLOR;
        #endregion

        #region button
        public static Font BUTTON_FONT;
        public static Color BUTTON_FONT_COLOR;
        public static Color BUTTON_COLOR;
        #endregion

        #region label
        public static Font LABEL_FONT;
        public static Color LABEL_FONT_COLOR;
        #endregion

        #region panel       
        public static Color PANEL_COLOR;
        #endregion

        public DesignUserControl()
        {
            InitializeComponent();
        }

        public static void ReadDefaultDesign()
        {
            try
            {
                string color = SQLClass.Select("SELECT value FROM defaultDesign WHERE type = 'System.Windows.Forms.Button' AND parameter = 'COLOR'")[0];
                BUTTON_COLOR = Color.FromArgb(Convert.ToInt32(color));
            }
            catch (Exception) { }
        }

        public static void ApplyDesign(Control Form)
        {
            foreach (Control ctrl in Form.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Font = TEXTBOX_FONT;
                    ctrl.ForeColor = TEXTBOX_FONT_COLOR;
                }
                else
                {
                    ApplyDesign(ctrl);
                }

                if (ctrl is Button)
                {
                    ctrl.Font = BUTTON_FONT;
                    ctrl.ForeColor = BUTTON_FONT_COLOR;
                    ctrl.BackColor = BUTTON_COLOR;
                }
                else
                {
                    ApplyDesign(ctrl);
                }

                if (ctrl is Label)
                {
                    ctrl.Font = LABEL_FONT;
                    ctrl.ForeColor = LABEL_FONT_COLOR;
                }
                else
                {
                    ApplyDesign(ctrl);
                }

                if (ctrl is Panel)
                {
                    ctrl.BackColor = PANEL_COLOR;
                }
                else
                {
                    ApplyDesign(ctrl);
                }
            }
        }

        /// <summary>
        /// Шрифт текстбокса
        /// </summary>
        private void TextboxFontButton_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = TEXTBOX_FONT;
            fontDialog1.Color = TEXTBOX_FONT_COLOR;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                TEXTBOX_FONT = fontDialog1.Font;
                TEXTBOX_FONT_COLOR = fontDialog1.Color;

                DesignUserControl_Load(null, null);
            }
        }

        /// <summary>
        /// Шрифт кнопки
        /// </summary>
        private void ButtonFontButton_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = BUTTON_FONT;
            fontDialog1.Color = BUTTON_FONT_COLOR;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                BUTTON_FONT = fontDialog1.Font;
                BUTTON_FONT_COLOR = fontDialog1.Color;

                DesignUserControl_Load(null, null);
            }
        }

        /// <summary>
        /// Цвет кнопки
        /// </summary>
        private void ButtonColorButton_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = BUTTON_COLOR;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                BUTTON_COLOR = colorDialog1.Color;

                DesignUserControl_Load(null, null);

                SQLClass.Update("DELETE FROM defaultDesign WHERE type = '" + button3.GetType() + "' AND parameter = 'COLOR'");

                SQLClass.Update("INSERT INTO defaultDesign (type, parameter, value) VALUES ('" + button3.GetType() + "', 'COLOR', '" + BUTTON_COLOR.ToArgb() + "')");
            }
        }

        /// <summary>
        /// Шрифт лайбла
        /// </summary>
        private void LabelFontButton_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = LABEL_FONT;
            fontDialog1.Color = LABEL_FONT_COLOR;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                LABEL_FONT = fontDialog1.Font;
                LABEL_FONT_COLOR = fontDialog1.Color;

                DesignUserControl_Load(null, null);
            }
        }

        /// <summary>
        /// Цвет панели
        /// </summary>
        private void PanelColorButton_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = PANEL_COLOR;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                PANEL_COLOR = colorDialog1.Color;

                DesignUserControl_Load(null, null);
            }
        }

        private void DesignUserControl_Load(object sender, EventArgs e)
        {
            textBox1.Font = TEXTBOX_FONT;
            textBox1.ForeColor = TEXTBOX_FONT_COLOR;
            button3.Font = BUTTON_FONT;
            button3.ForeColor = BUTTON_FONT_COLOR;
            button3.BackColor = BUTTON_COLOR;
            label3.Font = LABEL_FONT;
            label3.ForeColor = LABEL_FONT_COLOR;
            panel1.BackColor = PANEL_COLOR;
        }
    }
}
