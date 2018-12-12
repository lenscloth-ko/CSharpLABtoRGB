using LabToRGBColor.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace WinformTest
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
            //pnlColorPreview.BackColor = Color.FromArgb(100, 100, 100);
        }

        private void tbxLabColorL_KeyPress(object sender, KeyPressEventArgs e)
        {
            TypingOnlyNumber(sender, e, true, false);

            //CalColor();
        }

        private void tbxLabColorA_KeyPress(object sender, KeyPressEventArgs e)
        {
            TypingOnlyNumber(sender, e, true, true);

            //CalColor();
        }

        private void tbxLabColorB_KeyPress(object sender, KeyPressEventArgs e)
        {
            TypingOnlyNumber(sender, e, true, true);

            //CalColor();
        }

        private void CalColor()
        {
            double _L, _a, _b;

            //if (string.IsNullOrEmpty(tbxLabColorL.Text))
            //{
            //    tbxLabColorL.Text = "0";
            //}
            //if (string.IsNullOrEmpty(tbxLabColorA.Text))
            //{
            //    tbxLabColorA.Text = "0";
            //}
            //if (string.IsNullOrEmpty(tbxLabColorB.Text))
            //{
            //    tbxLabColorB.Text = "0";
            //}

            _L = double.Parse(tbxLabColorL.Text);
            _a = double.Parse(tbxLabColorA.Text);
            _b = double.Parse(tbxLabColorB.Text);

            ConvertColor cc = new ConvertColor();

            double[] rgb = new double[3];

            //Array rgb = new Array[3];

            rgb = cc.GetLabToRGB(_L, _a, _b);

            tbxRGB_R.Text = rgb[0].ToString();
            tbxRGB_G.Text = rgb[1].ToString();
            tbxRGB_B.Text = rgb[2].ToString();

        }

        /// <summary>
        /// 실수만
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="includePoint"></param>
        /// <param name="includeMinus"></param>
        public static void TypingOnlyNumber(object sender, KeyPressEventArgs e, bool includePoint, bool includeMinus)
        {
            bool isValidInput = false;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                if (includePoint == true) { if (e.KeyChar == '.') isValidInput = true; }
                if (includeMinus == true) { if (e.KeyChar == '-') isValidInput = true; }

                if (isValidInput == false) e.Handled = true;
            }

            if (includePoint == true)
            {
                if (e.KeyChar == '.' && (string.IsNullOrEmpty((sender as TextBox).Text.Trim()) || (sender as TextBox).Text.IndexOf('.') > -1)) e.Handled = true;
            }
            if (includeMinus == true)
            {
                if (e.KeyChar == '-' && (!string.IsNullOrEmpty((sender as TextBox).Text.Trim()) || (sender as TextBox).Text.IndexOf('-') > -1)) e.Handled = true;
            }
        } // end TypingOnlyNumber(object sender, KeyPressEventArgs e, bool includePoint, bool includeMinus)

        /// <summary>
        /// btnCalColor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalColor_Click(object sender, EventArgs e)
        {
            CalColor();
        } // end btnCalColor_Click
    }
}
