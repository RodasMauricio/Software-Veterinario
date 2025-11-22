using System;
using System.CodeDom;
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
    public partial class FrmClienteEliminado : Form
    {
        private List<Cliente> listaClienteEliminado;
        private Cliente clienteSeleccion;
        public FrmClienteEliminado()
        {
            InitializeComponent();
        }

        private void FrmClienteEliminado_Load(object sender, EventArgs e)
        {
            CargarFrm();
            AjustarOcultarColumnas();
        }
        private void CargarFrm()
        {
            NCliente nCliente = new NCliente();
            listaClienteEliminado = nCliente.ListarClientes(0);
            dgvClienteEliminado.DataSource = listaClienteEliminado;
        }
        private void AjustarOcultarColumnas()
        {
            dgvClienteEliminado.Columns["Activo"].Visible = false;
            dgvClienteEliminado.Columns["Id"].Width = 50;
        }
        private void lblX_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void EstadoBotones()
        {
            bool s = dgvClienteEliminado.SelectedRows.Count > 0;
            btnRecuperar.Enabled = s;
        }
        private void SeleccionCliente()
        {
            clienteSeleccion = (Cliente)dgvClienteEliminado.CurrentRow.DataBoundItem;
        }


        private void txtFiltroClienteEliminado_TextChanged(object sender, EventArgs e)
        {
            ClassHelper.ColorTxt(txtFiltroClienteEliminado);
            List<Cliente> filtroRapido;
            string filtro = txtFiltroClienteEliminado.Text.ToUpper();
            filtroRapido = listaClienteEliminado.FindAll(x => x.Nombre.ToUpper().Contains(filtro) || x.DniCuit.Contains(filtro) || x.Telefono.Contains(filtro));

            dgvClienteEliminado.DataSource = null;
            dgvClienteEliminado.DataSource = filtroRapido;
            AjustarOcultarColumnas();
        }
        private void dgvClienteEliminado_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvClienteEliminado.Rows.Count > 0)
                {
                    SeleccionCliente();
                    EstadoBotones();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            if (dgvClienteEliminado.Rows.Count > 0)
            {
                try
                {
                    SeleccionCliente();
                    DialogResult r = MessageBox.Show($"¿Desea recuperar este cliente eliminado ({clienteSeleccion.Nombre})?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        NCliente nCliente = new NCliente();
                        nCliente.Recuperar(clienteSeleccion.Id);
                        MessageBox.Show("¡Cliente recuperado!");
                        CargarFrm();
                        AjustarOcultarColumnas();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

    }
}
