using System.Text;
namespace PP_CuentaGanado;

public abstract class Persona
{
    short edad;
    string nombre;

    public short Edad
    {
        get => this.edad;
        set => this.edad = value;
    }

    public string Nombre
    {
        get => this.nombre;
        set => this.nombre = value;
    }

    protected Persona(string nombre, short edad)
    {
        this.nombre = nombre;
        this.edad = edad;
    }

    public static explicit operator string(Persona persona)
    {
        return persona.Mostrar();
    }

    protected virtual string Mostrar()
    {
        StringBuilder text = new StringBuilder();
        if(this.nombre != "")
        {
            text.AppendLine($"Nombre: {this.nombre}");
        }
        text.AppendLine($"Edad: {this.edad}");
        return text.ToString();
    }

    public abstract bool Validar();
}

