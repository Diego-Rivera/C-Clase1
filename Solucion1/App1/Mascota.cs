using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    /// <summary>
    /// Clase que permite almacenar valores para 
    /// una instancia de una nueva mascota
    /// </summary>
    internal class Mascota
    {
        private long codigo;
        private string nombre;
        private DateTime fechaNacimiento;
        private string especie;
        private string raza;

        public long Codigo { get => codigo;}
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Especie { get => especie; set => especie = value; }
        public string Raza { get => raza; set => raza = value; }

        /// <summary>
        /// Constructor sólo con el código de la mascota
        /// </summary>
        /// <param name="codigoMascota">Nro del chip 15 dígitos</param>
        public Mascota(long codigoMascota)
        {
            this.codigo = codigoMascota;
        }

        /// <summary>
        /// Cosntructor con todos los parámetros
        /// </summary>
        /// <param name="codigo">Nro del chip</param>
        /// <param name="nombre">Nombre de la mascota</param>
        /// <param name="fechaNacimiento">Fechga nac. mascota</param>
        /// <param name="especie">Nombre especie mascota</param>
        /// <param name="raza">Raza mascota</param>
        public Mascota(long codigo, string nombre, DateTime fechaNacimiento, string especie, string raza) : this(codigo)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.especie = especie;
            this.raza = raza;
        }
    }
}
