using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NRaza
    {
        public List<Raza> ListarRazas()
        {
            using (AccesoDatos datos = new AccesoDatos())
            {
                List<Raza> listaRazas = new List<Raza>();
                try
                {
                    datos.Consulta("Select R.Id, R.Descripcion, E.Id IdEspecie, E.Descripcion Especie From RAZAS R, ESPECIES E Where R.IdEspecie = E.Id");
                    datos.EjecutarConsulta();
                    while (datos.Lector.Read())
                    {
                        Raza r = new Raza();
                        r.Id = (int)datos.Lector["Id"];
                        r.Descripcion = (string)datos.Lector["Descripcion"];
                        r.Especie = new Especie();
                        r.Especie.Id = (int)datos.Lector["IdEspecie"];
                        r.Especie.Descripcion = (string)datos.Lector["Especie"];
                        listaRazas.Add(r);
                    }
                    return listaRazas;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public void Agregar(Raza r)
        {
            using (AccesoDatos datos = new AccesoDatos())
            {
                try
                {
                    datos.Consulta("Insert into RAZAS (Descripcion, IdEspecie)values(@Descripcion, @IdEspecie)");
                    datos.Parametros("@Descripcion", r.Descripcion);
                    datos.Parametros("@IdEspecie", r.Especie.Id);
                    datos.EjecutarComando();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public void Modificar(Raza r)
        {
            using (AccesoDatos datos = new AccesoDatos())
            {
                try
                {
                    datos.Consulta("Update RAZAS set Descripcion = @Descripcion, IdEspecie = @IdEspecie Where Id = @Id");
                    datos.Parametros("@Descripcion", r.Descripcion);
                    datos.Parametros("@IdEspecie", r.Especie.Id);
                    datos.Parametros("@Id", r.Id);
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
                    datos.Consulta("Delete From RAZAS Where Id = @Id");
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
