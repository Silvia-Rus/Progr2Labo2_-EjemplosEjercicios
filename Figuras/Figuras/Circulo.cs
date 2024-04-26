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

        float diametro;

        public Circulo(float diametro)
        {
            this.diametro = diametro;
        }

        public float Diametro
        {
            get => this.diametro;
            set => this.diametro = value;
        }

       

        // Área de un círculo = π * r²
        

        // Perímetro de un círculo = 2 * π * r
        

        // Tenga en cuenta que: π = 3.14 y r = ½ diámetro (el radio es la mitad del diámetro

    }
}
