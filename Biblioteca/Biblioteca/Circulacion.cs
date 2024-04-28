using System;
namespace Biblioteca
{
	public static class Circulacion
	{
        public static bool Prestar(Obra libro, Usuario usuario)
        {
            bool retorno = false;

            if (usuario.PuedePrestar(out int indice) && libro.EsPrestable())
            {
				usuario.AddObraPrestada(indice, libro.Barcode);
				libro.Prestado = true;
                retorno = true;
            }
            return retorno;
        }
    }
}

