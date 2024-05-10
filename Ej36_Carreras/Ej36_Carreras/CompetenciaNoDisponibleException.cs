using System;
using System.Text;

namespace Ej36_Carreras
{
	public class CompetenciaNoDisponibleException : Exception
	{
		string nombreClase;
		string nombreMetodo;

		public string NombreClase
		{
			get => this.nombreClase;
		}
        public string NombreMetodo
        {
            get => this.nombreMetodo;
        }


        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerException)
			: base(mensaje, innerException)
		{
			this.nombreMetodo = metodo;
			this.nombreClase = clase;
		}

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo)
          : this(mensaje, clase, metodo, null) { }


        public override string ToString()
        {
            StringBuilder data = new StringBuilder();
            data.AppendFormat("Excepción en el metodo {0} de la clase {1}\n", this.NombreMetodo, this.NombreClase);
            data.AppendLine("Algo salió mal, revisa los detalles.");
            data.AppendLine($"Detalles: {this.InnerException}");
            return data.ToString(); 
        }
    }
}

