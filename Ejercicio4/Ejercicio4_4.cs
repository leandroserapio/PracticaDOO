using System;

namespace Ejercicio4
{
    class Ejercicio4_4
    {
        static void Main(string[] args)
        {
            Jugador jugador1 = new Jugador("Lionel Messi", 36, 18, "Delantero");
            Jugador jugador2 = new Jugador("Sergio Ramos", 37, 20, "Defensor");

            Tecnico tecnico1 = new Tecnico("Pep Guardiola", 52, 15, "Táctica ofensiva");
            Tecnico tecnico2 = new Tecnico("Diego Simeone", 53, 12, "Táctica defensiva");

            // Mostrar información de todos los integrantes
            Console.WriteLine("░░░ INFORMACIÓN DE JUGADORES ░░░");
            Console.WriteLine("\n--- Jugador 1 ---");
            jugador1.MostrarInformacion();

            Console.WriteLine("\n--- Jugador 2 ---");
            jugador2.MostrarInformacion();

            Console.WriteLine("\n░░░ INFORMACIÓN DE TÉCNICOS ░░░");
            Console.WriteLine("\n--- Técnico 1 ---");
            tecnico1.MostrarInformacion();

            Console.WriteLine("\n--- Técnico 2 ---");
            tecnico2.MostrarInformacion();
        }

        public class Integrante
        {
            public string Nombre;
            public int Edad;
            public int Antiguedad;

            public Integrante()
            {
                Nombre = "Sin nombre";
                Edad = 0;
                Antiguedad = 0;
            }

            public Integrante(string nombre, int edad, int antiguedad)
            {
                this.Nombre = nombre;
                this.Edad = edad;
                this.Antiguedad = antiguedad;
            }
            public virtual void MostrarInformacion()
            {
                Console.WriteLine($"Nombre: {Nombre}");
                Console.WriteLine($"Edad: {Edad} años");
                Console.WriteLine($"Antigüedad: {Antiguedad} años");
            }
        }

        public class Jugador : Integrante
        {
            public string Posicion;

            public Jugador() : base()
            {
                Posicion = "Sin posición";
            }

            public Jugador(string nombre, int edad, int antiguedad, string posicion)
                : base(nombre, edad, antiguedad)
            {
                this.Posicion = posicion;
            }

            public override void MostrarInformacion()
            {
                base.MostrarInformacion();
                Console.WriteLine($"Posición: {Posicion}");
                Console.WriteLine($"Tipo: Jugador");
            }
        }

        public class Tecnico : Integrante
        {
            public string especialidad;

            public Tecnico() : base()
            {
                especialidad = "Sin especialidad";
            }

            public Tecnico(string nombre, int edad, int antiguedad, string especialidad)
                : base(nombre, edad, antiguedad)
            {
                this.especialidad = especialidad;
            }

            public override void MostrarInformacion()
            {
                base.MostrarInformacion();
                Console.WriteLine($"Especialidad: {especialidad}");
                Console.WriteLine($"Tipo: Técnico");
            }
        }
    }
}