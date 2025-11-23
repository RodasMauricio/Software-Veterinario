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
        public List<Servicio> ListarServicios(byte a)
        {
            using (AccesoDatos datos = new AccesoDatos())
            {
                List<Servicio> listaServicio = new List<Servicio>();
                try
                {
                    datos.Consulta($"Select S.Id, S.Nombre, S.Descripcion, S.CostoEstimado, S.Activo From SERVICIOS S Where S.Activo = {a}");
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
    
        public void Agregar(Servicio s)
        {
            using (AccesoDatos datos = new AccesoDatos())
            {
                try
                {
                    datos.Consulta("Insert into SERVICIOS (Nombre, Descripcion, CostoEstimado, Activo)values(@Nombre, @Descripcion, @Costo, @Activo)");
                    datos.Parametros("@Nombre", s.Nombre);
                    datos.Parametros("@Descripcion", s.Descripcion);
                    datos.Parametros("@Costo", s.CostoEstimado);
                    datos.Parametros("@Activo", 1);
                    datos.EjecutarComando();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public void Modificar(Servicio s)
        {
            using (AccesoDatos datos = new AccesoDatos())
            {
                try
                {
                    datos.Consulta("Update SERVICIOS set Nombre = @Nombre, Descripcion = @Descripcion, CostoEstimado = @Costo Where Id = @Id");
                    datos.Parametros("@Nombre", s.Nombre);
                    datos.Parametros("@Descripcion", s.Descripcion);
                    datos.Parametros("@Costo", s.CostoEstimado);
                    datos.Parametros("@Id", s.Id);
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
                    datos.Consulta("Update SERVICIOS set Activo = @Activo Where Id = @Id");
                    datos.Parametros("@Activo", 0);
                    datos.Parametros("@Id", id);
                    datos.EjecutarComando();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public void Recuperar(int id)
        {
            using (AccesoDatos datos = new AccesoDatos())
            {
                try
                {
                    datos.Consulta("Update SERVICIOS set Activo = @Activo Where Id = @Id");
                    datos.Parametros("@Activo", 1);
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
