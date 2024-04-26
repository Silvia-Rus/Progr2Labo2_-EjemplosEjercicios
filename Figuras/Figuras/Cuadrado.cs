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
        float ladoB;

        public Cuadrado(float ladoA, float ladoB) 
        {
            this.ladoA = ladoA;
            this.ladoB = ladoB;

        }

        public float LadoA 
        {  
            get => this.ladoA; 
            set => this.ladoA = value;
        }

        public float LadoB
        {
            get => this.ladoB;
            set => this.ladoB = value;

        }
        
        // Área del cuadrado = lado × lado
       

        // Perímetro = suma la longitud de cada uno de sus cuatro lados
       
    }
}
