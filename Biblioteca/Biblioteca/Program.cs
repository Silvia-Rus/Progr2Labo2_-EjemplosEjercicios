using Biblioteca;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Biblioteca;

class Program
{
    static void Main(string[] args)
    {

        Console.Title = "Biblioteca";

        Libro libroUno = new Libro("RayuelaBCBCBB<B", "Cortázar, Julio", 1997, 1111);
        Libro libroDos = new Libro("El Aleph", "Borges, Jorge Luis", 1997, 2222);
        Libro libroTres = new Libro("Yerma", "García Lorca, Federico", 2000, 3333);
        Libro libroCuatro = new Libro("El Túnel", "Sábato, Ernesto", 2000, 5555);
        Libro libroSinBC = new Libro("La Regenta", "Clarín", 2000);

        Usuario usuarioUno = new Usuario("111");
        Usuario usuarioDos = new Usuario("222");


        // LLLAMANDO A PROPIEDADES
        Console.WriteLine(libroUno.Titulo);
        Console.WriteLine(libroUno.Autor);

        // ACCEDIENDO PROPIEDADES
        //libroUno.Titulo =      "Rayuela";
        //objeto //propiedad    //value
        //Console.WriteLine(libroUno.Titulo);


        //// PRUEBA 1 - El libro no tiene Barcode
        //if(Circulacion.Prestar(libroSinBC, usuarioUno))
        //{
        //    Console.WriteLine("BUG : Presta libro aunque no tiene barcode");
        //}
        //else
        //{
        //    Console.WriteLine("OK : No presta porque no tiene Barcode");
        //}

        //// PRUEBA 2 - El libro ya está prestado
        //Circulacion.Prestar(libroUno, usuarioUno);     //Prestamos el libro la primera vez
        //if (Circulacion.Prestar(libroUno, usuarioDos)) //Prestamos un libro prestado a otro
        //{
        //    Console.WriteLine("BUG : Presta libro aunque está prestado");
        //}
        //else
        //{
        //    Console.WriteLine("OK : No presta porque está prestado");
        //}

        //// PRUEBA 3 - El usuario ya tiene 3 libro
        //Circulacion.Prestar(libroUno, usuarioUno);     //Prestamos el libro la primera vez
        //if (Circulacion.Prestar(libroUno, usuarioDos)) //Prestamos un libro prestado a otro
        //{
        //    Console.WriteLine("BUG : Presta libro aunque está prestado");
        //}
        //else
        //{
        //    Console.WriteLine("OK : No presta porque está prestado");
        //}

        // PRUEBA 4 -Intentamos prestar un cuarto libro al mismo usuario
        //Circulacion.Prestar(libroUno, usuarioUno);
        //Circulacion.Prestar(libroDos, usuarioUno);
        //Circulacion.Prestar(libroTres, usuarioUno);

        //if (Circulacion.Prestar(libroCuatro, usuarioUno))
        //{
        //    Console.WriteLine("BUG : Presta libro aunque el usuario ya tiene 3 libros prestados");
        //}
        //else
        //{
        //    Console.WriteLine("OK : No presta porque el usuario ya tiene 3 libros prestados");
        //}

        // CAMINO FELIZ

        if (Circulacion.Prestar(libroUno, usuarioUno))
        {
            Console.WriteLine("Presta perfecto. La vida nos sonríe.");
        }
        else
        {
            Console.WriteLine("BUG: No presta.");
        }

        Console.ReadKey();

    }
}

