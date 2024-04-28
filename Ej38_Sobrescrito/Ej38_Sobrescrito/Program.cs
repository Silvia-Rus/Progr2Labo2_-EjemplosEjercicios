namespace Ej38_Sobrescrito;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Ejercicio Nº38 Guía 2017";
        //Sobrescrito sobrecarga = new Sobrescrito();
        //Console.WriteLine(sobrecarga.ToString());
        //string objeto = "¡Este es mi método ToString sobrescrito!";
        //Console.WriteLine("----------------------------------------------");
        //Console.Write("Comparación Sobrecargas con String: ");
        //Console.WriteLine(sobrecarga.Equals(objeto));
        //Console.WriteLine("----------------------------------------------");
        //Console.WriteLine(sobrecarga.GetHashCode());
        //Console.ReadKey();

        SobreSobrescrito test = new SobreSobrescrito();
        Console.WriteLine(test.MiPropiedad);

        Console.ReadKey();
    }
}

