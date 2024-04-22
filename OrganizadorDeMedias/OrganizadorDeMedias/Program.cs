using OrganizadorDeMedias;
using System.Collections;
namespace OrganizadorDeMedias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SE CONSTRUYEN MEDIAS
            Media mediaUno = new Media("Azul");
            Media mediaDos = new Media("Rojo");
            Media mediaTres = new Media("Amarillo");
            Media mediaCuatro = new Media("Negro");
            Media mediaCinco = new Media("Verde");
            // Media[] organizadorMedias = { mediaUno, mediaDos, mediaTres, mediaCuatro, mediaCinco};

            //SE INSTANCIA EL ORGANIZADOR DE MEDIAS
            Media[] organizadorMedias = new Media[5];
            //SE COLOCAN LAS MEDIAS
            organizadorMedias[0] = mediaUno;
            organizadorMedias[1] = mediaDos;
            organizadorMedias[2] = mediaTres;
            organizadorMedias[3] = mediaCuatro;
            organizadorMedias[4] = mediaCinco;
            //VEMOS EL COLOR DE LAS MEDIAS
            foreach (Media media in organizadorMedias)
            {
                Console.WriteLine(media.Color);
            }


            Queue<Media> list = new Queue<Media>();
            list.Enqueue(mediaUno);
            list.Enqueue(mediaDos);
            list.Dequeue();

            ArrayList prueba = new ArrayList();
            prueba.Add(1);
            prueba.Add("Holi");


            List<Media> lista = new List<Media>();
            lista.Add(mediaUno);
            lista.Add(mediaDos);
            int count = lista.Count;
            Console.WriteLine(count);

            foreach (Media media in list)
            {
                Console.WriteLine(media.Color);
            }

            list.Dequeue();
            ////INSTANCIAMOS UNA MEDIA
            //Media mediaSeis = new Media("Blanco");
            ////INSTANCIAMOS EL ARRAY
            //Media[,] organizadorMediasDos = new Media[6, 4];
            ////METEMOS LA MEDIA EN EL ORGANIZADOR
            //organizadorMediasDos[0, 0] = mediaSeis;
            ////SACAMOS POR PANTALLA EL COLOR DE LA MEDIA
            //Console.Write("El color de las medias que tenemos en la posición 0-0 es: "
            //    +organizadorMediasDos[0, 0].Color);
            //Console.ReadKey();


            ////int[] cajoncito; // Declaración de un array de enteros
            ////cajoncito = new int[5]; // Creación de un array de 5 elementos

            //int[] cajoncito = { 1, 2, 3, 4, 5 };
        }
    }
}
