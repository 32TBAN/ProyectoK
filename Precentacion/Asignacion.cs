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

namespace Precentacion
{
    public partial class Asignacion : Form
    {
        private UsuarioEntidad usuarioSeleccionado = new UsuarioEntidad();
        private SolicitudEntidad solicitudSeleccionado = new SolicitudEntidad();
        private List<SolicitudEntidad> solicitudEntidadsAsignadas = new List<SolicitudEntidad>();
        private AsignacionesEntidad asignacion = new AsignacionesEntidad();
        public Asignacion()
        {
            InitializeComponent();
            CargarDataGrint();
        }

        private void CargarDataGrint()
        {
            List<UsuarioEntidad> usuariosTecnicos = new List<UsuarioEntidad>();

            foreach (var item in UsuarioNegocio.ListaUsuarios())
            {
                if (item.Perfil == "T")
                {
                    usuariosTecnicos.Add(item);
                }
            }

            List<SolicitudEntidad> solicitudEntidads = new List<SolicitudEntidad>();

            foreach (var item in SolicitudNegocio.ListaSolicitudesCompleta())
            {
                if (item.Estado == 0)
                {
                    solicitudEntidads.Add(item);
                }
            }

            dataGridView_Tecnicos.DataSource = usuariosTecnicos;
            dataGridView_Tecnicos.Columns["Foto"].Visible = false;
            dataGridView_Tecnicos.Columns["Id"].Visible = false;
            dataGridView_Tecnicos.Columns["Contraseña"].Visible = false;
            dataGridView_Tecnicos.Columns["Perfil"].Visible = false;

            dataGridView_Solicitudes.DataSource = solicitudEntidads;
            dataGridView_Solicitudes.Columns["Id"].Visible = false;
            dataGridView_Solicitudes.Columns["IdUsuario"].Visible = false;
            dataGridView_Solicitudes.Columns["IdTecnico"].Visible = false;
            dataGridView_Solicitudes.Columns["NombreTecnico"].Visible = false;
            dataGridView_Solicitudes.Columns["Estado"].Visible = false;

        }

        private void CargarSolucitudes()
        {
            dataGridView_Asignadas.DataSource = null;
            dataGridView_Asignadas.DataSource = solicitudEntidadsAsignadas;
            dataGridView_Asignadas.Columns["Id"].Visible = false;
            dataGridView_Asignadas.Columns["IdUsuario"].Visible = false;
            dataGridView_Asignadas.Columns["IdTecnico"].Visible = false;
            dataGridView_Asignadas.Columns["NombreTecnico"].Visible = false;
            dataGridView_Asignadas.Columns["Estado"].Visible = false;
            dataGridView_Asignadas.Columns["Fecha"].Visible = false;

        }

