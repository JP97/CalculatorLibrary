using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Calculator
    {
        public double Multiply(double tal1, double tal2)
        {

            double result = tal1 * tal2;

            return result;
        }
        public double Divide(double tal1, double tal2)
        {
            double result = tal1 / tal2;
            return result;
        }
        public double Minimum(double[] numbers)
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
        public double Maximum(double[] numbers)
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
        
        public double Average(double[] numbers)
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
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        }
    }
}
