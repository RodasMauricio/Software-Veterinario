using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NServicio
    {
        public List<Servicio> ListarServicios()
        {
            using (AccesoDatos datos = new AccesoDatos())
            {
                List<Servicio> listaServicio = new List<Servicio>();
                try
                {
                    datos.Consulta("Select S.Id, S.Nombre, S.Descripcion, S.CostoEstimado, S.Activo From SERVICIOS S");
                    datos.EjecutarConsulta();
                    while (datos.Lector.Read())
                    {
                        Servicio s = new Servicio();
                        s.Id = (int)datos.Lector["Id"];
                        s.Nombre = (string)datos.Lector["Nombre"];
                        s.Descripcion = (string)datos.Lector["Descripcion"];
                        s.CostoEstimado = (decimal)datos.Lector["CostoEstimado"];
                        s.Activo = (bool)datos.Lector["Activo"];
                        listaServicio.Add(s);
                    }
                    return listaServicio;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
