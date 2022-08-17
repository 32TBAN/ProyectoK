using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;
using System.IO;

namespace Precentacion
{
    public partial class AgregarPerfil : Form
    {
        UsuarioEntidad usuarioEntidad = new UsuarioEntidad();
        public AgregarPerfil()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            CrearNuevoPerfil();
        }

        private void CrearNuevoPerfil()
        {
            try
            {
                if (ControlDatos())
                {
                    usuarioEntidad.Nombre = rjTextBox_Nombre.Texts;
                    usuarioEntidad.Apellido = rjTextBox_Apellido.Texts;
                    usuarioEntidad.Cedula = rjTextBox_Cedula.Texts;
                    usuarioEntidad.Email = rjTextBox_Email.Texts;
                    usuarioEntidad.Contraseña = rjTextBox_Contrasenia.Texts;
                    usuarioEntidad.Foto = CargarImagen();

                    switch (rjComboBox_TipoPerfil.Texts)
                    {
                        case "Gerente":
                            usuarioEntidad.Perfil = "G";
                            break;
                        case "Jefe Técnico":
                            usuarioEntidad.Perfil = "J";
                            break;
                        case "Técnico":
                            usuarioEntidad.Perfil = "T";
                            break;
                        case "Usuario":
                            usuarioEntidad.Perfil = "U";
                            break;
                        default:
                            break;
                    }

                    UsuarioEntidad usuarioEntidadRespadldo = usuarioEntidad;
                    usuarioEntidad = UsuarioNegocio.Guardar(usuarioEntidad);
                    if (usuarioEntidad != null)
                    {
                        MessageBox.Show("Se ha guardado");
                        iconButton_Error.Visible = false;
                        label_Error.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("La imagen tiene que ser menor a 32KB", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        usuarioEntidad = usuarioEntidadRespadldo;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error: datos no validos");
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
            UsuarioEntidad usuarioEntidadBuscado = UsuarioNegocio.BuscarUsuarioCedula(rjTextBox_Cedula.Texts);
            if (usuarioEntidadBuscado != null)
            {
                if (rjTextBox_Nombre.Texts == "" || rjTextBox_Apellido.Texts == "" ||
                                rjTextBox_Cedula.Texts == "" || rjTextBox_Contrasenia.Texts == "" ||
                                rjComboBox_TipoPerfil.Texts == "" || rjTextBox_Email.Texts == "")
                {
                    MostrarError(0);
                    return false;
                }
                else if (rjTextBox_Email.Texts == UsuarioNegocio.BuscarUsuarioEmail(rjTextBox_Email.Texts).Email)
                {
                    MostrarError(2);
                    return false;
                }
                else if (rjTextBox_Cedula.Texts == usuarioEntidadBuscado.Cedula)
                {
                    MostrarError(3);
                    return false;
                }
                else if (rjTextBox_Cedula.Texts.Length != 10)
                {
                    MostrarError(4);
                    return false;
                }
                else
                {
                    foreach (var item in rjComboBox_TipoPerfil.Items)
                    {
                        if (item.ToString().Equals(rjComboBox_TipoPerfil.Texts))
                        {
                            return true;
                        }
                    }
                }
                MostrarError(1);
                return false;
            }
            else
            {
                MessageBox.Show("Cedula invalida");
                return false;
            }
        }

        private void MostrarError(int v)
        {
            String[] errors = new string[] { "Faltan datos","No existe ese tipo de perfil",
            "Ya existe un usuario con ese correo","Ya existe un usuario con esa cedula",
            "Cedula no valida"};
            label_Error.Text = errors[v];
            label_Error.ForeColor = Color.Red;
            iconButton_Error.Visible = true;
            label_Error.Visible = true;
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            DialogResult dr = of.ShowDialog();
            if (dr == DialogResult.OK)
            {
                rjCircularPictureBox_Foto.Image = Image.FromFile(of.FileName);
            }
        }

        private void rjTextBox_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void rjTextBox_Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
