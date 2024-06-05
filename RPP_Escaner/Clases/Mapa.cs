using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Mapa : Documento
    {
        int ancho;
        int alto;

        public int Ancho
        {
            get => this.ancho;
        }

        public int Alto
        {
            get => this.alto;
        }

        public int Superficie
        {
            get => this.alto * this.ancho;
        }

        public Mapa(string titulo, string autor, int anio, string numNormalizado, string codebar, int ancho, int alto)
           : base(titulo, autor, anio, numNormalizado, codebar)
        {
            this.ancho = ancho;
            this.alto = alto;
        }
                                                                                                                                       
        public static bool operator ==(Mapa m1, Mapa m2)   
        {
            return m1.Barcode == m2.Barcode || (m1.Titulo == m2.Titulo && m1.Autor == m2.Autor && m1.Anio == m2.Anio && m1.Superficie == m2.Superficie);
        }

        public static bool operator !=(Mapa m1, Mapa m2)
        {
            return !(m1 == m2);
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.Append(base.ToString());
            text.AppendLine($"Superficie: {this.Ancho} * {this.alto} = {this.Superficie} cm2.");
            return text.ToString();
        }

    }
}
