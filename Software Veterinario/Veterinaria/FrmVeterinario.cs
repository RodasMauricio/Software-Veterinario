using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Veterinaria
{
    public partial class FrmVeterinario : Form
    {
        private List<Veterinario> listaVeterinario;
        private Veterinario veterinarioSeleccion;
        private Veterinario veterinario = null;
        public FrmVeterinario()
        {
            InitializeComponent();
        }

        private void FrmVeterinario_Load(object sender, EventArgs e)
        {
            CargarFrm(1);
            AjustarOcultarColumnas();
        }
        private void CargarFrm(byte a)
        {
            NVeterinario nVeterinario = new NVeterinario();
            listaVeterinario = nVeterinario.ListarVeterinarios(a);
            dgvVeterinario.DataSource = listaVeterinario;
        }
        private void AjustarOcultarColumnas()
        {
            dgvVeterinario.Columns["Activo"].Visible = false;
            dgvVeterinario.Columns["Id"].Width = 50;
            dgvVeterinario.Columns["Matricula"].Width = 90;
            dgvVeterinario.Columns["Telefono"].Width = 110;
        }
        private void CargarValoresModificar()
        {
            txtNombre.Text = veterinario.Nombre;
            txtMatricula.Text = veterinario.Matricula;
            txtEmail.Text = veterinario.Email;
            txtTelefono.Text = veterinario.Telefono;
        }
        private void EstadoBotones()
        {
            if (dgvVeterinario.Rows.Count == 0)
            {
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                return;
            }
            bool s = dgvVeterinario.SelectedRows.Count > 0;
            btnModificar.Enabled = s;
            btnEliminar.Enabled = s;
        }
        private void InsertarValores()
        {
            if (veterinario == null)
                veterinario = new Veterinario();
            veterinario.Nombre = txtNombre.Text;
            veterinario.Matricula = txtMatricula.Text;
            veterinario.Email = txtEmail.Text;
            veterinario.Telefono = txtTelefono.Text;
        }
        private void LimpiarCarga()
        {
            ClassHelper.LimpiarTxt(txtNombre, txtMatricula, txtEmail, txtTelefono);
            btnAceptar.Text = "Aceptar";
        }
        private void SeleccionVeterinario()
        {
            if (dgvVeterinario.CurrentRow != null)
                veterinarioSeleccion = (Veterinario)dgvVeterinario.CurrentRow.DataBoundItem;
            else
                veterinarioSeleccion = (Veterinario)dgvVeterinario.Rows[0].DataBoundItem;
        }


        private void BloqueoAgregarModificar(bool v)
        {
            ClassHelper.HabilitarLbl(v, lblNombre, lblMatricula, lblEmail, lblTelefono);
            ClassHelper.HabilitarControles(v, txtNombre, txtMatricula, txtEmail, txtTelefono, btnAceptar);
        }


        private void dgvVeterinario_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvVeterinario.Rows.Count > 0)
                {
                    if (btnEliminados.Enabled != false)
                    {
                        SeleccionVeterinario();
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
            if (dgvVeterinario.Rows.Count > 0)
            {
                try
                {
                    SeleccionVeterinario();
                    DialogResult r = MessageBox.Show($"¿Desea recuperar este veterinario ({veterinarioSeleccion.Nombre})?", "Recuperar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        NVeterinario nVeterinario = new NVeterinario();
                        nVeterinario.Recuperar(veterinarioSeleccion.Id);
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
            veterinario = null;
            btnAceptar.Text = "Agregar";
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvVeterinario.Rows.Count > 0)
            {
                try
                {
                    LimpiarCarga();
                    SeleccionVeterinario();
                    veterinario = veterinarioSeleccion;
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
            if (dgvVeterinario.Rows.Count > 0)
            {
                try
                {
                    LimpiarCarga();
                    BloqueoAgregarModificar(false);
                    SeleccionVeterinario();
                    DialogResult r = MessageBox.Show($"¿Desea eliminar este veterinario ({veterinarioSeleccion.Nombre})?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        NVeterinario nVeterinario = new NVeterinario();
                        nVeterinario.Eliminar(veterinarioSeleccion.Id);
                        CargarFrm(1);
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
            if (txtNombre.Text != "" && txtMatricula.Text != "" && txtEmail.Text != "" && txtTelefono.Text != "")
            {
                DialogResult r = MessageBox.Show($"¿Desea {btnAceptar.Text} este veterinario ({txtNombre.Text})?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    InsertarValores();
                    NVeterinario nVeterinario = new NVeterinario();
                    if (veterinario.Id > 0)
                        nVeterinario.Modificar(veterinario);
                    else
                        nVeterinario.Agregar(veterinario);
                    CargarFrm(1);
                    AjustarOcultarColumnas();
                }

            }
            else
            {
                MessageBox.Show("Debe completar los campos necesarios (Nombre - Matrícula - Email - Teléfono)");
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCarga();
            BloqueoAgregarModificar(false);
        }



        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ClassHelper.ColorTxt(txtNombre);
        }
        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {
            ClassHelper.ColorTxt(txtMatricula);
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            ClassHelper.ColorTxt(txtEmail);
        }
        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            ClassHelper.ColorTxt(txtTelefono);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
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

        private void FrmVeterinario_SizeChanged(object sender, EventArgs e)
        {
            AjustarOcultarColumnas();
        }
    }
}
