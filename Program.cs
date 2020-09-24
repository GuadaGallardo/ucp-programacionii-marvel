using System;

namespace trabajo_practico_3_programacion_ii
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos a mi juego MARVEL.");
            Superpoder superpoder = new Superpoder();
            Superheroe superheroe = new Superheroe(1,superpoder);
            Villano villano = new Villano();
            
            Combate combate = new Combate(superheroe, villano, 3);

            combate.Comenzar();



            


        }
    }
}
