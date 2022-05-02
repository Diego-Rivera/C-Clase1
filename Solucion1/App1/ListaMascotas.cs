using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    /// <summary>
    /// Clase que permite almacenarr un arreglo de 10 mascotas
    /// </summary>
    internal class ListaMascotas
    {
        Mascota[] misMascotas=new Mascota[10];
        private bool hayEspacio;

        public ListaMascotas()
        {
            hayEspacio = true;
        }
        
        /// <summary>
        /// Clase que permite agregar una nueva mascota
        /// en la primera posición null que encuentre.
        /// Modifica el valor hayEspacio si ya no quedan 
        /// posiciones disponibles
        /// </summary>
        /// <param name="nueva">Una nueva mascota</param>
        /// <returns>True si pudo agregar la mascota, False
        /// si no pudo</returns>
        public bool AgregarMascota(Mascota nueva)
        {
            bool res = false;
            int posicion = Disponible();
            if (posicion>-1)
            {
                misMascotas[posicion] = nueva;
                res = true;
            }
            return res;
        }

        private int Disponible()
        {
            int a=-1;
            for (int i = 0; i < misMascotas.Length; i++)
            {
                if(misMascotas[i]==null)
                {
                    a = i;
                    break;
                }
            }

            return a;
        }
    }
}
