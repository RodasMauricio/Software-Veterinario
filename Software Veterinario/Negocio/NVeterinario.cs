using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NVeterinario
    {
        public List<Veterinario> ListarVeterinarios(byte a)
        {
            using (AccesoDatos datos = new AccesoDatos())
            {
                List<Veterinario> listaVeterinarios = new List<Veterinario>();
                try
                {
                    datos.Consulta($"Select V.Id, V.Nombre, V.Matricula, V.Email, V.Telefono, V.Activo From VETERINARIOS V Where V.Activo = {a}");
                    datos.EjecutarConsulta();
                    while (datos.Lector.Read())
                    {
                        Veterinario v = new Veterinario();
                        v.Id = (int)datos.Lector["Id"];
                        v.Nombre = (string)datos.Lector["Nombre"];
                        v.Matricula = (string)datos.Lector["Matricula"];
                        v.Email = (string)datos.Lector["Email"];
                        v.Telefono = (string)datos.Lector["Telefono"];
                        v.Activo = (bool)datos.Lector["Activo"];
                        listaVeterinarios.Add(v);
                    }
                    return listaVeterinarios;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public void Agregar(Veterinario v)
        {
            using (AccesoDatos datos = new AccesoDatos())
            {
                try
                {
                    datos.Consulta("Insert into VETERINARIOS (Nombre, Matricula, Email, Telefono)values(@Nombre, @Matricula, @Email, @Telefono)");
                    datos.Parametros("@Nombre", v.Nombre);
                    datos.Parametros("@Matricula", v.Matricula);
                    datos.Parametros("@Email", v.Email);
                    datos.Parametros("@Telefono", v.Telefono);
                    datos.EjecutarComando();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public void Modificar(Veterinario v)
        {
            using (AccesoDatos datos = new AccesoDatos())
            {
                try
                {
                    datos.Consulta("Update VETERINARIOS set Nombre = @Nombre, Matricula = @Matricula, Email = @Email, Telefono = @Telefono Where Id = @Id");
                    datos.Parametros("@Nombre", v.Nombre);
                    datos.Parametros("@Matricula", v.Matricula);
                    datos.Parametros("@Email", v.Email);
                    datos.Parametros("@Telefono", v.Telefono);
                    datos.Parametros("@Id", v.Id);
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
                    datos.Consulta("Update VETERINARIOS set Activo = @Activo Where Id = @Id");
                    datos.Parametros("@Activo", 0);
                    datos.Parametros("@Id", id);
                    datos.EjecutarConsulta();
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
                    datos.Consulta("Update VETERINARIOS set Activo = @Activo Where Id = @Id");
                    datos.Parametros("@Activo", 1);
                    datos.Parametros("@Id", id);
                    datos.EjecutarConsulta();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

    }
}
