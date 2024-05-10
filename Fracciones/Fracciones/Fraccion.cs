using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Fracciones
{
	public class Fraccion
	{
		public int num;
		public int den;

		public Fraccion(int num, int den)
        {

            if (den == 0)
            {
                throw new DenominadorCeroException("El denominador no puede ser cero", "constructor de la fracción",
                                                        new DivideByZeroException("La fracción en el fondo es una división",
                                                            new ArgumentException("El denominador que entra por parámetro es 0")));

                //throw new DivideByZeroException("El denominador no puede ser cerooooo");
                //throw new ArgumentException("BOOOM EL DENOMINADOR NO PUEDE SER CERO!!!");
            }
            this.num = num;
            this.den = den;
        }


        public static Fraccion operator +(Fraccion a, Fraccion b)
        {
            int num = (a.num * b.den) + (a.den * b.num);
            int den = a.den * b.den;
            Fraccion retorno = new Fraccion(num, den);
            return retorno;
        }

        public static Fraccion operator *(Fraccion a, Fraccion b)
        {
            int num = a.num * b.num;
            int den = a.den * b.den;
            Fraccion retorno = new Fraccion(num, den);
            return retorno;
        }

    }
}

