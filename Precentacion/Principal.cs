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
using Entidades;

namespace Precentacion
{
    public partial class Principal : Form
    {
        public UsuarioEntidad usuarioEntidad { get; set; }
        public Form formAbierto = null;
        public Principal(UsuarioEntidad usuarioEntidad)
        {
            InitializeComponent();
            CargarDatos();
            this.usuarioEntidad = usuarioEntidad;
        }

        private void CargarDatos()
        {

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

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
            AbrirFormularios(new Perfil());

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
            label_fecha.Text = DateTime.Now.ToString("dddd MMMM yyy");
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new AgregarPerfil());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            panel_Menu.Visible = false;
            iconButton_VerMenu.Visible = true;
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            panel_Menu.Visible = true;
            iconButton_VerMenu.Visible = false;
        }
    }
}
