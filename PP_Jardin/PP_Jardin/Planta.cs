using System;
using System.Text;

namespace PP_Jardin
{
	public abstract class Planta
	{

        #region Atributos
        string nombre;
		int tamanio;
        #endregion

        #region Propiedades
        public int Tamanio
		{
			get => this.tamanio;
		}

		public abstract bool TieneFlores { get; }

        public abstract bool TieneFruto { get; }

		#endregion

        #region Constructores
        public Planta(string nombre, int tamanio)
		{
			this.nombre = nombre;
			this.tamanio = tamanio;
		}
		#endregion

		#region Métodos
		public virtual string ResumenDeDatos()
		{
			//TERNARIO           //condición      //return si true  //return sin false
			string tieneFlores = this.TieneFlores ? "SÍ"             : "NO";
			string tieneFruto  = this.TieneFruto  ? "SÍ"             : "NO"; 

			//ES LO MISMO QUE DECIR LO SIGUIENTE
			//string tieneFlores = "NO";
			//string tieneFruto = "NO";
			//if(this.TieneFlores)
			//{
			//	tieneFlores = "SÍ";
			//}
			//if (this.TieneFruto)
			//{
			//	tieneFruto = "SÍ";
			//}

			StringBuilder text = new StringBuilder();
			text.AppendLine($"{this.nombre} tiene un tamaño de {this.tamanio}");
			text.AppendLine($"Tiene flores: {tieneFlores}");
            text.AppendLine($"Tiene fruto: {tieneFruto}");
            return text.ToString();
		}
        #endregion
    }
}

