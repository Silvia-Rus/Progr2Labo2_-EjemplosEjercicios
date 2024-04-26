using System;
using System.Drawing;
using System.Text;

namespace Ej34_AutomovilMotoCamion
{
	public class VehiculoTerrestre
	{
		short cantidadRuedas;
		short cantidadPuertas;
		Colores color;

		public enum Colores { Error, Rojo, Blanco, Azul, Gris, Negro }


        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, string color)
		{
			this.cantidadRuedas = cantidadRuedas;
			this.cantidadPuertas = cantidadPuertas;
			Colores colorValidado = this.ConvertirColor(color);
			if(colorValidado == Colores.Error)
			{
				throw new ArgumentException("MALLLL"); 
			}
			else
			{
				this.color = colorValidado;

            }
           
		}

		private bool ValidadorColor(string color)
		{
			bool retorno = false;

			//si el color está dentro del enum devolver true


			return retorno;

		}

        public Colores ConvertirColor(string color)
        {
			Colores retorno;
			Colores.TryParse(color, out retorno);
            Console.WriteLine(retorno);
			return retorno;
           
        }

   //     private Colores convertidorColor(string color)
   //     {
   //         Colores retorno = Colores.Rojo;

   //         //si el color está dentro del enum devolver el objeto de tipo Colores
			////si no? validadorColor?

   //         return retorno;

   //     }


        public short CantidadRuedas
		{
			get => this.cantidadRuedas;
			set => this.cantidadRuedas = value;
		}

        public short CantidadPuertas
        {
            get => this.cantidadPuertas;
            set => this.cantidadPuertas = value;
        }

        public Colores Color
        {
            get => this.color;
            set => this.color = value;
        }

		public string Mostrar()
		{
			StringBuilder texto = new StringBuilder();
			texto.AppendLine($"Cantidad de ruedas: {this.cantidadRuedas}");
            texto.AppendLine($"Cantidad de puertas: {this.cantidadPuertas}");
			texto.AppendLine($"Color: {this.color}");
			return texto.ToString();
        }


    }
}

