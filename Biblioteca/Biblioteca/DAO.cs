using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Biblioteca
{
	public static class DAO
	{

        private static string connString;
        private static MySqlConnection myConnection;
        private static MySqlCommand myCommand;


        static DAO()
		{
            connString = "Server=127.0.0.1;Port=8889;Database=BIBLIOTECA_Ej;Uid=root;";
            myConnection = new MySqlConnection(connString);
            myCommand = new MySqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;
        }

        public static List<Usuario> buscarPorDNI(string dni)
        {
            return DAO.buscarPorCampo("DNI", dni);
        }

        public static List<Usuario> buscarPorCampo(string campo, string valor)
        {
            List<Usuario> retorno = new List<Usuario>();
            myCommand.CommandText = String.Format($"SELECT * FROM USUARIOS WHERE {campo} = {valor}");

            try
            {
                myConnection.Open();
                MySqlDataReader reader = myCommand.ExecuteReader();
                while (reader.Read())
                {
                    string nombre = (string)reader["nombre"];
                    string dni = (string)reader["dni"];
                    retorno.Add(new Usuario(dni, nombre));
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error en ListaUsuarios", e);
            }
            finally
            {
                myCommand.Parameters.Clear();
                myConnection.Close();
            }
            return retorno;
        }

        public static List<Obra>ListaUsuarios(string tipo)
        {
            List<Usuario> retorno = new List<Usuario>();
            myCommand.CommandText = String.Format($"SELECT * FROM USUARIOS ");

            try
            {
                myConnection.Open();
                MySqlDataReader reader = myCommand.ExecuteReader();
                while(reader.Read())
                {
                    string nombre = (string)reader["nombre"];
                    string dni = (string)reader["dni"];
                    retorno.Add(new Usuario(dni, nombre));
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error en ListaUsuarios", e);
            }
            finally
            {
                myCommand.Parameters.Clear();
                myConnection.Close();
            }
            return retorno;
        }

        public static void GuardarUsuario(Usuario u)
        {
            try
            {
                myConnection.Open();
                string stringtext = "";
                myCommand.CommandText = $"INSERT INTO USUARIOS (nombre,DNI) VALUES (@nombre, @dni);";
                myCommand.Parameters.AddWithValue("@nombre", u.Nombre);
                myCommand.Parameters.AddWithValue("@DNI", u.DNI);
                int rows = myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error guardando usuario:", ex);
            }
            finally
            {
                myCommand.Parameters.Clear();
                myConnection.Close();
            }
        }


        public static void Modificar(Usuario u, string campo, string nuevoValor)
        {
            try
            {
                myConnection.Open();
                myCommand.CommandText = $"UPDATE USUARIOS SET {campo} = @nuevoValor WHERE DNI = @DNI";
                myCommand.Parameters.AddWithValue("@nuevoValor", nuevoValor);
                myCommand.Parameters.AddWithValue("@DNI", u.DNI);
                int rows = myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error modificando usuario:", ex);
            }
            finally
            {
                myCommand.Parameters.Clear();
                myConnection.Close();
            }
        }












    }
}

