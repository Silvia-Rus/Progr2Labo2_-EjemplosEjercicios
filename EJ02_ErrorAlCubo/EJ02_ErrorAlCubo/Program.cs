using System.Runtime.ConstrainedExecution;

namespace EJ02_ErrorAlCubo;

class Program
{
    //Ingresar un número y mostrar el cuadrado y el cubo del mismo.
    //Se debe validar que el número sea mayor que cero,
    //caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".

    static void Main(string[] args)
    {
        int numero;
        Console.WriteLine("Ingrese un número");
        string entrada = Console.ReadLine();
        while(!int.TryParse(entrada, out numero) || numero < 1)
        {
            Console.WriteLine("ERROR. ¡Reingresar número!");
            entrada = Console.ReadLine();
        }

        double cuadrado = Math.Pow(numero, 2);
        double cubo = Math.Pow(numero, 3);

        Console.WriteLine("El cuadrado del numero introducido es: {0} ", cuadrado);
        Console.WriteLine("El cubo del numero introducido es: " + cubo);


        Console.ReadKey();
    }
}

