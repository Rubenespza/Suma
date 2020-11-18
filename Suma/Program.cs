using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear o declarar las variables a utilizar
            int n1, n2, s;

            //Preguntar el valor del primer numero
            Console.Write("N1: ");

            n1 = Int32.Parse(Console.ReadLine());
            //Preguntar el valor del segundo numero
            Console.Write("N2: ");
            n2 = Int32.Parse(Console.ReadLine());

            //Restar
            s = n1 + n2;
            
            //Mostrar el resultado
            Console.Write("A suma es" + s);
            Console.ReadKey();
        }
    }
}
