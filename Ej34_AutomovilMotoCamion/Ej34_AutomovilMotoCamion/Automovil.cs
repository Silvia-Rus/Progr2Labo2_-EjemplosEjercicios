using System;
namespace Ej34_AutomovilMotoCamion
{
	public class Automovil : VehiculoTerrestre
	{

		short cantidadMarchas;
		int cantidadPasajeros;

		public Automovil(short cantidadRuedas, short cantidadPuertas, string color, short cantidadMarchas, int cantidadPasajeros)
			: base(cantidadRuedas, cantidadPuertas, color)
        {
			this.cantidadMarchas = cantidadMarchas;
			this.cantidadPasajeros = cantidadPasajeros;
		}


		public short CantidadMarchas
		{
			get => this.cantidadMarchas;
			set => this.cantidadMarchas = value;
		}

        public int CantidadPasajeros
        {
            get => this.cantidadPasajeros;
            set => this.cantidadPasajeros = value;
        }

    }
}

