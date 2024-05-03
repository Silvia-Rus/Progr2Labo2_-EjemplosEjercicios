using System.Text;
namespace PP_Jardin;

public class Jardin
{
    public enum Tipo
    {
        Terroso,
        Arenoso
    }
    #region Atributos
    int espacioTotal;
    List<Planta> plantas;
    static Tipo suelo;
    #endregion
    #region Propiedades
    public static Tipo TipoSuelo
    {
        set => Jardin.suelo = value;
    }
    #endregion
    #region Constructores
    static Jardin()
    {
        suelo = Tipo.Terroso;
    }
    public Jardin()
    {
        this.plantas = new List<Planta>();
    }

    public Jardin(int espacioTotal) : this()
    {
        this.espacioTotal = espacioTotal;
    }
    #endregion
    #region Métodos
    public int EspacioOcupado()
    {
        int retorno = 0;
        foreach(Planta planta in this.plantas)
        {
            retorno += planta.Tamanio;
        }
        return retorno;
    }
    public int EspacioOcupado(Planta planta) 
    {
        return this.EspacioOcupado() + planta.Tamanio;
    }
    public static bool operator +(Jardin jardin, Planta planta)
    {
        bool retorno = false;
        int espacioAOcupar = jardin.EspacioOcupado(planta);
        if(espacioAOcupar <= jardin.espacioTotal)
        {
            jardin.plantas.Add(planta);
            retorno = true;
        }
        return retorno;
    }
    //LO MISMO PERO CON UN TERNARIO
    //public static bool operator +(Jardin jardin, Planta planta)
    //{

    //    int espacioAOcupar = jardin.EspacioOcupado(planta);
    //    bool retorno = espacioAOcupar <= jardin.espacioTotal ? true : false;
    //    if (retorno)
    //    {
    //        jardin.plantas.Add(planta);
    //    }
    //    return retorno;
    //}
    public override string ToString()
    {
        StringBuilder text = new StringBuilder();
        text.AppendLine($"Composición del jardín: {Jardin.suelo.ToString()}");
        text.AppendLine($"Espacio ocupado: {this.EspacioOcupado()} de {this.espacioTotal}");
        text.AppendLine("------------");
        text.AppendLine($"LISTA DE PLANTAS:");
        foreach(Planta p in this.plantas)
        {
            text.AppendLine(p.ResumenDeDatos());
        }
        return text.ToString();
    }
    #endregion
}

