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
        public FrmTurno()
        {
            InitializeComponent();
        }

        private void FrmTurno_Load(object sender, EventArgs e)
        {
            NTurno nTurno = new NTurno();
            listaTurno = nTurno.ListarTurnos();
            dgvTurno.DataSource = listaTurno;
        }
    }
}
