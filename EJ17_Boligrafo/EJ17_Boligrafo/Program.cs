using Boligrafo;
using System.Globalization;

namespace Ej17_Boligrafo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boligrafo.Boligrafo boliUno = new Boligrafo.Boligrafo(10, ConsoleColor.Blue);
            Boligrafo.Boligrafo boliDos = new Boligrafo.Boligrafo(50, ConsoleColor.Red);

            String dibujoUno;
            boliUno.Pintar(9, out dibujoUno);
            Console.WriteLine(dibujoUno); //MUESTRA 2
            boliUno.Recargar();
            Console.WriteLine(boliUno.getTinta()); //MUESTRA 100

            Console.ReadKey();
        }
    }
}
