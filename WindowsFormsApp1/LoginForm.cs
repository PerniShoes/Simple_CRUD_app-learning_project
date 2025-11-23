using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraWaitForm;
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
        // Controls size of field inputs:
        float fieldsFontDivisor = 30f;
        // These control the position of labels and fields:
        float loginFieldWidthMultiplier = 0.5f;     // 0.5f = 50% 
        float loginFieldHeightMultiplier = 0.40f;    
        float passwordFieldWidthMultiplier = 0.5f;
        float passwordFieldHeightMultiplier = 0.58f;

        public LoginForm()
        {
            InitializeComponent();
            // Avoids flicker on first (or future) redraw
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint, true);
            this.UpdateStyles();
            //

            InitializeDefaultUsers();

            LoginButton.Paint += LoginButtonPaint;
            ResizePanels();
            this.AcceptButton = LoginButton;

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
            LoginButton.Font = new Font(LoginButton.Font.FontFamily, Math.Max(height / 40,1), LoginButton.Font.Style);

            LoginButton.Left = (int)(width * passwordFieldWidthMultiplier - LoginButton.Width / 2f);
            LoginButton.Top = (int)((height - LoginButton.Height) * (passwordFieldHeightMultiplier + 0.16f));
        }
        private void ResizeLabels(int width, int height)
        {
            float fontSizeDivisor = 35;
            float horizonatlOffset = 4f;

            LoginLabel.Font = new Font(LoginLabel.Font.FontFamily, Math.Max(height / fontSizeDivisor,1), LoginLabel.Font.Style);
            LoginLabel.Left = (int)(width * loginFieldWidthMultiplier - LoginField.Width / 2f+ horizonatlOffset);
            LoginLabel.Top = (int)((height - LoginLabel.Height) * (loginFieldHeightMultiplier-0.06f));

            PasswordLabel.Font = new Font(PasswordLabel.Font.FontFamily, Math.Max(height / fontSizeDivisor,1), PasswordLabel.Font.Style);
            PasswordLabel.Left = (int)(width * passwordFieldWidthMultiplier - PasswordField.Width / 2f+ horizonatlOffset);
            PasswordLabel.Top = (int)((height - PasswordLabel.Height) * (passwordFieldHeightMultiplier-0.06f));


        }
        private void ResizeLoginField(int width, int height)
        {
            LoginField.Width = (int)(width * 0.4);
            // Font size controls height 
            LoginField.Font = new Font(LoginField.Font.FontFamily, Math.Max(height / fieldsFontDivisor,1), LoginField.Font.Style);
            LoginField.Left = (int)(width * loginFieldWidthMultiplier - LoginField.Width / 2f);
            LoginField.Top = (int)((height - LoginField.Height) * loginFieldHeightMultiplier);

        }
        private void ResizePasswordField(int width, int height)
        {
            PasswordField.Width = (int)(width * 0.4);
            // Font size controls height 
            PasswordField.Font = new Font(PasswordField.Font.FontFamily, Math.Max(height / fieldsFontDivisor,1), PasswordField.Font.Style);
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
        private void LoginButton_Click(object sender, EventArgs e)
        {
            App.CurrentUser = null;
            string username = LoginField.Text.Trim();
            string password = PasswordField.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                XtraMessageBox.Show("Please enter both username and password.");
                return;
            }

            using (Session session = new Session())
            {
                User user = session.FindObject<User>(
                    CriteriaOperator.Parse("Username = ?", username));

                if (user != null && user.CheckPassword(password))
                {
                    App.CurrentUser = user;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("Invalid username or password.");
                }
            }
        }

        private void InitializeDefaultUsers()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                bool hasUsers = uow.Query<User>().Any();
                if (hasUsers)
                    return; 

                CreateUser("Admin", "12345");
                CreateUser("Marek", "hasło");
                CreateUser("Guest", "123");

                uow.CommitChanges();
            }
        }
        public void CreateUser(string username, string password)
        {
            using (Session session = new Session())
            {
                User existing = session.FindObject<User>(
                    CriteriaOperator.Parse("Username = ?", username));

                if (existing != null)
                    throw new Exception("User already exists.");

                User newUser = new User(session)
                {
                    Username = username
                };
                newUser.SetPassword(password);
                newUser.Save();
            }
        }


}
}
