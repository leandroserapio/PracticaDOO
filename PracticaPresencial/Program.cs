using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{

    static void Main(string[] args)
    {

        Persona[] arrayPersonas = new Persona[5];

        arrayPersonas[0] = new Usuario("Leandro", "Seerapio", "leandro", "1234");
        arrayPersonas[1] = new Cliente("Ayelen", "Gutierrez", "asdasd@gmail.com");

        arrayPersonas[1].mostrarInfo();

        Console.WriteLine("Iniciar Sesión");

    }

    public class Persona
    {
        public string Name;
        public string Apellido;

        public Persona(string name, string apellido)
        {

            this.Name = name;
            this.Apellido = apellido;

        }

        public virtual void mostrarInfo()
        {
            Console.WriteLine($"Nombre: {Name} \nApellido: {Apellido}");
        }

    }

    public class Usuario : Persona
    {

        public string Username;
        public string Password;

        public Usuario(string name, string apellido, string username, string password) : base(name, apellido)
        {

            this.Username = username;
            this.Password = password;

        }

        public bool IniciarSesion(string username, string password)
        {
            Console.Write("Ingresar usuario: ");
            string usuarioIngresado = Console.ReadLine();

            Console.Write("Ingresar contraseña: ");
            string contraseniaIngresada = Console.ReadLine();

            if (usuarioIngresado == Username && contraseniaIngresada == Password)
            {
                return true;
                
            }

            return false;
        }

        public override void mostrarInfo()
        {
            base.mostrarInfo();
        }

        public void CambiarPassword()
        {
        }

    }

    public class Cliente : Persona
    {
        public string Correo;

        public Cliente() 
        {
            this.Correo = "Sin correo";
        }

        public Cliente(string name, string apellido, string correo) : base(name, apellido)
        {
            this.Correo = correo;
        }

        public override void mostrarInfo()
        {
            base.mostrarInfo();
            Console.WriteLine($"Correo: {Correo}");
        }
    }
}