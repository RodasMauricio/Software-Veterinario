using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Dominio;
using Negocio;

namespace Veterinaria
{
    public partial class FrmHistorial : Form
    {
        private List<Historial> listaHistorial;
        private Historial historialSeleccion;
        private Historial historial = null;
        public FrmHistorial()
        {
            InitializeComponent();
        }

        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            CargarFrm();
            AjustarOcultarColumnas();
        }
        private void CargarFrm()
        {
            NHistorial nHistorial = new NHistorial();
            listaHistorial = nHistorial.ListarHistorial();
            dgvHistorial.DataSource = listaHistorial;
        }
        private void AjustarOcultarColumnas()
        {
            dgvHistorial.Columns["Id"].Visible = false;
            dgvHistorial.Columns["Turno"].Width = 70;
            dgvHistorial.Columns["PrecioFinal"].Width = 90;
        }
        private void CargarValoresModificar()
        {
            txtIdTurno.Text = historial.Turno.Id.ToString();
            txtMotivoConsulta.Text = historial.MotivoConsulta;
            txtDiagnostico.Text = historial.Diagnostico;
            txtTratamiento.Text = historial.Tratamiento;
            txtPrecioFinal.Text = historial.PrecioFinal.ToString();
        }
        private void EstadoBotones()
        {
            if (dgvHistorial.Rows.Count == 0)
            {
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                return;
            }
            bool s = dgvHistorial.SelectedRows.Count > 0;
            btnModificar.Enabled = s;
            btnEliminar.Enabled = s;
        }
        private void InsertarValores()
        {
            if (historial == null)
                historial = new Historial();
            historial.Turno = new Turno();
            historial.Turno.Id = int.Parse(txtIdTurno.Text);
            historial.MotivoConsulta = txtMotivoConsulta.Text;
            historial.Diagnostico = txtDiagnostico.Text;
            historial.Tratamiento = txtTratamiento.Text;
            historial.PrecioFinal = decimal.Parse(txtPrecioFinal.Text);
        }
        private void LimpiarCarga()
        {
            ClassHelper.LimpiarTxt(txtIdTurno, txtMotivoConsulta, txtDiagnostico, txtTratamiento, txtPrecioFinal);
            btnAceptar.Text = "Aceptar";
        }
        private void SeleccionHistorial()
        {
            if (dgvHistorial.CurrentRow != null)
                historialSeleccion = (Historial)dgvHistorial.CurrentRow.DataBoundItem;
            else
                historialSeleccion = (Historial)dgvHistorial.Rows[0].DataBoundItem;
        }
        private void BloqueoAgregarModificar(bool v)
        {
            ClassHelper.HabilitarLbl(v, lblIdTurno, lblMotivoConsulta, lblDiagnostico, lblTratamiento, lblPrecioFinal);
            ClassHelper.HabilitarControles(v, txtIdTurno, txtMotivoConsulta, txtDiagnostico, txtTratamiento, txtPrecioFinal, btnAceptar);
        }

        private bool ValidarTurno(int id)
        {
            NTurno nTurno = new NTurno();
            List<Turno> listaTurno = nTurno.ListarTurnos();
            foreach (var i in listaTurno)
            {
                if (id == i.Id)
                    return true;
            }
            return false;
        }

        private void txtFiltroHistorial_TextChanged(object sender, EventArgs e)
        {
            ClassHelper.ColorTxt(txtFiltroHistorial);
            List<Historial> filtroRapido;
            string filtro = txtFiltroHistorial.Text.ToUpper();
            filtroRapido = listaHistorial.FindAll(x => x.Turno.Id.ToString().ToUpper().Contains(filtro));

            dgvHistorial.DataSource = null;
            dgvHistorial.DataSource = filtroRapido;
            AjustarOcultarColumnas();
        }

        private void dgvHistorial_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvHistorial.Rows.Count > 0)
                {
                    SeleccionHistorial();
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
            historial = null;
            btnAceptar.Text = "Agregar";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            LimpiarCarga();
            SeleccionHistorial();
            historial = historialSeleccion;
            BloqueoAgregarModificar(true);
            CargarValoresModificar();
            btnAceptar.Text = "Modificar";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvHistorial.Rows.Count > 0)
            {
                try
                {
                    LimpiarCarga();
                    BloqueoAgregarModificar(false);
                    SeleccionHistorial();
                    DialogResult r = MessageBox.Show($"¿Desea eliminar este historial asociado al turno nro ({historialSeleccion.Turno.Id})?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        NHistorial nHistorial = new NHistorial();
                        nHistorial.Eliminar(historialSeleccion.Id);
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
            if (txtIdTurno.Text != "" && txtMotivoConsulta.Text != "" && txtDiagnostico.Text != "" && txtTratamiento.Text != "" && txtPrecioFinal.Text != "")
            {
                if (ValidarTurno(int.Parse(txtIdTurno.Text)))
                {
                    DialogResult r = MessageBox.Show($"¿Desea {btnAceptar.Text} este historial asociado al turno nro ({txtIdTurno.Text})?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        try
                        {
                            InsertarValores();
                            NHistorial nHistorial = new NHistorial();
                            if (historial.Id > 0)
                                nHistorial.Modificar(historial);
                            else
                                nHistorial.Agregar(historial);
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
                    MessageBox.Show("El Id del turno no existe.");
                }
            }
            else
            {
                MessageBox.Show("Debe completar los campos necesarios (IdTurno - Motivo consulta - Diagnóstico - Tratamiento - Precio)");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCarga();
            BloqueoAgregarModificar(false);
        }

        private void txtIdTurno_TextChanged(object sender, EventArgs e)
        {
            ClassHelper.ColorTxt(txtIdTurno);
        }

        private void txtMotivoConsulta_TextChanged(object sender, EventArgs e)
        {
            ClassHelper.ColorTxt(txtMotivoConsulta);
        }

        private void txtDiagnostico_TextChanged(object sender, EventArgs e)
        {
            ClassHelper.ColorTxt(txtDiagnostico);
        }

        private void txtTratamiento_TextChanged(object sender, EventArgs e)
        {
            ClassHelper.ColorTxt(txtTratamiento);
        }

        private void txtPrecioFinal_TextChanged(object sender, EventArgs e)
        {
            ClassHelper.ColorTxt(txtPrecioFinal);
        }

        private void txtPrecioFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtIdTurno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void dgvHistorial_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvHistorial.Columns["PrecioFinal"].Visible == true)
            {
                if (e.Value != null && e.Value is decimal)
                {
                    e.Value = string.Format("{0:C0}", e.Value);
                }
            }
        }
    }
}
