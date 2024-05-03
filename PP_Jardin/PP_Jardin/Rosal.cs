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

		Color florColor;

        public Rosal(string nombre, int tamanio)
            : base(nombre, tamanio)
        {
        }

        public Rosal(string nombre, int tamanio, Color color)
			: this(nombre, tamanio)
		{
			this.florColor = color;
		}

        public override bool TieneFlores
        {
            get => true;
        }

        public override bool TieneFruto
        {
            get => false;
        }

        public override string ResumenDeDatos()
        {
            StringBuilder text = new StringBuilder();
            text.Append(base.ResumenDeDatos());
            text.AppendLine($"Flores de color: {this.florColor.ToString()}");
            return text.ToString();
        }
    }
}

