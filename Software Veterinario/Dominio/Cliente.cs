using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Dni-Cuit")]
        public string DniCuit { get; set; }
        public string Email { get; set; }
        [DisplayName("Teléfono")]
        public string Telefono { get; set; }
        [DisplayName("Dirección")]
        public string Direccion { get; set; }
        public string Localidad { get; set; }
        public bool Activo { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
