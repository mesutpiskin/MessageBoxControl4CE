namespace TestProject
{
    partial class Form1
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
            this.lbl_Sonuc = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_show3 = new System.Windows.Forms.Button();
            this.btn_show1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_show2 = new System.Windows.Forms.Button();
            this.btn_hide = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Sonuc
            // 
            this.lbl_Sonuc.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular);
            this.lbl_Sonuc.Location = new System.Drawing.Point(26, 168);
            this.lbl_Sonuc.Name = "lbl_Sonuc";
            this.lbl_Sonuc.Size = new System.Drawing.Size(394, 75);
            this.lbl_Sonuc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.btn_show3);
            this.panel1.Controls.Add(this.btn_show1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btn_show2);
            this.panel1.Controls.Add(this.btn_hide);
            this.panel1.Location = new System.Drawing.Point(6, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 437);
            // 
            // btn_show3
            // 
            this.btn_show3.Location = new System.Drawing.Point(182, 7);
            this.btn_show3.Name = "btn_show3";
            this.btn_show3.Size = new System.Drawing.Size(103, 46);
            this.btn_show3.TabIndex = 8;
            this.btn_show3.Text = "SHOW (t=1s)";
            this.btn_show3.Click += new System.EventHandler(this.btn_show3_Click);
            // 
            // btn_show1
            // 
            this.btn_show1.Location = new System.Drawing.Point(3, 7);
            this.btn_show1.Name = "btn_show1";
            this.btn_show1.Size = new System.Drawing.Size(64, 46);
            this.btn_show1.TabIndex = 5;
            this.btn_show1.Text = "SHOW";
            this.btn_show1.Click += new System.EventHandler(this.btn_show1_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(3, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(490, 375);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(58, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(69, 95);
            // 
            // btn_show2
            // 
            this.btn_show2.Location = new System.Drawing.Point(73, 7);
            this.btn_show2.Name = "btn_show2";
            this.btn_show2.Size = new System.Drawing.Size(103, 46);
            this.btn_show2.TabIndex = 7;
            this.btn_show2.Text = "SHOW (t=10s)";
            this.btn_show2.Click += new System.EventHandler(this.btn_show2_Click);
            // 
            // btn_hide
            // 
            this.btn_hide.Location = new System.Drawing.Point(291, 7);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(72, 46);
            this.btn_hide.TabIndex = 6;
            this.btn_hide.Text = "Hide";
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(526, 465);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Sonuc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Sonuc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_show3;
        private System.Windows.Forms.Button btn_show1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_show2;
        private System.Windows.Forms.Button btn_hide;
    }
}

