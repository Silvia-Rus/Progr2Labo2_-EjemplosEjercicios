using PP_CuentaGanado;
namespace Consola;

class Program
{
    static void Main(string[] args)
    {

        Bar b = Bar.GetBar();
        Empleado e = new Empleado("Pepe", 25);
        bool pudo = b + e; 
        Console.WriteLine(b.ToString());
    }
}

