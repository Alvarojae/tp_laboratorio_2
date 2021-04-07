using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        /// <summary>
        /// 
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this.numero = numero;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="numero"></param>
        public Numero(string numero)
        {
            this.SetNumero = numero;
        }

        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="n1">Objeto primer numero </param>
        /// <param name="n2">Objeto segundo numero </param>
        /// <returns>La divicion de los dos Numeros</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            return n1.numero / n2.numero;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        private static bool EsBinario(string binario)
        {
            for (int i = 0; i < binario.Length; i++)
                if (!(binario[i] == '0' || binario[i] == '1'))
                    return false;
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        private static double ValidarNumero(string strNumero)
        {
            double resultado = 0;
            if (double.TryParse(strNumero, out resultado))
                return resultado;
            else
                return 0;
        }


        public static string BinarioDecimal(string binario)
        {
            int potencia=1;
            int resultado=0;
            if(EsBinario(binario))
            {
                for (int i = binario.Length - 1; i >= 0; i--)
                {
                    if (binario[i] == '1')
                        resultado = resultado + (1 * potencia);
                    potencia = potencia * 2;
                }
            }
            return resultado.ToString();
        }

        public static string DecimalBinario(string numero)
        {
            int num = (int)double.Parse(numero);
            string binario = String.Empty;
            do
            {
                binario = Convert.ToString(num % 2) + binario;
                num = num / 2;
            } while (num >= 1);
            return binario;
        }


        public static string DecimalBinario(double numero)
        {
            int num = (int)numero;
            string binario = String.Empty;
            do
            {
                binario = Convert.ToString(num % 2) + binario;
                num = num / 2;
            } while (num >= 1);
            return binario;
        }
    }
}
