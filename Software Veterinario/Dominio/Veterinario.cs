using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Veterinario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Matrícula")]
        public string Matricula { get; set; }
        public string Email { get; set; }
        [DisplayName("Teléfono")]
        public string Telefono { get; set; }
        public bool Activo { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
