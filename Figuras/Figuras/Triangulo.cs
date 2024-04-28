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


        public Triangulo(float baseTriangulo, float ladoTriangulo, float alturaTriangulo)
            : base(alturaTriangulo)
        {
            this.baseTriangulo = baseTriangulo;
            this.ladoTriangulo = ladoTriangulo;
        }

        public float BaseTriangulo
        {
           set => this.baseTriangulo = value;    
           get => this.baseTriangulo;
        }

        public float LadoTriangulo
        {
            set => this.ladoTriangulo = value;
            get => this.ladoTriangulo;
        }

        public float AlturaTriangulo 
        {
            set => this.Altura = value;
            get => this.Altura;
        }


        //El área de un triángulo es igual a base por altura partido por 2.
        public override float CalcularArea()
        {
            return (this.baseTriangulo * this.AlturaTriangulo) / 2;
        }

        // El perímetro de un triángulo es igual a la suma de sus tres lados.
        public override float CalcularPerimetro()
        {
            return 
        }


    }
}
