using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    internal class Triangulo : Figuras
    {
        float baseTriangulo;
        float ladoTriangulo;
        float alturaTriangulo;


        public Triangulo(float baseTriangulo, float ladoTriangulo, float alturaTriangulo)   
        {
            this.baseTriangulo = baseTriangulo;
            this.ladoTriangulo = alturaTriangulo;
        }

        public float BaseTriangulo
        {
           set => this.baseTriangulo = value;    
           get => this.baseTriangulo;
        }

        public float AlturaTriangulo 
        {
            set => this.alturaTriangulo = value;
            get => this.alturaTriangulo;
        }

        public float LadoTriangulo
        {
            set => this.ladoTriangulo = value;
            get => this.ladoTriangulo;
        }

        //El área de un triángulo es igual a base por altura partido por 2.
        
        
        // El perímetro de un triángulo es igual a la suma de sus tres lados.
        

    }
}
