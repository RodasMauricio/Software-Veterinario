using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Dominio;

namespace Negocio
{
    public class AccesoDatos : IDisposable
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        private bool valorDispose;

        public AccesoDatos()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
            string connectionString = config.GetConnectionString("VeterinariaDB");
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("Error! VeterinariaDB no se encontró o está vacía.");
            }
            conexion = new SqlConnection(connectionString);
            comando = new SqlCommand();
        }

        public SqlDataReader Lector
        {
            get { return lector; }
        }

        public void Consulta(string c)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = c;
        }

        public void Parametros(string n, object v)
        {
            comando.Parameters.AddWithValue(n, v);
        }
        public void EjecutarConsulta()
        {
            comando.Connection = conexion;
            conexion.Open();
            lector = comando.ExecuteReader();
        }

        public void EjecutarComando()
        {
            comando.Connection = conexion;
            conexion.Open();
            comando.ExecuteNonQuery();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!valorDispose)
            {
                if (disposing)
                {
                    if (lector != null)
                    {
                        if (!lector.IsClosed)
                            lector.Close();
                        lector.Dispose();
                        lector = null;
                    }
                    if (conexion != null)
                    {
                        if (conexion.State != System.Data.ConnectionState.Closed)
                            conexion.Close();
                        conexion.Dispose();
                        conexion = null;
                    }
                    if (comando != null)
                    {
                        comando.Dispose();
                        comando = null;
                    }
                }
                valorDispose = true;
            }
        }


        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
