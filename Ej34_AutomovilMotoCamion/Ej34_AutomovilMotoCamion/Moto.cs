using System;
namespace Ej34_AutomovilMotoCamion
{
	public class Moto : VehiculoTerrestre
	{
		short cilindrada;



        public Moto(short cantidadRuedas, short cantidadPuertas, string color, short cilindrada)
        : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cilindrada = cilindrada;
        }

        public short Cilindrada
        {
            get => this.cilindrada;
            set => this.cilindrada = value;
        }
    }
}

