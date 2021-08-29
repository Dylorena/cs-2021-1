using System;

namespace _013
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animais = new Animal[10];

            Cavalo cavalo = new();
            Console.WriteLine(cavalo.EmitirSom()); 
            Cachorro cachorro = new();
            Console.WriteLine(cachorro.EmitirSom()); 
            Preguica preguica = new();
            Console.WriteLine(preguica.EmitirSom());


            Veterinario vet = new();
            Console.WriteLine(vet.Examinar(cachorro));
            Console.WriteLine(vet.Examinar(cavalo));
            Console.WriteLine(vet.Examinar(preguica));

            animais[0] = new Cavalo();
            animais[1] = new Cachorro();
            animais[2] = new Preguica();
            animais[3] = new Cavalo();
            animais[4] = new Cachorro();
            animais[5] = new Preguica();
            animais[6] = new Cavalo();
            animais[7] = new Cachorro();
            animais[8] = new Preguica();
            animais[9] = new Cavalo();

            Zoologico.AndarZoologico(animais);
        }
    }
}
