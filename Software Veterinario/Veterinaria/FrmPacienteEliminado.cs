using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria
{
    public partial class FrmPacienteEliminado : Form
    {
        private List<Paciente> listaPacienteEliminado;
        private Paciente pacienteSeleccion;
        public FrmPacienteEliminado()
        {
            InitializeComponent();
        }

        private void FrmPacienteEliminado_Load(object sender, EventArgs e)
        {
            CargarFrm();
            AjustarOcultarColumnas();
        }
        private void CargarFrm()
        {
            NPaciente nPaciente = new NPaciente();
            listaPacienteEliminado = nPaciente.ListarPacientes(0);
            dgvPacienteEliminado.DataSource = listaPacienteEliminado;
        }
        private void AjustarOcultarColumnas()
        {
            dgvPacienteEliminado.Columns["Activo"].Visible = false;
            dgvPacienteEliminado.Columns["FechaNacimiento"].Visible = false;
            dgvPacienteEliminado.Columns["Observacion"].Visible = false;
            dgvPacienteEliminado.Columns["Id"].Width = 50;
            dgvPacienteEliminado.Columns["Sexo"].Width = 40;
        }
        private void lblX_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void EstadoBotones()
        {
            bool s = dgvPacienteEliminado.SelectedRows.Count > 0;
            btnRecuperar.Enabled = s;
        }
        private void SeleccionPaciente()
        {
            pacienteSeleccion = (Paciente)dgvPacienteEliminado.CurrentRow.DataBoundItem;
        }

        private void txtFiltroPacienteEliminado_TextChanged(object sender, EventArgs e)
        {
            ClassHelper.ColorTxt(txtFiltroPacienteEliminado);
            List<Paciente> filtroRapido;
            string filtro = txtFiltroPacienteEliminado.Text.ToUpper();
            filtroRapido = listaPacienteEliminado.FindAll(x => x.Nombre.ToUpper().Contains(filtro) || x.Especie.Descripcion.ToUpper().Contains(filtro) || x.Raza.Descripcion.ToUpper().Contains(filtro) || x.Cliente.Nombre.ToUpper().Contains(filtro));

            dgvPacienteEliminado.DataSource = null;
            dgvPacienteEliminado.DataSource = filtroRapido;
            AjustarOcultarColumnas();
        }
        private void dgvPacienteEliminado_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvPacienteEliminado.Rows.Count > 0)
                {
                    SeleccionPaciente();
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
            if (dgvPacienteEliminado.Rows.Count > 0)
            {
                try
                {
                    SeleccionPaciente();
                    DialogResult r = MessageBox.Show($"¿Desea recuperar este paciente eliminado ({pacienteSeleccion.Nombre})?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        NPaciente nPaciente = new NPaciente();
                        nPaciente.Recuperar(pacienteSeleccion.Id);
                        MessageBox.Show("¡Paciente recuperado!");
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
