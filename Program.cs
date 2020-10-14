using System;

namespace trabajo_practico_3_programacion_ii
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos a mi juego MARVEL.");
            Superheroe sup1 = new Superheroe("Spiderman", 1992, "Marvel", 100);
            Villano vi1 = new Villano("Linterna verde", 1990, "Marvel", 80);
            sup1.Atacar(vi1);
            vi1.Atacar(sup1);
        
        }

    }
}
