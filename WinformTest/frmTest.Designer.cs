namespace WinformTest
{
    partial class frmTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxLabColorB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxLabColorA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxLabColorL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxRGB_B = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxRGB_G = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxRGB_R = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlColorPreview = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCalColor = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxLabColorB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxLabColorA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxLabColorL);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LAB";
            // 
            // tbxLabColorB
            // 
            this.tbxLabColorB.Location = new System.Drawing.Point(36, 122);
            this.tbxLabColorB.MaxLength = 4;
            this.tbxLabColorB.Name = "tbxLabColorB";
            this.tbxLabColorB.Size = new System.Drawing.Size(100, 21);
            this.tbxLabColorB.TabIndex = 3;
            this.tbxLabColorB.Text = "0";
            this.tbxLabColorB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLabColorB_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "b";
            // 
            // tbxLabColorA
            // 
            this.tbxLabColorA.Location = new System.Drawing.Point(36, 77);
            this.tbxLabColorA.MaxLength = 4;
            this.tbxLabColorA.Name = "tbxLabColorA";
            this.tbxLabColorA.Size = new System.Drawing.Size(100, 21);
            this.tbxLabColorA.TabIndex = 2;
            this.tbxLabColorA.Text = "0";
            this.tbxLabColorA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLabColorA_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "a";
            // 
            // tbxLabColorL
            // 
            this.tbxLabColorL.Location = new System.Drawing.Point(36, 32);
            this.tbxLabColorL.MaxLength = 3;
            this.tbxLabColorL.Name = "tbxLabColorL";
            this.tbxLabColorL.Size = new System.Drawing.Size(100, 21);
            this.tbxLabColorL.TabIndex = 1;
            this.tbxLabColorL.Text = "0";
            this.tbxLabColorL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLabColorL_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "L";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCalColor);
            this.groupBox2.Controls.Add(this.tbxRGB_B);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbxRGB_G);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbxRGB_R);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(199, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 207);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RGB";
            // 
            // tbxRGB_B
            // 
            this.tbxRGB_B.Enabled = false;
            this.tbxRGB_B.Location = new System.Drawing.Point(36, 86);
            this.tbxRGB_B.Name = "tbxRGB_B";
            this.tbxRGB_B.Size = new System.Drawing.Size(100, 21);
            this.tbxRGB_B.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "B";
            // 
            // tbxRGB_G
            // 
            this.tbxRGB_G.Enabled = false;
            this.tbxRGB_G.Location = new System.Drawing.Point(36, 59);
            this.tbxRGB_G.Name = "tbxRGB_G";
            this.tbxRGB_G.Size = new System.Drawing.Size(100, 21);
            this.tbxRGB_G.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "G";
            // 
            // tbxRGB_R
            // 
            this.tbxRGB_R.Enabled = false;
            this.tbxRGB_R.Location = new System.Drawing.Point(36, 32);
            this.tbxRGB_R.Name = "tbxRGB_R";
            this.tbxRGB_R.Size = new System.Drawing.Size(100, 21);
            this.tbxRGB_R.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "R";
            // 
            // pnlColorPreview
            // 
            this.pnlColorPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColorPreview.Location = new System.Drawing.Point(12, 225);
            this.pnlColorPreview.Name = "pnlColorPreview";
            this.pnlColorPreview.Size = new System.Drawing.Size(351, 100);
            this.pnlColorPreview.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "(0 to 100)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(79, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "(0 to 100)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "(-128 to 128)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(61, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "(-128 to 128)";
            // 
            // btnCalColor
            // 
            this.btnCalColor.Location = new System.Drawing.Point(36, 120);
            this.btnCalColor.Name = "btnCalColor";
            this.btnCalColor.Size = new System.Drawing.Size(100, 23);
            this.btnCalColor.TabIndex = 2;
            this.btnCalColor.Text = "변환";
            this.btnCalColor.UseVisualStyleBackColor = true;
            this.btnCalColor.Click += new System.EventHandler(this.btnCalColor_Click);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 365);
            this.Controls.Add(this.pnlColorPreview);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTest";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxLabColorB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxLabColorA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxLabColorL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxRGB_B;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxRGB_G;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxRGB_R;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlColorPreview;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalColor;
    }
}