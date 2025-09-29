using System;

class Program
{
    static void Main(string[] args)
    {
        InstanciaVirtual[] arrayInstancias = new InstanciaVirtual[1];

        arrayInstancias[0] = new InstanciaVirtual("VM-IFTS-11","2.0.8.6","Linux",false);
        arrayInstancias[0].mostraInformacion();

        arrayInstancias[0].Levantar();

        arrayInstancias[0].mostraInformacion();

        arrayInstancias[0].Bajar();

        arrayInstancias[0].mostraInformacion();


    }

    public class InstanciaVirtual 
    {
        public string Nombre;
        public string Version;
        public string SistemaOperativo;
        public bool Estado;

        public InstanciaVirtual(){}
        public InstanciaVirtual(string nombre, string version, string sistemaOperativo, bool estado)
        {
            this.Nombre = nombre;
            this.Version = version;
            this.SistemaOperativo = sistemaOperativo;
            this.Estado = estado;
        }

        public virtual void Levantar()
        {
            Estado = true;
            Console.WriteLine("Instancia Levantada\n");
        }
        public virtual void Bajar()
        {
            Estado = false;
            Console.WriteLine("Instancia Bajada\n") 
        }

        public virtual void mostraInformacion()
        {
            string estadoTexto = Estado ? "UP" : "DOWN";
            Console.WriteLine($"Nombre:  {Nombre}");
            Console.WriteLine($"Version:  {Version}");
            Console.WriteLine($"Sistema Operativo:  {SistemaOperativo}");
            Console.WriteLine($"Estado de la Maquina Virtual:  {estadoTexto}\n");
        }
    }

}










