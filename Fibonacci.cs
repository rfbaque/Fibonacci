using System;

namespace FibonacciApi
{
    public class Fibonacci : IFibonacci
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public Fibonacci()
        {
        }

        static int[] GetFibonacciSeries(int size)
        {
            int[] serie = new int[size + 1];

            if (size == 0)
                serie[0] = 0;

            else if (size == 1)
                serie[1] = 1;

            else
            {
                serie[0] = 0;
                serie[1] = 1;

                for (int contador = 2; contador <= size; contador++)
                    serie[contador] = serie[contador - 1] + serie[contador - 2];
            }

            return serie;
        }

        /// <summary>
        /// Returns an integer representing the Fibonacci series value requested by parameter. 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int GetValueOfFibonacciSeries(int index)
        {
            var serie = GetFibonacciSeries(index);
            return serie[index];
        }
    }
}
