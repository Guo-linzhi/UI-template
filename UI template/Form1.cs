using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_template
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            btnClosefrm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
        }
        #region UI介面
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
                index = random.Next(ThemeColor.ColorList.Count);
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("微軟正黑體", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
                    currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnClosefrm.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            if (currentButton != null) 
            {
                currentButton.BackColor = Color.FromArgb(51, 51, 76);
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
        }
        private void OpenChildForm(Form ChildForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(ChildForm);
            this.panelDesktopPane.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
            lblTitle.Text = ChildForm.Text;
        }
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "Home";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnClosefrm.Visible = false;
        }
        private void btnClosefrm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        #endregion

        #region 視窗跳轉按鈕
        private void btnConnent_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.formConnent(), sender);
        }
        private void btnAuto_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.formAuto(), sender);
        }
        private void btnManual_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.formManual(), sender);
        }
        private void btnHistory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.formHistory(), sender);
        }
        private void btmDownload_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.formDownload(), sender);
        }
        private void btnAbnormal_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.formAbnormal(), sender);
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.formSetting(), sender);
        }
        #endregion
    }
}
