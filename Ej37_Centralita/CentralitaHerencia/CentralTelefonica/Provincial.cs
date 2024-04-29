using System;
using System.Text;

namespace CentralTelefonica
{
	public class Provincial : Llamada
	{
		public enum Franja
		{
			Franja_1,
			Franja_2,
			Franja_3
		}

		Franja franjaHoraria;

		public float CostoLlamada
		{
			get => this.CalcularCosto();
		}

		public Provincial(Franja miFranja, Llamada llamada)
			: base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
		{
			this.franjaHoraria = miFranja;
		}

		public Provincial(string origen, Franja miFranja, float duracion, string destino)
			:base(duracion, destino, origen)
		{
			this.franjaHoraria = miFranja;
		}

		private float CalcularCosto()
		{
			float precio = 0;
			switch (this.franjaHoraria)
			{
                case Franja.Franja_1:
					precio = 0.99F;
					break;
				case Franja.Franja_2:
					precio = 1.25F;
					break;
				case Franja.Franja_3:
					precio = 0.66F;
					break;
				default:
					precio = -1;
					break;
            }
			return precio * this.Duracion;
		}

        public override string Mostrar()
        {
            StringBuilder texto = new StringBuilder();
            texto.Append($"{base.Mostrar()}");
            texto.AppendLine($"Franja Horaria: {this.franjaHoraria}");
            texto.AppendLine($"Costo de la llamada: {this.CostoLlamada}");

            return texto.ToString();
        }


    }
}

