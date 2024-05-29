using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCourseWork
{
    public class FibonacciMethod
    {
        public List<double> Passed
        {
            get;
            private set;
        }
        public int Comp
        {
            get;
            private set;
        }
        public FibonacciMethod()
        {
            Passed = new List<double>();
        }
    
        public int FibonacciSearch(double[] arr, double key)
        {
            Comp = 0;
            Passed.Clear();

            int fibM2 = 0;
            int fibM1 = 1;
            int fibM = fibM2 + fibM1;
            int n = arr.Length;

            while (fibM < n)
            {
                fibM2 = fibM1;
                fibM1 = fibM;
                fibM = fibM1 + fibM2;
            }

            int offset = -1;
           

            while (fibM2 >= 0)
            {
                int i = Math.Min(offset + fibM2, n - 1);
                Comp++;
                Passed.Add(arr[i]);

                if (arr[i] < key)
                {
                    fibM = fibM1;
                    fibM1 = fibM2;
                    fibM2 = fibM - fibM1;
                    offset = i;
                }
                else if (arr[i] > key)
                {
                    fibM = fibM2;
                    fibM1 = fibM1 - fibM2;
                    fibM2 = fibM - fibM1;
                }
                else
                    return i;
            }

            if (fibM1 == 1)
            {
                Comp++;
                Passed.Add(arr[offset + 1]);
            }
            if (fibM1 == 1 && arr[offset + 1] == key) 
            {
                return offset + 1;
            }

            return -1;
        }
    }
}
