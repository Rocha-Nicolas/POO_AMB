using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ABM
{
    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

    }


    internal class Program
    {

        static void Main(string[] args)
        {

            List<Persona> listaPersona = new List<Persona>();

            int opcion;

            do
            {
                Console.WriteLine(" >MENU: ");
                Console.WriteLine("1. Ingresar una persona");
                Console.WriteLine("2. Modificar una persona");
                Console.WriteLine("3. Dar baja a una persona");
                Console.WriteLine("4. Mostrar la lista de personas");
                Console.WriteLine("5. Salir");

                Console.WriteLine("Ingrese una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el nombre de la Persona:");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese la edad de la Persona: ");
                        int edad = int.Parse(Console.ReadLine());
                        listaPersona.Add(new Persona(nombre, edad));
                        Console.WriteLine("Se a ingresado una nueva Persona");
                        Console.WriteLine("");
                        break;

                    case 2:
                        Console.WriteLine("Ingrese el inidce de la persona que se desea Modificar: ");
                        int indice = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el nuevo nombre de la persona: ");
                        listaPersona[indice].Nombre = Console.ReadLine();
                        Console.Write("Ingrese la nueva edad de la persona: ");
                        listaPersona[indice].Edad = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nSe ha modificado la persona.\n");
                        Console.WriteLine("");
                        break;

                    case 3:
                        Console.WriteLine("Ingrese el indice de la persona que se desea eliminar");
                        int indiceEliminar = int.Parse(Console.ReadLine());
                        listaPersona.RemoveAt(indiceEliminar);
                        Console.WriteLine("Se a eliminado la persona");
                        Console.WriteLine("");
                        break;

                    case 4:
                        Console.WriteLine("-- Lista de Personas --");
                        foreach (Persona item in listaPersona)
                        {
                            Console.WriteLine("Nombre: {0}, Edad: {1}", item.Nombre, item.Edad);
                        }
                        Console.WriteLine("---");
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        Console.WriteLine("");
                        break;
                }

            }while(opcion!=5);

            Console.ReadKey();

        }
    }
}
