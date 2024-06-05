using System;
using System.Text;

namespace Clases
{
	public class TipoIncorrectoException : Exception
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


        public TipoIncorrectoException(string mensaje, string nombreClase, string nombreMetodo, Exception innerException)
			: base(mensaje, innerException)
		{

            this.nombreMetodo = nombreMetodo;
            this.nombreClase = nombreClase;

		}

        public TipoIncorrectoException(string mensaje, string nombreClase, string nombreMetodo)
          : this(mensaje, nombreClase, nombreMetodo, new Exception()) { }

        public override string ToString()
        {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"Excepción en el metodo {this.NombreMetodo} de la clase {this.NombreClase}");
            data.AppendLine("Algo salió mal, revisa los detalles.");
            data.AppendLine($"Detalles: {this.InnerException}");
            return data.ToString();
        }
    }
}

