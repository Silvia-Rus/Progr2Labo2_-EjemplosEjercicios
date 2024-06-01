using System;
using System.Data;
//BUSCAR EL NUGET APROPIADO SEGÚN EL MOTOR DE BD QUE VAYAMOS A USAR
//using System.Data.SqlClient; // Para usar SMSS (el del videíto)
using MySql.Data.MySqlClient; //Para usar MySQL (instalando XAMP, MAMP, WAMP, etc.)

namespace Biblioteca
{
	public static class UsuarioDAO
	{

        private static string connString;
        // private static SqlConnection myConnection; // usando SMSSS
        // private static SqlCommand myCommand; // usando SMSS
        private static MySqlConnection myConnection; //usando MySQL
        private static MySqlCommand myCommand; //usando MySQL


        static UsuarioDAO()
		{
            //OJO: la sintaxis de la connection string es distinta si se usa SMSS
            //se recomienda buscar cómo hacerla en ChatGPT teniendo en cuenta
            //si usamos un puerto específico, si tenemos user y pw, etc.
            connString = "Server=127.0.0.1;Port=8889;Database=BIBLIOTECA_Ej;Uid=root;";
            myConnection = new MySqlConnection(connString);
            myCommand = new MySqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;
        }

        public static List<Usuario> buscarPorDNI(string dni)
        {
            return UsuarioDAO.buscarPorCampo("DNI", dni);
        }

       
        private static List<Usuario> buscarPorCampo(string campo, string valor)
        {
            //Se puede hacer una validación del campo que entra por string
            List<Usuario> retorno = new List<Usuario>();
            //Los mensajes de error relacionados con la construcción de la sentencia de búsqueda
            //no suelen ser muy claros. Se recomienda lanzarlas en el gestor de BD si no funcionan
            //sobre lo esperado.
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

        //devuelve la lista completa de usuarios en la tabla "USUARIOS"
        public static List<Usuario>ListaUsuarios(string tipo)
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

        public static bool GuardarUsuario(Usuario u)
        {
            bool retorno = false;
            try
            {
                myConnection.Open();
                myCommand.CommandText = $"INSERT INTO USUARIOS (nombre,DNI) VALUES (@nombre, @dni);";
                myCommand.Parameters.AddWithValue("@nombre", u.Nombre);
                myCommand.Parameters.AddWithValue("@DNI", u.DNI);
                int rows = myCommand.ExecuteNonQuery();
                retorno = true;
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
            return retorno;
        }


        public static bool Modificar(Usuario u, string campo, string nuevoValor)
        {
            bool retorno = false;
            try
            {
                myConnection.Open();
                myCommand.CommandText = $"UPDATE USUARIOS SET {campo} = @nuevoValor WHERE DNI = @DNI";
                myCommand.Parameters.AddWithValue("@nuevoValor", nuevoValor);
                myCommand.Parameters.AddWithValue("@DNI", u.DNI);
                int rows = myCommand.ExecuteNonQuery();
                retorno = true;
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
            return retorno;
        }












    }
}

