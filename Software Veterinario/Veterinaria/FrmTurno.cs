using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
        private List<Turno> listaTurnoFechaSeleccionada;
        private Turno turno = null;
        private Turno turnoSeleccion;
        private DateTime fechaHoy;
        private DateTime fechaSeleccionada;
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
            fechaHoy = dtpFecha.Value;
            NTurno nTurno = new NTurno();
            NPaciente nPaciente = new NPaciente();
            NVeterinario nVeterinario = new NVeterinario();
            NServicio nServicio = new NServicio();
            NEstadoTurno nEstadoTurno = new NEstadoTurno();
            listaTurno = nTurno.ListarTurnos();
            listaPaciente = nPaciente.ListarPacientes(1);
            listaVeterinario = nVeterinario.ListarVeterinarios();
            listaServicio = nServicio.ListarServicios();
            listaEstadoTurno = nEstadoTurno.ListarEstadoTurno();
            CargarTurnosHoy();
            ClassHelper.CargarCbx(cbPaciente, listaPaciente, "Id", "Nombre");
            ClassHelper.CargarCbx(cbVeterinario, listaVeterinario, "Id", "Nombre");
            ClassHelper.CargarCbx(cbServicio, listaServicio, "Id", "Nombre");
            ClassHelper.CargarCbx(cbEstado, listaEstadoTurno, "Id", "Descripcion");
            CargarHorario();
        }
        private void AjustarOcultarColumnas()
        {
            dgvTurno.Columns["Notas"].Visible = false;
            dgvTurno.Columns["Id"].Width = 50;
            dgvTurno.Columns["Paciente"].Width = 70;
            dgvTurno.Columns["Estado"].Width = 80;
        }
        private void CargarTurnosHoy()
        {
            listaTurnoFechaSeleccionada = new List<Turno>();
            foreach (Turno t in listaTurno)
            {
                if (t.FechaHoraInicio.Date == fechaHoy.Date)
                {
                    listaTurnoFechaSeleccionada.Add(t);
                }
            }
            dgvTurno.DataSource = null;
            dgvTurno.DataSource = listaTurnoFechaSeleccionada;
            dtpTurno.Value = DateTime.Now;
            AjustarOcultarColumnas();
        }
        private void CargarHorario()
        {
            cbHorario.Items.Clear();
            DateTime hora = new DateTime(1, 1, 1, 7, 0, 0);
            DateTime fin = new DateTime(1, 1, 1, 14, 45, 0);
            while (hora <= fin)
            {
                cbHorario.Items.Add(hora.ToString("HH:mm"));
                hora = hora.AddMinutes(15);
            }
        }
        private void TurnoFechaSeleccionada()
        {
            fechaSeleccionada = dtpTurno.Value;
            listaTurnoFechaSeleccionada = new List<Turno>();
            foreach (Turno t in listaTurno)
            {
                if (t.FechaHoraInicio.Date == fechaSeleccionada.Date)
                    listaTurnoFechaSeleccionada.Add(t);
            }
            dgvTurno.DataSource = null;
            dgvTurno.DataSource = listaTurnoFechaSeleccionada;
            AjustarOcultarColumnas();
        }
        private void CargarValoresModificar()
        {
            cbPaciente.SelectedValue = turno.Paciente.Id;
            cbVeterinario.SelectedValue = turno.Veterinario.Id;
            cbServicio.SelectedValue = turno.Servicio.Id;
            dtpFecha.Value = turno.FechaHoraInicio;
            int i = cbHorario.FindStringExact(turno.FechaHoraInicio.ToString("HH:mm"));
            if (i != -1)
                cbHorario.SelectedIndex = i;
            cbEstado.SelectedValue = turno.Estado.Id;
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
            DateTime fecha = dtpFecha.Value.Date;
            TimeSpan horaSeleccion = TimeSpan.Parse(cbHorario.SelectedItem.ToString());
            turno.FechaHoraInicio = fecha.Add(horaSeleccion);
            turno.Estado = (EstadoTurno)cbEstado.SelectedItem;
            turno.Notas = txtNotas.Text;
        }
        private void LimpiarCarga()
        {
            dtpFecha.Value = DateTime.Now;
            ClassHelper.LimpiarCbx(cbPaciente, cbVeterinario, cbServicio, cbHorario, cbEstado);
            ClassHelper.LimpiarTxt(txtNotas);
            btnAceptar.Text = "Aceptar";
        }

        private void SeleccionTurno()
        {
            turnoSeleccion = (Turno)dgvTurno.CurrentRow.DataBoundItem;
        }

        private void BloqueoAgregarModificar(bool v)
        {
            ClassHelper.HabilitarLbl(v, lblPaciente, lblVeterinario, lblServicio, lblFecha,lblHorario, lblEstado, lblNotas);
            ClassHelper.HabilitarControles(v, cbPaciente, cbVeterinario, cbServicio, dtpFecha, cbHorario, cbEstado, txtNotas, btnAceptar);
        }

        private void txtFiltroTurno_TextChanged(object sender, EventArgs e)
        {
            ClassHelper.ColorTxt(txtFiltroTurno);
            List<Turno> filtroRapido;
            string filtro = txtFiltroTurno.Text.ToUpper();
            filtroRapido = listaTurnoFechaSeleccionada.FindAll(x => x.Id.ToString().ToUpper().Contains(filtro) || x.Paciente.Nombre.ToUpper().Contains(filtro));
            //filtroRapido = listaTurno.FindAll();

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
                        LimpiarCarga();
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
            if (cbPaciente.SelectedIndex != -1 && cbVeterinario.SelectedIndex != -1 && cbServicio.SelectedIndex != -1 && cbHorario.SelectedIndex != -1 && cbEstado.SelectedIndex != -1 && txtNotas.Text != "")
            {
                DialogResult r = MessageBox.Show($"¿Desea {btnAceptar.Text} este turno?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    try
                    {
                        InsertarValores();
                        NTurno nturno = new NTurno();
                        if (turno.Id > 0)
                            nturno.Modificar(turno);
                        else
                            nturno.Agregar(turno);
                        CargarFrm();
                        AjustarOcultarColumnas();
                        LimpiarCarga();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            else
            {
                MessageBox.Show("Faltan datos por ingresar.\nRevise (Paciente - Veterinario - Servicio - Fecha - Horario - Estado)");
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCarga();
            BloqueoAgregarModificar(false);
        }

        private void txtNotas_TextChanged(object sender, EventArgs e)
        {
            ClassHelper.ColorTxt(txtNotas);
        }

        private void dtpTurno_ValueChanged(object sender, EventArgs e)
        {
            TurnoFechaSeleccionada();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarTurnosHoy();
            AjustarOcultarColumnas();
        }
    }
}
