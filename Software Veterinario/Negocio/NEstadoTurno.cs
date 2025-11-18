using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NEstadoTurno
    {
        public List<EstadoTurno> ListarEstadoTurno()
        {
            using (AccesoDatos datos = new AccesoDatos())
            {
                List<EstadoTurno> listaEstadoTurno = new List<EstadoTurno>();
                try
                {
                    datos.Consulta("Select E.Id, E.Descripcion From ESTADOS_TURNO E");
                    datos.EjecutarConsulta();
                    while (datos.Lector.Read())
                    {
                        EstadoTurno e = new EstadoTurno();
                        e.Id = (int)datos.Lector["Id"];
                        e.Descripcion = (string)datos.Lector["Descripcion"];
                        listaEstadoTurno.Add(e);
                    }
                    return listaEstadoTurno;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
