using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    public static class ClassHelper
    {
        private static Color txtClaro = Color.FromArgb(120, 120, 160);
        private static Color txtOscuro = Color.FromArgb(40, 40, 60);


        public static void ColorTxt(TextBox txt)
        {
            if (txt.Text != "")
                txt.BackColor = txtOscuro;
            else
                txt.BackColor = txtClaro;
        }

        public static void HabilitarLbl(bool v, params Label[] labels)
        {
            foreach (Label lbl in labels)
            {
                lbl.Enabled = v;
            }
        }
        public static void HabilitarControles(bool v, params Control[] controls)
        {
            foreach (Control ctrl in controls)
            {
                ctrl.Enabled = v;
            }
        }


        public static void LimpiarTxt(params TextBox[] textboxs)
        {
            foreach (TextBox c in textboxs)
            {
                c.Clear();
            }
        }

        public static void LimpiarCbx(params ComboBox[] cbxs)
        {
            foreach (ComboBox cb in cbxs)
            {
                cb.SelectedIndex = -1;
            }
        }


        public static void CargarCbx<T>(ComboBox cbx, List<T> ls, string id, string descripcion)
        {
            cbx.DataSource = ls;
            cbx.ValueMember = id;
            cbx.DisplayMember = descripcion;
            cbx.SelectedIndex = -1;
        }
    }
}
