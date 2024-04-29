using System.Text;
namespace CentralTelefonica;

public abstract class Llamada
{
    public enum TipoLlamada
    {
        Local,
        Provincial,
        Todas
    }

    protected float duracion;
    protected string nroDestino;
    protected string nroOrigen;

    public abstract float  CostoLlamada { get; }

    public float Duracion
    {
        get => this.duracion;
    }

    public string NroDestino
    {
        get => this.nroDestino;
    }

    public string NroOrigen
    {
        get => this.nroOrigen;
    }

    public Llamada(float duracion, string nroDestino, string nroOrigen)
    {
        this.duracion = duracion;
        this.nroDestino = nroDestino;
        this.nroOrigen = nroOrigen;
    }

    protected virtual string Mostrar()
    {
        StringBuilder texto = new StringBuilder();
        texto.AppendLine($"Duración: {this.duracion}");
        texto.AppendLine($"Nro. Origen: {this.nroOrigen}");
        texto.AppendLine($"Nro. Destino: {this.nroDestino}");
        return texto.ToString();
    }

    public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
    {
        return llamada1.Duracion.CompareTo(llamada2.Duracion);
    }

    public static bool operator ==(Llamada l1, Llamada l2)
    {
        return l1.GetType() == l2.GetType()
            && l1.NroOrigen == l1.NroDestino
            && l2.NroOrigen == l2.NroDestino;
    }

    public static bool operator !=(Llamada l1, Llamada l2)
    {
        return !(l1 == l2);
    }


}
