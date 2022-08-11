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
                if (!item.Estado)
                {
                    solicitudEntidads.Add(item);
                }
            }

            dataGridView_Tecnicos.DataSource = usuariosTecnicos;
            dataGridView_Solicitudes.DataSource = solicitudEntidads;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
