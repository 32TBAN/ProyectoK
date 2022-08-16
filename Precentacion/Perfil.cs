using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Precentacion
{
    public partial class Perfil : Form
    {
        private UsuarioEntidad usuarioEntidad { get; set; }
        private bool editarC = false;
        public Perfil(UsuarioEntidad usuarioEntidad)
        {
            InitializeComponent();
            this.usuarioEntidad = usuarioEntidad;
            CargarDatos();
        }

        private void OcultarComponentes()
        {
            label1_NuevaC.Visible = false;
            rjTextBox_NuevaC.Visible = false;
            label_Confirmar.Visible = false;
            rjTextBox_Confirmar.Visible = false;
            iconButton_Error.Visible = false;
            label_Error.Visible = false;
        }

        private void CargarDatos()
        {
            label_Nombre.Text = usuarioEntidad.Nombre;
            label_Apellido.Text = usuarioEntidad.Apellido;
            label_Email.Text = usuarioEntidad.Email;
            label_Permisos.Text = usuarioEntidad.Perfil;
            rjCircularPictureBox_Foto.Image = CargarBytesImagen(usuarioEntidad.Foto);
            rjTextBox_Nombre.Texts = usuarioEntidad.Nombre;
            rjTextBox_Apellido.Texts = usuarioEntidad.Apellido;
            rjTextBox_Email.Texts = usuarioEntidad.Email;
            rjTextBox_Contrasenia.Texts = usuarioEntidad.Contraseña;
        }
        private Image CargarBytesImagen(byte[] foto)
        {
            try
            {
                MemoryStream ms = new MemoryStream(foto, 0, foto.Length);
                ms.Write(foto, 0, foto.Length);
                return Image.FromStream(ms, true);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar imagen de perfil");
                return null;
            }

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (panel_EditarPerfil.Visible)
                panel_EditarPerfil.Visible = false;
            else
                panel_EditarPerfil.Visible = true;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (ControlDatos())
            {
                usuarioEntidad.Nombre = rjTextBox_Nombre.Texts;
                usuarioEntidad.Apellido = rjTextBox_Apellido.Texts;
                usuarioEntidad.Email = rjTextBox_Email.Texts;
                usuarioEntidad.Contraseña = rjTextBox_Contrasenia.Texts;
                usuarioEntidad.Foto = CargarImagen();

                usuarioEntidad = UsuarioNegocio.Guardar(usuarioEntidad);//TODO: Error al ingresar otra imagen
                if (usuarioEntidad != null)
                {
                    MessageBox.Show("Se ha Editado");
                    OcultarComponentes();
                }
            }
        }
        private byte[] CargarImagen()
        {
            string sTemp = Path.GetTempFileName();
            FileStream fs = new FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            rjCircularPictureBox_Foto.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
            fs.Position = 0;

            int imgLength = Convert.ToInt32(fs.Length);
            byte[] bytes = new byte[imgLength];
            fs.Read(bytes, 0, imgLength);
            fs.Close();
            return bytes;
        }
        private bool ControlDatos()
        {
            if (rjTextBox_Nombre.Texts == "" || rjTextBox_Apellido.Texts == "" || 
                rjTextBox_Contrasenia.Texts == "" || rjTextBox_Email.Texts == "")
            {
                MostrarError(0);
                return false;
            }
            if (rjTextBox_Email.Texts != usuarioEntidad.Email)
            {
                if (rjTextBox_Email.Texts == UsuarioNegocio.BuscarUsuarioEmail(rjTextBox_Email.Texts).Email)
                {
                    MostrarError(2);
                    return false;
                }
            }
            else if (editarC)
            {
                if (rjTextBox_NuevaC.Texts == rjTextBox_Confirmar.Texts)
                {
                    MostrarError(1);
                    return false;
                }
            }
            return true;
        }

        private void MostrarError(int v)
        {
            String[] errors = new string[] { "Faltan datos","Las contraseñas no coinciden",
            "Ya existe un usuario con ese correo"};
            label_Error.Text = errors[v];
            label_Error.ForeColor = Color.Red;
            iconButton_Error.Visible = true;
            label_Error.Visible = true;
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            DialogResult dr = of.ShowDialog();
            if (dr == DialogResult.OK)
            {
                rjCircularPictureBox_Foto.Image = Image.FromFile(of.FileName);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label1_NuevaC.Visible = true;
            rjTextBox_NuevaC.Visible = true;
            label_Confirmar.Visible = true;
            rjTextBox_Confirmar.Visible = true;
            if (editarC)
                editarC = false;
            else
                editarC = true;
        }
    }
}
