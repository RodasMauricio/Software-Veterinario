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
    public partial class FrmPaciente : Form
    {
        List<Paciente> listaPaciente;
        public FrmPaciente()
        {
            InitializeComponent();
        }

        private void FrmPaciente_Load(object sender, EventArgs e)
        {
            NPaciente nPaciente = new NPaciente();
            listaPaciente = nPaciente.ListarPacientes();
            dgvPaciente.DataSource = listaPaciente;
            dgvPaciente.Columns["Activo"].Visible = false;
        }
    }
}
