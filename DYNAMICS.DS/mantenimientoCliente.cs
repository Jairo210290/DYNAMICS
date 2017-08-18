using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace DYNAMICS.DS
{
    public class mantenimientoCliente
    {

        private String connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public Boolean Agregar(BE.Cliente mantenimiento) {

            Boolean condicion = true;
            var sqlConnection  = new SqlConnection(connectionString);
            var command = new SqlCommand();

            try {
                sqlConnection.ConnectionString = connectionString;

                command.Parameters.Add(new SqlParameter("nombre", mantenimiento.Nombre));
                command.Parameters.Add(new SqlParameter("apellido", mantenimiento.Apellido));
                command.Parameters.Add(new SqlParameter("telefono1", mantenimiento.Telefono1));
                command.Parameters.Add(new SqlParameter("telefono2", mantenimiento.Telefono2));

                sqlConnection.Open();

                command.CommandText = "AgregarCliente";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Connection = sqlConnection;
                command.ExecuteNonQuery();
                sqlConnection.Close();

            } catch (Exception Ex) {
                condicion = false;
                throw new Exception("Problemas al Insertar en la Bd" + Ex.ToString());
            }

            finally {
                if (sqlConnection.State != 0){
                    sqlConnection.Close();
                }
            }

            return condicion;
        }

        public List<BE.Cliente> Listar()
        {
            List<BE.Cliente> lista = new List<BE.Cliente>();
            BE.Cliente cliente;
            var sqlConnection = new SqlConnection(connectionString);
            var command = new SqlCommand();

            try
            {
                sqlConnection.ConnectionString = connectionString;
                sqlConnection.Open();

                command.CommandText = "ListaClientes";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Connection = sqlConnection;
                command.ExecuteNonQuery();

                var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                    cliente = new BE.Cliente();
                    cliente.IdCliente = reader.GetInt32(0);
                    cliente.Nombre = reader[1].ToString();
                    cliente.Apellido = reader[2].ToString();
                    cliente.Telefono1 = reader[3].ToString();
                    cliente.Telefono2 = reader[4].ToString();
                    lista.Add(cliente);
                }
                
                reader.Close();
                sqlConnection.Close();

            }
            catch (Exception Ex)
            {
                throw new Exception("Problemas al Insertar en la Bd" + Ex.ToString());
            }

            finally
            {
                if (sqlConnection.State != 0)
                {
                    sqlConnection.Close();
                }
            }


            return lista;
        }

        public BE.Cliente ObtenerCliente(int IdCliente)
        {

            List<BE.Cliente> lista = new List<BE.Cliente>();
            BE.Cliente cliente = new BE.Cliente();
            var sqlConnection = new SqlConnection(connectionString);
            var command = new SqlCommand();

            try
            {
                sqlConnection.ConnectionString = connectionString;
                command.Parameters.Add(new SqlParameter("id", IdCliente));
                sqlConnection.Open();

                command.CommandText = "ObtenerCliente";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Connection = sqlConnection;
                command.ExecuteNonQuery();

                var reader = command.ExecuteReader();
                reader.Read();
                
                    cliente.IdCliente = reader.GetInt32(0);
                    cliente.Nombre = reader[1].ToString();
                    cliente.Apellido = reader[2].ToString();
                    cliente.Telefono1 = reader[3].ToString();
                    cliente.Telefono2 = reader[4].ToString();
                    lista.Add(cliente);
                

                reader.Close();
                sqlConnection.Close();

            }
            catch (Exception Ex)
            {
                throw new Exception("Problemas al Insertar en la Bd" + Ex.ToString());
            }

            finally
            {
                if (sqlConnection.State != 0)
                {
                    sqlConnection.Close();
                }
            }


            return cliente;
        }

        public Boolean Editar(BE.Cliente mantenimiento)
        {

            Boolean condicion = true;
            var sqlConnection = new SqlConnection(connectionString);
            var command = new SqlCommand();

            try
            {
                sqlConnection.ConnectionString = connectionString;

                command.Parameters.Add(new SqlParameter("IdCliente", mantenimiento.IdCliente));
                command.Parameters.Add(new SqlParameter("nombre", mantenimiento.Nombre));
                command.Parameters.Add(new SqlParameter("apellido", mantenimiento.Apellido));
                command.Parameters.Add(new SqlParameter("telefono1", mantenimiento.Telefono1));
                command.Parameters.Add(new SqlParameter("telefono2", mantenimiento.Telefono2));

                sqlConnection.Open();

                command.CommandText = "EditarCliente";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Connection = sqlConnection;
                command.ExecuteNonQuery();
                sqlConnection.Close();

            }
            catch (Exception Ex)
            {
                condicion = false;
                throw new Exception("Problemas al Insertar en la Bd" + Ex.ToString());
            }

            finally
            {
                if (sqlConnection.State != 0)
                {
                    sqlConnection.Close();
                }
            }

            return condicion;
        }


    }
}
