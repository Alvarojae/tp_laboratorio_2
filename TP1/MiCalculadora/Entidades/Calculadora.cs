using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {

        private static string ValidarOperador(char operador)
        {
            if(operador == '+' || operador == '-' || operador == '*' || operador == '/')
            {
                return operador.ToString();
            }
            return "+";
        }

        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double cuenta = 0;
            if (operador == "")
                operador = "+";
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
            return cuenta;
        }
    }
}
