using System;
namespace Ej38_Sobrescrito
{
	public class SobreSobrescrito : Sobrescrito
	{

        public SobreSobrescrito() : base(){}

        public override string MiPropiedad
        {
            get => this.miAtributo;
        }

        public override string MiMetodo()
        {
            return this.MiPropiedad;
        }

    }
}

