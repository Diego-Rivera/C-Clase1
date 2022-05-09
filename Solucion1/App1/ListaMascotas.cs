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

        public bool Eliminar(int codigo)
        {
            bool res = false;

            int x = 0;
            foreach(Mascota m in misMascotas)
            {
                if(m!=null)
                { 
                    if(m.Codigo == codigo)
                    {
                        misMascotas[x] = null;
                        res = true;
                        break;
                    }
                }
                x++;
            }

            return res;
        }

        public bool Modificar(Mascota m)
        {
            bool res=false;
            int x = 0;
            foreach(Mascota m2 in misMascotas)
            {
                if(m2.Codigo == m.Codigo)
                {
                    misMascotas[x].Raza = m.Raza;
                    misMascotas[x].Nombre = m.Nombre;
                    misMascotas[x].FechaNacimiento = m.FechaNacimiento;
                    res = true;
                    break;
                }
            }

            return res;
        }

        public Mascota Buscar(int codigo)
        {
            Mascota encontrada = null;

            foreach(Mascota m in misMascotas)
            {
                if (m != null)
                {
                    if (m.Codigo == codigo)
                    {
                        encontrada = m;
                        break;
                    }
                }
            }
            return encontrada;
        }
    }
}
