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
        public Revicion()
        {
            InitializeComponent();
            CargarListas();
        }

        private void CargarListas()
        {
            List<SolicitudEntidad> solicitudEntidads = new List<SolicitudEntidad>();
            List<Asignaciones> asignaciones = AsignacionNegocio.ListaAsignacionTerminada();
            foreach (var item in SolicitudNegocio.ListaSolicitudesCompleta())
            {
                foreach (var item1 in asignaciones)
                {
                    if (item.Id == item1.IdSolicitud)
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
    }
}
