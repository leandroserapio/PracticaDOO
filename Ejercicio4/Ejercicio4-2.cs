using System;

/*
 
2) Crear la clase Vehiculo que contenga marca, modelo y anio. 
Debe tener los métodos: CambiarMarcha() (simplemente un texto 
que informe el cambio de marcha) MostrarInformacion() 
 
Luego, crear tres clases que hereden de Vehiculo Auto Camioneta Moto 

Agregar propiedades específicas: 

Auto: CantidadPuertas, esAutomatico (booleano)
Moto: TipoManubrio 
Camioneta: cantidadPuertas, es4x4 (booleano). 

Se deben instanciar en el Main, creando un objeto de cada clase hija y llamar a sus métodos. 
 */

namespace Ejercicio4
{
    class Ejercicio4_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("░░░░░░░░░ AUTO ░░░░░░░░░");
            Vehiculo vehiculo1 = new Auto("Audi", "A4", 2024, 4, true);
            vehiculo1.MostrarInformacion();
            Console.WriteLine();

            Console.WriteLine("░░░░░░░░░ MOTO ░░░░░░░░░");
            Vehiculo vehiculo2 = new Moto("Zanella", "250", 2016, "Tracker");
            vehiculo2.MostrarInformacion();
            Console.WriteLine();

            Console.WriteLine("░░░░░░░░░ CAMIONETA ░░░░░░░░░");
            Vehiculo vehiculo3 = new Camioneta("Toyota", "Hylux", 2016, 4, true);
            vehiculo3.MostrarInformacion();
            Console.WriteLine();

        }

        public class Vehiculo
        {
            public string Marca;
            public string Modelo;
            public int Anio;

            public Vehiculo() { }

            public Vehiculo(string marca, string modelo, int anio)
            {
                this.Marca = marca;
                this.Modelo = modelo;
                this.Anio = anio;
            }

            public virtual void CambiarMarcha()
            {
                Console.WriteLine("Cambiaste de Marcha");
            }

            public virtual void MostrarInformacion()
            {
                Console.WriteLine($"Marca: {Marca} \nModelo: {Modelo} \nAño: {Anio}");
            }
        }

        public class Auto : Vehiculo
        {

            public int CantidadPuertas;
            public bool esAutomatico;
            public string Transmision => esAutomatico ? "Si" : "No";

            public Auto() { }

            public Auto(string marca, string modelo, int anio, int puertas, bool automatico) : base(marca, modelo, anio)
            {
                this.CantidadPuertas = puertas;
                this.esAutomatico = automatico;
            }

            public override void CambiarMarcha()
            {
                base.CambiarMarcha();
            }

            public override void MostrarInformacion()
            {
                base.MostrarInformacion();
                Console.WriteLine($"Cantidad de puertas: {CantidadPuertas} \n¿Es Automatico?: {Transmision}");
            }
        }


        public class Moto : Vehiculo
        {
            public string TipoManubrio;

            public Moto() { }

            public Moto(string marca, string modelo, int anio, string manubrio) : base(marca, modelo, anio)
            {
                this.TipoManubrio = manubrio;
            }

            public override void CambiarMarcha()
            {
                base.CambiarMarcha();
            }

            public override void MostrarInformacion()
            {
                base.MostrarInformacion();
                Console.WriteLine($"Tipo de Manubrio: {TipoManubrio}");
            }
        }


        public class Camioneta : Vehiculo
        {

            public int CantidadPuertas;
            public bool es4x4;
            public string Tipo => es4x4 ? "Si" : "No";

            public Camioneta() { }

            public Camioneta(string marca, string modelo, int anio, int puertas, bool todoTerreno) : base(marca, modelo, anio)
            {
                this.CantidadPuertas = puertas;
                this.es4x4 = todoTerreno;
            }

            public override void CambiarMarcha()
            {
                base.CambiarMarcha();
            }

            public override void MostrarInformacion()
            {
                base.MostrarInformacion();
                Console.WriteLine($"Cantidad de puertas: {CantidadPuertas} \n¿Es 4x4?: {Tipo}");
            }
        }




    }
}
