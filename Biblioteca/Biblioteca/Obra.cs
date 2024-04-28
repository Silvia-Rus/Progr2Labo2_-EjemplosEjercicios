using System;
using System.Drawing;
using System.Text;

namespace Biblioteca
{
    public class Obra
	{
        protected string titulo;
		string autor;
		int anio;
		int barcode;
		bool prestado;
		DateTime fechaPrestado;
        DateTime fechaDevolucion;

        public Obra(string titulo, string autor, int anio)
		{
			this.titulo = titulo;
			this.autor = autor;
			this.anio = anio;
			this.prestado = false;
		}

		public Obra(string titulo, string autor, int anio, int barcode)
			: this(titulo, autor, anio)
		{
			this.barcode = barcode;
        }

		public string Titulo
		{
			get { return this.titulo; }
			//get => this.titulo;
			set => this.titulo = value;
		}

		public string Autor
		{
			get => this.autor;
			set => this.autor = value;
		}

        //propiedad para el anio
        public int Anio
        {
            get => this.anio;
            set => this.anio = value;
        }

        //propiedad para el barcode
        public int Barcode
        {
            get => this.barcode;
            set => this.barcode = value;
        }

        public bool Prestado
		{
			set
			{
				if(value == true)
				{
                    this.prestado = true;
                    this.fechaPrestado = DateTime.Now;
                }
				else
				{
					this.prestado = false;
                    this.fechaDevolucion = DateTime.Now;
                }
            }

			get => this.prestado;
		}

		public DateTime FechaPrestamo
		{
			get => this.fechaPrestado;
		}

		//OPERADORES SOBERCARGADOS PORQUE LA IGUALDAD SI NO MIRA AL LUGAR EN LA MEMORIA
		public static bool operator ==(Obra a, Obra b)
		{
			//EXPLICADO EN LARGO
			//bool retorno = false;

			//if (a.titulo == b.titulo && a.autor == b.autor)
			//{

			//	retorno = true;
			//}
			//return retorno;

			//EXPLICADO EN CORTO
			return a.titulo == b.titulo && a.autor == b.autor;
		}

		public static bool operator !=(Obra a, Obra b)
		{
			return !(a == b);
			// return !(a.titulo == b.titulo && a.autor == b.autor);
		}

		public bool EsPrestable()
		{
			bool retorno = false;
			if(this.barcode > 0 && this.prestado == false)
			{
				retorno = true;
			}
			return retorno;
		}

		public override string ToString()
		{
			StringBuilder retorno = new StringBuilder();
			retorno.AppendLine($"Título: {this.titulo}.");
			retorno.AppendLine($"Autor: {this.autor}.");
			retorno.AppendLine($"Año: {this.anio}.");
            return retorno.ToString();
		}

		//Destrabado por Rodrigo :)
		public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Obra obraAComprar = (Obra)obj;
            return this.autor == obraAComprar.autor && this.titulo == obraAComprar.titulo;
        }

    }
}

