using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        public static double Operar(Numero num1, Numero num2,String operador)
        {
            if(operador == "+")
                return (num1 + num2);
            if (operador == "-")
                return (num1 - num2);
            if (operador == "/")
                return (num1 / num2);
            if (operador == "*")
                return (num1 * num2);
            else
                return 0;
        }
    }
}
