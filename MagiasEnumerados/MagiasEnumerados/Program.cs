using System.Collections.Generic;

namespace MagiasEnumerados;

class Program
{
    public enum Colores
    {
        Default, //entero subyacente 0
        Azul,    //entero subyacente 1
        Verde,   //entero subyacente 2
        Rojo     //entero subyacente 3
    }

    public enum Cilindradas
    {
        c120 = 120, //entero subyacente 120
        c250 = 250, //entero subyacente 250
        c600 = 600  //entero subyacente 600
    }

    static void Main(string[] args)
    {

        //PARSEAR DE STRING A ENUM - VALIDAR SI ESTÁ EN EL ENUM
        Enum.TryParse("Rojo", out Colores color);
        Console.WriteLine($"El color parseado es: {color}"); // lo encuentra - devuelve "Rojo" de tipo Colores

        Enum.TryParse("ZZZZ", out Colores color2);
        Console.WriteLine($"El color parseado es: {color}"); // no lo encuentra - devuelve "Default" de tipo Colores por ser el primero de la lista


        //CONVERTIR DE ENUM A ARRAY
        Array arrayDeColores = Enum.GetValues(typeof(Colores));
        foreach (Colores item in arrayDeColores)
        {
            Console.WriteLine(item);
        }

        //ASIGNAR EL ENTERO SUBYACENTE
        Console.WriteLine($"El entero de {Colores.Azul} es {(int)Colores.Azul}"); 
        Console.WriteLine($"El entero de {Cilindradas.c120} es {(int)Cilindradas.c120}");

       
        Console.ReadKey();
    }

   
}

