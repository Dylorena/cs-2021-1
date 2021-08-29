using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013
{
    class Zoologico
    {
        public static void AndarZoologico(Animal[] animais)
        {
            foreach (Animal animal in animais)
            {
                Console.WriteLine(animal.EmitirSom());

                if (animal is Cachorro)
                {
                    var tempAnimal = animal as Cachorro;
                    Console.WriteLine(tempAnimal.Correr());
                } else if (animal is Cavalo)
                {
                    var tempAnimal = animal as Cavalo;
                    Console.WriteLine(tempAnimal.Correr());
                }
            }
        }
    }
}
