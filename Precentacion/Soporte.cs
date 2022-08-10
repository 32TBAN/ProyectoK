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
using FontAwesome.Sharp;
using Negocio;

namespace Precentacion
{
    public partial class Soporte : Form
    {
        SolicitudEntidad solicitudEntidad = new SolicitudEntidad();
        private IconButton bottonActivo;
        private Panel bordeInferior;
        public UsuarioEntidad usuarioEntidad { get; set; }
        public Soporte(UsuarioEntidad usuarioEntidad)
        {
            InitializeComponent();
            CargarDatos();
            this.usuarioEntidad = usuarioEntidad;
        }

        private void CargarDatos()
        {
            CargarSolicitudes(true);
            //botones
            bordeInferior = new Panel();
            bordeInferior.Size = new Size(181, 2);
            panel_Cabezera.Controls.Add(bordeInferior);
            ActivateButton(iconButton_Pincipal);
        }

        private void CargarSolicitudes(bool general)
        {
            List<SolicitudEntidad> solicitudEntidads = SolicitudNegocio.ListaSolicitudes(22);
            if (solicitudEntidads.Count >= 1)
            {
                panel_Contendor.Controls.Clear();
                panel_Contendor.Controls.Add(label_Solicitud);
                if (general)
                {
                    foreach (var item in solicitudEntidads)
                    {
                        Solicitudes solicitudes = new Solicitudes();
                        solicitudes.label_Emisor.Click += Label_Emisor_Click;
                        if (item.IdTecnico == 0)
                            solicitudes.Emisor = "Aun no se ha asignado aun tecnico";
                        else
                            solicitudes.Emisor = UsuarioNegocio.BuscarUsuarioID(item.IdTecnico).Nombre;
                        solicitudes.Asunto = item.Asunto;
                        solicitudes.Descripcion = item.Descripcion;
                        solicitudes.Fecha = item.Fecha.ToShortDateString();
        
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
                    List<SolicitudEntidad> solicitudHechas = solicitudEntidads.Where(x => x.Estado == true).ToList();
                    if (solicitudHechas.Count >=1 )
                    {
                        foreach (var item in solicitudHechas)
                        {
                            if (item.Estado)
                            {
                                Solicitudes solicitudes = new Solicitudes();
                                solicitudes.Emisor = "Aun no se ha asignado aun tecnico";
                                solicitudes.Asunto = item.Asunto;
                                solicitudes.Descripcion = item.Descripcion;
                                solicitudes.Fecha = item.Fecha.ToShortDateString();

                                panel_Contendor.Controls.Add(solicitudes);
                                foreach (Solicitudes sol in panel_Contendor.Controls.OfType<Solicitudes>())
                                {
                                    sol.Dock = DockStyle.Top;
                                }
                            }
                        }
                    }
                    else
                    {
                        label_Solicitud.Text = "Sus solicitudestan aun estan pendientes";
                        label_Solicitud.Visible = true;
                        
                    }

                }
            }
            else
                label_Solicitud.Visible = true;
            panel_Contendor.Controls.Add(panel_NuevaSolicitud);
            panel_NuevaSolicitud.Visible = false;
        }

        private void Label_Emisor_Click(object sender, EventArgs e)
        {
            panel_Cabezera.Visible = false;
            panel_Contendor.Controls.Clear();
            AbrirForm(new Calificar());
           //TODO: VER DESCRIPCION COMPLETA Y SI YA HAY UN TECNICO ENCARGADO
        }
        public void AbrirForm(Form form)
        {
            form.TopLevel = true;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel_Contendor.Controls.Add(form);
            panel_Contendor.Tag = form;
            form.BringToFront();
            form.Show();
            form.FormClosed += Form_FormClosed;
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            //TODO: Cargar las listas
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            CargarSolicitudes(false);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            panel_NuevaSolicitud.Visible = true;
            panel_NuevaSolicitud.BringToFront();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            panel_NuevaSolicitud.Visible = false;
            panel_NuevaSolicitud.SendToBack();
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
                    CargarSolicitudes(true);
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

        #region DiseñoBotones
       
    //Methods
    private void ActivateButton(object senderBtn)
    {
        if (senderBtn != null)
        {
            DisableButton();

            bottonActivo = (IconButton)senderBtn;
            bottonActivo.ForeColor = Color.Red;
            bottonActivo.TextAlign = ContentAlignment.MiddleCenter;           
            bottonActivo.IconColor = Color.Red;

            bordeInferior.BackColor = Color.Red;
            bordeInferior.Location = new Point(bottonActivo.Location.X,5);
            bordeInferior.Visible = true;
            bordeInferior.BringToFront();
        }
    }
    private void DisableButton()
    {
        if (bottonActivo != null)
        {
            bottonActivo.BackColor = Color.White;
            bottonActivo.ForeColor = Color.Black;
            bottonActivo.IconColor = Color.FromArgb(242, 207, 141);
        }
    }
        #endregion

        private void iconButton_Pincipal_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            CargarSolicitudes(true);
        }
    }
}
