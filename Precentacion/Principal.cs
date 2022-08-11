using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using FontAwesome.Sharp;
namespace Precentacion
{
    public partial class Principal : Form
    {
        private UsuarioEntidad usuarioEntidad { get; set; }
        private Form formAbierto = null;
        private int bordeForm = 2;
        private Size formSize;
        private IconButton bottonActivo;
        private Panel leftBorderBtn;
        public Principal(UsuarioEntidad usuarioEntidad)
        {
            InitializeComponent();
            this.usuarioEntidad = usuarioEntidad;
            CargarDatos();
            //Menu
            this.Padding = new Padding(bordeForm);
            this.BackColor = Color.FromArgb(41, 39, 89);
            //botones
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panel_Menu.Controls.Add(leftBorderBtn);
            ContraerMenu();
        }

        private void CargarDatos()
        {
            label_Permisos.Text = usuarioEntidad.Perfil;
            label_Nombre.Text = usuarioEntidad.Nombre + " " + usuarioEntidad.Apellido;
        }
        #region Botones
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                bottonActivo = (IconButton)senderBtn;
                bottonActivo.BackColor = Color.FromArgb(37, 36, 81);
                bottonActivo.ForeColor = color;
                bottonActivo.TextAlign = ContentAlignment.MiddleCenter;
                bottonActivo.IconColor = color;
                bottonActivo.TextImageRelation = TextImageRelation.TextBeforeImage;
                bottonActivo.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, bottonActivo.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconButton_Form.IconChar = bottonActivo.IconChar;
                iconButton_Form.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (bottonActivo != null)
            {
                bottonActivo.BackColor = Color.FromArgb(41, 39, 89);
                bottonActivo.ForeColor = Color.Gainsboro;
                bottonActivo.TextAlign = ContentAlignment.MiddleLeft;
                bottonActivo.IconColor = Color.Gainsboro;
                bottonActivo.TextImageRelation = TextImageRelation.ImageBeforeText;
                bottonActivo.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        #endregion
        #region Redimencionar Form
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020;
            const int SC_RESTORE = 0xF120;
            const int WM_NCHITTEST = 0x0084;
            const int resizeAreaSize = 10;
            #region Form Resize

            const int HTCLIENT = 1;
            const int HTLEFT = 10;
            const int HTRIGHT = 11;
            const int HTTOP = 12;
            const int HTTOPLEFT = 13;
            const int HTTOPRIGHT = 14;
            const int HTBOTTOM = 15;
            const int HTBOTTOMLEFT = 16;
            const int HTBOTTOMRIGHT = 17;
            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)
                {
                    if ((int)m.Result == HTCLIENT)
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32());
                        Point clientPoint = this.PointToClient(screenPoint);
                        if (clientPoint.Y <= resizeAreaSize)
                        {
                            if (clientPoint.X <= resizeAreaSize)
                                m.Result = (IntPtr)HTTOPLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))
                                m.Result = (IntPtr)HTTOP;
                            else
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize))
                        {
                            if (clientPoint.X <= resizeAreaSize)
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))
                                m.Result = (IntPtr)HTBOTTOM;
                            else
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion

            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            if (m.Msg == WM_SYSCOMMAND)
            {
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)
                    this.Size = formSize;
            }
            base.WndProc(ref m);

        }
        #endregion
        public void AbrirFormularios(Form form)
        {
            if (formAbierto != null)
            {
                formAbierto.Close();
            }
            formAbierto = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel_C.Controls.Add(form);
            panel_C.Tag = form;
            form.BringToFront();
            form.Show();
        }

        #region MoverForm
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirFormularios(new Perfil(usuarioEntidad));
            Reset();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_Hora.Text = DateTime.Now.ToString("HH:mm:ss");
            label_fecha.Text = DateTime.Now.ToString("D",CultureInfo.CreateSpecificCulture("es-MX"));
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new AgregarPerfil());
            ActivateButton(sender, RGBColors.color1);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ContraerMenu();
        }

        private void ContraerMenu()
        {
            if (this.panel_Menu.Width > 200) 
            {
                panel_Menu.Width = 100;
                rjCircularPictureBox1.Visible = false;
                label_Permisos.Visible = false;
                label_Nombre.Visible = false;
                linkLabel_Perfil.Visible = false;
                iconButton_Menu.Dock = DockStyle.Top;
                foreach (Button menuButton in panel_Menu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            { //Expand menu
                panel_Menu.Width = 230;
                rjCircularPictureBox1.Visible = true;
                label_Permisos.Visible = true;
                label_Nombre.Visible = true;
                linkLabel_Perfil.Visible = true;
                iconButton_Menu.Dock = DockStyle.None;
                foreach (Button menuButton in panel_Menu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void Principal_Resize(object sender, EventArgs e)
        {
            AjustarForm();
        }

        private void AjustarForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: 
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal: 
                    if (this.Padding.Top != bordeForm)
                        this.Padding = new Padding(bordeForm);
                    break;
            }
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            AbrirFormularios(new Soporte(usuarioEntidad));
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
        }

        private void iconButton_Form_Click(object sender, EventArgs e)
        {
            if (formAbierto != null)
            {
                formAbierto.Close();
                Reset();
            }
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconButton_Form.IconChar = IconChar.Home;
            iconButton_Form.IconColor = Color.FromArgb(242, 207, 141);
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            //TODO: SALIR FORM
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            //TODO: Asignar una solicitud a un tecnico
        }
    }
}
