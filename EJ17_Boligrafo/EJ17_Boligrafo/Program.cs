using Boligrafo;
using System.Globalization;

namespace Ej17_Boligrafo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boligrafo.Boligrafo boliUno = new Boligrafo.Boligrafo(2, ConsoleColor.Blue);
            Boligrafo.Boligrafo boliDos = new Boligrafo.Boligrafo(50, ConsoleColor.Red);

            String dibujoUno;
            boliUno.Pintar(9, out dibujoUno);
            Console.WriteLine(dibujoUno);
            boliUno.Recargar();
            Console.WriteLine(boliUno.getTinta());

            Console.ReadKey();
        }
    }
}
