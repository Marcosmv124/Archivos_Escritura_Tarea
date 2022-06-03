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
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("ejemplo.txt",true);// Cambios
            // Si el archivo no existe lo creara
            // Si el archivo existe, escribira en el

            string[] Lines =
            {
                "Esto es la primera Linea",
                "Esto es la segunda Linea",
                "Esto es la tercera Linea",
                "Esto es la cuarta Linea"
            };

            foreach (string Line in Lines)
            {
                sw.WriteLine(Line);
            }
            sw.Close();

            Console.WriteLine("Escribiendo........");
            Console.ReadLine();
        }
    }
}
