using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Comp
{
    public partial class DesignUserControl : UserControl
    {

        public static ContextMenuStrip BLOCK_CM;
        public static ContextMenuStrip BUTTON_CM;
        public static ContextMenuStrip LABEL_CM;

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
            ///Чтение цвета кнопки
            try
            {
                string color = SQLClass.Select("SELECT value FROM defaultDesign WHERE type = 'System.Windows.Forms.Button' AND parameter = 'COLOR'")[0];
                BUTTON_COLOR = Color.FromArgb(Convert.ToInt32(color));
            }
            catch (Exception) { }

            ///Чтение типа и цвета шрифта кнопки
            try
            {
                string color = SQLClass.Select("SELECT value FROM defaultDesign WHERE type = 'System.Windows.Forms.Button' AND parameter = 'FONT_COLOR'")[0];
                BUTTON_FONT_COLOR = Color.FromArgb(Convert.ToInt32(color));

                string font = SQLClass.Select("SELECT value FROM defaultDesign WHERE type = 'System.Windows.Forms.Button' AND parameter = 'FONT'")[0];
                string[] parts = font.Split(new char[] {';'});
                BUTTON_FONT = new Font(new FontFamily(parts[0]), (float)Convert.ToDouble(parts[1]));
            }
            catch (Exception) { }

            ///Чтение типа и цвета шрифта текстбоксов
            try
            {
                string color = SQLClass.Select("SELECT value FROM defaultDesign WHERE type = 'System.Windows.Forms.textBox' AND parameter = 'FONT_COLOR'")[0];
                TEXTBOX_FONT_COLOR = Color.FromArgb(Convert.ToInt32(color));

                string font = SQLClass.Select("SELECT value FROM defaultDesign WHERE type = 'System.Windows.Forms.textBox' AND parameter = 'FONT'")[0];
                string[] parts = font.Split(new char[] { ';' });
                TEXTBOX_FONT = new Font(new FontFamily(parts[0]), (float)Convert.ToDouble(parts[1]));
            }
            catch (Exception) { }

            ///Чтение типа и цвета шрифта лейблов
            try
            {
                string color = SQLClass.Select("SELECT value FROM defaultDesign WHERE type = 'System.Windows.Forms.label' AND parameter = 'FONT_COLOR'")[0];
                LABEL_FONT_COLOR = Color.FromArgb(Convert.ToInt32(color));

                string font = SQLClass.Select("SELECT value FROM defaultDesign WHERE type = 'System.Windows.Forms.label' AND parameter = 'FONT'")[0];
                string[] parts = font.Split(new char[] { ';' });
                LABEL_FONT = new Font(new FontFamily(parts[0]), (float)Convert.ToDouble(parts[1]));
            }
            catch (Exception) { }

            ///Чтение цвета панели
            try
            {
                string color = SQLClass.Select("SELECT value FROM defaultDesign WHERE type = 'System.Windows.Forms.panel' AND parameter = 'COLOR'")[0];
                PANEL_COLOR = Color.FromArgb(Convert.ToInt32(color));
            }
            catch (Exception) { }
        }

        public static void ReadBlockDesign(Control block)
        {
            Control parent = block;
            while (!(parent is Panel || parent is TableLayoutPanel ||
                    parent is UserControl || parent is Form))
            {
                parent = parent.Parent;
            }
            try
            {
                string width = SQLClass.Select("SELECT value FROM blockdesign WHERE name = '" + block.Name + "' AND form = '" + parent.Name + "' AND parameter = 'WIDTH'")[0];
            
                int WIDTH = Convert.ToInt32(width);
                TableLayoutPanel tp = (TableLayoutPanel)block.Parent;
                TableLayoutPanelCellPosition pos = tp.GetPositionFromControl(block);
                tp.ColumnStyles[pos.Column].Width = WIDTH;

            }
            catch (Exception) { }
        }

        public static void ReadUniqueButtonDesign(Button btn)
        {
            //Чтение цвета кнопки
            try
            {
                string color = SQLClass.Select("SELECT value FROM uniqueDesign WHERE type = 'System.Windows.Forms.Button' AND name = '" + btn.Name + "' AND form = '" + btn.FindForm().Name + "' AND parameter = 'COLOR'")[0];
                btn.BackColor = Color.FromArgb(Convert.ToInt32(color));
            }
            catch (Exception) { }

            //Чтение типа и цвета шрифта кнопки
            try
            {
                string color = SQLClass.Select("SELECT value FROM uniqueDesign WHERE type = 'System.Windows.Forms.Button' AND name = '" + btn.Name + "' AND form = '" + btn.FindForm().Name + "' AND parameter = 'FONT_COLOR'")[0];
                btn.ForeColor = Color.FromArgb(Convert.ToInt32(color));

                string font = SQLClass.Select("SELECT value FROM uniqueDesign WHERE type = 'System.Windows.Forms.Button' AND name = '" + btn.Name + "' AND form = '" + btn.FindForm().Name + "' AND parameter = 'FONT'")[0];
                string[] parts = font.Split(new char[] { ';' });
                btn.Font = new Font(new FontFamily(parts[0]), (float)Convert.ToDouble(parts[1]));
            }
            catch (Exception) { }

            //Чтение координат положения
            try
            {
                string location = SQLClass.Select("SELECT value FROM uniqueDesign WHERE type = 'System.Windows.Forms.Button' AND name = '" + btn.Name + "' AND form = '" + btn.FindForm().Name + "' AND parameter = 'LOCATION'")[0];
                string[] parts = location.Split(new char[] { ',' });
                btn.Location = new Point(Convert.ToInt32(parts[0]), Convert.ToInt32(parts[1]));
            }
            catch (Exception) { }

            //Чтение размера
            try
            {
                string size = SQLClass.Select("SELECT value FROM uniqueDesign WHERE type = 'System.Windows.Forms.Button' AND name = '" + btn.Name + "' AND form = '" + btn.FindForm().Name + "' AND parameter = 'SIZE'")[0];
                string[] parts = size.Split(new char[] { ',' });
                btn.Size = new Size(Convert.ToInt32(parts[0]), Convert.ToInt32(parts[1]));
            }
            catch (Exception) { }

            //Чтение доступности админу
            try
            {
                string admin = SQLClass.Select("SELECT value FROM uniqueDesign WHERE type = 'System.Windows.Forms.Button' AND name = '" + btn.Name + "' AND form = '" + btn.FindForm().Name + "' AND parameter = 'ADMIN'")[0];
                btn.AccessibleDescription = admin; 
            }
            catch (Exception) { }
        }

        public static void ReadUniqueLabelDesign(Label lbl)
        {
            //Чтение типа и цвета шрифта лэйбла
            try
            {
                string color = SQLClass.Select("SELECT value FROM uniqueDesign WHERE type = 'System.Windows.Forms.Label' AND name = '" + lbl.Name + "' AND form = '" + lbl.FindForm().Name + "' AND parameter = 'FONT_COLOR'")[0];
                lbl.ForeColor = Color.FromArgb(Convert.ToInt32(color));

                string font = SQLClass.Select("SELECT value FROM uniqueDesign WHERE type = 'System.Windows.Forms.Label' AND name = '" + lbl.Name + "' AND form = '" + lbl.FindForm().Name + "' AND parameter = 'FONT'")[0];
                string[] parts = font.Split(new char[] { ';' });
                lbl.Font = new Font(new FontFamily(parts[0]), (float)Convert.ToDouble(parts[1]));
            }
            catch (Exception) { }

            
        }
        public static void ApplyMenu(Control Form)
        {
            foreach (Control ctrl in Form.Controls)
            {              
                if (ctrl is Button && MainForm.isAdmin)
                {
                    ctrl.ContextMenuStrip = BUTTON_CM;                    
                }
                else
                {
                    ApplyMenu(ctrl);
                }

                if(ctrl is Label && MainForm.isAdmin)
                {
                    ctrl.ContextMenuStrip = LABEL_CM;
                }
                else
                {
                    ApplyMenu(ctrl);
                }
            }
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
                    ReadUniqueButtonDesign(ctrl as Button);

                    if(!MainForm.isAdmin && ctrl.AccessibleDescription == "1")
                    {
                        ctrl.Visible = false;
                    }
                }
                else
                {
                    ApplyDesign(ctrl);
                }

                if (ctrl is Label)
                {
                    ctrl.Font = LABEL_FONT;
                    ctrl.ForeColor = LABEL_FONT_COLOR;
                    //ReadUniqueLabelDesign(ctrl as Label);
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

                if (ctrl.AccessibleDescription == "block")
                {
                    ReadBlockDesign(ctrl);
                    ApplyDesign(ctrl);
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

                SQLClass.Update("DELETE FROM defaultDesign WHERE type = '" + textBox1.GetType() + "' AND parameter = 'FONT'");
                SQLClass.Update("DELETE FROM defaultDesign WHERE type = '" + textBox1.GetType() + "' AND parameter = 'FONT_COLOR'");

                SQLClass.Update("INSERT INTO defaultDesign (type, parameter, value) VALUES ('" + textBox1.GetType() + "', 'FONT', '" + TEXTBOX_FONT.Name + ";" + TEXTBOX_FONT.Size.ToString() + "')");
                SQLClass.Update("INSERT INTO defaultDesign (type, parameter, value) VALUES ('" + textBox1.GetType() + "', 'FONT_COLOR', '" + TEXTBOX_FONT_COLOR.ToArgb() + "')");

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

                SQLClass.Update("DELETE FROM defaultDesign WHERE type = '" + button3.GetType() + "' AND parameter = 'FONT'");
                SQLClass.Update("DELETE FROM defaultDesign WHERE type = '" + button3.GetType() + "' AND parameter = 'FONT_COLOR'");

                SQLClass.Update("INSERT INTO defaultDesign (type, parameter, value) VALUES ('" + button3.GetType() + "', 'FONT', '" + BUTTON_FONT.Name + ";" + BUTTON_FONT.Size.ToString() + "')");
                SQLClass.Update("INSERT INTO defaultDesign (type, parameter, value) VALUES ('" + button3.GetType() + "', 'FONT_COLOR', '" + BUTTON_FONT_COLOR.ToArgb() + "')");
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

                SQLClass.Update("DELETE FROM defaultDesign WHERE type = '" + label3.GetType() + "' AND parameter = 'FONT'");
                SQLClass.Update("DELETE FROM defaultDesign WHERE type = '" + label3.GetType() + "' AND parameter = 'FONT_COLOR'");

                SQLClass.Update("INSERT INTO defaultDesign (type, parameter, value) VALUES ('" + label3.GetType() + "', 'FONT', '" + LABEL_FONT.Name + ";" + LABEL_FONT.Size.ToString() + "')");
                SQLClass.Update("INSERT INTO defaultDesign (type, parameter, value) VALUES ('" + label3.GetType() + "', 'FONT_COLOR', '" + LABEL_FONT_COLOR.ToArgb() + "')");
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

                SQLClass.Update("DELETE FROM defaultDesign WHERE type = '" + panel1.GetType() + "' AND parameter = 'COLOR'");

                SQLClass.Update("INSERT INTO defaultDesign (type, parameter, value) VALUES ('" + panel1.GetType() + "', 'COLOR', '" + PANEL_COLOR.ToArgb() + "')");

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
