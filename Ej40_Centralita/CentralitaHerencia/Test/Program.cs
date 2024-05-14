using CentralTelefonica;
using static CentralTelefonica.Provincial;

namespace Test;

class Program
{
    static void Main(string[] args)
    {
        // Mi central
        Centralita c = new Centralita("Centralita de Rus");

        // Mis 4 llamadas
        Local      l1 = new Local     ("20", 12, "30", 34);
        Local      l2 = new Local     ("20", 12, "30", 34);
        Provincial p1 = new Provincial("20", Provincial.Franja.Franja_3, 20, "30");
        Provincial p2 = new Provincial("20", Provincial.Franja.Franja_3, 20, "30");

        // Las llamadas se irán registrando en la Centralita.
        c += l1;
        c += l2; // ESTA NO SE SUMA
        c += p1;
        c += p2; // ESTA NO SE SUMA

        //c.OrdenarLlamadas();
        Console.WriteLine(c.ToString());
        Console.ReadKey();
    }
}

