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
    public partial class FrmCliente : Form
    {
        private List<Cliente> listaCliente;
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            NCliente nCliente = new NCliente();
            listaCliente = nCliente.ListarClientes();
            dgvCliente.DataSource = listaCliente;
            dgvCliente.Columns["Activo"].Visible = false;
        }
    }
}
