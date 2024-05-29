using System;
namespace PP_CuentaGanado
{
	public class Bar
	{
		List<Empleado> empleados;
		List<Gente> gente;
		string CUIL;

		static Bar singleton;


		private Bar(string CUIL)
		{
			this.empleados = new List<Empleado>();
            this.gente = new List<Gente>();
			this.CUIL = CUIL;
        }

		public static Bar GetBar(string CUIL)
		{
			if(Bar.singleton is null)
			{
				Bar.singleton = new Bar(CUIL);
			}
			return Bar.singleton;
		}


    }
}

