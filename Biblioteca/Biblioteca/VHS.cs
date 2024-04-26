using System;
namespace Biblioteca
{
    public class VHS : Obra
    {
        int duracion;

        public VHS(string titulo, string autor, int anio, int duracion)
        : base(titulo, autor, anio)
        {

            this.duracion = duracion;

        }

        public int Duracion
        {
            get => this.duracion;
        }
    }
}

