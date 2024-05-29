using PP_CuentaGanado;
namespace Test;

class Program
{
    static void Main(string[] args)
    {
        Bar miBar = Bar.GetBar("111");
        Bar tuBar = Bar.GetBar("111");

        Gente g = new Gente(39);

        string gStr = (string)g;


    }
}

