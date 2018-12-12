﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using LABtoRGB.Lib;

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
            onlyNum(sender, e);


            CalColor();
        }

        private void tbxLabColorA_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNum(sender, e);

            CalColor();
        }

        private void tbxLabColorB_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNum(sender, e);

            CalColor();
        }

        private void CalColor()
        {
            double _L, _a, _b;

            if (string.IsNullOrEmpty(tbxLabColorL.Text))
            {
                tbxLabColorL.Text = "0";
            }
            if (string.IsNullOrEmpty(tbxLabColorA.Text))
            {
                tbxLabColorA.Text = "0";
            }
            if (string.IsNullOrEmpty(tbxLabColorB.Text))
            {
                tbxLabColorB.Text = "0";
            }

            _L = double.Parse(tbxLabColorL.Text);
            _a = double.Parse(tbxLabColorA.Text);
            _b = double.Parse(tbxLabColorB.Text);

            //ConvertColor

            for (int i = 0; i < cc; i++)
            {

            }

            
        }

        private void onlyNum(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        } // end onlyNum(object sender, KeyPressEventArgs e) 
    }
}