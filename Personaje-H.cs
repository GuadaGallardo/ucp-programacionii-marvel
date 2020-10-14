using System;

namespace trabajo_practico_3_programacion_ii
{
    public abstract class Personaje
    {
        #region atributos
            private string Nombre;
            private int AnioCreacion;
            private string Universo;
            private int Stamina;
        #endregion

        #region constructores
        public Personaje(string nombre, int anioCreacion, string universo, int stamina){
            this.Nombre = nombre;
            this.AnioCreacion = anioCreacion;
            this.Universo = universo;
            this.Stamina = stamina;
        }
                    
        #endregion

        #region set / get
        public void SetNombre(string nombre){
            this.Nombre = nombre;
        }
        
        public string GetNombre(){
            return this.Nombre;
        }

        public void SetAnioCreación(int aniocreacion){
            this.AnioCreacion = aniocreacion;
        }
        public int GetAnioCreacion(){
            return this.AnioCreacion;
        }
        public void SetUniverso(string universo){
            this.Universo = universo;
        }

        public string GetUniverso(){
            return this.Universo;
        }

        public void SetStamina(int stamina){
            this.Stamina = stamina;
        }
        public int GetStamina(){
            return this.Stamina;
        }
        #endregion

        #region métodos
            //El método Atacar() de la clase personaje, 
            //¿debería ser Virtual o Abstracto? Justificar
             
            //En este caso puede utilizarse un método virtual para la acción del ataque
            // ya que los personajes interactúan entre sí, y los ataques son iguales de un personaje a otro. 
            // El método virtual no requiere ser sobreescrito de manera obligatoria en las subclases y
            // en este caso práctico se recurrió a esa caracteristica, existiendo solo en la clase padre, 
            // devolviendo el nombre del personaje al que se está atacando.

            public virtual void Atacar(Personaje personaje){
                Console.WriteLine("Estoy atacando a " + personaje.GetNombre());
            }
        #endregion
    }
}
