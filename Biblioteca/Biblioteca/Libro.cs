using System;
using System.Drawing;

namespace Biblioteca
{
    public class Libro
	{

        string titulo;
		string autor;
		int anio;
		int barcode;
		bool prestado;
		DateTime fechaPrestado;
        DateTime fechaDevolucion;


        public Libro(string titulo, string autor, int anio)
		{
			this.titulo = titulo;
			this.autor = autor;
			this.anio = anio;
			this.prestado = false;
		}

		public Libro(string titulo, string autor, int anio, int barcode)
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

		//public Estado EstadoCirculacion
		//{
		//	set => this.estadoCirculacion = value;
		//}

        //propiedad para el anio



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
		public static bool operator ==(Libro a, Libro b)
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

		public static bool operator !=(Libro a, Libro b)
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

		


	}
}

