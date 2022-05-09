using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Menu
    {
        ListaMascotas lista = new ListaMascotas();

        public void MostrarMenu()
        {
            bool salir = true;
            string opcion = "";
            while(salir)
            {
                Console.WriteLine("1. Agregar mascota");
                Console.WriteLine("2. Buscar mascota");
                Console.WriteLine("3. Borrar mascota");
                Console.WriteLine("4. Modificar mascota");
                Console.WriteLine("5. Salir");

                opcion = Console.ReadLine();

                switch(opcion)
                {
                    case "1":
                        Console.WriteLine("Ingreso de nueva mascota");
                        long codigo=0;
                        string nombre;
                        DateTime fechaNacimiento;
                        string especie;
                        string raza;
                        bool funciona = true;

                        while (funciona)
                        {
                            try
                            {
                                Console.WriteLine("Ingresa el código");
                                codigo = long.Parse(Console.ReadLine());
                                funciona = false;
                            }
                            catch(FormatException ex)
                            {
                                Console.WriteLine("El código sólo puede ser un número");
                            }
                        }
                        Console.WriteLine("Ingresa el nombre");
                        nombre = Console.ReadLine();

                        funciona = false;
                        while(!funciona)
                        {
                            try
                            {
                                Console.WriteLine("Ingresa la fecha");
                                fechaNacimiento = DateTime.Parse(Console.ReadLine());
                                funciona = true;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("El formato de la fecha no es el correcto");
                            }
                        }
                       

                        Console.WriteLine("Ingresa la especie");
                        especie = Console.ReadLine();

                        Console.WriteLine("Ingresa la raza");
                        raza=Console.ReadLine();

                        Mascota m = new Mascota(codigo, nombre, fechaNacimiento, especie, raza);

                        if (lista.AgregarMascota(m))
                            Console.WriteLine("Mascota agregada con exito");
                        else
                            Console.WriteLine("Falló agregar la mascota");

                        break;
                    case "2":
                        BuscarMascota();
                        break;
                    case "3":
                        Eliminar();
                        break;
                    case "4":
                        Modificar();
                        break;
                    case "5":
                        salir = false;
                        Console.WriteLine("Gracias XD");
                        Console.WriteLine("Presiona cualquier tecla para salir");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Sólo valores entre 1 y 5 Gracias Imbécil");
                        break;
                }

            }
        }

        private void Modificar()
        {
            int codigo=0;
            bool correcto = false;
            while (!correcto)
            {
                try
                {
                    Console.WriteLine("Ingresa el código de la mascota");
                    codigo = int.Parse(Console.ReadLine());
                    correcto = true;
                }
                catch(FormatException)
                {
                    Console.WriteLine("El código ingresado no tiene el formato correcto");

                }
            }

            Mascota m = lista.Buscar(codigo);
            if(m!=null)
            {
                string nombre;
                DateTime fechaNacimiento=DateTime.Now;
                string especie;
                string raza;

                Console.WriteLine("Ingresa el nombre");
                nombre = Console.ReadLine();

                correcto = false;
                while (!correcto)
                {
                    try
                    {
                        Console.WriteLine("Ingresa la fecha");
                        fechaNacimiento = DateTime.Parse(Console.ReadLine());
                        correcto = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("El fomato de la fecha no es correcto");
                    }
                }
                Console.WriteLine("Ingresa la especie");
                especie = Console.ReadLine();

                Console.WriteLine("Ingresa la raza");
                raza = Console.ReadLine();

                m.Nombre = nombre;
                m.Raza = raza;
                m.FechaNacimiento = fechaNacimiento;
                m.Especie = especie;
                if(lista.Modificar(m))
                {
                    Console.WriteLine("Mascota Modificada");
                }
                else
                {
                    Console.WriteLine("No se pudo modificar");
                }

            }
            else
            {
                Console.WriteLine("No se ha encontrado la mascota");
            }
        }

        private void BuscarMascota()
        {
            int codigo=0;
            bool correcto = false;
            while(!correcto)
            {
                try
                {
                    Console.WriteLine("Ingresa el código de la mascota");
                    codigo = int.Parse(Console.ReadLine());
                    correcto = true;
                }
                catch(FormatException)
                {
                    Console.WriteLine("El nro del chip no tiene el formato correcto");

                }
            }

            Mascota e=lista.Buscar(codigo);
            if(e!=null)
            {
                Console.WriteLine("Datos de la mascota");
                Console.WriteLine("Código: " +  e.Codigo);
                Console.WriteLine("Nombre: " +  e.Nombre);
                Console.WriteLine("Fecha de Nacimiento: " + e.FechaNacimiento);
                Console.WriteLine("Especie: " + e.Especie);
                Console.WriteLine("Raza: " + e.Raza);

            }
            else
            {
                Console.WriteLine("No se ha encontrado la mascota");
            }
        }

        private void Eliminar()
        {
            int codigo = 0;
            bool correcto = false;
            while (!correcto)
            {
                try
                {
                    Console.WriteLine("Ingresa el nro del chip del animal");
                    codigo = int.Parse(Console.ReadLine());
                    correcto = true;
                    
                }
                catch(FormatException)
                {
                    Console.WriteLine("El nro del chip no tiene el formato correcto");

                }
            }

            if(lista.Eliminar(codigo))
            {
                Console.WriteLine("Mascota eliminada!");
            }
            else
            {
                Console.WriteLine("El código del chip no existe");
            }
        }
    }
}
