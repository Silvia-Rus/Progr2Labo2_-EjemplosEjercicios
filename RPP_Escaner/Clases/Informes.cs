using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public static class Informes
    {

        private static void MostrarDocumentosPorEstado(Escaner e, Documento.Paso estado, 
                                                                  out int extension, 
                                                                  out int cantidad,
                                                                  out string resumen)
        {
            extension = 0;
            cantidad = 0;
            resumen = "";
            
            //UN SOLO FOREACH
            foreach(Documento item in e.ListaDocumentos)
            {
                if (item.Estado == estado)
                {
                    switch(e.Tipo)
                    {
                        case Escaner.TipoDoc.libro:
                            Libro libro = (Libro)item;
                            extension += libro.NumPaginas;
                            break;
                        case Escaner.TipoDoc.mapa:
                            Mapa mapa = (Mapa)item;
                            extension += mapa.Superficie;
                            break;
                    }
                    resumen += item.ToString();
                    cantidad++;
                }
            }
        }
        
        //cantidad de páginas y libros en distribuido
        public static void MostrarDistribuidos(Escaner e, out int extension, out int cantidad, out string resumen)
        {
            Informes.MostrarDocumentosPorEstado(e, Documento.Paso.Distribuido, out extension, out cantidad, out resumen);
        }
        //cantidad de páginas y libros en escaner
        public static void MostrarEnEscaner(Escaner e, out int extension, out int cantidad, out string resumen)
        {
            Informes.MostrarDocumentosPorEstado(e, Documento.Paso.EnEscaner, out extension, out cantidad, out resumen);
        }
        //cantidad de páginas y libros en revisión
        public static void MostrarEnRevision(Escaner e, out int extension, out int cantidad, out string resumen)
        {
            Informes.MostrarDocumentosPorEstado(e, Documento.Paso.EnRevision, out extension, out cantidad, out resumen);
        }
        //cantidad de páginas y libros escaneados
        public static void MostrarTerminados(Escaner e, out int extension, out int cantidad, out string resumen)
        {
            Informes.MostrarDocumentosPorEstado(e, Documento.Paso.Terminado, out extension, out cantidad, out resumen);
        }

    }
}
