using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Especie Especie { get; set; }
        public Raza Raza { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string ColorPelaje { get; set; }
        public decimal Peso { get; set; }
        public string Observacion { get; set; }
        public bool Activo { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
