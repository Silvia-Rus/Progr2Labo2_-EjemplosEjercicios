using System;
using System.Text;

namespace PP_CuentaGanado
{
	public class Empleado : Persona
	{
		int dni;

		public Empleado(string nombre, short edad) : base(nombre, edad)
		{
            this.dni = -1;
		}

        public Empleado(string nombre, short edad, int dni) : base(nombre, edad)
		{
			this.dni = dni;
		}

        protected override string Mostrar()
        {
            StringBuilder text = new StringBuilder();
            text.Append("EMPLEADO:");
            text.AppendLine(base.Mostrar());
            if (this.dni > 0)
            {
                text.AppendLine($"DNI: {this.dni}");
            }
            return text.ToString();
        }

        public static bool operator ==(Empleado e1, Empleado e2)
        {
            return e1.Nombre == e2.Nombre && e1.Edad == e2.Edad;
        }

        public static bool operator !=(Empleado e1, Empleado e2)
        {
            return !(e1 == e2);
        }

        public override bool Validar()
        {
            return this.Edad > 21 && this.Nombre.Length > 2;
        }



    }
}

