using Biblioteca;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Biblioteca;

class Program
{
    static void Main(string[] args)
    {

        Console.Title = "Biblioteca";

        Obra obraUno = new Obra("RayuelaBCBCBB<B", "Cortázar, Julio", 1997, 1111);
        Obra libroDos = new Obra("El Aleph", "Borges, Jorge Luis", 1997, 2222);
        Obra libroTres = new Obra("Yerma", "García Lorca, Federico", 2000, 3333);
        Obra libroCuatro = new Obra("El Túnel", "Sábato, Ernesto", 2000, 5555);
        Libro libroSinBC = new Libro("La Regenta", "Clarín", 2000, 500);

        Enciclopedia enciclopedia = new Enciclopedia("Larousse", "VVAA", 2000, 1000, 10);
        VHS vhs = new VHS("Dumbo", "Disney", 1985, 90);


        Console.WriteLine(enciclopedia.Mostrar());
        //Console.WriteLine(obraUno.Titulo);

        //Obra --> Libro --> Enciclopedia
        //Obra |--> VHS

        Usuario usuarioUno = new Usuario("111");
        Usuario usuarioDos = new Usuario("222");


        // LLLAMANDO A PROPIEDADES
        //Console.WriteLine(libroUno.Titulo);
        //Console.WriteLine(libroUno.Autor);

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

        //if (Circulacion.Prestar(libroUno, usuarioUno))
        //{
        //    Console.WriteLine("Presta perfecto. La vida nos sonríe.");
        //}
        //else
        //{
        //    Console.WriteLine("BUG: No presta.");
        //}

        Console.ReadKey();

    }
}

