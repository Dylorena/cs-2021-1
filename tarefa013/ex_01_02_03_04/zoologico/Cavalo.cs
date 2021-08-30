using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013
{
    class Cavalo : Animal
    {
        public override string EmitirSom()
        {
            return "Potoc potoc inriiiii";
        }

        public string Correr()
        {
            return "Potoc potoc potoc";
        }
    }
}
