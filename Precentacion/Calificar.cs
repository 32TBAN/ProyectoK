using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public Calificar(int idSolicitud)
        {
            InitializeComponent();
            CargarDatos(idSolicitud);
        }

        private void CargarDatos(int idSolicitud)
        {
            solicitudEntidad = SolicitudNegocio.BuscarSolicitud(idSolicitud);
            if (solicitudEntidad != null)
            {
                label_Asunto.Text = solicitudEntidad.Asunto;
                usuarioEntidadTecnico = UsuarioNegocio.BuscarUsuarioID(solicitudEntidad.IdTecnico);
                if (usuarioEntidadTecnico.Id != 0)
                {
                    label_Coreo.Text = usuarioEntidadTecnico.Email;
                }
                else
                {
                    label_Coreo.Text = "No se ha asignado";
                }
                label_Descrpcion.Text = solicitudEntidad.Descripcion;
                label_Fecha_Envio.Text = solicitudEntidad.Fecha.ToLongDateString()+"        ";
            }
            usuarioEntidadNormal = UsuarioNegocio.BuscarUsuarioID(solicitudEntidad.IdUsuario);

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (solicitudEntidad.Estado)
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
            
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            //TODO: Ver informacion del tecnico si no hay no mostrar
            if (!panel_Min.Visible)
            {
                panel_Min.Visible = true;
                if (usuarioEntidadTecnico.Id != 0)
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
            if (solicitudEntidad.Estado)
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

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (!solicitudEntidad.Estado)
            {
                if (ControlDatos())
                {
                    solicitudEntidad.Asunto = textBox_Asunto.Text;
                    solicitudEntidad.Descripcion = richTextBox_Descripcion.Text;
                    solicitudEntidad.Urgencia = rjComboBox_Urgencia.Texts;
                    solicitudEntidad.Dispositivo = rjComboBox_Dispositivo.Texts;
                    solicitudEntidad.Area = rjComboBox_Area.Texts;
                    solicitudEntidad.Fecha = DateTime.Now;
                    solicitudEntidad.Estado = false;

                    solicitudEntidad = SolicitudNegocio.Guardar(solicitudEntidad);
                    if (solicitudEntidad != null)
                    {
                        MessageBox.Show("Se ha modificado su solicitud");
                        Limpiar();
                        panel_NuevaSolicitud.Visible = false;
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
    }
}
