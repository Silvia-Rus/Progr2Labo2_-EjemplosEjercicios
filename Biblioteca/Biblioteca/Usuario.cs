using System;
namespace Biblioteca
{
	public class Usuario
	{
		string dni;
		public int[] barcodeObraPrestada;
		const int maxObrasPrestadas = 3;

		public Usuario(string dni)
		{
			this.dni = dni;
			this.barcodeObraPrestada = new int[3];
			this.InitObraPrestadas();

		}

		private void InitObraPrestadas()
		{
			for(int i = 0; i < this.barcodeObraPrestada.Length ; i++)
			{
				this.barcodeObraPrestada[i] = -1;
			}
		}

		public void AddObraPrestada(int indice, int barcode)
		{
			this.barcodeObraPrestada[indice] = barcode;
        }

		public bool PuedePrestar(out int indice)
		{
			indice = this.PrimerIndiceLibre();
			return indice > -1;
		}
	

		private int PrimerIndiceLibre()
		{
			return Array.IndexOf(this.barcodeObraPrestada, -1);
        }




	}
}

