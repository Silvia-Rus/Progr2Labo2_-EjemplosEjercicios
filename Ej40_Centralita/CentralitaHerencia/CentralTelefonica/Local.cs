using System;
using System.Text;

namespace CentralTelefonica
{
	public class Local : Llamada
	{
		float costo;

		public override float CostoLlamada
		{
			get => this.CalcularCosto();
		}

        public Local(Llamada llamada, float costo)
            : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo)
			:base(duracion, destino, origen)
		{
			this.costo = costo;
		}

		private float CalcularCosto()
		{
			return this.duracion * this.costo;
		}

        protected override string Mostrar()
        {
            StringBuilder texto = new StringBuilder();
            texto.Append($"{base.Mostrar()}");
            texto.AppendLine($"Costo de la llamada: {this.CostoLlamada}");
            return texto.ToString();
        }

        public override bool Equals(object? obj)
        {
            return obj != null && obj is Local;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}

