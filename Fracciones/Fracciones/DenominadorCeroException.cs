using System;
namespace Fracciones
{
	public class DenominadorCeroException : Exception
	{
		string nombreMetodo; 

		public DenominadorCeroException(string mensaje, string metodo, Exception innerException)
			: base(mensaje, innerException)
		{
			this.nombreMetodo = metodo; 
		}

		public string NombreMetodo
		{
			get => this.nombreMetodo; 
		}
	}
}

