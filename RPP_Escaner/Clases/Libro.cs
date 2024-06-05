using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Libro : Documento
    {

        int numPaginas;

        public int NumPaginas
        {
            get => this.numPaginas;
        }

        public string ISBN
        {
            get => this.NumNormalizado;
        }
      
        public Libro(string titulo, string autor, int anio, string numNormalizado, string barcode, int numPaginas)
           : base(titulo, autor, anio, numNormalizado, barcode)
        {
            this.numPaginas = numPaginas;
        }

        public static bool operator ==(Libro l1, Libro l2)
        {
            return l1.Barcode == l2.Barcode || (l1.Titulo == l2.Titulo && l1.Autor == l2.Autor) || l1.ISBN == l2.ISBN;
        }

        public static bool operator !=(Libro l1, Libro l2)
        {
            return !(l1 == l2);
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.Append(base.ToString());
            text.AppendLine($"Número de páginas: {this.NumPaginas}.");
            return text.ToString();
        }



    }
}
