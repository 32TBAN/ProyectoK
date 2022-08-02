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
            usuarioEntidad = UsuarioNegocio.BuscarUsuarioEmail(rjTextBox_Usuario.Texts);
            if (rjTextBox_Usuario.Texts == "")
            {

            }
            else if (rjTextBox_Contrasenia.Texts == "")
            {

            }
            return true;
        }
    }
}
