using System;
namespace PP_Jardin
{
	public class Arbusto : Planta
	{
        #region Propiedades
        public override bool TieneFlores
		{
			get => false;
		}
        public override bool TieneFruto
        {
            get => false;
        }
        #endregion
        #region Constructor
        public Arbusto(string nombre, int tamanio) : base(nombre, tamanio)
		{
		}
        #endregion
    }
}

