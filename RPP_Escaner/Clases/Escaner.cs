using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Escaner
    {
        public enum Departamento { nulo, mapoteca, procesosTecnicos}
        public enum TipoDoc { libro, mapa }
        
        string marca;
        Departamento locacion;
        TipoDoc tipo;
        List<Documento> listaDocumentos;

        public string Marca
        {
            get => this.marca;
        }

        public Departamento Locacion
        {
            get => this.locacion;
        }

        public TipoDoc Tipo
        {
            get => this.tipo;
        }

        public List<Documento> ListaDocumentos
        {
            get => this.listaDocumentos;
        }

        public Escaner(string marca, TipoDoc tipo)
        {
            this.marca = marca;
            this.tipo = tipo;
            switch(tipo)
            {
                case TipoDoc.mapa:
                    this.locacion = Departamento.mapoteca;
                    break;
                case TipoDoc.libro:
                    this.locacion = Departamento.procesosTecnicos;
                    break;
            }
            this.listaDocumentos = new List<Documento>();
        }

        public static bool operator ==(Escaner e, Documento d)
        {
            bool retorno = false;

            TipoDoc tipoDocParam = d is Libro ? TipoDoc.libro : TipoDoc.mapa;

            if (e.tipo == tipoDocParam)
            {
                if(e.listaDocumentos.Count() > 0)
                {
                    //UN SOLO FOREACH
                    foreach (Documento item in e.listaDocumentos)
                    {
                        //UN SOLO IF
                        if ((d is Libro && (Libro)item == (Libro)d) ||
                            (d is Mapa && (Mapa)item == (Mapa)d))
                        {
                            retorno = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                throw new TipoIncorrectoException("Este escáner no acepta este tipo de documento", "Escáner.cs", "Validación ==");

            }
            return retorno;
        }

        public static bool operator !=(Escaner e, Documento d)
        {
            return !(e == d);
        }

        public static bool operator +(Escaner e,Documento d)
        {
            bool retorno = false;

            if(d.Estado == Documento.Paso.Inicio)
            {
                try
                {
                    if (e != d)
                    {
                        d.AvanzarEstado();
                        e.listaDocumentos.Add(d);
                    }
                }
                catch (TipoIncorrectoException ex)
                {
                    throw new TipoIncorrectoException("El documento no se pudo añadir a la lista", "Escaner.cs", "sobrecarga +", ex);
                }
            }
            return retorno;
        }

        public bool CambiarEstadoDocumento(Documento d)
        {
            bool retorno = false;
            if(d != null)
            {
                d.AvanzarEstado();
                retorno = true;
            }
            return retorno;
        }
    }
}
