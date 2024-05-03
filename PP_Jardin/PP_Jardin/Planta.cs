using System.Text;
namespace PP_Jardin;

public abstract class Planta
{
    string nombre;
    int tamanio;

    public Planta(string nombre, int tamanio)
    {
        this.tamanio = tamanio;
        this.nombre = nombre;
    }

    public int Tamanio
    {
        get => this.tamanio;
    }

    public abstract bool TieneFlores { get; }
    public abstract bool TieneFruto { get; }

    public virtual string ResumenDeDatos()
    {
        string tieneFlores = this.TieneFlores ? "SÍ" : "NO";
        string tieneFruto = this.TieneFruto ? "SÍ" : "NO";

        StringBuilder text = new StringBuilder();
        text.AppendLine($"{this.nombre} tiene un tamaño de {this.tamanio}");
        text.AppendLine($"Tiene flores: {tieneFlores}");
        text.AppendLine($"Tiene fruto: {tieneFruto}");
        return text.ToString();
    }

}

