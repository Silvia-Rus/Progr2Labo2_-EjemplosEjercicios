using System;
using System.Text;

namespace PP_Jardin
{
	public class Rosal : Planta
	{
		public enum Color
		{
			Roja,
			Blanca,
			Amarilla,
			Rosa,
			Azul
		}
        #region Atributos
        Color florColor;
        #endregion
        #region Propiedades
        public override bool TieneFlores
        {
            get => true;
        }
        public override bool TieneFruto
        {
            get => false;
        }
        #endregion
        #region Constructores
        public Rosal(string nombre, int tamanio) : base(nombre, tamanio)
        {
        }
        public Rosal(string nombre, int tamanio, Color flor) : base(nombre, tamanio)
        {
            this.florColor = flor;
        }
        #endregion
        #region Método
        public override string ResumenDeDatos()
        {
            StringBuilder text = new StringBuilder();
            text.Append(base.ResumenDeDatos());
            text.AppendLine($"Flores de color: {this.florColor.ToString()}");
            return text.ToString();
        }
        #endregion
    }
}

