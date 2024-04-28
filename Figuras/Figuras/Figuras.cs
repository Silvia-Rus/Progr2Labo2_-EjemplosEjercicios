using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    internal abstract class Figuras
    {

        private float altura;

        protected Figuras(float altura)
        {
            this.altura = altura;
        }

        protected virtual float Altura
        {
            get => this.altura;
            set => this.altura = value;
        }

        public abstract float CalcularArea();
        public abstract float CalcularPerimetro();

    }
}
