using System.Collections.Generic;
using System;

namespace klasser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            List<pokemon> pokemonLista = new List<pokemon>();
            pokemonLista.Add(new pokemon("Bulbasaur", 45, 49, 45, 49));
            
            Console.WriteLine(pokemonLista[0].name);
            Console.WriteLine(pokemonLista[0].health);
            Console.WriteLine(pokemonLista[0].damage);
            Console.WriteLine(pokemonLista[0].defense);
            Console.WriteLine(pokemonLista[0].speed);

            fågel fågel = new fågel();
            fågel.Name = "blåmes";
            fågel.x = 1;
            fågel.y = 2;
            fågel.z = 3;
            fågel.hastighet = 10;

            träd träd  = new träd();
            Console.WriteLine(träd.AntaletLöv);
        }
    }
}
