using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Course_work
{
    //class for generation a sorted array of a specified dimension within specified limits
    public class ArrayGeneration
    {
        private double[] array;

        //creating of empty array, where dimension - number of elements
        public void EmptyArray(int dimension)
        {
            array = new double[dimension];
        }

        //process of generation the random array and sorting it
        //dimension - number of elements
        //lowerLimit and upperLimit - generation limits
        public double[] GenerateOrderedArray(int dimension, double lowerLimit, double upperLimit)
        {
            Random random = new();
            double number;
            for (int i = 0; i < dimension; i++)
            {
                number = lowerLimit + (random.NextDouble() * (upperLimit - lowerLimit));
                number = Math.Round(number, 2);
                array[i] = number;
            }
            Array.Sort(array);
            return array;
        }

        //returns already sorted array
        public double[] GetArray()
        {
            return array;
        }
    }
}

