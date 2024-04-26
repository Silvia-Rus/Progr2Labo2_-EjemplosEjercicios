using System;
using System.Text;

namespace Biblioteca
{
	public class Enciclopedia : Libro 
	{

		int numeroVolumenes;

		public Enciclopedia(string titulo, string autor, int anio, int numeroPaginas, int numeroVolumenes)
			: base(titulo,autor, anio, numeroPaginas)
        {
			this.numeroVolumenes = numeroVolumenes;

		}


        public string Mostrar()
        {
            StringBuilder texto = new StringBuilder();
            texto.Append(base.Mostrar());
            texto.AppendLine($"Núm. Volúmenes: {this.numeroVolumenes}");
            return texto.ToString();
        }


    }
}

