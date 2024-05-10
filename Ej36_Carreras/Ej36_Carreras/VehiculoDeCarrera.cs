using System.Text;

namespace Ej36_Carreras;

public class VehiculoDeCarrera
{
    short cantidadCombustible;
    bool enCompetencia;
    string escuderia;
    short numero;
    short vueltasRestantes;

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

    public string Escuderia
    {
        get => this.escuderia;
        set => this.escuderia = value;
    }

    public short Numero
    {
        get => this.numero;
        set => this.numero = value;
    }

    public short VueltasRestantes
    {
        get => this.vueltasRestantes;
        set => this.vueltasRestantes = value;
    }

    public VehiculoDeCarrera(short numero, string escuderia)
    {
        this.numero = numero;
        this.escuderia = escuderia;
        this.enCompetencia = false;
        this.cantidadCombustible = 0;
        this.vueltasRestantes = 0;
    }
    public virtual string MostrarDatos()
    {
        StringBuilder text = new StringBuilder();
        text.AppendLine("VEHÍCULO:");
        text.AppendLine($"Número: {this.numero}");
        text.AppendLine($"Escudería: {this.escuderia}");
        return text.ToString();
    }


}

