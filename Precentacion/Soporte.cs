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
    public partial class Soporte : Form
    {
        SolicitudEntidad solicitudEntidad = new SolicitudEntidad();
        public UsuarioEntidad usuarioEntidad { get; set; }
        public Soporte(UsuarioEntidad usuarioEntidad)
        {
            InitializeComponent();
            CargarDatos();
            this.usuarioEntidad = usuarioEntidad;
        }

        private void CargarDatos()
        {
            CargarSolicitudes();
            panel_NuevaSolicitud.Visible = false;
        }

        private void CargarSolicitudes()
        {
            List<SolicitudEntidad> solicitudEntidads = SolicitudNegocio.ListaSolicitudes(22);
            if (solicitudEntidads.Count >= 1)
            {
                foreach (var item in solicitudEntidads)
                {
                    Solicitudes solicitudes = new Solicitudes();
                    solicitudes.Emisor = "Diego";
                    solicitudes.Asunto = item.Asunto;
                    solicitudes.Descripcion = item.Descripcion;
                    solicitudes.Fecha = item.Fecha.ToLongDateString();

                    panel_Contendor.Controls.Add(solicitudes);
                    foreach (Solicitudes sol in panel_Contendor.Controls.OfType<Solicitudes>())
                    {
                        sol.Dock = DockStyle.Top;
                    }
                }
                label_Solicitud.Visible = false;
            }
            else
            {
                label_Solicitud.Visible = true;
            }

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            panel_NuevaSolicitud.Visible = true;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            panel_NuevaSolicitud.Visible = false;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            textBox_Asunto.Text = "";
            richTextBox_Descripcion.Text = "";
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (ControlDatos())
            {
                solicitudEntidad.IdUsuario = 22;
                solicitudEntidad.IdTecnico = 0;
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
                    MessageBox.Show("Se ha enviado su solicitud");
                    Limpiar();
                    panel_NuevaSolicitud.Visible = false;
                    CargarSolicitudes();
                }
            }
        }

        private bool ControlDatos()
        {
            if (textBox_Asunto.Text =="" || richTextBox_Descripcion.Text == "" ||
                rjComboBox_Urgencia.Texts == "" || rjComboBox_Dispositivo.Texts == "")
            {
                MostrarError(0);
                return false;
            }
            return true;
        }

        private void MostrarError(int v)
        {
            String[] errors = new string[] { "Faltan datos"};
            label_Error.Text = errors[v];
            label_Error.ForeColor = Color.Red;
            iconButton_Error.Visible = true;
            label_Error.Visible = true;
        }
    }
}
