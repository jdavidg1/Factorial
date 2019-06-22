using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa para calcular el factorial de un número

            int n=0,numero = 0, resultado=1;

            Console.Write("Cual es el número a calcular el factorial: ");

            numero = Convert.ToInt32(Console.ReadLine());
            

            for(n=numero; n>=1; n--)
            {
                
                resultado *= n;
                
            }
            
            Console.WriteLine($"El factorial de {numero} es {resultado}");
            Console.ReadKey();
                
                
        }
    }
}
