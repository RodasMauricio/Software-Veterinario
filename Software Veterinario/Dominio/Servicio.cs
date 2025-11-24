using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Servicio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public decimal CostoEstimado { get; set; }
        public bool Activo { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
