using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Historial
    {
        public int Id { get; set; }
        public Turno Turno { get; set; }
        public string MotivoConsulta { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public decimal PrecioFinal { get; set; }
    }
}
