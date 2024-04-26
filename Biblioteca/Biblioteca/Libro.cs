using System;
using System.Text;

namespace Biblioteca
{
	public class Libro : Obra //LIBRO DERIVA DE OBRA
	{
		int numeroPaginas;

		//public Libro(string titulo, string autor, int anio) : base(titulo, autor, anio) { }


		public Libro(string titulo, string autor, int anio, int numeroPaginas)
			: base(titulo, autor, anio)
		{

			this.numeroPaginas = numeroPaginas;

		}

		public Libro(string titulo, string autor, int anio, int numeroPaginas, int barcode)
			: this(titulo, autor, anio, numeroPaginas)
		{
			this.Barcode = barcode;
		}

		public int NumeroPaginas
		{
			get => this.numeroPaginas;
		}

		public string Mostrar()
		{
            StringBuilder texto = new StringBuilder();
			texto.Append(base.Mostrar());
			texto.AppendLine($"Núm. Páginas: {this.NumeroPaginas}");
			return texto.ToString();
		}
		

    }
}

