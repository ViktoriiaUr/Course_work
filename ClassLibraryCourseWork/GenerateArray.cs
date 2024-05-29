using System.Drawing;

namespace ClassLibraryCourseWork
{
    public class GenerateArray
    {
        private double[] array;

        public void EmptyArray(int dimension)
        {
            array = new double[dimension];
        }

        public void GenerateOrderedArray(int dimension, double lowerLimit, double upperLimit)
        {
            Random random = new ();
            double number;
            for (int i = 0; i < dimension; i++) 
            {
                number = lowerLimit + (random.NextDouble() * (upperLimit - lowerLimit));
                number = Math.Round(number, 2);
                array[i] = number;
            }
            Array.Sort(array);
        }

        public double[] GetArray()
        {
            return array;
        }
    }   
}
