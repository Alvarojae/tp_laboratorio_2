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
        /// constructor predeterminado que setea al atributo en 0
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }


        /// <summary>
        /// constructor que inicializa su atributo con un doble
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this.numero = numero;
        }


        /// <summary>
        /// constructor que inicializa su atributo con un string pasandolo anteriormente por una validacion
        /// </summary>
        /// <param name="numero">valor que va a tomar el atributo</param>
        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }

        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }

      


        /// <summary>
        /// validatios of a string if is binary
        /// </summary>
        /// <param name="binario">string pasado para validar</param>
        /// <returns>true if is binary, false if is not </returns>
        private static bool EsBinario(string binario)
        {
            for (int i = 0; i < binario.Length; i++)
                if (!(binario[i] == '0' || binario[i] == '1'))
                    return false;
            return true;
        }

      

        /// <summary>
        /// convert a binary to decimal
        /// </summary>
        /// <param name="binario">binario pasado para la convercion </param>
        /// <returns> result of the convertion if is correct, 0 if isnt binary</returns>
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
        /// <summary>
        /// convert a decimal to binary
        /// </summary>
        /// <param name="numero">string sent to convert to binary </param>
        /// <returns>value of the convert or "-1" if cant convert the decimal </returns>
        public static string DecimalBinario(string numero)
        {
            int resultado = 0;
            if (int.TryParse(numero, out resultado))
            {
                int num = Math.Abs(resultado);
                string binario = String.Empty;
                do
                {
                    binario = Convert.ToString(num % 2) + binario;
                    num = num / 2;
                } while (num >= 1);
                return binario;
            }
            else
                return "-1";
        }

        /// <summary>
        /// convert a decimal to binary
        /// </summary>
        /// <param name="numero">double sent to convert to binary </param>
        /// <returns>value of the convert </returns>
        public static string DecimalBinario(double numero)
        {
            int num = Math.Abs((int)numero);
            string binario = String.Empty;
            do
            {
                binario = Convert.ToString(num % 2) + binario;
                num = num / 2;
            } while (num >= 1);
            return binario;
        }



        /// <summary>
        /// Valida si el valor pasado por parametro es un valor numerico
        /// </summary>
        /// <param name="strNumero">numero a validar</param>
        /// <returns>retorna numero si es correcto , 0 si no lo pasado no es un numero </returns>
        private static double ValidarNumero(string strNumero)
        {
            double resultado = 0;
            if (double.TryParse(strNumero, out resultado))
                return resultado;
            else
                return 0;
        }



        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator /(Numero n1, Numero n2)
        {
          if (n2.numero == 0)
             return double.MinValue;
          else
            return n1.numero / n2.numero;
        }
    }
}
