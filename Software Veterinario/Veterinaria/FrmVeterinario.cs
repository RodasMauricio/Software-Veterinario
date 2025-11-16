using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Veterinaria
{
    public partial class FrmVeterinario : Form
    {
        private List<Veterinario> listaVeterinario;
        public FrmVeterinario()
        {
            InitializeComponent();
        }

        private void FrmVeterinario_Load(object sender, EventArgs e)
        {
            NVeterinario nVeterinario = new NVeterinario();
            listaVeterinario = nVeterinario.ListarVeterinarios();
            dgvVeterinario.DataSource = listaVeterinario;
        }
    }
}
