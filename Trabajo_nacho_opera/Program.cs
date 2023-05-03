using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nachoOpera;

namespace Trabajo_nacho_opera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Ingrese el primer numero ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Ingrese el segundo numero ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double suma = operaciones.sumar(num1, num2);
            double resta = operaciones.restar(num1, num2);
            double mult = operaciones.multiplicacion(num1, num2);
            double div = operaciones.division(num1, num2);

            Console.WriteLine(" El resultado de la suma es: " + suma);
            Console.WriteLine(" El resultado de la resta es: " + resta);
            Console.WriteLine(" El resultado de la multiplicacion es: " + mult);
            if(num2 == 0)
            {
                Console.WriteLine(" Division por 0 no existe");
            }
            else
            {
                Console.WriteLine(" El resultado de la division es: " + div);
            }
            
            Console.ReadLine();
        }
    }
}
