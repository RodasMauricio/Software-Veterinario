using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria
{
    public partial class FrmEspecieRaza : Form
    {
        private List<Especie> listaEspecie;
        private List<Raza> listaRaza;
        private Raza raza = null;
        private Raza razaSeleccion;
        private Especie especie = null;
        private Especie especieSeleccion;
        byte n = 0;
        bool esRaza = false;
        public FrmEspecieRaza()
        {
            InitializeComponent();
        }
        public FrmEspecieRaza(byte v)
        {
            InitializeComponent();
            n = v;
            esRaza = true;
        }

        private void FrmEspecieRaza_Load(object sender, EventArgs e)
        {
            if (n == 0)
            {
                //especie
                CargarFrmEspecie();
                dgvPropiedad.DataSource = listaEspecie;
            }
            else
            {
                //raza
                CargarFrmRaza();
                HabilitarEspecie();
            }

        }

        private void lblX_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CargarFrmEspecie()
        {
            NEspecie nEspecie = new NEspecie();
            listaEspecie = nEspecie.ListarEspecies();
        }
        private void CargarFrmRaza()
        {
            NRaza nRaza = new NRaza();
            listaRaza = nRaza.ListarRazas();
            dgvPropiedad.DataSource = listaRaza;
            CargarFrmEspecie();
            ClassHelper.CargarCbx(cbEspecie, listaEspecie, "Id", "Descripcion");
        }
        private void HabilitarEspecie()
        {
            lblEspecie.Visible = true;
            cbEspecie.Visible = true;
        }
        private void CargarValoresModificar()
        {
            if (esRaza == false)
            {
                txtNombre.Text = especie.Descripcion;
            }
            else
            {
                txtNombre.Text = raza.Descripcion;
                cbEspecie.SelectedValue = raza.Especie.Id;
            }
        }
        private void EstadoBotones()
        {
            bool s = dgvPropiedad.SelectedRows.Count > 0;
            btnModificar.Enabled = s;
            btnEliminar.Enabled = s;
        }
        private void InsertarValores()
        {

        }
        private void LimpiarCarga()
        {
            ClassHelper.LimpiarTxt(txtNombre);
            if (esRaza == true)
                ClassHelper.LimpiarCbx(cbEspecie);
        }

        private void SeleccionPropiedad()
        {
            if (esRaza == false)
            {
                if (dgvPropiedad.Rows.Count > 0)
                    especieSeleccion = (Especie)dgvPropiedad.CurrentRow.DataBoundItem;
                else
                    especieSeleccion = (Especie)dgvPropiedad.Rows[0].DataBoundItem;

            }
            else
            {
                if (dgvPropiedad.CurrentRow != null)
                    razaSeleccion = (Raza)dgvPropiedad.CurrentRow.DataBoundItem;
                else
                    razaSeleccion = (Raza)dgvPropiedad.Rows[0].DataBoundItem;
            }
        }

        private void BloqueoAgregarModificar(bool v)
        {
            ClassHelper.HabilitarLbl(v, lblNombre);
            ClassHelper.HabilitarControles(v, txtNombre);
            if (esRaza == true)
            {
                ClassHelper.HabilitarLbl(v, lblEspecie);
                ClassHelper.HabilitarControles(v, cbEspecie);
            }
        }

        private void dgvPropiedad_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvPropiedad.Rows.Count > 0)
                {
                    SeleccionPropiedad();
                    LimpiarCarga();
                    BloqueoAgregarModificar(false);
                    EstadoBotones();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            LimpiarCarga();
            BloqueoAgregarModificar(true);
            raza = null;
            btnAceptar.Text = "Agregar";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            LimpiarCarga();
            SeleccionPropiedad();
            if (esRaza == false)
                especie = especieSeleccion;
            else
                raza = razaSeleccion;
            BloqueoAgregarModificar(true);
            CargarValoresModificar();
            btnAceptar.Text = "Modificar";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPropiedad.Rows.Count > 0)
            {
                try
                {
                    LimpiarCarga();
                    BloqueoAgregarModificar(false);
                    SeleccionPropiedad();
                    DialogResult r = MessageBox.Show($"¿Desea eliminar esa propiedad?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        if (esRaza == false)
                        {
                            NEspecie nEspecie = new NEspecie();
                            //
                        }
                        else
                        {
                            NRaza nRaza = new NRaza();
                            nRaza.Eliminar(razaSeleccion.Id);
                            CargarFrmRaza();
                        }
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
