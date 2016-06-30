namespace WinCEUtility
{
    partial class UCMessageBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ignore = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.div_header = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_timout = new System.Windows.Forms.Label();
            this.div_footer = new System.Windows.Forms.Panel();
            this.btn_accept = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer();
            this.div_body = new System.Windows.Forms.Panel();
            this.tbx_message = new System.Windows.Forms.TextBox();
            this.div_header.SuspendLayout();
            this.div_footer.SuspendLayout();
            this.div_body.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ignore
            // 
            this.btn_ignore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ignore.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.btn_ignore.ForeColor = System.Drawing.Color.Navy;
            this.btn_ignore.Location = new System.Drawing.Point(418, 3);
            this.btn_ignore.Name = "btn_ignore";
            this.btn_ignore.Size = new System.Drawing.Size(180, 60);
            this.btn_ignore.TabIndex = 3;
            this.btn_ignore.Text = "{NO}";
            this.btn_ignore.Click += new System.EventHandler(this.button_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_ok.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.btn_ok.ForeColor = System.Drawing.Color.Navy;
            this.btn_ok.Location = new System.Drawing.Point(210, 3);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(180, 60);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "{OK}";
            this.btn_ok.Click += new System.EventHandler(this.button_Click);
            // 
            // div_header
            // 
            this.div_header.Controls.Add(this.lbl_title);
            this.div_header.Controls.Add(this.lbl_timout);
            this.div_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.div_header.Location = new System.Drawing.Point(0, 0);
            this.div_header.Name = "div_header";
            this.div_header.Size = new System.Drawing.Size(601, 60);
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.Navy;
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_title.Font = new System.Drawing.Font("Tahoma", 32F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(529, 60);
            this.lbl_title.Text = "{Title}";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_timout
            // 
            this.lbl_timout.BackColor = System.Drawing.Color.Maroon;
            this.lbl_timout.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_timout.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lbl_timout.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_timout.Location = new System.Drawing.Point(529, 0);
            this.lbl_timout.Name = "lbl_timout";
            this.lbl_timout.Size = new System.Drawing.Size(72, 60);
            this.lbl_timout.Text = "0";
            this.lbl_timout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_timout.Visible = false;
            // 
            // div_footer
            // 
            this.div_footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.div_footer.Controls.Add(this.btn_ok);
            this.div_footer.Controls.Add(this.btn_ignore);
            this.div_footer.Controls.Add(this.btn_accept);
            this.div_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.div_footer.Location = new System.Drawing.Point(0, 310);
            this.div_footer.Name = "div_footer";
            this.div_footer.Size = new System.Drawing.Size(601, 66);
            // 
            // btn_accept
            // 
            this.btn_accept.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.btn_accept.ForeColor = System.Drawing.Color.Navy;
            this.btn_accept.Location = new System.Drawing.Point(3, 3);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(180, 60);
            this.btn_accept.TabIndex = 1;
            this.btn_accept.Text = "{YES}";
            this.btn_accept.Click += new System.EventHandler(this.button_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // div_body
            // 
            this.div_body.BackColor = System.Drawing.SystemColors.HighlightText;
            this.div_body.Controls.Add(this.tbx_message);
            this.div_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.div_body.Location = new System.Drawing.Point(0, 60);
            this.div_body.Name = "div_body";
            this.div_body.Size = new System.Drawing.Size(601, 250);
            // 
            // tbx_message
            // 
            this.tbx_message.BackColor = System.Drawing.SystemColors.Info;
            this.tbx_message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_message.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold);
            this.tbx_message.ForeColor = System.Drawing.Color.Black;
            this.tbx_message.Location = new System.Drawing.Point(0, 0);
            this.tbx_message.Multiline = true;
            this.tbx_message.Name = "tbx_message";
            this.tbx_message.ReadOnly = true;
            this.tbx_message.Size = new System.Drawing.Size(601, 250);
            this.tbx_message.TabIndex = 6;
            this.tbx_message.Text = "{Message Content}";
            this.tbx_message.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx_message.TextChanged += new System.EventHandler(this.tbx_message_TextChanged);
            // 
            // UCMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.div_body);
            this.Controls.Add(this.div_header);
            this.Controls.Add(this.div_footer);
            this.Name = "UCMessageBox";
            this.Size = new System.Drawing.Size(601, 376);
            this.div_header.ResumeLayout(false);
            this.div_footer.ResumeLayout(false);
            this.div_body.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ignore;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Panel div_header;
        private System.Windows.Forms.Panel div_footer;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_timout;
        private System.Windows.Forms.Panel div_body;
        private System.Windows.Forms.TextBox tbx_message;
    }
}
