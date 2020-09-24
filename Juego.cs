using System;

namespace trabajo_practico_3_programacion_ii
{
    class Juego
    {
        #region Atributos
        private bool Resultado;
        private Combate Combates;
        private int Nivel;
        #endregion

        #region Constructor
        public Juego(){
            this.Resultado = false;
            this.Combates = new Combate();
            this.Nivel = 1;
        }
        

        public Juego(bool resultado, Combate combate, int nivel){
            this.Resultado = resultado;
            this.Combates = combate;
            this.Nivel = nivel;
        }
        #endregion

        #region setters y getters
        //set
        public void SetResultado(bool resultado){
            this.Resultado = resultado;
        }

        //get
        public bool GetResultado(){
            return this.Resultado;
        }
        //set
        public void SetCombates(Combate valorCombate){
            this.Combates = valorCombate;
        }

        //get
        public Combate GetCombates(){
            return this.Combates;
        }
        //set
        public void SetNivel(int nivel){
            this.Nivel = nivel;
        }

        //get
        public int GetNivel(){
            return this.Nivel;
        }
        #endregion
        
        #region metodos
        public void Comenzar(){
           
        }

        public void Terminar(){
            
        }
        #endregion


    }
}