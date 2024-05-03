using System;
using System.Text;

namespace PP_CuentaGanado
{
	public class Bar
	{
		List<Empleado> empleados;
		List<Gente> gente;
		static Bar singleton;

		private Bar()
		{
			this.empleados = new List<Empleado>();
			this.gente = new List<Gente>();
		}

		public List<Empleado> Empleados
		{
			get => this.empleados;
		}

        public List<Gente> Gente
        {
            get => this.gente;
        }
        public static Bar GetBar()
        {
            if (Bar.singleton is null)
            {
                Bar.singleton = new Bar();
            }
            return Bar.singleton;
        }

        public static bool operator +(Bar bar, Empleado empleado)
        {
            bool retorno = true;
            //CHEQUEO SI HAY DUPLICADOS
            foreach(Empleado e in bar.Empleados)
            {
                if(e == empleado)
                {
                    retorno = false;
                    break;
                }
            }
            //LO SUMO SI LO PUEDO VALIDAR
            if(retorno == true && empleado.Validar())
            {
                bar.empleados.Add(empleado);
            }
            return retorno;
        }

        public static bool operator +(Bar bar, Gente gente)
        {
            bool retorno = false;
            int numeroDeGenteAceptada = bar.empleados.Count() * 10;
            int numeroDeGenteQueHabra= bar.gente.Count() + 1;
            if (numeroDeGenteAceptada >= numeroDeGenteQueHabra)
            {
                bar.gente.Add(gente);
                retorno = true;
            }

            return retorno;
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine("EMPLEADOS:");
            if(this.empleados.Count() > 0)
            {
                foreach (Empleado e in this.empleados)
                {
                    text.AppendLine((string)e);
                }
            }
            else
            {
                text.AppendLine("--> No hay empleados todavía.");
            }
         
            text.AppendLine("GENTE:");
            if(this.gente.Count() > 0)
            {
                foreach (Gente g in this.gente)
                {
                    text.AppendLine((string)g);
                }
            }
            else
            {
                text.AppendLine("--> No hay gente todavía.");
            }

            return text.ToString();
        }




    }
}

