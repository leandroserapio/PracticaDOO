using System;

namespace Ejercicio4
{
    class Ejercicio4_5
    {
        static void Main(string[] args)
        {
            Pokemon[] pokedex = new Pokemon[6];

            pokedex[0] = new PokemonFuego("Charizard", 50);
            pokedex[1] = new PokemonAgua("Blastoise", 48);
            pokedex[2] = new PokemonElectrico("Pikachu", 35);
            pokedex[3] = new PokemonFuego("Arcanine", 42);
            pokedex[4] = new PokemonAgua("Gyarados", 55);
            pokedex[5] = new PokemonElectrico("Zapdos", 60);

            Console.WriteLine("░░░░░░░░░░░░░░ POKEDEX - BATALLA POKEMON ░░░░░░░░░░░░░░\n");

            for (int i = 0; i < pokedex.Length; i++)
            {
                Console.WriteLine($"Pokemon #{i + 1}:");
                pokedex[i].MostrarInformacion();
                pokedex[i].Atacar();
                Console.WriteLine();
            }

            Console.WriteLine("░░░░░░░░░░░░░░ FIN DE LA BATALLA ░░░░░░░░░░░░░░");
        }

        public class Pokemon
        {
            public string Nombre;
            public int Nivel;

            public Pokemon()
            {
                Nombre = "Pokemon desconocido";
                Nivel = 1;
            }

            public Pokemon(string nombre, int nivel)
            {
                this.Nombre = nombre;
                this.Nivel = nivel;
            }

            public virtual void Atacar()
            {
                Console.WriteLine($"{Nombre} ataca!");
            }

            public virtual void MostrarInformacion()
            {
                Console.WriteLine($"Nombre: {Nombre} - Nivel: {Nivel}");
            }
        }

        public class PokemonFuego : Pokemon
        {
            public PokemonFuego() : base()
            {
            }

            public PokemonFuego(string nombre, int nivel) : base(nombre, nivel)
            {
            }

            public override void Atacar()
            {
                Console.WriteLine($"Pokemon {Nombre} lanza una llamarada!");
            }

            public override void MostrarInformacion()
            {
                Console.WriteLine($"Nombre: {Nombre} - Nivel: {Nivel} - Tipo: Fuego 🔥");
            }
        }

        public class PokemonAgua : Pokemon
        {
            public PokemonAgua() : base()
            {
            }

            public PokemonAgua(string nombre, int nivel) : base(nombre, nivel)
            {
            }

            public override void Atacar()
            {
                Console.WriteLine($"Pokemon {Nombre} lanza un chorro de agua!");
            }

            public override void MostrarInformacion()
            {
                Console.WriteLine($"Nombre: {Nombre} - Nivel: {Nivel} - Tipo: Agua 💧");
            }
        }

        public class PokemonElectrico : Pokemon
        {
            public PokemonElectrico() : base()
            {
            }

            public PokemonElectrico(string nombre, int nivel) : base(nombre, nivel)
            {
            }

            public override void Atacar()
            {
                Console.WriteLine($"Pokemon {Nombre} lanza un impactrueno!");
            }

            public override void MostrarInformacion()
            {
                Console.WriteLine($"Nombre: {Nombre} - Nivel: {Nivel} - Tipo: Eléctrico ⚡");
            }
        }
    }
}