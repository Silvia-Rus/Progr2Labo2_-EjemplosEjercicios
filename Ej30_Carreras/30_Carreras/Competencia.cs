using System;
namespace _30_Carreras
{
	public class Competencia
	{
		short cantidadCompetidores;
		short cantidadVueltas;
		List<AutoF1> competidores;

		private Competencia()
		{
            this.competidores = new List<AutoF1>();
		}

		public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
		{
			this.cantidadVueltas = cantidadVueltas;
			this.cantidadCompetidores = cantidadCompetidores;
		}

        public string MostrarDatos()
        {
            string texto = "";


            return texto;
        }
        public static bool operator !=(Competencia c, AutoF1 a1)
        {
            return !(c == a1);
        }

        public static bool operator ==(Competencia c, AutoF1 a1)
        {
            bool retorno = false;
            foreach(AutoF1 a in c.competidores)
            {
                if(a == a1)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator +(Competencia c, AutoF1 a1)
        {
            bool retorno = false;

            if(c.competidores.Count() < c.cantidadCompetidores && c != a1)
            {
                a1.EnCompetencia = true;
                a1.VueltasRestantes = c.cantidadVueltas;
                Random rndm = new Random();
                a1.CantidadCombustible = (short)rndm.Next(15, 100);
                c.competidores.Add(a1);
                retorno = true;
            }
            return retorno;
        }

        public static bool operator -(Competencia c, AutoF1 a1)
        {
            bool retorno = false;

            return retorno;
        }
    }
}

