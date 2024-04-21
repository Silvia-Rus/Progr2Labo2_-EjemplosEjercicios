using System;
namespace Biblioteca
{
	public static class Circulacion
	{
	
		//public static bool Prestar(Libro libro, Usuario usuario)
		//{
		//	bool retorno = false;

		//	/
		//	if (usuario.AddLibroPrestado(libro.Barcode) && libro.EsPrestable())
		//	{		
		//		libro.Prestado = true;
	    //      retorno = true;
		//	}
		//	return retorno;
		//}

        public static bool Prestar(Libro libro, Usuario usuario)
        {
            bool retorno = false;

            if (usuario.PuedePrestar(out int indice) && libro.EsPrestable())
            {
				usuario.AddLibroPrestado(indice, libro.Barcode);
				libro.Prestado = true;
                retorno = true;
            }
            return retorno;
        }


    }
}

