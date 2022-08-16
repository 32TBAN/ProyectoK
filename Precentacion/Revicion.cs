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
    public partial class Revicion : Form
    {
        private AsignacionesEntidad asignacionSol { get; set; }
        private SolicitudEntidad solicitudEntidad { get; set; }
        List<SolicitudEntidad> solicitudEntidads = new List<SolicitudEntidad>();
        List<AsignacionesEntidad> asignaciones = new List<AsignacionesEntidad>();
        public Revicion()
        {
            InitializeComponent();
            CargarListas();
        }

        private void CargarListas()
        {
            asignaciones = AsignacionNegocio.ListaAsignacionTerminada();
            foreach (var item in SolicitudNegocio.ListaSolicitudesCompleta())
            {
                foreach (var item1 in asignaciones)
                {
                    if (item.Id == item1.IdSolicitud && item.Estado == 1)
                    {
                        solicitudEntidads.Add(item);
                    }
                }
            }
            dataGridView_Realizadas.DataSource = solicitudEntidads;
            dataGridView_Realizadas.Columns["Id"].Visible = false;
            dataGridView_Realizadas.Columns["IdUsuario"].Visible = false;
            dataGridView_Realizadas.Columns["IdTecnico"].Visible = false;
            dataGridView_Realizadas.Columns["NombreTecnico"].Visible = false;
            dataGridView_Realizadas.Columns["Estado"].Visible = false;
            dataGridView_Realizadas.Columns["Fecha"].Visible = false;
        }

        private void dataGridView_Realizadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Q = Convert.ToInt32(dataGridView_Realizadas.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                CargarDatos(Q);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no ha seleccionado una fila valida" +
                    " " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatos(int q)
        {
            foreach (var item in asignaciones)
            {
                if (item.IdSolicitud == q)
                {
                    asignacionSol = item;
                }
            }
            foreach (var item in solicitudEntidads)
            {
                if (item.Id == q)
                {
                    solicitudEntidad = item;
                }
            }
            Fecha.Text = solicitudEntidad.Fecha.ToString();
            label_Descripcion.Text = solicitudEntidad.Descripcion;
            label_Requisitos.Text = asignacionSol.Respuesta;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            try
            {
                asignacionSol.Total = Convert.ToSingle(textBox_Total.Text);
                asignacionSol = AsignacionNegocio.Actualizar(asignacionSol);
                if (asignacionSol != null)
                {
                MessageBox.Show("Se ha enviado el total");
                solicitudEntidad.Estado = 2;
                SolicitudNegocio.Guardar(solicitudEntidad);
                CargarListas();
                }
                else
                    MessageBox.Show("A ocurrido un error al enviar el total");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro el valor no es valido");
            }
        }

        private void textBox_Total_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
    }
}
