using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregar los namespaces necesarios
using System.Data;
using System.Data.SqlClient;

namespace BulletProofRecords
{
    class Conexion
    {
        // Propiedades
        private string servidor;
        private string baseDatos;
        public SqlConnection conn;
        public SqlCommand cmd;

        // Constructores
        public Conexion() { }

        public Conexion(string elServidor, string laBaseDatos)
        {
            servidor = elServidor;
            baseDatos = laBaseDatos;
            EstablecerConexion();
        }

        // Métodos
        /// <summary>
        ///Realizar la conexion a la base de datos
        /// </summary>
        public void EstablecerConexion()
        {
            try
            {
                conn = new SqlConnection(@"Server = localhost; Database=AdventureWorks2014; User Id=Jacki; 
                                    Password=12345;");

                // Establecer conexión
                conn.Open();
            }
            catch (Exception)
            {
                //throw new CustomException("¡Servidor o base de datos no encontrados!");
            }
        }

        /// <summary>
        /// Ejecuta un comando SQL.
        /// </summary>
        /// <param name="elComando">El query SQL a ejecutar</param>
        public SqlCommand EjecutarComando(string elComando)
        {
            return cmd = new SqlCommand(elComando, conn);
        }

        /// <summary>
        /// Cierra la conexión al servidor SQL.
        /// </summary>
        public void CerrarConexion()
        {
            conn.Close();
        }
    }
}
