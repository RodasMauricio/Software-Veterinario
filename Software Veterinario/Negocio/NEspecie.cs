using System;
using System.Collections.Generic;
using System.Data.Common;
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
    
        public void Agregar(Especie e)
        {
            using (AccesoDatos datos = new AccesoDatos())
            {
                try
                {
                    datos.Consulta("Insert into ESPECIES (Descripcion)values(@Descripcion)");
                    datos.Parametros("@Descripcion", e.Descripcion);
                    datos.EjecutarComando();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    
        public void Modificar(Especie e)
        {
            using (AccesoDatos datos = new AccesoDatos())
            {
                try
                {
                    datos.Consulta("Update ESPECIES set Descripcion = @Descripcion Where Id = @Id");
                    datos.Parametros("@Descripcion", e.Descripcion);
                    datos.Parametros("@Id", e.Id);
                    datos.EjecutarComando();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public void Eliminar(int id)
        {
            using (AccesoDatos datos = new AccesoDatos())
            {
                try
                {
                    datos.Consulta("Delete From ESPECIES Where Id = @Id");
                    datos.Parametros("@Id", id);
                    datos.EjecutarComando();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }


    }
}
