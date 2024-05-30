using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Course_work
{
    public class InterpolationMethod : SearchMethod
    {
        public List<double> Passed
        {
            get;
            private set;
        }
        public InterpolationMethod()
        {
            Passed = new List<double>();
        }
        //number of comparisons
        public int Comp
        {
            get;
            private set;
        }
        //realization of interpolation search
        public override int Search(double[] arr, double key)
        {
            Comp = 0;
            Passed.Clear();

            int low = 0;
            int high = arr.Length - 1;
            while (low <= high && key >= arr[low] && key <= arr[high])
            {
                if (low == high)
                {
                    Comp++;
                    Passed.Add(arr[low]);
                    if (arr[low] == key)
                        return low;
                    return -1;
                }
                int pos = low + (int)((high - low) * (key - arr[low]) / (arr[high] - arr[low]));
                
                Comp++;
                Passed.Add(arr[pos]);
                if (arr[pos] == key)
                {
                    return pos;
                }
                if (arr[pos] < key)
                {
                    low = pos + 1;
                }
                else
                    high = pos - 1;
            }
            return -1;
        }
    }
}
