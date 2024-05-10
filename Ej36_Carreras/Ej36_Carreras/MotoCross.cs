using System;
using System.Text;

namespace Ej36_Carreras
{
	public class MotoCross : VehiculoDeCarrera
	{
        short cilindrada;

        public short Cilindrada
        {
            set => this.cilindrada = value;
            get => this.cilindrada;
        }

        public MotoCross(short numero, string escuderia) : base(numero, escuderia)
        {
        }

        public MotoCross(short numero, string escuderia, short cilindrada) : base(numero, escuderia)
        {
            this.cilindrada = cilindrada;
        }

        public override string MostrarDatos()
        {

            StringBuilder text = new StringBuilder();
            text.Append(base.MostrarDatos());
            text.AppendLine($"Cilindrada: {this.cilindrada}");
            text.AppendLine($"----------------------------");
            return text.ToString();
        }

        public static bool operator ==(MotoCross m1, MotoCross m2)
        {
            return m1.Numero == m2.Numero
                && m1.Escuderia == m2.Escuderia
                && m1.cilindrada == m2.cilindrada;
        }

        public static bool operator !=(MotoCross m1, MotoCross m2)
        {
            return !(m1 == m2);
        }
    }
}

