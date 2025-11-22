using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        // Controls size of field input:
        float fieldsFontDivisor = 30f;
        // These control the position of labels and fields:
        float loginFieldWidthMultiplier = 0.5f;     // 0.5f = 50% 
        float loginFieldHeightMultiplier = 0.40f;    
        float passwordFieldWidthMultiplier = 0.5f;
        float passwordFieldHeightMultiplier = 0.58f;

        public LoginForm()
        {
            InitializeComponent();
            LoginButton.Paint += LoginButtonPaint;
            ResizePanels();

        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate();   // Forces repaint

            ResizePanels();
        }

        private void ResizePanels()
        {
            int w = this.ClientSize.Width;
            int h = this.ClientSize.Height;

            ResizeLoginField(w,h);
            ResizePasswordField(w, h);
            ResizeLabels(w, h);
            ResizeButtons(w, h);

            pictureBox1.Height = (int)(h * 0.15);

        }
        private void LoginButtonPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            using (LinearGradientBrush brush = new LinearGradientBrush(
                LoginButton.ClientRectangle,
                    Color.FromArgb(250, 241, 146, 189), // Lighter color 
                    Color.FromArgb(100, 53, 68, 120),   // Darker color
                LinearGradientMode.BackwardDiagonal))
            {
                g.FillRectangle(brush, LoginButton.ClientRectangle);
            }
            LoginButton.ForeColor = Color.White;
            TextRenderer.DrawText(
                g,
                LoginButton.Text,
                LoginButton.Font,
                LoginButton.ClientRectangle,
                LoginButton.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

            using (Pen pen = new Pen(Color.Black, 1)) 
            {
                Rectangle rect = LoginButton.ClientRectangle;
                rect.Width -= 1;
                rect.Height -= 1;
                g.DrawRectangle(pen, rect);
            }
        }
        private void ResizeButtons(int width, int height)
        {
            LoginButton.Width = (int)(width * 0.35);
            LoginButton.Height = (int)(height * 0.05);
            LoginButton.Font = new Font(LoginButton.Font.FontFamily, height / 40, LoginButton.Font.Style);

            LoginButton.Left = (int)(width * passwordFieldWidthMultiplier - LoginButton.Width / 2f);
            LoginButton.Top = (int)((height - LoginButton.Height) * (passwordFieldHeightMultiplier + 0.16f));
        }
        private void ResizeLabels(int width, int height)
        {
            float fontSizeDivisor = 35;
            float horizonatlOffset = 4f;

            LoginLabel.Font = new Font(LoginLabel.Font.FontFamily, height / fontSizeDivisor, LoginLabel.Font.Style);
            LoginLabel.Left = (int)(width * loginFieldWidthMultiplier - LoginField.Width / 2f+ horizonatlOffset);
            LoginLabel.Top = (int)((height - LoginLabel.Height) * (loginFieldHeightMultiplier-0.06f));

            PasswordLabel.Font = new Font(PasswordLabel.Font.FontFamily, height / fontSizeDivisor, PasswordLabel.Font.Style);
            PasswordLabel.Left = (int)(width * passwordFieldWidthMultiplier - PasswordField.Width / 2f+ horizonatlOffset);
            PasswordLabel.Top = (int)((height - PasswordLabel.Height) * (passwordFieldHeightMultiplier-0.06f));


        }
        private void ResizeLoginField(int width, int height)
        {
            LoginField.Width = (int)(width * 0.4);
            // Font size controls height 
            LoginField.Font = new Font(LoginField.Font.FontFamily, height/ fieldsFontDivisor, LoginField.Font.Style);
            LoginField.Left = (int)(width * loginFieldWidthMultiplier - LoginField.Width / 2f);
            LoginField.Top = (int)((height - LoginField.Height) * loginFieldHeightMultiplier);

        }
        private void ResizePasswordField(int width, int height)
        {
            PasswordField.Width = (int)(width * 0.4);
            // Font size controls height 
            PasswordField.Font = new Font(PasswordField.Font.FontFamily, height / fieldsFontDivisor, PasswordField.Font.Style);
            PasswordField.Left = (int)(width * passwordFieldWidthMultiplier - PasswordField.Width / 2f);
            PasswordField.Top = (int)((height - PasswordField.Height) * passwordFieldHeightMultiplier);
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Rectangle rect = this.ClientRectangle;
            if (rect.Width > 0 && rect.Height > 0)
            {
                using (System.Drawing.Drawing2D.LinearGradientBrush brush =
                new System.Drawing.Drawing2D.LinearGradientBrush(
                    rect,
                    Color.FromArgb(200, 241, 146, 189),   // Top color 
                    Color.FromArgb(200, 53, 68, 120),     // Bottom color
                    System.Drawing.Drawing2D.LinearGradientMode.Vertical))
                {
                    e.Graphics.FillRectangle(brush, rect);
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
