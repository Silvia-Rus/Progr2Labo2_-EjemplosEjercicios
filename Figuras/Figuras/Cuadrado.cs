using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    internal class Cuadrado : Figuras   
    {
       
        float ladoA;

        public Cuadrado(float ladoA, float ladoB) : base(ladoB)
        {
            this.ladoA = ladoA;
        }

        public float LadoA 
        {  
            get => this.ladoA; 
            set => this.ladoA = value;
        }

        public float LadoB
        {
            get => this.Altura;
            set => this.Altura = value;
        }

        // Área del cuadrado = lado × lad
        protected override float CalcularArea()
        {
            return this.ladoA * this.LadoB;
        }

        // Perímetro = suma la longitud de cada uno de sus cuatro lados

        public override float CalcularPerimetro()
        {
            return (this.ladoA * 2) + (this.LadoB * 2);
        }

    }
}
