using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    internal class Pato : Animal
    {
        public override string EmitirSonido()
        {
            return "¡Cuack!";
        }
    }
}
