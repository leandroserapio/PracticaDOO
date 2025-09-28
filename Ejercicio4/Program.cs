using System;

/*
Necesitamos registrar las coordenadas geograficas de las bases
militares argentinas secretas en el mundo. Para ello nos requieren
tener un arreglo donde se almacene la latitud y otro de longitud que
imprimiendo sus indices equivalentes nos brinden la ubicación exacta
(es decir, latitud[0] con longitud[0] es una ubicación, latitud[1]
con longitud[1] es otra ubicación.1) Necesitamos registrar las 
coordenadas geograficas de las bases militares argentinas secretas 
en el mundo. Para ello nos requieren tener un arreglo donde se almacene
la latitud y otro de longitud que imprimiendo sus indices equivalentes 
nos brinden la ubicación exacta (es decir, latitud[0] con longitud[0] 
es una ubicación, latitud[1] con longitud[1] es otra ubicación.
*/

class Program
{
    static void Main(string[] args)
    {
        
        Coordenada[] arrLat = new Latitud[5];
        Coordenada[] arrLong = new Longitud[5];

        arrLat[0] = new Latitud(34.0522);
        arrLong[0] = new Longitud(118.2437);

        arrLat[1] = new Latitud(2.3522);
        arrLong[1] = new Longitud(2.3522);

        arrLat[2] = new Latitud(23.6345);
        arrLong[2] = new Longitud(133.8807);

        arrLat[3] = new Latitud(51.5074);
        arrLong[3] = new Longitud(0.1278);

        arrLat[4] = new Latitud(35.6895);
        arrLong[4] = new Longitud(139.6917);
        
        for (int i = 0; arrLat.Length > i; i++)
        {
            Console.WriteLine($"Ubicacion {i+1}");
            Console.WriteLine($"Latitud: {arrLat[0].mostrarCoordenada()} || Longitud: {arrLong[0].mostrarCoordenada()}\n");
        }
        

        
    }

    public class Coordenada
    {
        public double CoordenadaPrincipal;

        public Coordenada() { }

        public Coordenada(double coor)
        {
            this.CoordenadaPrincipal = coor;
        }

        public virtual double mostrarCoordenada()
        {
            return this.CoordenadaPrincipal;
        }
    }

    public class Latitud : Coordenada
    {
        

        public Latitud() { }

        public Latitud(double coor) : base(coor)
        {

        }

        public override double mostrarCoordenada()
        {
            return base.mostrarCoordenada();
        }
    }

    public class Longitud : Coordenada
    {


        public Longitud() { }

        public Longitud(double coor) : base(coor)
        {

        }

        public override double mostrarCoordenada()
        {
            return base.mostrarCoordenada();
        }
    }


}
