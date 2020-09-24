using System;

namespace trabajo_practico_3_programacion_ii
{
    class Superpoder
    {
        #region Atributos
        private bool Tipo;
        private int CantidadUsos;

        #endregion

        #region Constructor
        public Superpoder(){
            this.Tipo = true;
            this.CantidadUsos = 1;
        }

        public Superpoder(bool verdadero, int usos){
            this.Tipo = verdadero;
            this.CantidadUsos = usos;
        }
        #endregion

        #region setters y getters
        //set
        public void SetTipo(bool verdadero){
            this.Tipo = verdadero;
        }

        //get
        public bool GetTipo(){
            return this.Tipo;
        }

        //set
        public void SetCantidadUsos(int valor){
            this.CantidadUsos = valor;
        }

        //get
        public int GetCantidadUsos(){
            return this.CantidadUsos;
        }
        #endregion

        #region metodos
     
        public void Usar(Superheroe superheroe){

            int usos;
            usos = this.CantidadUsos - 1;
            
        }
        #endregion

    }
}

