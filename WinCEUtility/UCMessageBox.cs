using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace WinCEUtility
{
    public partial class UCMessageBox : UserControl
    {
        public string YesText = "EVET";//for Turkish
        public string NoText = "HAYIR";
        public string OkText = "TAMAM";

        public DialogResult DialogResult = DialogResult.OK;

        private int timeout = 0; //as seconds
        private void SetTimout(int timeout)
        {
            if (timeout < 100)
            {
                this.timeout = timeout;
            }
            else this.timeout = 100;
        }

        private void SetButtons(MsgButtons buttons)
        {
            div_footer.Visible = true;

            switch (buttons)
            {
                case MsgButtons.None:
                    div_footer.Visible = false;
                    break;
                case MsgButtons.OK:
                    btn_ok.Visible = true;
                    btn_accept.Visible = btn_ignore.Visible = false;
                    break;
                case MsgButtons.YesNo:
                    btn_ok.Visible = false;
                    btn_accept.Visible = btn_ignore.Visible = true;
                    break;
                case MsgButtons.AllButtons:
                    btn_ok.Visible = btn_accept.Visible = btn_ignore.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void SetState(DisplayState state)
        {
            switch (state)
            {
                case DisplayState.Hidden:
                    this.Visible = false;
                    break;
                case DisplayState.Normal:
                    this.Dock = DockStyle.None;

                    this.Width = DefaultWidth;
                    this.Height = DefaultHeight;

                    this.BringParentMiddle();
                    this.Visible = true;
                    break;
                case DisplayState.FullScreen:
                    this.Dock = DockStyle.Fill;
                    this.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void BringParentMiddle()
        {
            if (this.Parent == null) return;

            int x = (this.Parent.Width - this.Width) / 2;
            int y = (this.Parent.Height - this.Height) / 2;

            this.Location = new Point(x, y);
        }

        public int DefaultWidth = 600;
        public int DefaultHeight = 400;

        public void Show(string title, string message, MsgButtons buttons, DisplayState state, int timeout)
        {
            if (state == DisplayState.Hidden) return;

            this.lbl_title.Text = title;
            this.tbx_message.Text = message;

            this.btn_accept.Text = this.YesText;
            this.btn_ignore.Text = this.NoText;
            this.btn_ok.Text = this.OkText;

            SetButtons(buttons);
            SetState(state);

            if (timeout > 0)
            {
                this.timeout = timeout;
                this.timer1.Enabled = true;
            }
            else
            {
                this.timeout = 0;
                this.timer1.Enabled = false;
                lbl_timout.Visible = false;
            }

            this.BringToFront();
        }

        public new void Hide()
        {
            if (timer1.Enabled) timer1.Enabled = false;

            lbl_timout.Visible = false;

            SetState(DisplayState.Hidden);
        }

        public UCMessageBox(Control parent)
        {
            InitializeComponent();

            this.Parent = parent;
            this.Visible = false;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (sender.Equals(btn_accept))
            {
                this.DialogResult = DialogResult.Yes;
            }
            else if (sender.Equals(btn_ignore))
            {
                this.DialogResult = DialogResult.Ignore;
            }
            else if (sender.Equals(btn_ok))
            {
                this.DialogResult = DialogResult.OK;
            }

            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeout > 1)
            {
                if (!lbl_timout.Visible) lbl_timout.Visible = true;
                timeout--;
                lbl_timout.Text = timeout.ToString();
            }
            else
            {
                timeout = 0;
                timer1.Enabled = false;

                this.Hide();
            }
        }

        private void tbx_message_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public enum DisplayState { Hidden = 0, Normal = 1, FullScreen = 2 }
    public enum MsgButtons { None = 0, OK = 1, YesNo = 2, AllButtons = 3 }
}
