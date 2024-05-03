using System.Numerics;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

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

    public static explicit operator string(Persona persona)
    {
        return persona.Mostrar();
    }

    protected virtual string Mostrar()
    {
        StringBuilder text = new StringBuilder();
        if(this.nombre != "")
        {
            text.AppendLine($"Nombre: {this.nombre}.");
        }
        text.AppendLine($"DNI: {this.edad}.");
        return text.ToString();
    }

    internal Persona(string nombre, short edad)
    {
        this.nombre = nombre;
        this.edad = edad;
    }

    public abstract bool Validar();


}

