using System;
using System.Text;
namespace PP_Jardin
{
	public class Jardin
	{
		public enum Tipo
		{
			Terroso,
			Arenoso
		}

		int espacioTotal;
		static Tipo suelo;
		List<Planta> plantas;

		static Jardin()
		{
			suelo = Tipo.Terroso;
		}

		private Jardin()
		{
			this.plantas = new List<Planta>();
		}

		public Jardin(int espacioTotal) : this()
		{
			this.espacioTotal = espacioTotal;
		}

		public static Tipo TipoSuelo
		{
			set => Jardin.suelo = value; 
		}

		private int EspacioOcupado()
		{
			int retorno = 0;
			foreach(Planta planta in this.plantas)
			{
				retorno += planta.Tamanio;
			}
			return retorno;
		}

		private int EspacioOcupado(Planta planta)
		{
			return this.EspacioOcupado() + planta.Tamanio;
		}

		public static bool operator+(Jardin jardin, Planta planta)
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

        public override string ToString()
        {
			StringBuilder text = new StringBuilder();
			text.AppendLine($"Composición del jardín: {Jardin.suelo}");
			text.AppendLine($"Espacio ocupado: {this.EspacioOcupado()} de {this.espacioTotal}");
			text.AppendLine($"LISTA DE PLANTAS");
			foreach(Planta planta in this.plantas)
			{
				text.AppendLine(planta.ResumenDeDatos());
			}
			return text.ToString();
        }













    }
}

