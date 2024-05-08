using System;
using System.Text;

namespace Ej36_Carreras
{
	public class AutoF1 : VehiculoDeCarrera
	{

		short caballosDeFuerza;

		public short CaballosDeFuerza
		{
			set => this.caballosDeFuerza = value;
			get => this.caballosDeFuerza;
		}

		public AutoF1(short numero, string escuderia) : base(numero, escuderia)
		{
		}

        public AutoF1(short numero, string escuderia, short caballosDeFuerza) : base(numero, escuderia)
        {
			this.caballosDeFuerza = caballosDeFuerza;
        }

        public override string MostrarDatos()
        {

            StringBuilder text = new StringBuilder();
            text.Append(base.MostrarDatos());
            text.AppendLine($"Caballos de fuerza: {this.caballosDeFuerza}");
            text.AppendLine($"----------------------------");
            return text.ToString();
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return a1.Numero           == a2.Numero
                && a1.Escuderia        == a2.Escuderia
                && a1.CaballosDeFuerza == a2.CaballosDeFuerza;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
    }
}

