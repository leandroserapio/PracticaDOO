using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

3) Crear la clase Persona con los siguientes atributos: 

nombre 
private edad 
DNI 

Método: MostrarInformación() que imprima por consola los tres atributos. 

Crear 3 constructores: 

Uno vacío. 
Uno que reciba por parámetro el nombre y la edad. 
Uno que reciba el nombre, la edad y el DNI. 

En el Main: Crear tres objetos de Persona usando los distintos constructores 
y mostrar los valores de sus propiedades con el método MostrarInformación(). 
 
*/
class Ejercicio4_3
{
    static void Main(string[] args)
    {
        Persona persona1 = new Persona();
        persona1.mostrarInfo();

        Persona persona2 = new Persona("Ayelen", 25);   
        persona2.mostrarInfo();

        Persona persona3 = new Persona("Ayelen", 25, 41200330);
        persona3.mostrarInfo();
    }

    public class Persona
    {
        public string Nombre;
        private int Edad { get; set; }
        public int DNI;

        public Persona() 
        {
            this.Nombre = "Sin Nombre";
            this.Edad = 0;
            this.DNI = 0;   
        }

        public Persona(string nombre, int edad)
        {
            this.Nombre = nombre;
            this.Edad = edad;
        }

        public Persona(string nombre, int edad, int dni)
        {
            this.Nombre = nombre;
            this.Edad = edad;   
            this.DNI = dni;
        }
        public void mostrarInfo() 
        {
            Console.WriteLine($"Nombre: {Nombre}\nEdad: {Edad}\nDni: {DNI}");
        }

    }
}

