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
    class Canción 
    {
        // Propiedades que tendrá nuestra clase base
        public int id { get; set; }
        public string nombre { get; set; }
        public string artista { get; set; }
        public string album { get; set; }
        public string genero { get; set; }
        public string añoCreacion { get; set; }

        public void CrearCancion(Canción can)
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "BullrtProofRecords");
            string sql;

            sql = @"exec sp_crearCliente @nombre, @apellido, @identidad, @direccion, @telefono, @celular";

            SqlCommand cmd = conexion.EjecutarComando(sql);

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@id", SqlDbType.Char).Value = can.id;
                    cmd.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = can.nombre;
                    cmd.Parameters.Add("@artista", SqlDbType.NVarChar).Value = can.artista;
                    cmd.Parameters.Add("@album", SqlDbType.NVarChar).Value = can.album;
                    cmd.Parameters.Add("@genero", SqlDbType.Char).Value = can.genero;
                    cmd.Parameters.Add("@añoCreacion", SqlDbType.Char).Value = can.añoCreacion;
                }

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

                throw;
            }
            finally
            {
                conexion.CerrarConexion();
            }

        }

        public static Canción ObtenerCancion(int id)
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "BulletProofRecords");
            string sql;
            Canción resultado = new Canción();

            // Query SQL
            sql = @"SELECT *
                    Music.Cancion
                    WHERE Id = @id";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    rdr = cmd.ExecuteReader();
                }

                while (rdr.Read())
                {
                    resultado.id = rdr.GetInt16(0);
                    resultado.nombre = rdr.GetString(1);
                    resultado.artista = rdr.GetString(2);
                    resultado.album = rdr.GetString(3);
                    resultado.genero = rdr.GetString(4);
                    resultado.añoCreacion = rdr.GetString(5);
                }

                return resultado;
            }
            catch (SqlException ex)
            {
                return resultado;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public List<Canción> ListarCancion(int id)
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "BulletProofRecords");
            string sql;
            List<Canción> lista = new List<Canción>();

            // Query SQL
            sql = @"SELECT *
                    Music.Cancion
                    WHERE Id = @id";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    rdr = cmd.ExecuteReader();
                }

                while (rdr.Read())
                {
                    Canción resultado = new Canción();
                    resultado.id = rdr.GetInt32(0);
                    resultado.nombre = rdr.GetString(1);
                    resultado.artista = rdr.GetString(2);
                    resultado.album = rdr.GetString(3);
                    resultado.genero = rdr.GetString(4);
                    resultado.añoCreacion = rdr.GetString(5);
                    lista.Add(resultado);
                }

                return lista;
            }
            catch (SqlException ex)
            {
                return lista;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
    }



    
}

