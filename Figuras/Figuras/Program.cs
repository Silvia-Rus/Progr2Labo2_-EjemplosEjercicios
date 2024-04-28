namespace Figuras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo(3, 5, 4.77F);
            Circulo circulo = new Circulo(10);
            Cuadrado cuadrado = new Cuadrado(5, 5);

            Console.WriteLine($"Área del triángulo: {triangulo.CalcularArea()}");
            Console.WriteLine($"Perímetro del tríángulo: {triangulo.CalcularPerimetro()}");
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Área del círculo: {circulo.CalcularArea()}");
            Console.WriteLine($"Perímetro del círculo: {circulo.CalcularPerimetro()}");
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Área del cuadrado: {cuadrado.CalcularArea()}");
            Console.WriteLine($"Perímetro del cuadrado: {cuadrado.CalcularPerimetro()}");

            Console.ReadKey();


        }
    }
}
