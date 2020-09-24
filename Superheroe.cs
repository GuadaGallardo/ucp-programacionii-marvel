using System;

namespace trabajo_practico_3_programacion_ii
{
    class Superheroe
    {
        #region Atributos
        private int CantidadVidas;
        private Superpoder Superpoder;
        #endregion

        #region Constructor
        public Superheroe(){
            this.CantidadVidas = 1;
            this.Superpoder = new Superpoder();
        }

        public Superheroe(int vidas, Superpoder superpoder){
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


        }

        public void DefenderAtaque(){ // o es int? 

        } 

        public void UsarSuperpoder(){


        }

        #endregion


    }
}
