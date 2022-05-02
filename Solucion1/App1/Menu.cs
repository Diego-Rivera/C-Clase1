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


                        Console.WriteLine("Ingresa la fecha");
                        fechaNacimiento = DateTime.Parse(Console.ReadLine());


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
                        Console.WriteLine("Presionó 2");
                        break;
                    case "3":
                        Console.WriteLine("Presionó 3");
                        break;
                    case "4":
                        Console.WriteLine("Presionó 4");
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
    }
}
