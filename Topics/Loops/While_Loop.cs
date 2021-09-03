using System;

namespace Loops
{
    public class While_Loop
    {
        public static int Sum(int[] numbers)
        {
           
            var a = 0;
            var acumSumWhile = 0;
            while ( a < numbers.Length)
            {
                
                acumSumWhile = numbers[a] + acumSumWhile;
                a++;
            }
            return acumSumWhile;

            //var acumSum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    acumSum = numbers[i] + acumSum;
            //}
            //return acumSum;
        }

        public static int BinarySearch(int[] numbers, int item)
        {
            var inicio = 0;
            var final = numbers.Length;
           

            while (inicio < final)
            {
                var mitad = (inicio + final) / 2;
                if (item == numbers[mitad])
                {
                    return mitad;
                }
                else if (item > numbers[mitad])
                {
                    inicio = mitad;
                }
                else
                {
                    final = mitad;
                }
            }
            return -1;
        }
    }
}
