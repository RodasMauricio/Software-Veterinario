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
    public partial class FrmHistorial : Form
    {
        private List<Historial> listaHistorial;
        public FrmHistorial()
        {
            InitializeComponent();
        }

        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            NHistorial nHistorial = new NHistorial();
            listaHistorial = nHistorial.ListarHistorial();
            dgvHistorial.DataSource = listaHistorial;
        }
    }
}
