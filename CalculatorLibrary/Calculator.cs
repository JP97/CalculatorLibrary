using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Calculator
    {

        public static double Multiply(double v1, double v2)
        {

            return v1 * v2;
        }
        public static double Divide(double tal1, double tal2)
        {
            return tal1 / tal2;
        }
        public static double Minimum(double[] numbers)
        {
            

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[0] >= numbers[i])
                {
                    numbers[0] = numbers[i];
                }
            }
            return numbers[0];
        }
        public static double Maximum(double[] numbers)
        {
            double result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {

                if ( result < numbers[i])
                {
                    result = numbers[i];
                }
            }
            return result;
        }

        public static double Average(double[] numbers)
        {
            double result = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                result = result + numbers[i];
            }
            double resultat = result / numbers.Length;

            return resultat;
        }

        public static double Sum(double[] numbers)
        {
            double sum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public static double Add(double v1, double v2)
        {
            return v1 + v2;

        }

        public static double Subtract(double v1, double v2)
        {
            return v1 - v2;
        }
    }
}
