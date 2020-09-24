// #Constructores (al menos 2)
// #Atributos
// #Métodos getters y setters para cada atributo
// #Definición de los métodos (no implementación)


using System;

namespace trabajo_practico_3_programacion_ii
{
    class Combate
    {
        #region Atributos
        private Superheroe Superheroe;
        private Villano Villano;

        //private Personaje Ganador;

        private int CantidadUsosSuperpoder;


        #endregion

        #region Constructor
        public Combate(){
            this.Superheroe = new Superheroe();
            this.Villano = new Villano();
            this.CantidadUsosSuperpoder = 1;
        }
        #endregion

        #region Constructor
        public Combate(Superheroe valorSuperheroe, Villano valorVillano, int usosSuperpoder){
            
            this.Superheroe = valorSuperheroe;
            this.Villano = valorVillano;
            //this.Ganador = valorPersonaje;
            this.CantidadUsosSuperpoder = usosSuperpoder;
            
        }
        #endregion

        #region setters y getters
        //set
        public void SetSuperheroe(Superheroe Superheroe){
            this.Superheroe = Superheroe;
        }

        //get
        public Superheroe GetSuperheroe(){
            return this.Superheroe;
        }

        //set
        public void SetVillano(Villano Villano){
            this.Villano = Villano;
        }

        //get
        public Villano GetVillano(){
            return this.Villano;
        }
        
        
        //set
        public void SetCantidadUsosSuperpoder(int cantidadUsos){
            this.CantidadUsosSuperpoder = cantidadUsos;
        }

        //get
        public int GetCantidadUsosSuperpoder(){
            return this.CantidadUsosSuperpoder;
        }
        #endregion  

        #region metodos
        public void Comenzar(){
            Console.WriteLine("El combate ha comenzado...");
           
        }
        public void Terminar(){

         
          
        }
        public void Turno(){

           
        }
        #endregion

    }
}