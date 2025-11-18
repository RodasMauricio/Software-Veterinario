using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Veterinaria
{
    public partial class FrmTurno : Form
    {
        private List<Turno> listaTurno;
        private List<Paciente> listaPaciente;
        private List<Veterinario> listaVeterinario;
        private List<Servicio> listaServicio;
        private List<EstadoTurno> listaEstadoTurno;
        private Turno turno = null;
        private Turno turnoSeleccion;
        public FrmTurno()
        {
            InitializeComponent();
        }

        private void FrmTurno_Load(object sender, EventArgs e)
        {
            CargarFrm();
        }
        private void CargarFrm()
        {
            NTurno nTurno = new NTurno();
            NPaciente nPaciente = new NPaciente();
            NVeterinario nVeterinario = new NVeterinario();
            NServicio nServicio = new NServicio();
            NEstadoTurno nEstadoTurno = new NEstadoTurno();
            listaTurno = nTurno.ListarTurnos();
            listaPaciente = nPaciente.ListarPacientes();
            listaVeterinario = nVeterinario.ListarVeterinarios();
            listaServicio = nServicio.ListarServicios();
            listaEstadoTurno = nEstadoTurno.ListarEstadoTurno();
            dgvTurno.DataSource = listaTurno;
            ClassHelper.CargarCbx(cbPaciente, listaPaciente, "Id", "Nombre");
            ClassHelper.CargarCbx(cbVeterinario, listaVeterinario, "Id", "Nombre");
            ClassHelper.CargarCbx(cbServicio, listaServicio, "Id", "Nombre");
            ClassHelper.CargarCbx(cbEstado, listaEstadoTurno, "Id", "Descripcion");
        }
        private void AjustarOcultarColumnas()
        {
            dgvTurno.Columns["Notas"].Visible = false;
        }
        private void CargarValoresModificar()
        {
            cbPaciente.SelectedIndex = turno.Paciente.Id;
            cbVeterinario.SelectedIndex = turno.Veterinario.Id;
            cbServicio.SelectedIndex = turno.Servicio.Id;
            dtpFecha.Value = turno.FechaHoraInicio;
            cbEstado.SelectedIndex = turno.Estado.Id;
            txtNotas.Text = turno.Notas;
        }
        private void EstadoBotones()
        {
            bool s = dgvTurno.SelectedRows.Count > 0;
            btnModificar.Enabled = s;
            btnEliminar.Enabled = s;
        }
        private void InsertarValores()
        {
            if (turno == null)
                turno = new Turno();
            turno.Paciente = (Paciente)cbPaciente.SelectedItem;
            turno.Veterinario = (Veterinario)cbVeterinario.SelectedItem;
            turno.Servicio = (Servicio)cbServicio.SelectedItem;
            turno.FechaHoraInicio = dtpFecha.Value;
            turno.Estado = (EstadoTurno)cbEstado.SelectedItem;
            turno.Notas = txtNotas.Text;
        }
        private void LimpiarCarga()
        {
            dtpFecha.Value = DateTime.Now;
            ClassHelper.LimpiarCbx(cbPaciente, cbVeterinario, cbServicio, cbEstado);
            ClassHelper.LimpiarTxt(txtNotas);
            btnAceptar.Text = "Aceptar";
        }

        private void SeleccionTurno()
        {
            turnoSeleccion = (Turno)dgvTurno.CurrentRow.DataBoundItem;
        }

        private void BloqueoAgregarModificar(bool v)
        {
            ClassHelper.HabilitarLbl(v, lblPaciente, lblVeterinario, lblServicio, lblFecha, lblEstado, lblNotas);
            ClassHelper.HabilitarControles(v, cbPaciente, cbVeterinario, cbServicio, dtpFecha, cbEstado, txtNotas, btnAceptar);
        }

        private void txtFiltroTurno_TextChanged(object sender, EventArgs e)
        {
            ClassHelper.ColorTxt(txtFiltroTurno);
            List<Turno> filtroRapido;
            string filtro = txtFiltroTurno.Text.ToUpper();
            filtroRapido = listaTurno.FindAll(x => x.Id.ToString().ToUpper().Contains(filtro) || x.Paciente.Nombre.ToUpper().Contains(filtro));

            dgvTurno.DataSource = null;
            dgvTurno.DataSource = filtroRapido;
            AjustarOcultarColumnas();
        }

        private void dgvTurno_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvTurno.Rows.Count > 0)
                {
                    SeleccionTurno();
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
            turno = null;
            btnAceptar.Text = "Agregar";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            LimpiarCarga();
            SeleccionTurno();
            turno = turnoSeleccion;
            BloqueoAgregarModificar(true);
            CargarValoresModificar();
            btnAceptar.Text = "Modificar";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTurno.Rows.Count > 0)
            {
                try
                {
                    LimpiarCarga();
                    BloqueoAgregarModificar(false);
                    SeleccionTurno();
                    DialogResult r = MessageBox.Show($"¿Desea eliminar este turno({turnoSeleccion.Id})?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        NTurno nTurno = new NTurno();
                        nTurno.Eliminar(turnoSeleccion.Id);
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












        //
    }
}
