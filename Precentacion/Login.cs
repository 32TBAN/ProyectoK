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
using Negocio;
using Entidades;
using Precentacion;

namespace Presentacion
{
    public partial class Login : Form
    {
        UsuarioEntidad usuarioEntidad = new UsuarioEntidad();
        public Login()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        #region MoverInterfas
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCaprure();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsq, int wParam, int lParam);

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCaprure();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (ControlarDatos())
            {

            }
        }

        private bool ControlarDatos()
        {
            if (rjTextBox_Usuario.Texts == "")
            {
                MostrarError(0);
                return false;
            }
            else if (rjTextBox_Contrasenia.Texts == "")
            {
                MostrarError(1);
                return false;
            }
            else
            {
                usuarioEntidad = UsuarioNegocio.BuscarUsuarioEmail(rjTextBox_Usuario.Texts);
                if (usuarioEntidad == null)
                {
                    usuarioEntidad = new UsuarioEntidad();
                    MostrarError(2);
                    return false;
                }else if (usuarioEntidad.Id == 0)
                {
                    MostrarError(3);
                    return false;
                }
                else if (usuarioEntidad.Contraseña != rjTextBox_Contrasenia.Texts)
                {
                    MostrarError(4);
                    return false;
                }
            }
            iconButton_Error.Visible = false;
            label_Error.Visible = false;
            return true;
        }

        private void MostrarError(int v)
        {
            String[] errors = new string[] { "No ha ingresado su correo", "No ha ingresado su contraseña",
            "Ha ocurrido un error","Usted no esta registrado","La contraseña no coincide"};
            label_Error.Text = errors[v];
            label_Error.ForeColor = Color.Red;
            iconButton_Error.Visible = true;
            label_Error.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperarContraseña rc = new RecuperarContraseña();
            rc.Show();
        }
    }
}
