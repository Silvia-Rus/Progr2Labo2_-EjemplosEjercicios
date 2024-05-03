using System;
using System.Text;
namespace PP_Jardin
{
	public class Banano : Planta
	{
        #region Atributos
        string codigo;
        #endregion
        #region Propiedades
        public override bool TieneFlores
        {
            get => true;
        }
        public override bool TieneFruto
        {
            get => true;
        }
        #endregion
        #region Constructor
        public Banano(string nombre, int tamanio, string codigo) : base(nombre, tamanio)
        {
            this.codigo = codigo;
        }
        #endregion
        #region Métodos
        public override string ResumenDeDatos()
        {
            StringBuilder text = new StringBuilder();
            text.Append(base.ResumenDeDatos());
            text.AppendLine($"Código internacional: {this.codigo}");
            return text.ToString();
        }
        #endregion
    }

}

