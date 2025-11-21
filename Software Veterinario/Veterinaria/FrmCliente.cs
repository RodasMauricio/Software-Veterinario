using System;
using System.ClientModel;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Veterinaria
{
    public partial class FrmCliente : Form
    {
        private List<Cliente> listaCliente;
        private List<Paciente> listaPaciente;
        private List<string> nombrePacientes;
        private Cliente clienteSeleccion;
        private Cliente cliente = null;
        private NPaciente nPaciente;
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            CargarFrm();
            AjustarOcultarColumnas();
        }

        private void CargarFrm()
        {
            NCliente nCliente = new NCliente();
            nPaciente = new NPaciente();
            listaCliente = nCliente.ListarClientes();
            dgvCliente.DataSource = listaCliente;
        }
        private void AjustarOcultarColumnas()
        {
            dgvCliente.Columns["Activo"].Visible = false;
            dgvCliente.Columns["Id"].Width = 50;
        }
        private void CargarValoresModificar()
        {
            txtNombre.Text = cliente.Nombre;
            txtDniCuit.Text = cliente.DniCuit;
            txtEmail.Text = cliente.Email;
            txtTelefono.Text = cliente.Telefono;
            txtDireccion.Text = cliente.Direccion;
            txtLocalidad.Text = cliente.Localidad;
        }
        private int CantidadPacientes()
        {
            listaPaciente = nPaciente.ListarPacientes();
            nombrePacientes = null;
            nombrePacientes = new List<string>();
            int cont = 0;
            foreach (var p in listaPaciente)
            {
                if (clienteSeleccion.Id == p.Cliente.Id)
                {
                    cont++;
                    nombrePacientes.Add(p.Id.ToString() + "    " + p.Nombre);
                }
            }
            return cont;
        }
        private void EstadoBotones()
        {
            bool s = dgvCliente.SelectedRows.Count > 0;
            btnModificar.Enabled = s;
            btnEliminar.Enabled = s;
            btnPaciente.Enabled = s;
            if (btnPaciente.Enabled)
                btnPaciente.Text = CantidadPacientes().ToString();
            else
                btnPaciente.Text = "0";
            if (btnPaciente.Text == "0")
                btnPaciente.Enabled = false;
        }
        private void InsertarValores()
        {
            if (cliente == null)
                cliente = new Cliente();
            cliente.Nombre = txtNombre.Text;
            cliente.DniCuit = txtDniCuit.Text;
            cliente.Email = txtEmail.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.Localidad = txtLocalidad.Text;
        }
        private void LimpiarCarga()
        {
            ClassHelper.LimpiarTxt(txtNombre, txtDniCuit, txtEmail, txtTelefono, txtDireccion, txtLocalidad);
            btnAceptar.Text = "Aceptar";
        }
        private void SeleccionCliente()
        {
            clienteSeleccion = (Cliente)dgvCliente.CurrentRow.DataBoundItem;
        }


        private void BloqueoAgregarModificar(bool v)
        {
            ClassHelper.HabilitarLbl(v, lblNombre, lblDniCuit, lblEmail, lblTelefono, lblDireccion, lblLocalidad);
            ClassHelper.HabilitarControles(v, txtNombre, txtDniCuit, txtEmail, txtTelefono, txtDireccion, txtLocalidad, btnAceptar);
        }

        private void txtFiltroCliente_TextChanged(object sender, EventArgs e)
        {

            ClassHelper.ColorTxt(txtFiltroCliente);
            List<Cliente> filtroRapido;
            string filtro = txtFiltroCliente.Text.ToUpper();
            filtroRapido = listaCliente.FindAll(x => x.Nombre.ToUpper().Contains(filtro) || x.DniCuit.Contains(filtro) || x.Email.ToUpper().Contains(filtro) || x.Telefono.Contains(filtro) || x.Direccion.ToUpper().Contains(filtro) || x.Localidad.ToUpper().Contains(filtro));

            dgvCliente.DataSource = null;
            dgvCliente.DataSource = filtroRapido;
            AjustarOcultarColumnas();
        }
        private void dgvCliente_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvCliente.Rows.Count > 0)
                {
                    SeleccionCliente();
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
            cliente = null;
            btnAceptar.Text = "Agregar";
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            LimpiarCarga();
            SeleccionCliente();
            cliente = clienteSeleccion;
            BloqueoAgregarModificar(true);
            CargarValoresModificar();
            btnAceptar.Text = "Modificar";
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCliente.Rows.Count > 0)
            {
                try
                {
                    LimpiarCarga();
                    BloqueoAgregarModificar(false);
                    SeleccionCliente();
                    DialogResult r = MessageBox.Show($"¿Desea eliminar este cliente ({clienteSeleccion.Nombre})?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        int n = CantidadPacientes();
                        if (n > 0)
                        {
                            DialogResult x = MessageBox.Show($"Al eliminar a este cliente, también se eliminará al paciente asociado. ¿Desea continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (!(x == DialogResult.Yes))
                                return;
                        }
                        NCliente nCliente = new NCliente();
                        nCliente.Eliminar(clienteSeleccion.Id);
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtDniCuit.Text != "" && (txtEmail.Text != "" || txtTelefono.Text != ""))
            {
                DialogResult r = MessageBox.Show($"¿Desea {btnAceptar.Text} este cliente ({txtNombre.Text})?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    try
                    {
                        InsertarValores();
                        NCliente nCliente = new NCliente();
                        if (cliente.Id > 0)
                            nCliente.Modificar(cliente);
                        else
                            nCliente.Agregar(cliente);
                        CargarFrm();
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
                MessageBox.Show("Debe completar los campos necesarios (Nombre - Dni-Cuit - Email o Teléfono)");
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
        private void txtDniCuit_TextChanged(object sender, EventArgs e)
        {
            ClassHelper.ColorTxt(txtDniCuit);
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            ClassHelper.ColorTxt(txtEmail);
        }
        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            ClassHelper.ColorTxt(txtTelefono);
        }
        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            ClassHelper.ColorTxt(txtDireccion);
        }
        private void txtLocalidad_TextChanged(object sender, EventArgs e)
        {
            ClassHelper.ColorTxt(txtLocalidad);
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            string nombres = string.Join("\n", nombrePacientes);
            MessageBox.Show("Id - Nombre:\n" + nombres, "Pacientes");
        }

        private void txtDniCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
