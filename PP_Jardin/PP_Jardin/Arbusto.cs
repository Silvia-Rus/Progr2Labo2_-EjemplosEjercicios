using System;
namespace PP_Jardin
{
	public class Arbusto : Planta
	{

		public Arbusto(string nombre, int tamanio) : base(nombre, tamanio)
		{

		}

		public override bool TieneFlores
		{
			get => false;
		}

        public override bool TieneFruto
		{
            get => false;
        }
           

    }
}