        private void dataGridView_Tecnicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                usuarioSeleccionado.Id = Convert.ToInt32(dataGridView_Tecnicos.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                usuarioSeleccionado.Cedula = dataGridView_Tecnicos.Rows[e.RowIndex].Cells["Cedula"].Value.ToString();
                textBox_Cedula.Text = usuarioSeleccionado.Cedula;
                label_Tecnico.Text = usuarioSeleccionado.Cedula;
                CargarSolictudesTec();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no ha seleccionado una fila valida" +
                    " " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarSolictudesTec()
        {
            List<SolicitudEntidad> solicitudEntidadTecnico = new List<SolicitudEntidad>();
            foreach (var item in SolicitudNegocio.ListaSolicitudesCompleta())
            {
                if (item.IdTecnico == usuarioSeleccionado.Id && item.Estado == 1)
                    solicitudEntidadTecnico.Add(item);
            }
            dataGridView_SolicitudesTec.DataSource = solicitudEntidadTecnico;
            dataGridView_SolicitudesTec.Columns["Id"].Visible = false;
            dataGridView_SolicitudesTec.Columns["IdUsuario"].Visible = false;
            dataGridView_SolicitudesTec.Columns["IdTecnico"].Visible = false;
            dataGridView_SolicitudesTec.Columns["NombreTecnico"].Visible = false;
            dataGridView_SolicitudesTec.Columns["Estado"].Visible = false;
        }

        private void dataGridView_Solicitudes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (usuarioSeleccionado.Id != 0)
                {
                    int c = Convert.ToInt32(dataGridView_Solicitudes.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    if (ComprobarExistencia(c))
                    {
                        solicitudSeleccionado = SolicitudNegocio.BuscarSolicitud(c);
                        solicitudEntidadsAsignadas.Add(solicitudSeleccionado);
                        CargarSolucitudes();
                    }
                }
                else
                    MessageBox.Show("Primero debe seleccionar un tecnico");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no ha seleccionado una fila valida" +
                    " " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ComprobarExistencia(int c)
        {
            foreach (var item in solicitudEntidadsAsignadas)
            {
                if (item.Id == c)
                {
                    MessageBox.Show("Esa solicitud ya esta asigna a este usuario");
                    return false; 
                }
            }
            return true;
        }

        private void dataGridView_Asignadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               int quitar = Convert.ToInt32(dataGridView_Asignadas.Rows[e.RowIndex].Cells["Id"].Value.ToString());
               QuitarLista(quitar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no ha seleccionado una fila valida" +
                    " " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void QuitarLista(int quitar)
        {
            if (MessageBox.Show("Esta seguro que desea quitar esta solicitud?", "Quitar", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (var item in solicitudEntidadsAsignadas)
                {
                    if (item.Id == quitar)
                    {
                        solicitudEntidadsAsignadas.Remove(item);
                        break;
                    }
                }
                CargarSolucitudes();
            }
            
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            CargarAsignaciones();
        }

        private void CargarAsignaciones()
        {
            if (solicitudEntidadsAsignadas.Count >= 1)
            {
                foreach (var item in solicitudEntidadsAsignadas)
                {
                    asignacion.IdSolicitud = item.Id;
                    asignacion.IdTecnico = usuarioSeleccionado.Id;
                    asignacion.Respuesta = "";
                    asignacion.Terminada = false;
                    asignacion.Total = 0;
                    AsignacionesEntidad asignacionesRespaldo = asignacion;
                    asignacion = AsignacionNegocio.Guardar(asignacion);
                    item.IdTecnico = usuarioSeleccionado.Id;
                    item.Estado = 1;
                    SolicitudNegocio.Guardar(item);
                    if (asignacion == null)
                    {
                        MessageBox.Show("Error al asignar la solicitud"+" "+asignacion.IdSolicitud);
                        asignacion = asignacionesRespaldo;
                    }
                }
                MessageBox.Show("Se han asignado tadas las solicitudes");
                CargarDataGrint();
                CargarSolictudesTec();
                solicitudEntidadsAsignadas.Clear();
                dataGridView_Asignadas.DataSource = null;
            }
            else
                MessageBox.Show("Aun no hay ninguna solicitud");
        }

        private void dataGridView_SolicitudesTec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Q = Convert.ToInt32(dataGridView_SolicitudesTec.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                EliminarAsignacion(Q);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no ha seleccionado una fila valida" +
                    " " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarAsignacion(int quitar)
        {
            if (MessageBox.Show("Esta seguro que desea quitarle esta solicitud a este tecnico?", "Quitar", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SolicitudEntidad solicitudEntidadEliminar = SolicitudNegocio.BuscarSolicitud(quitar);
                if (AsignacionNegocio.Eliminar(solicitudEntidadEliminar.Id, solicitudEntidadEliminar.IdTecnico))
                {
                    MessageBox.Show("Se ha quitado esa asigancion");
                    solicitudEntidadEliminar.Estado = 0;
                    solicitudEntidadEliminar = SolicitudNegocio.Guardar(solicitudEntidadEliminar);
                    CargarDataGrint();
                    CargarSolictudesTec();
                }
                else
                {
                    MessageBox.Show("Error eliminar");
                }
                CargarSolucitudes();
            }
        }
    }
}
