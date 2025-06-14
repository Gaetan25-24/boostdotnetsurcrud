using FontAwesome.Sharp;
using GestionConger.FormulairePanel;
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

namespace GestionConger.FormulaireMain
{
    public partial class FormMain : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form form;
        public FormMain()
        {
            InitializeComponent();
            addContenue(new Acceuil());

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableBoutton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        private void DisableBoutton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void addContenue(Form childForm)
        {
            if (form != null)
            {
                form.Close();
            }
            form = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContenu.Controls.Add(childForm);
            panelContenu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnAcceuil_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            addContenue(new Acceuil());
        }

        private void btnCongé_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            addContenue(new FormConge());
        }

        private void btnDemande_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            addContenue(new FormDemande());
        }

        private void btnConsultation_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            addContenue(new FormConsultation());
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            addContenue(new FormService());
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            Form1 form = new Form1();
            
            form.Show();
            this.Hide();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconManakeli_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;

        }

        private void iconReduire_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconClose_MouseHover(object sender, EventArgs e)
        {
            iconClose.IconColor = Color.Red;
        }

        private void iconManakeli_MouseHover(object sender, EventArgs e)
        {
            iconManakeli.IconColor = Color.Yellow;
        }

        private void iconReduire_MouseHover(object sender, EventArgs e)
        {
            iconReduire.IconColor = Color.Blue;
        }

        private void iconClose_MouseLeave(object sender, EventArgs e)
        {
            iconClose.IconColor = Color.Gainsboro;
        }

        private void iconManakeli_MouseLeave(object sender, EventArgs e)
        {
            iconManakeli.IconColor = Color.Gainsboro;
        }

        private void iconReduire_MouseLeave(object sender, EventArgs e)
        {
            iconReduire.IconColor = Color.Gainsboro;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            reset();
            addContenue(new Acceuil());
        }
        public void reset()
        {
            DisableBoutton();
            leftBorderBtn.Visible = false;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            addContenue(new Moncompte());
            reset();
        }
    }
}
