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
        private Servicio servicioSeleccion;
        private Servicio servicio = null;
        public FrmServicio()
        {
            InitializeComponent();
        }

        private void FrmServicio_Load(object sender, EventArgs e)
        {
            CargarFrm(1);
            AjustarOcultarColumnas();
        }

        private void CargarFrm(byte a)
        {
            NServicio nServicio = new NServicio();
            listaServicio = nServicio.ListarServicios(a);
            dgvServicio.DataSource = listaServicio;
        }
        private void AjustarOcultarColumnas()
        {
            dgvServicio.Columns["Activo"].Visible = false;
            dgvServicio.Columns["Id"].Width = 50;
            dgvServicio.Columns["Nombre"].Width = 170;
            dgvServicio.Columns["CostoEstimado"].Width = 100;
        }
        private void CargarValoresModificar()
        {
            txtNombre.Text = servicio.Nombre;
            txtDescripcion.Text = servicio.Descripcion;
            txtCosto.Text = servicio.CostoEstimado.ToString("N0");
        }
        private void EstadoBotones()
        {
            bool s = dgvServicio.SelectedRows.Count > 0;
            btnModificar.Enabled = s;
            btnEliminar.Enabled = s;
        }

        private void InsertarValores()
        {
            if (servicio == null)
                servicio = new Servicio();
            servicio.Nombre = txtNombre.Text;
            servicio.Descripcion = txtDescripcion.Text;
            servicio.CostoEstimado = decimal.Parse(txtCosto.Text);
        }
        private void LimpiarCarga()
        {
            ClassHelper.LimpiarTxt(txtNombre, txtDescripcion, txtCosto);
            btnAceptar.Text = "Aceptar";
        }
        private void SeleccionServicio()
        {
            servicioSeleccion = (Servicio)dgvServicio.CurrentRow.DataBoundItem;
        }

        private void BloqueoAgregarModificar(bool v)
        {
            ClassHelper.HabilitarLbl(v, lblNombre, lblDescripcion, lblCosto);
            ClassHelper.HabilitarControles(v, txtNombre, txtDescripcion, txtCosto, btnAceptar);
        }

        private void dgvServicio_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvServicio.Rows.Count > 0)
                {
                    if (btnEliminados.Enabled != false)
                    {
                        SeleccionServicio();
                        LimpiarCarga();
                        BloqueoAgregarModificar(false);
                        EstadoBotones();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
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


        private void btnEliminados_Click(object sender, EventArgs e)
        {
            CargarFrm(0);
            AjustarOcultarColumnas();
            btnRecuperar.Visible = true;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEliminados.Enabled = false;
        }
        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            if (dgvServicio.Rows.Count > 0)
            {
                try
                {
                    SeleccionServicio();
                    DialogResult r = MessageBox.Show($"¿Desea recuperar este servicio ({servicioSeleccion.Nombre})?", "Recuperar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        NServicio nServicio = new NServicio();
                        nServicio.Recuperar(servicioSeleccion.Id);
                        CargarFrm(0);
                        AjustarOcultarColumnas();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            LimpiarCarga();
            BloqueoAgregarModificar(true);
            servicio = null;
            btnAceptar.Text = "Agregar";
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvServicio.Rows.Count > 0)
            {
                try
                {
                    LimpiarCarga();
                    SeleccionServicio();
                    servicio = servicioSeleccion;
                    BloqueoAgregarModificar(true);
                    CargarValoresModificar();
                    btnAceptar.Text = "Modificar";
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvServicio.Rows.Count > 0)
            {
                try
                {
                    LimpiarCarga();
                    BloqueoAgregarModificar(false);
                    SeleccionServicio();
                    DialogResult r = MessageBox.Show($"¿Desea eliminar este servicio ({servicioSeleccion.Nombre})?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        NServicio nServicio = new NServicio();
                        nServicio.Eliminar(servicioSeleccion.Id);
                        CargarFrm(1);
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
            if (txtNombre.Text != "" && txtDescripcion.Text != "" && txtCosto.Text != "")
            {
                DialogResult r = MessageBox.Show($"¿Desea {btnAceptar.Text} este servicio ({txtNombre.Text})?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    try
                    {
                        InsertarValores();
                        NServicio nServicio = new NServicio();
                        if (servicio.Id > 0)
                            nServicio.Modificar(servicio);
                        else
                            nServicio.Agregar(servicio);
                        CargarFrm(1);
                        AjustarOcultarColumnas();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe completar los campos necesarios (Nombre - Descripción - Costo)");
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCarga();
            BloqueoAgregarModificar(false);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarFrm(1);
            AjustarOcultarColumnas();
            btnRecuperar.Visible = false;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEliminados.Enabled = true;
        }


        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ClassHelper.ColorTxt(txtNombre);
        }
        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            ClassHelper.ColorTxt(txtDescripcion);
        }
        private void txtCosto_TextChanged(object sender, EventArgs e)
        {
            ClassHelper.ColorTxt(txtCosto);
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void FrmServicio_SizeChanged(object sender, EventArgs e)
        {
            AjustarOcultarColumnas();
        }
    }
}
