using System;

namespace trabajo_practico_3_programacion_ii
{
    class Item
    {

        #region Atributos
        private string Tipo;
        #endregion

        #region Constructor
        public Item(){
            this.Tipo = "";
            
        }
        #endregion

        #region Constructor
        public Item(string tipo){
            this.Tipo = tipo;
            
        }
        #endregion 

        #region setters y getters
        //set
        public void SetTipo(string tipo){
            this.Tipo = "";
        }

        //get
        public string GetTipo(){
            return this.Tipo;
        }
        #endregion

        #region metodos
        public string SortearTipoItem(){
            return this.Tipo; //sorteo ?
          
        }
        #endregion

    }
}
