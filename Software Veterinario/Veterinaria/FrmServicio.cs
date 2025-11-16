using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Veterinaria
{
    public partial class FrmServicio : Form
    {
        private List<Servicio> listaServicio;
        public FrmServicio()
        {
            InitializeComponent();
        }

        private void FrmServicio_Load(object sender, EventArgs e)
        {
            CargarFrm();
        }

        private void CargarFrm()
        {
            NServicio nServicio = new NServicio();
            listaServicio = nServicio.ListarServicios();
            dgvServicio.DataSource = listaServicio;
            AjustarOcultarColumnas();
        }
        private void AjustarOcultarColumnas()
        {
            dgvServicio.Columns["Activo"].Visible = false;
            dgvServicio.Columns["Id"].Width = 50;
            dgvServicio.Columns["Nombre"].Width = 170;
            dgvServicio.Columns["CostoEstimado"].Width = 100;
        }


        private void dgvServicio_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvServicio.Columns["CostoEstimado"].Visible == true)
            {
                if (e.Value != null && e.Value is decimal)
                {
                    e.Value = string.Format("{0:C0}", e.Value);
                }
            }
        }
    }
}
