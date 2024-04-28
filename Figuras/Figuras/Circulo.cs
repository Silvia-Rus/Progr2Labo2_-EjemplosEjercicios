using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    internal class Circulo : Figuras
    {

        public Circulo(float diametro) : base(diametro) { }
        

        public float Diametro
        {
            get => this.Altura;
            set => this.Altura = value;
        }

        private float Radio
        {
            get => this.Diametro / 2;
        }

        // Área de un círculo = π * r²

        public override float CalcularArea()
        {
            return 3.14F * this.Radio * this.Radio;
        }

        // Perímetro de un círculo = 2 * π * r

        public override float CalcularPerimetro()
        {
            return 2 * 3.14F * this.Radio;
        }

        // Tenga en cuenta que: π = 3.14 y r = ½ diámetro (el radio es la mitad del diámetro

    }
}
