using Fracciones;
namespace Fracciones;

class Program
{
    static void Main(string[] args)
    {

        Console.Title = "Fracciones";

        Console.WriteLine("SUMA");
        Fraccion fraccionUno = new Fraccion(1, 5);
        Fraccion fraccionDos = new Fraccion(2, 3);
        Fraccion resultado = fraccionUno + fraccionDos;
        Console.WriteLine(resultado.num + "/" + resultado.den);

        //Console.WriteLine("MULTIPLICACIÓN");
        //Fraccion fraccionUno = new Fraccion(7, 8);
        //Fraccion fraccionDos = new Fraccion(9, 5);
        //Fraccion resultado = fraccionUno * fraccionDos;
        //Console.WriteLine(resultado.num+"/"+resultado.den);


        //Console.WriteLine("CONSTRUIR UNA FRACCIÓN QUE EXPLOTA");
        //Fraccion fraccionBOOM = new Fraccion(7, 0);



    }
}

