using System;
namespace Biblioteca
{
	public class Usuario
	{
		string dni;
		public int[] barcodeLibroPrestado;
		const int maxLibrosPrestados = 3;

		public Usuario(string dni)
		{
			this.dni = dni;
			this.barcodeLibroPrestado = new int[3];
			this.InitLibroPrestados();

		}

		private void InitLibroPrestados()
		{
			for(int i = 0; i < this.barcodeLibroPrestado.Length ; i++)
			{
				this.barcodeLibroPrestado[i] = -1;
			}
		}

		public void AddLibroPrestado(int indice, int barcode)
		{
			this.barcodeLibroPrestado[indice] = barcode;
        }

		public bool PuedePrestar(out int indice)
		{
			indice = this.PrimerIndiceLibre();
			return indice > -1;
		}
	

		private int PrimerIndiceLibre()
		{
			return Array.IndexOf(this.barcodeLibroPrestado, -1);
        }




	}
}

