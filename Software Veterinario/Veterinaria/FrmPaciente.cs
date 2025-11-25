using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Veterinaria
{
    public partial class FrmPaciente : Form
    {
        private List<Paciente> listaPaciente;
        private Paciente pacienteSeleccion;
        private Paciente paciente = null;
        public FrmPaciente()
        {
            InitializeComponent();
        }

        private void FrmPaciente_Load(object sender, EventArgs e)
        {
            CargarFrm();
            AjustarOcultarColumnas();
        }

        private void CargarFrm()
        {
            NPaciente nPaciente = new NPaciente();
            NEspecie nEspecie = new NEspecie();
            //NRaza nRaza = new NRaza();
            NCliente nCliente = new NCliente();
            listaPaciente = nPaciente.ListarPacientes(1);
            dgvPaciente.DataSource = listaPaciente;
            AjustarOcultarColumnas();
            ClassHelper.CargarCbx(cbEspecie, nEspecie.ListarEspecies(), "Id", "Descripcion");
            //ClassHelper.CargarCbx(cbRaza, nRaza.ListarRazas(), "Id", "Descripcion");
            ClassHelper.CargarCbx(cbCliente, nCliente.ListarClientes(1), "Id", "Nombre");
        }
        private void AjustarOcultarColumnas()
        {
            dgvPaciente.Columns["Activo"].Visible = false;
            dgvPaciente.Columns["FechaNacimiento"].Visible = false;
            dgvPaciente.Columns["Observacion"].Visible = false;
            dgvPaciente.Columns["Id"].Width = 50;
            dgvPaciente.Columns["Sexo"].Width = 40;
        }
        private void CargarValoresModificar()
        {
            txtNombre.Text = paciente.Nombre;
            cbEspecie.SelectedValue = paciente.Especie.Id;
            cbRaza.SelectedValue = paciente.Raza.Id;
            cbCliente.SelectedValue = paciente.Cliente.Id;
            dtpFechaNacimiento.Value = paciente.FechaNacimiento;
            txtSexo.Text = paciente.Sexo;
            txtColorPelaje.Text = paciente.ColorPelaje;
            txtPeso.Text = paciente.Peso.ToString();
            txtObservaciones.Text = paciente.Observacion;
        }
        private void EstadoBotones()
        {
            if (dgvPaciente.Rows.Count == 0)
            {
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                return;
            }
            bool s = dgvPaciente.SelectedRows.Count > 0;
            btnModificar.Enabled = s;
            btnEliminar.Enabled = s;
        }
        private void InsertarValores()
        {
            if (paciente == null)
                paciente = new Paciente();
            paciente.Nombre = txtNombre.Text;
            paciente.Especie = (Especie)cbEspecie.SelectedItem;
            paciente.Raza = (Raza)cbRaza.SelectedItem;
            paciente.Cliente = (Cliente)cbCliente.SelectedItem;
            paciente.FechaNacimiento = dtpFechaNacimiento.Value;
            paciente.Sexo = txtSexo.Text.ToUpper();
            paciente.ColorPelaje = txtColorPelaje.Text;
            paciente.Peso = decimal.Parse(txtPeso.Text);
            paciente.Observacion = txtObservaciones.Text;
        }
        private void LimpiarCarga()
        {
            ClassHelper.LimpiarTxt(txtNombre, txtSexo, txtColorPelaje, txtPeso, txtObservaciones);
            dtpFechaNacimiento.Value = DateTime.Now;
            ClassHelper.LimpiarCbx(cbEspecie, cbRaza, cbCliente);
            btnAceptar.Text = "Aceptar";
        }
        private void SeleccionPaciente()
        {
            pacienteSeleccion = (Paciente)dgvPaciente.CurrentRow.DataBoundItem;
        }

        private void BloqueoAgregarModificar(bool v)
        {
            ClassHelper.HabilitarLbl(v, lblNombre, lblEspecie, lblRaza, lblCliente, lblFechaNacimiento, lblSexo, lblColorPelaje, lblPeso, lblObservaciones);
            ClassHelper.HabilitarControles(v, txtNombre, cbEspecie, cbRaza, cbCliente, dtpFechaNacimiento, txtSexo, txtColorPelaje, txtPeso, txtObservaciones, btnAgregarEspecie, btnAgregarRaza, btnAceptar);
        }

        private void txtFiltroPaciente_TextChanged(object sender, EventArgs e)
        {
            ClassHelper.ColorTxt(txtFiltroPaciente);
            List<Paciente> filtroRapido;
            string filtro = txtFiltroPaciente.Text.ToUpper();
            filtroRapido = listaPaciente.FindAll(x => x.Nombre.ToUpper().Contains(filtro) || x.Especie.Descripcion.ToUpper().Contains(filtro) || x.Raza.Descripcion.ToUpper().Contains(filtro) || x.Cliente.Nombre.ToUpper().Contains(filtro));

            dgvPaciente.DataSource = null;
            dgvPaciente.DataSource = filtroRapido;
            AjustarOcultarColumnas();
        }

        private void dgvPaciente_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvPaciente.Columns["Peso"].DefaultCellStyle.Format = "0.00 kg";
        }

        private void dgvPaciente_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvPaciente.Rows.Count > 0)
                {
                    SeleccionPaciente();
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
            BloqueoAgregarModificar(true);
            LimpiarCarga();
            paciente = null;
            btnAceptar.Text = "Agregar";
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvPaciente.Rows.Count > 0)
            {
                try
                {
                    LimpiarCarga();
                    SeleccionPaciente();
                    paciente = pacienteSeleccion;
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
            if (dgvPaciente.Rows.Count > 0)
            {
                try
                {
                    LimpiarCarga();
                    BloqueoAgregarModificar(false);
                    SeleccionPaciente();
                    DialogResult r = MessageBox.Show($"¿Desea eliminar este paciente ({pacienteSeleccion.Nombre})?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        NPaciente nPaciente = new NPaciente();
                        nPaciente.Eliminar(pacienteSeleccion.Id);
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
            if (txtNombre.Text != "" && cbEspecie.SelectedIndex != -1 && cbCliente.SelectedIndex != -1 && cbRaza.SelectedIndex != -1 && txtPeso.Text != "")
            {
                DialogResult r = MessageBox.Show($"¿Desea {btnAceptar.Text} este paciente ({txtNombre.Text})?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    try
                    {
                        InsertarValores();
                        NPaciente nPaciente = new NPaciente();
                        if (paciente.Id > 0)
                            nPaciente.Modificar(paciente);
                        else
                            nPaciente.Agregar(paciente);
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
                MessageBox.Show("Debe completar los campos necesarios (Nombre - Especie - Cliente - Peso)");

            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCarga();
            BloqueoAgregarModificar(false);
        }

        private void btnAgregarEspecie_Click(object sender, EventArgs e)
        {
            FrmEspecieRaza ventana = new FrmEspecieRaza();
            ventana.ShowDialog();
            CargarFrm();
            AjustarOcultarColumnas();
        }
        private void btnAgregarRaza_Click(object sender, EventArgs e)
        {
            FrmEspecieRaza ventana = new FrmEspecieRaza(1);
            ventana.ShowDialog();
            CargarFrm();
            AjustarOcultarColumnas();
        }




        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ClassHelper.ColorTxt(txtNombre);
        }
        private void txtSexo_TextChanged(object sender, EventArgs e)
        {
            ClassHelper.ColorTxt(txtSexo);

        }
        private void txtColorPelaje_TextChanged(object sender, EventArgs e)
        {
            ClassHelper.ColorTxt(txtColorPelaje);

        }
        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            ClassHelper.ColorTxt(txtPeso);
        }
        private void txtObservaciones_TextChanged(object sender, EventArgs e)
        {
            ClassHelper.ColorTxt(txtObservaciones);

        }


        private void btnEliminados_Click(object sender, EventArgs e)
        {
            FrmPacienteEliminado ventana = new FrmPacienteEliminado();
            ventana.ShowDialog();
            CargarFrm();
            AjustarOcultarColumnas();
        }

        private void cbEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEspecie.SelectedIndex > -1)
            {
                string especie = cbEspecie.SelectedItem.ToString();
                NRaza nRaza = new NRaza();
                List<Raza> listaRaza = nRaza.ListarRazas();
                List<Raza> listaRazaAcorde = new List<Raza>();
                foreach (var i in listaRaza)
                {
                    if (especie == i.Especie.Descripcion)
                        listaRazaAcorde.Add(i);
                }
                ClassHelper.CargarCbx(cbRaza, listaRazaAcorde, "Id", "Descripcion");

            }
        }

        private void FrmPaciente_SizeChanged(object sender, EventArgs e)
        {
            AjustarOcultarColumnas();
        }

    }
}
