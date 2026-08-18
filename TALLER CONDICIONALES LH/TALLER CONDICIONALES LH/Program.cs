using System;

namespace TALLER_CONDICIONALES_LH
{
    internal class Program
    {
        static void Main(string[] args);

        Console.WriteLine("Ingrese el numero 1:");
            int numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el numero 2:");
            int numero2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el numero 3:");
            int numero3 = int.Parse(Console.ReadLine());

        if (numero1 == numero2 || numero1 == numero3 || numero2 == numero3)
        {
            Console.WriteLine("Error: Se deben ingresar numeros diferentes.");
        }
        else 
        {
          int mayor = numero1;
          #if (numero2 > mayor) mayor = numero2;
          if (numero3 > mayor) mayor = numero3;

          
        }
    }
    }
}
