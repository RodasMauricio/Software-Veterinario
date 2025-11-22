using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NCliente
    {
        public List<Cliente> ListarClientes(byte a)
        {
            using (AccesoDatos datos = new AccesoDatos())
            {
                List<Cliente> listaClientes = new List<Cliente>();
                try
                {
                    datos.Consulta($"Select C.Id, C.Nombre, C.DNI_CUIT, C.Email, C.Telefono, C.Direccion, C.Localidad, C.Activo From CLIENTES C Where C.Activo = {a}");
                    datos.EjecutarConsulta();

                    while (datos.Lector.Read())
                    {
                        Cliente c = new Cliente();
                        c.Id = (int)datos.Lector["Id"];
                        c.Nombre = (string)datos.Lector["Nombre"];
                        c.DniCuit = (string)datos.Lector["DNI_CUIT"];
                        c.Email = (string)datos.Lector["Email"];
                        c.Telefono = (string)datos.Lector["Telefono"];
                        c.Direccion = (string)datos.Lector["Direccion"];
                        c.Localidad = (string)datos.Lector["Localidad"];
                        c.Activo = (bool)datos.Lector["Activo"];
                        listaClientes.Add(c);
                    }
                    return listaClientes;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }


        public void Agregar(Cliente c)
        {
            using (AccesoDatos datos = new AccesoDatos())
            {
                try
                {
                    datos.Consulta("Insert into CLIENTES (Nombre, DNI_CUIT, Email, Telefono, Direccion, Localidad, Activo)values(@Nombre, @DniCuit, @Email, @Telefono, @Direccion, @Localidad, @Activo)");
                    datos.Parametros("@Nombre", c.Nombre);
                    datos.Parametros("@DniCuit", c.DniCuit);
                    datos.Parametros("@Email", c.Email);
                    datos.Parametros("@Telefono", c.Telefono);
                    datos.Parametros("@Direccion", c.Direccion);
                    datos.Parametros("@Localidad", c.Localidad);
                    datos.Parametros("@Activo", 1);
                    datos.EjecutarComando();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public void Modificar(Cliente c)
        {
            using (AccesoDatos datos = new AccesoDatos())
            {
                try
                {
                    datos.Consulta("Update CLIENTES set Nombre = @Nombre, DNI_CUIT = @DniCuit, Email = @Email, Telefono = @Telefono, Direccion = @Direccion, Localidad = @Localidad Where Id = @Id");
                    datos.Parametros("@Nombre", c.Nombre);
                    datos.Parametros("@DniCuit", c.DniCuit);
                    datos.Parametros("@Email", c.Email);
                    datos.Parametros("@Telefono", c.Telefono);
                    datos.Parametros("@Direccion", c.Direccion);
                    datos.Parametros("@Localidad", c.Localidad);
                    datos.Parametros("@Id", c.Id);
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
                    datos.Consulta("Update CLIENTES set Activo = @Activo Where Id = @Id");
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
                    datos.Consulta("Update CLIENTES set Activo = @Activo Where Id = @Id");
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
