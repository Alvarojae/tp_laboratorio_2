using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// validate the operator of the calculator 
        /// </summary>
        /// <param name="operador">operator send to validate </param>
        /// <returns>return the operator if is correct if not return "+" </returns>
        private static string ValidarOperador(char operador)
        {
            if(operador == '+' || operador == '-' || operador == '*' || operador == '/')
            {
                return operador.ToString();
            }
            return "+";
        }

        /// <summary>
        /// operates with the objects
        /// </summary>does the operation between the two objects of the class
        /// <param name="num1">first object to operate</param>
        /// <param name="num2">second object to operate</param>
        /// <param name="operador">the operator of the math account </param>
        /// <returns>account result</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double cuenta = 0;
            if (operador != "")
            {
                switch (ValidarOperador(Convert.ToChar(operador)))
                {
                    case "+":
                        cuenta = num1 + num2;
                        break;
                    case "-":
                        cuenta = num1 - num2;
                        break;
                    case "*":
                        cuenta = num1 * num2;
                        break;
                    case "/":
                        cuenta = num1 / num2;
                        break;
                }
            }  else
                cuenta = num1 + num2;

            return cuenta;
        }
    }
}
