using Biblioteca;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Biblioteca;

class Program
{
    static void Main(string[] args)
    {
        Usuario u2 = new Usuario("1234", "Mari");
        Biblioteca.UsuarioDAO.GuardarUsuario(u2);

        //List<Usuario> usuarios = Biblioteca.DAO.ListaUsuarios();

        //foreach (Usuario u in usuarios)
        //{
        //    Console.WriteLine(u.Nombre);
        //}


    }
}

