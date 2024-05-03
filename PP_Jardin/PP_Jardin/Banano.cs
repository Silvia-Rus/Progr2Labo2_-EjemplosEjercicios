using System;
using System.Text;
namespace PP_Jardin
{
	public class Banano : Planta
	{
		string codigo;

		public Banano(string nombre, int tamanio, string codigo)
			:base(nombre, tamanio)
		{
			this.codigo = codigo;
		}

        public override bool TieneFlores
		{
			get => true;
		}

        public override bool TieneFruto
        {
            get => true;
        }

        public override string ResumenDeDatos()
        {
			StringBuilder text = new StringBuilder();
			text.Append(base.ResumenDeDatos());
			text.AppendLine($"Código internacional: {this.codigo}");
			return text.ToString();
        }


    }
}

