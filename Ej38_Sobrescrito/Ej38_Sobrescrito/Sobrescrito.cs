using System;
namespace Ej38_Sobrescrito
{
    public abstract class Sobrescrito
    {
        protected string miAtributo;

        public Sobrescrito()
        {
            this.miAtributo = "Probar abstractos";
        }

        public abstract string MiPropiedad { get; }

        public override string ToString()
        {
            return "¡Este es mi métdo ToString() sobreescrito!";
        }

        public override bool Equals(object? obj)
        {

            return obj != null && obj.GetType() == this.GetType();
        }

        public override int GetHashCode()
        {
            return 1142510187;
        }

        public abstract string MiMetodo();
    }
}

