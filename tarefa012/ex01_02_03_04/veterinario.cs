using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013
{
    class Veterinario
    {
        public string Examinar(Animal animal)
        {
            return $"Examinou e o animal fez {animal.EmitirSom()}";
        }
    }
}
