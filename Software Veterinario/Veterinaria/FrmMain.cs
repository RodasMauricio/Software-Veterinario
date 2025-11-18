using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Dominio;
using Negocio;

namespace Veterinaria
{
    public partial class FrmMain : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private Type frm;
        [DllImport("user32.dll")]

        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public FrmMain()
        {
            InitializeComponent();
        }

        private void AbrirFormHijo(Form formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                Control anterior = this.panelContenedor.Controls[0];
                this.panelContenedor.Controls.RemoveAt(0);
                if (anterior is Form formAnterior)
                {
                    formAnterior.Close();
                    formAnterior.Dispose();
                }
            }
            this.frm = formHijo.GetType();
            Form fh = formHijo;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }





        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                btnMaximizar.Visible = true;
                btnNormal.Visible = false;
            }
        }
        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (menuVertical.Width == 170)
                menuVertical.Width = 72;
            else
                menuVertical.Width = 170;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnNormal.Visible = true;
        }
        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnNormal.Visible = false;
        }
        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        private void btnFormColor(ref Button btnN)
        {
            List<Button> listaBtn = new List<Button>()
            { btnPacientes, btnClientes, btnTurnos, btnHistorial, btnVeterinarios, btnServicios};
            foreach (Button btn in listaBtn)
            {
                if (btn.BackColor == Color.FromArgb(60, 60, 80))
                {
                    btn.BackColor = Color.FromArgb(40, 40, 60);
                }
            }
            btnN.BackColor = Color.FromArgb(60, 60, 80);
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (this.frm == (typeof(FrmCliente)))
                return;
            AbrirFormHijo(new FrmCliente());
            btnFormColor(ref btnClientes);
        }
        private void btnPacientes_Click(object sender, EventArgs e)
        {
            if (this.frm == typeof(FrmPaciente))
                return;
            AbrirFormHijo(new FrmPaciente());
            btnFormColor(ref btnPacientes);
        }
        private void btnTurnos_Click(object sender, EventArgs e)
        {
            if (this.frm == typeof(FrmTurno))
                return;
            AbrirFormHijo(new FrmTurno());
            btnFormColor(ref btnTurnos);
        }
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            if (this.frm == typeof(FrmHistorial))
                return;
            AbrirFormHijo(new FrmHistorial());
            btnFormColor(ref btnHistorial);
        }
        private void btnVeterinarios_Click(object sender, EventArgs e)
        {
            if (this.frm == typeof(FrmVeterinario))
                return;
            AbrirFormHijo(new FrmVeterinario());
            btnFormColor(ref btnVeterinarios);
        }
        private void btnServicios_Click(object sender, EventArgs e)
        {
            if (this.frm == typeof(FrmServicio))
                return;
            AbrirFormHijo(new FrmServicio());
            btnFormColor(ref btnServicios);
        }

        private void tmHoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            //lblFecha.Text = DateTime.Now.ToString("dddd dd MMMM yyyy");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
