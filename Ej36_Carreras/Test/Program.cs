using Ej36_Carreras;

namespace Test;

class Program
{
    static void Main(string[] args)
    {
        MotoCross a1 = new MotoCross(3, "moto");
        AutoF1 a2 = new AutoF1(4, "Ferrari");
        AutoF1 a3 = new AutoF1(4, "Ferrari");
        //AutoF1 a4 = new AutoF1(5, "McLaren");
        //AutoF1 a5 = new AutoF1(6, "Ferrari");
        //AutoF1 a6 = new AutoF1(8, "Ferrari");

        Competencia c = new Competencia(3, 4, Competencia.TipoCompetencia.F1);

        string strA1 =
            c + a1 ?
                a1.MostrarDatos()
                :
                "ERRORRR!\n" + a1.MostrarDatos();
        Console.WriteLine(strA1);
        string strA2 = c + a2 ? a2.MostrarDatos() : "ERRORRR!\n" + a2.MostrarDatos();
        Console.WriteLine(strA2);
        string strA3 = c + a3 ? a3.MostrarDatos() : "ERRORRR!\n" + a3.MostrarDatos();
        Console.WriteLine(strA3); //ERROR POR AUTO DUPLICADO
        //string strA4 = c + a4 ? a4.MostrarDatos() : "ERRORRR!\n" + a4.MostrarDatos();
        //Console.WriteLine(strA4);
        //string strA5 = c + a5 ? a5.MostrarDatos() : "ERRORRR!\n" + a5.MostrarDatos();
        //Console.WriteLine(strA5);
        //string strA6 = c + a6 ? a6.MostrarDatos() : "ERRORRR!\n" + a6.MostrarDatos();
        //Console.WriteLine(strA6); //ERROR PORQUE NO CABE EN LA LISTA

    }
}

