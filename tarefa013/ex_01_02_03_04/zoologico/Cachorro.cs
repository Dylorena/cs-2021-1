using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013
{
    class Cachorro : Animal
    {
        public override string EmitirSom()
        {
            return "Au Au";
        }

        public string Correr()
        {
            return "***cachorro correndo***";
        }
    }
}
