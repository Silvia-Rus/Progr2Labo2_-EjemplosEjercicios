using System;
using System.Text;

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

        public override string ToString()
        {
            StringBuilder texto = new StringBuilder();
            texto.Append(base.ToString());
            texto.AppendLine($"Duración: {this.Duracion} minutos.");
            return texto.ToString();
        }
    }
}

