using System;
namespace Ej34_AutomovilMotoCamion
{
	public class Camion : VehiculoTerrestre
	{
		short cantidadMarchas;
		int pesoCarga;

        public Camion(short cantidadRuedas, short cantidadPuertas, string color, short cantidadMarchas, int pesoCarga)
                : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.pesoCarga = pesoCarga;
        }

        public short CantidadMarchas
        {
            set => this.cantidadMarchas = value;
            get => this.cantidadMarchas;
        }

        public int PesoCarga
        {
            set => this.pesoCarga = value;
            get => this.pesoCarga;
        }


    }
}

