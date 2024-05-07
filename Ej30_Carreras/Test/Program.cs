using _30_Carreras;
namespace Test;

class Program
{
    static void Main(string[] args)
    {
        AutoF1 a1 = new AutoF1(3, "Ferrari");
        AutoF1 a2 = new AutoF1(4, "Ferrari");
        AutoF1 a3 = new AutoF1(4, "Ferrari");
        AutoF1 a4 = new AutoF1(5, "McLaren");
        AutoF1 a5 = new AutoF1(6, "Ferrari");
        AutoF1 a6 = new AutoF1(8, "Ferrari");

        Competencia c = new Competencia(3, 4);

        string strA1 = c + a1 ? a1.MostrarDatos() : "ERRORRR!\n" + a1.MostrarDatos();
        string strA2 = c + a2 ? a2.MostrarDatos() : "ERRORRR!\n" + a2.MostrarDatos();
        string strA3 = c + a3 ? a3.MostrarDatos() : "ERRORRR!\n" + a3.MostrarDatos();
        string strA4 = c + a4 ? a4.MostrarDatos() : "ERRORRR!\n" + a4.MostrarDatos();
        string strA5 = c + a5 ? a5.MostrarDatos() : "ERRORRR!\n" + a5.MostrarDatos();
        string strA6 = c + a6 ? a6.MostrarDatos() : "ERRORRR!\n" + a6.MostrarDatos();

        Console.WriteLine(strA1);
        Console.WriteLine(strA2);
        Console.WriteLine(strA3); //ERROR POR AUTO DUPLICADO
        Console.WriteLine(strA4);
        Console.WriteLine(strA5);
        Console.WriteLine(strA6); //ERROR PORQUE NO CABE EN LA LISTA













    }
}
