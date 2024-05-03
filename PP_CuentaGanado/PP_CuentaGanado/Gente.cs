using System;
using System.Text;

namespace PP_CuentaGanado
{
	public class Gente : Persona
	{
		public Gente(short edad) : base("", edad)
		{
		}
        protected override string Mostrar()
        {
            StringBuilder text = new StringBuilder();
            text.Append("GENTE:");
            text.AppendLine(base.Mostrar());
            return text.ToString();
        }
        public override bool Validar()
        {
            return this.Edad > 18;
        }
    }
}

