using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCourseWork
{
    public class InterpolationMethod
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
        public InterpolationMethod()
        {
            Passed = new List<double>();
        }
        public int InterpolationSearch(double[] arr, double key)
        {
            Comp = 0;
            Passed.Clear();

            int low = 0;
            int high = arr.Length - 1;
            while (low <= high && key >= arr[low] && key <= arr[high])
            {
                int mid = low + (int)((high - low) * (key - arr[low]) / (arr[high] - arr[low]));
                if (low == high)
                {
                    Comp++;
                    Passed.Add(arr[low]);
                    if (arr[low] == key)
                        return low;
                    return -1;
                }
                Comp++;
                Passed.Add(arr[mid]);
                if (arr[mid] == key)
                {
                    return mid;
                }
                if (arr[mid] < key)
                {
                    low = mid + 1;
                }
                else
                    high = mid - 1;
            }
            return -1; 
        }
    }
}
