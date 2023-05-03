using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nachoOpera
{
    public class operaciones
    {
        /// <summary>
        /// metodo sumar
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static double sumar(double num1, double num2)
        {
            return num1 + num2;
        }
        /// <summary>
        /// metodo restar
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static double restar(double num1, double num2)
        {
            return num1 - num2;
        }
        /// <summary>
        /// metodo multipicar
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static double multiplicacion(double num1, double num2)
        {
            return num1 * num2;
        }
        /// <summary>
        /// metodo dividir 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static double division(double num1, double num2)
        {
            if(num2 == 0)
            {
                Console.WriteLine(" Division por 0 no existe");
            }
                return num1 / num2;
            
            
        }
    }
}
