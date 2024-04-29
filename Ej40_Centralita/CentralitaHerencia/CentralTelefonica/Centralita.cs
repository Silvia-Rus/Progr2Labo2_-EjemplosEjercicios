using System;
using System.Text;

namespace CentralTelefonica
{
	public class Centralita
	{
		List<Llamada> listaDeLlamadas;
		string razonSocial;

        public Centralita() : this("")
		{
		}

		public Centralita(string nombreEmpresa) 
		{
			this.razonSocial = nombreEmpresa;
			this.listaDeLlamadas = new List<Llamada>();
        }

        public float GananciasPorLocal
        {
            get => this.CalcularGanancia(Llamada.TipoLlamada.Local);
        }

        public float GananciasPorProvincial
        {
            get => this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
        }

        public float GananciasPorTotal
        {
            get => this.CalcularGanancia(Llamada.TipoLlamada.Todas);
        }

        public List<Llamada> Llamadas
        {
            get => this.listaDeLlamadas;
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
		{
			float ganancia = 0;
			foreach(Llamada llamada in this.listaDeLlamadas)
			{
				if((tipo == Llamada.TipoLlamada.Local || tipo == Llamada.TipoLlamada.Todas) && llamada is Local)
				{
					ganancia += ((Local)llamada).CostoLlamada;
				}
				else if((tipo == Llamada.TipoLlamada.Provincial || tipo == Llamada.TipoLlamada.Todas) && llamada is Provincial)
				{
                    ganancia += ((Provincial)llamada).CostoLlamada;
                }
            }
			return ganancia;
		}

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private string Mostrar()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine($"Razón social: {this.razonSocial}.");
            text.AppendLine($"Ganancia total: {this.GananciasPorTotal}.");
            text.AppendLine($"Ganancia por local: {this.GananciasPorLocal}.");
            text.AppendLine($"Ganancia por provincial: {this.GananciasPorProvincial}.");
            text.AppendLine("DETALLE DE LLAMADAS:");
            foreach (Llamada llamada in this.Llamadas)
            {
                text.AppendLine("-Llamada:");
                if (llamada is Local)
                {
                    text.AppendLine(((Local)llamada).ToString());
                }
                else if (llamada is Provincial)
                {
                    text.AppendLine(((Provincial)llamada).ToString());
                }
            }
            text.AppendLine("-----------------");
            return text.ToString();

        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.listaDeLlamadas.Add(nuevaLlamada);
        }

        public static bool operator ==(Centralita c, Llamada llamada)
        {
            bool retorno = false;
            foreach(Llamada item in c.listaDeLlamadas)
            {
                if(item == llamada)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        public static Centralita operator +(Centralita c, Llamada llamada)
        {
            if(c != llamada)
            {
                c.AgregarLlamada(llamada);
            }
            return c;
        }





    }
}

