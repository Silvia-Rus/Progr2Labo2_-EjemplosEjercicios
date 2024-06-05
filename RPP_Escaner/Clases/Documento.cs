
using System.Text;
namespace Clases
{
    public abstract class Documento
    {
        public enum Paso { Inicio, Distribuido, EnEscaner, EnRevision, Terminado}
        
        string titulo;
        string autor;
        int anio;
        string numNormalizado;
        string barcode;
        Paso estado;

        public string Titulo
        {
            get => this.titulo;
        }
        public string Autor
        {
            get => this.autor;
        }

        public int Anio
        {
            get => this.anio;
        }
        public string Barcode
        {
            get => this.barcode;    
        }
        protected string NumNormalizado
        {
            get => this.numNormalizado;
        }

        public Paso Estado
        {
            get => this.estado;
        }
        public Documento(string titulo, string autor, int anio, string numNormalizado, string barcode)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anio = anio;
            this.numNormalizado = numNormalizado;
            this.barcode = barcode;
            this.estado = Paso.Inicio;
        }

        public bool AvanzarEstado()
        {
            //MANERA 1 - (GAUCHITA)
            bool retorno = false;
            if (this.estado != Paso.Terminado)
            {
                this.estado++;
                retorno = true;
            }

            // MANERA 2 - (NO TAN GAUCHITA)
            //bool retorno = true;

            //switch(this.estado)
            //{
            //    case Paso.Inicio:
            //        this.estado = Paso.Distribuido; 
            //        break;
            //    case Paso.Distribuido:
            //        this.estado = Paso.EnEscaner;
            //        break;
            //    case Paso.EnEscaner:
            //        this.estado = Paso.EnRevision;
            //        break;
            //    case Paso.EnRevision:
            //        this.estado = Paso.Terminado;
            //        break;
            //    case Paso.Terminado:
            //        retorno = false;
            //        break;
            //}
            return retorno;
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine($"Titulo: {this.titulo}");
            text.AppendLine($"Autor: {this.autor}");
            text.AppendLine($"Año: {this.anio}");
            if (this is Libro) { text.AppendLine($"ISBN: {this.numNormalizado}"); }
            text.AppendLine($"Cód. de barras: {this.barcode}");
            return text.ToString();
        }
    }

}
