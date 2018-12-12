using System;
using System.Collections.Generic;
using System.Drawing;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using LabToRGBColor.Lib;

namespace WebTest
{
    public partial class testWeb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var r = Request["rgb_r"];
            var g = Request["rgb_g"];
            var b = Request["rgb_b"];
        }

        protected void tbxLabColorL_TextChanged(object sender, EventArgs e)
        {
            TypingOnlyNumber(sender, e, true, true);
        }

        protected void tbxLabColorA_TextChanged(object sender, EventArgs e)
        {
            TypingOnlyNumber(sender, e, true, true);
        }

        protected void tbxLabColorB_TextChanged(object sender, EventArgs e)
        {
            TypingOnlyNumber(sender, e, true, true);
        }

        /// <summary>
        /// 실수만
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="includePoint"></param>
        /// <param name="includeMinus"></param>
        public static void TypingOnlyNumber(object sender, EventArgs e, bool includePoint, bool includeMinus)
        {
            bool isValidInput = false;
            //if (!char.IsControl(e..KeyChar) && !char.IsDigit(e.KeyChar))
            //{
            //    if (includePoint == true) { if (e.KeyChar == '.') isValidInput = true; }
            //    if (includeMinus == true) { if (e.KeyChar == '-') isValidInput = true; }

            //    if (isValidInput == false) e.Handled = true;
            //}

            //if (includePoint == true)
            //{
            //    if (e.KeyChar == '.' && (string.IsNullOrEmpty((sender as TextBox).Text.Trim()) || (sender as TextBox).Text.IndexOf('.') > -1)) e.Handled = true;
            //}
            //if (includeMinus == true)
            //{
            //    if (e.KeyChar == '-' && (!string.IsNullOrEmpty((sender as TextBox).Text.Trim()) || (sender as TextBox).Text.IndexOf('-') > -1)) e.Handled = true;
            //}
        } // end TypingOnlyNumber(object sender, KeyPressEventArgs e, bool includePoint, bool includeMinus)

        private void CalColor(bool previewColor)
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

            if (previewColor)
            {
                //pnlColorPreview.BackColor = Color.FromArgb(int.Parse(rgb[0].ToString()), int.Parse(rgb[1].ToString()), int.Parse(rgb[2].ToString()));
                //tdColor.BgColor = string.Format("rgb({0},{1},{2})", rgb[0].ToString(), rgb[1].ToString(), rgb[2].ToString()) ;
                //background-color: rgb(243, 255, 0);
                //tdColor.Style.ba
            }


        }

        protected void btnCalColor_Click(object sender, EventArgs e)
        {
            CalColor(true);
        }
    }
}