using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
            AjustarOcultarColumnas();
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
        private void AjustarOcultarColumnas()
        {
            dgvPropiedad.Columns["Id"].Width = 50;
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
                txtDescripcion.Text = especie.Descripcion;
            }
            else
            {
                txtDescripcion.Text = raza.Descripcion;
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
            if (esRaza == false)
            {
                if (especie == null)
                    especie = new Especie();
                especie.Descripcion = txtDescripcion.Text;
            }
            else
            {
                if (raza == null)
                    raza = new Raza();
                raza.Descripcion = txtDescripcion.Text;
                raza.Especie = (Especie)cbEspecie.SelectedItem;
            }
        }
        private void LimpiarCarga()
        {
            ClassHelper.LimpiarTxt(txtDescripcion);
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
            ClassHelper.HabilitarLbl(v, lblDescripcion);
            ClassHelper.HabilitarControles(v, txtDescripcion);
            if (esRaza == true)
            {
                ClassHelper.HabilitarLbl(v, lblEspecie);
                ClassHelper.HabilitarControles(v, cbEspecie);
            }
        }


        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            ClassHelper.ColorTxt(txtFiltro);
            string filtro = txtFiltro.Text.ToUpper();
            if (esRaza == false)
            {
                List<Especie> filtroRapido;
                filtroRapido = listaEspecie.FindAll(x => x.Descripcion.ToUpper().Contains(filtro));
                dgvPropiedad.DataSource = null;
                dgvPropiedad.DataSource = filtroRapido;
            }
            else
            {
                List<Raza> filtroRapido;
                filtroRapido = listaRaza.FindAll(x => x.Descripcion.ToUpper().Contains(filtro));
                dgvPropiedad.DataSource = null;
                dgvPropiedad.DataSource = filtroRapido;
            }
            AjustarOcultarColumnas();
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
            if (esRaza == false)
                especie = null;
            else
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
                            nEspecie.Eliminar(especieSeleccion.Id);
                            CargarFrmEspecie();
                            dgvPropiedad.DataSource = listaEspecie;
                        }
                        else
                        {
                            NRaza nRaza = new NRaza();
                            nRaza.Eliminar(razaSeleccion.Id);
                            CargarFrmRaza();
                        }
                        AjustarOcultarColumnas();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (esRaza == false)
            {
                if (txtDescripcion.Text != "")
                {
                    try
                    {
                        DialogResult r = MessageBox.Show($"¿Desea {btnAceptar.Text} esta especie ({txtDescripcion.Text})?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (r == DialogResult.Yes)
                        {
                            InsertarValores();
                            NEspecie nEspecie = new NEspecie();
                            if (especie.Id > 0)
                                nEspecie.Modificar(especie);
                            else
                                nEspecie.Agregar(especie);
                            CargarFrmEspecie();
                            dgvPropiedad.DataSource = listaEspecie;
                            AjustarOcultarColumnas();
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar una descripción.");
                }
            }
            else
            {
                if (txtDescripcion.Text != "" && cbEspecie.SelectedIndex != -1)
                {
                    DialogResult r = MessageBox.Show($"¿Desea {btnAceptar.Text} esta raza ({txtDescripcion.Text})?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        InsertarValores();
                        NRaza nRaza = new NRaza();
                        if (raza.Id > 0)
                            nRaza.Modificar(raza);
                        else
                            nRaza.Agregar(raza);
                        CargarFrmRaza();
                        AjustarOcultarColumnas();
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar una descripción y seleccionar una especie.");
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCarga();
            BloqueoAgregarModificar(false);
        }


        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            ClassHelper.ColorTxt(txtDescripcion);
        }
    }
}
