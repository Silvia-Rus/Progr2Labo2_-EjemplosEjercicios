using System.Text;
namespace _30_Carreras;

public class AutoF1
{
    short cantidadCombustible;
    bool enCompetencia;
    string escuderia;
    short numero;
    short vueltasRestantes;

    public AutoF1(short numero, string escuderia)
    {
        this.numero = numero;
        this.escuderia = escuderia;
        this.enCompetencia = false;
        this.cantidadCombustible = 0;
        this.vueltasRestantes = 0;

    }

    public short CantidadCombustible
    {
        get => this.cantidadCombustible;
        set => this.cantidadCombustible = value;
    }

    public bool EnCompetencia
    {
        get => this.enCompetencia;
        set => this.enCompetencia = value;

    }

    public short VueltasRestantes
    {
        get => this.vueltasRestantes;
        set => this.vueltasRestantes = value;
    }

    public string MostrarDatos()
    {
        StringBuilder text = new StringBuilder();
        text.AppendLine("AUTO:");
        text.AppendLine($"Número: {this.numero}");
        text.AppendLine($"Escudería: {this.escuderia}");
        text.AppendLine($"----------------------------");

        return text.ToString();
    }

    public static bool operator!=(AutoF1 a1, AutoF1 a2)
    {
        return !(a1 == a2);
    }

    public static bool operator ==(AutoF1 a1, AutoF1 a2)
    {
        return a1.numero == a2.numero && a1.escuderia == a2.escuderia;
    }




}

