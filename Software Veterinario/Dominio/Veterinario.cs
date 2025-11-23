using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Veterinario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public bool Activo { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
