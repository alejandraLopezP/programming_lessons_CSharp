using System;

namespace Loops
{
    public class For_Loop
    {
        //returns the position of the item if found, else returns -1
        public static int LinearSearch(int[] numbers, int item)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == item)
                {
                    return i;
                }
                
            }
            return -1;
        }

        //return the max number of the array
        public static int FindMaxNumber(int[] numbers)
        {
            int maxTmp = int.MinValue;//que le vaya cambiando el valor a ésta variable mediante una comparacion
            //4,5,0,12,1
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxTmp)
                {
                    maxTmp = numbers[i];
                }
            }
            return maxTmp;
        }


        //returns the result of multiplying a and b without using built-in function
        public static int Multiplication(int a, int b)
        {
            int acumSum = 0;
            for (int i = 0; i < b; i++)
            {
                acumSum = a + acumSum;
            }
            return acumSum;
        }


        public static float Average(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                throw new Exception("Empty array");
            }
            int acumSum = 0;
            //3,1,4     3
            for (int i = 0; i < numbers.Length; i++)
            {
                acumSum = numbers[i] + acumSum;
            }
            return acumSum / numbers.Length;
        }

        public static int LinearPower(int a, int b)
        {
            int acumMulti = 1;
            for (int i = 0; i < b; i++)
            {
                acumMulti = a * acumMulti;
            }
            return acumMulti;
        }

        public static int LinearPower2(int a, int b)
        {
            int acumMulti = 1;
            for (int i = 0; i < b; i++)
            {
                acumMulti = Multiplication(a, acumMulti);
            }
            return acumMulti;
        }

        public static int Factorial(int a)
        {
            int acumProd = 1;
            //1*2*3*4
            for (int i = 1; i <= a; i++)
            {
                acumProd = i * acumProd;
            }
            return acumProd;
        }
    }
}