using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NEspecie
    {
        public List<Especie> ListarEspecies()
        {
            using (AccesoDatos datos = new AccesoDatos())
            {
                List<Especie> listaEspecies = new List<Especie>();
                try
                {
                    datos.Consulta("Select E.Id, E.Descripcion From ESPECIES E");
                    datos.EjecutarConsulta();

                    while (datos.Lector.Read())
                    {
                        Especie e = new Especie();
                        e.Id = (int)datos.Lector["Id"];
                        e.Descripcion = (string)datos.Lector["Descripcion"];
                        listaEspecies.Add(e);
                    }
                    return listaEspecies;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
