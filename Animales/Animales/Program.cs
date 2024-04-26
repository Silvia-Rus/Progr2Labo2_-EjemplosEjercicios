namespace Animales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro perro = new Perro();
            Gato gato = new Gato();
            Pato pato = new Pato();

            Console.WriteLine($"El perro hace: {perro.EmitirSonido()}");
            Console.WriteLine($"El gato hace: {gato.EmitirSonido()}");
            Console.WriteLine($"El pato hace: {pato.EmitirSonido()}");

            Console.ReadKey();
        }
    }
}
