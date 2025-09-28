using System;

class Program
{
    static void Main(string[] args)
    {
        Empleado[] arrayPersonas = new Empleado[10];

        arrayPersonas[0] = new Administrativo("Laura", "Fernandez", "Recursos Humanos", "Asistente");
        arrayPersonas[1] = new Administrativo("Pedro", "Gómez", "Contabilidad", "Analista");
        arrayPersonas[2] = new Administrativo("María", "López", "Marketing", "Coordinadora");

        arrayPersonas[3] = new Gerente("Javier", "Martínez", 10, 3);
        arrayPersonas[4] = new Gerente("Sofía", "Pérez", 8, 2);

        arrayPersonas[5] = new Tecnico("Carlos", "Ruiz", "Backend", "C#");
        arrayPersonas[6] = new Tecnico("Ana", "Torres", "Frontend", "JavaScript");
        arrayPersonas[7] = new Tecnico("Diego", "Sánchez", "DevOps", "Python");
        arrayPersonas[8] = new Tecnico("Lucía", "García", "Testing", "Java");
        arrayPersonas[9] = new Tecnico("Marta", "Castro", "Mobile", "Kotlin");


        Console.WriteLine("░░░░░░░░░░░░ LISTADO EMPLEADOS ░░░░░░░░░░░░\n");

        for (int i = 0 ; i < arrayPersonas.Length; i++)
        {
            string tipo = arrayPersonas[i].GetType().Name;
            Console.WriteLine($"Empleado {i + 1} ({tipo})");
            arrayPersonas[i].mostrarInfo();
            Console.WriteLine();
        }



    }

    public class Empleado
    {
        public string Nombre;
        public string Apellido;

        public Empleado()
        {

        }

        public Empleado (string nombre, string apellido )
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public virtual void mostrarInfo() 
        {
            Console.WriteLine($"-- Nombre: {Nombre} \n-- Apellido: {Apellido}");
        }
    }

    public class Tecnico : Empleado
    {
        public string Especialidad;
        public string LenguajePrincipal;

        public Tecnico() { }

        public Tecnico(string nombre, string apellido, string especialidad, string lenguajePrincipal) : base(nombre, apellido)
        { 
            this.Especialidad = especialidad;
            this.LenguajePrincipal = lenguajePrincipal;
        }

        public override void mostrarInfo()
        {
            base.mostrarInfo();
            Console.WriteLine($"-- Especialidad: {Especialidad} \n-- Lenguaje principal que usa: {LenguajePrincipal}");
        }
    }

    public class Gerente : Empleado
    {
        public int AniosExperiencia;
        public int AreasACargo;

        public Gerente() { }

        public Gerente(string nombre, string apellido, int anios, int areas) : base(nombre, apellido)
        {
            this.AniosExperiencia = anios;
            this.AreasACargo = areas;
        }
    
        public override void mostrarInfo() 
        {
            base.mostrarInfo();
            Console.WriteLine("-- Años de experiencia: " + AniosExperiencia + "\n-- Areas a Cargo: " + AreasACargo);
        }
    }

    public class Administrativo : Empleado
    {
        public string Area;
        public string PuestoTrabajo;
    
        public Administrativo() { }

        public Administrativo(string nombre, string apellido, string area, string puestoTrabajo) : base(nombre, apellido)
        {
            this.Area = area;
            this.PuestoTrabajo = puestoTrabajo;
        }

        public override void mostrarInfo()
        {
            base.mostrarInfo();
            Console.WriteLine($"-- Area: {Area} \n-- Puesto de Trabajo: {PuestoTrabajo}");
        }
    }
}