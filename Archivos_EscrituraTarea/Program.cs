using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace Archivos_EscrituraTarea
{
    class Program
    {
        class Persona
        {
            // Campos de la clase 
            public string Nombre;
            public int Edad; 

         //Constructor de la clase
          public Persona(string Nombre, int Edad)
          {
                this.Nombre = Nombre; 
                this.Edad = Edad; 
          }
            // Destructor de la clase persona
            ~Persona()
            {
                Console.WriteLine("Memoria liberada de la clase persona: "); 
            }

        }
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("ejemplo.txt",true);// Cambios
            // Si el archivo no existe lo creara
            // Si el archivo existe, escribira en el

          // Declaración de variables
            string Nom;
            int Edad; 
 
                Console.Write("\nIngresa el nombre: "); 
                Nom = Console.ReadLine();
                Console.Write("\nIngresa Edad : ");
                Edad = int.Parse(Console.ReadLine());
                Persona Datos = new Persona(Nom, Edad);

            sw.WriteLine("\n" + Datos.Nombre + " " + "\n" +
               Datos.Edad ); 

            sw.Close();
            Console.WriteLine("Escribiendo........");
            Console.ReadLine();
        }
    }
}
