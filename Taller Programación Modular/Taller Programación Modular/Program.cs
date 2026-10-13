using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_Programación_Modular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            int vocales = 0;
            int consonantes = 0;
            string vls = "aeiouAEIOU";

            Console.WriteLine("Ingrese una palabra:");
            palabra = Console.ReadLine();

     
            foreach (char c in palabra)
            {
                if (char.IsLetter(c)) 
                {
                    if (vls.Contains(c))
                    {
                        vocales++;
                    }
                    else 
                    {
                        consonantes++;
                    }
                }
            }

            Console.WriteLine("Palabra ingresada: " + palabra);
            Console.WriteLine("Cantidad de vocales: " + vocales);
            Console.WriteLine("Cantidad de consonantes: " + consonantes);

            Console.ReadLine();
        }

    }

}

