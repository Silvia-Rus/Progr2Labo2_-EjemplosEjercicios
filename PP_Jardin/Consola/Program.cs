using PP_Jardin;

namespace Consola;

class Program
{
    static void Main(string[] args)
    {
        Jardin jardin = new Jardin(100);
        bool pudo = jardin + new Arbusto("Arbusto 1", 10);
             pudo = jardin + new Arbusto("Arbusto 2", 15);
             pudo = jardin + new Rosal("Rosa 1", 20, Rosal.Color.Amarilla);
             pudo = jardin + new Rosal("Rosa clásica", 25);
             pudo = jardin + new Banano("Banano ecuador", 30, "ECU001");
        if (!(jardin + new Banano("No carga", 1, "ARG028")))
        {
            Console.WriteLine("ERROR!");
        }

        Console.WriteLine(jardin.ToString());
    }
}

