using System;

namespace trabajo_practico_3_programacion_ii
{
    public class Superheroe : Personaje {

        #region atributos
        private int CantidadVidas;
        private Superpoder Superpoder;
        #endregion


        #region Constructor
        public Superheroe(string nombre, int anioCreacion, string universo, int stamina) : base(nombre, anioCreacion,universo,stamina){
            this.CantidadVidas = 1;
            this.Superpoder = new Superpoder();
        }

        public Superheroe(string nombre, int anioCreacion, string universo, int stamina, int vidas, Superpoder superpoder) : base(nombre, anioCreacion,universo,stamina){
            this.CantidadVidas = vidas;
            this.Superpoder = superpoder;
        }
        #endregion
        
        #region setters y getters
        //set
        public void SetCantidadVidas(int vidas){
            this.CantidadVidas = vidas;
        }

        //get
        public int GetCantidadVidas(){
            return this.CantidadVidas;
        }
        //set
        public void SetSuperpoder(Superpoder valorSuperpoder){
            this.Superpoder = valorSuperpoder;
        }

        //get
        public Superpoder GetSuperpoder(){
            return this.Superpoder;
        }
        #endregion
        
        #region metodos
        // obtener item  item
        //usar item (item item) void 
        //Defender (ataqie, int) void
        //UsarSuperpoder() void

        public Item ObtenerItem(){
            return new Item(); 
          
        }

        public void UsarItem(Item item){
            Console.WriteLine("Estoy usando un item");

        }

        public void DefenderAtaque(){ // o es int? 

        } 

        public void UsarSuperpoder(){

        }

        #endregion


    }
}
