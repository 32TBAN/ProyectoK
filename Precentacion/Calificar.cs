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
    public partial class Calificar : Form
    {
        private SolicitudEntidad solicitudEntidad { get; set; }
        private UsuarioEntidad usuarioEntidadTecnico { get; set; }
        private UsuarioEntidad usuarioEntidadNormal { get; set; }
        private int usllama { get; set; }
        Asignaciones asignacion = new Asignaciones();
        public Calificar(int idSolicitud,int usllama)
        {
            InitializeComponent();
            this.usllama = usllama;
            CargarDatos(idSolicitud);
        }

        private void CargarDatos(int idSolicitud)
        {
            solicitudEntidad = SolicitudNegocio.BuscarSolicitud(idSolicitud);
            usuarioEntidadNormal = UsuarioNegocio.BuscarUsuarioID(solicitudEntidad.IdUsuario);
            usuarioEntidadTecnico = UsuarioNegocio.BuscarUsuarioID(solicitudEntidad.IdTecnico);

            if (solicitudEntidad != null)
            {
                CargarTxtPerfil();
            }
        }

        private void CargarTxtPerfil()
        {
            label_Asunto.Text = solicitudEntidad.Asunto;
            label_Descrpcion.Text = solicitudEntidad.Descripcion;
            label_Fecha_Envio.Text = solicitudEntidad.Fecha.ToLongDateString() + "        ";
            asignacion.IdSolicitud = solicitudEntidad.Id;
            asignacion.IdTecnico = usuarioEntidadTecnico.Id;

            if (usuarioEntidadNormal.Id == usllama)
            {
                if (solicitudEntidad.Estado == 1)
                {
                    label_Coreo.Text = usuarioEntidadTecnico.Email;
                    rjCircularPictureBox_perfil.Image = CargarImagen(usuarioEntidadTecnico.Foto);
                    label_Fecha.Text = "En proceso";
                    richTextBox_Requisitos.Text = "Aun no se revisa su solicitud";
                    Total.Text = "Aun no se revisa su solicitud";
                }
                else if (solicitudEntidad.Estado == 2)
                {
                    label_Coreo.Text = usuarioEntidadTecnico.Email;
                    rjCircularPictureBox_perfil.Image = CargarImagen(usuarioEntidadTecnico.Foto);

                    List<Asignaciones>  asignacionesTerminada = AsignacionNegocio.ListaAsignacionTerminada();

                    foreach (var item in asignacionesTerminada)
                    {
                        if (item.IdSolicitud == solicitudEntidad.Id)
                        {
                            label_Fecha.Text = item.FechaFin.ToString();
                            richTextBox_Requisitos.Text = item.Respuesta;
                            Total.Text += item.Total.ToString();
                        }
                    }
                }
                else
                {
                    label_Coreo.Text = "No se ha asignado";
                    richTextBox_Requisitos.Text = "No se ha asignado";
                    label_Fecha.Text = "En proceso";
                }
            }
            else
            {
                UsuarioEntidad usuarioEnvio = UsuarioNegocio.BuscarUsuarioID(solicitudEntidad.IdUsuario);
                if (solicitudEntidad.Estado == 1)
                {
                    label_Coreo.Text = usuarioEnvio.Email;
                    rjCircularPictureBox_perfil.Image = CargarImagen(usuarioEnvio.Foto);
                    label_Fecha.Text = solicitudEntidad.Fecha.ToString();
                    richTextBox_Requisitos.Text = "Escriba todo lo necesitado para solicionar el problema(heramientas, programas etc.)";
                    Total.Text += "Aun no se revisa la solicitud";

                    List<Asignaciones> asignacionesTerminada = AsignacionNegocio.ListaAsignacionTerminada();
                    foreach (var item in asignacionesTerminada)
                    {
                        if (item.IdSolicitud == solicitudEntidad.Id)
                        {
                            label_Coreo.Text = usuarioEnvio.Email;
                            rjCircularPictureBox_perfil.Image = CargarImagen(usuarioEnvio.Foto);
                            label_Fecha.Text = solicitudEntidad.Fecha.ToString();
                            richTextBox_Requisitos.Text = item.Respuesta;
                            Total.Text += item.Total.ToString();
                        }
                    }

                    richTextBox_Requisitos.ReadOnly = false;
                    rjButton_EnviarRes.Visible = true;
                }
                else
                {
                    List<Asignaciones> asignacionesTerminada = AsignacionNegocio.ListaAsignacionTerminada();
                    foreach (var item in asignacionesTerminada)
                    {
                        if (item.IdSolicitud == solicitudEntidad.Id)
                        {
                            label_Coreo.Text = usuarioEnvio.Email;
                            rjCircularPictureBox_perfil.Image = CargarImagen(usuarioEnvio.Foto);
                            label_Fecha.Text = solicitudEntidad.Fecha.ToString();
                            richTextBox_Requisitos.Text = item.Respuesta;
                            Total.Text += item.Total.ToString();
                        }
                    }
                    richTextBox_Requisitos.ReadOnly = true;
                }
            }
        }

        private Image CargarImagen(byte[] foto)
        {
            try
            {
                MemoryStream ms = new MemoryStream(foto, 0, foto.Length);
                ms.Write(foto, 0, foto.Length);
                return Image.FromStream(ms, true);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (solicitudEntidad.Estado==2)
            {
                NotaServicio();
            }
            else
            {
                this.Close();
            }
        }

        private void NotaServicio()
        {
            //TODO: Calificar
            panel_Calificasion.Visible = true;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            //TODO: Ver informacion del tecnico si no hay no mostrar
            if (!panel_Min.Visible)
            {
                panel_Min.Visible = true;
                if (usuarioEntidadTecnico.Id != 0 && solicitudEntidad.Estado != 0)
                {
                    label_Encargado.Text = usuarioEntidadTecnico.Nombre + " " + usuarioEntidadTecnico.Apellido;
                    if (usuarioEntidadNormal != null)
                    {
                        label_Para.Text = usuarioEntidadNormal.Nombre + " " + usuarioEntidadNormal.Apellido;
                    }
                    label_AsuntoMin.Text = solicitudEntidad.Asunto;
                }
                else
                {
                    label_Encargado.Visible = false;
                    label_Para.Visible = false;
                    label_Fecha.Visible = false;
                    label_AsuntoMin.Visible = false;
                    label_ENCARGO.Visible = true;
                }
            }
            else
            {
                panel_Min.Visible = false;
            }
           
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            panel_Calificasion.Visible = false;
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            if (solicitudEntidad.Estado == 2)
            {
                NotaServicio();
            }
            else
            {
                PdfServicio();
            }
        }

        private void PdfServicio()
        {
           //TODO: Hacer pdf del servicio
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            //TODO: Editar Solicitud
            panel_NuevaSolicitud.Visible = true;
        }
        private bool ControlDatos()
        {
            if (textBox_Asunto.Text == "" || richTextBox_Descripcion.Text == "" ||
                rjComboBox_Urgencia.Texts == "" || rjComboBox_Dispositivo.Texts == "")
            {
                MostrarError(0);
                return false;
            }
            return true;
        }
        private void MostrarError(int v)
        {
            String[] errors = new string[] { "Faltan datos" };
            label_Error.Text = errors[v];
            label_Error.ForeColor = Color.Red;
            iconButton_Error.Visible = true;
            label_Error.Visible = true;
        }
        private void Limpiar()
        {
            textBox_Asunto.Text = "";
            richTextBox_Descripcion.Text = "";
        }
        private void iconButton4_Click(object sender, EventArgs e)
        {
            //TODO: Eliminar Solicitud
            if (MessageBox.Show("Esta seguro que desea eliminar esta solicitud?","Eliminar",MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (SolicitudNegocio.EliminarSolicitud(solicitudEntidad.Id))
                {
                    MessageBox.Show("Se ha eliminado");
                    this.Close();
                }  
                else
                    MessageBox.Show("No se ha podido eliminar");
            }
        }

        private void iconPictureBox5_MouseHover(object sender, EventArgs e)
        {
            //TODO: Calificacion estrellas

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            panel_NuevaSolicitud.Visible = false;
        }
        /// <summary>
        /// Edita la solicitudes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (solicitudEntidad.Estado == 0)
            {
                if (ControlDatos())
                {
                    solicitudEntidad.Asunto = textBox_Asunto.Text;
                    solicitudEntidad.Descripcion = richTextBox_Descripcion.Text;
                    solicitudEntidad.Urgencia = rjComboBox_Urgencia.Texts;
                    solicitudEntidad.Dispositivo = rjComboBox_Dispositivo.Texts;
                    solicitudEntidad.Area = rjComboBox_Area.Texts;
                    solicitudEntidad.Fecha = DateTime.Now;
                    solicitudEntidad.Estado = 0;

                    solicitudEntidad = SolicitudNegocio.Guardar(solicitudEntidad);
                    if (solicitudEntidad != null)
                    {
                        MessageBox.Show("Se ha modificado su solicitud");
                        Limpiar();
                        panel_NuevaSolicitud.Visible = false;
                        CargarDatos(solicitudEntidad.Id);
                    }
                    else
                    {
                        MessageBox.Show("No puede editar esta solicitud");
                    }
                }
            }
            else
            {
                MessageBox.Show("No puede editar esta solicitud");
            }
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            //enviar calificacion
            this.Close();
        }

        private void richTextBox_Requisitos_Enter(object sender, EventArgs e)
        {
            if (richTextBox_Requisitos.Text == "Escriba todo lo necesitado para solicionar el problema(heramientas, programas etc.)")
            {
                richTextBox_Requisitos.Text = "";
            }
        }

        private void rjButton_EnviarRes_Click(object sender, EventArgs e)
        {
            if (richTextBox_Requisitos.Text != "")
            {
                asignacion.Terminada = true;
                asignacion.Respuesta = richTextBox_Requisitos.Text;
                asignacion.FechaFin = DateTime.Now;

                asignacion = AsignacionNegocio.Actualizar(asignacion);
                if (asignacion != null)
                {
                    MessageBox.Show("Se ha enviado su respuesta el tecnico jefe la revisara");
                    richTextBox_Requisitos.ReadOnly = true;
                    rjButton_EnviarRes.Visible = false;
                }
                else
                    MessageBox.Show("Error al envia su respuesta");
            }
            else
            {
                MessageBox.Show("Aun no ha escrito su respuesta");
            }
        }
    }
}
