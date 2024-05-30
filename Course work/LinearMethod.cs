using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Course_work
{
    public class LinearMethod : SearchMethod
    {
        
        //thу list will consist of the elements that were compared
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
        public LinearMethod()
        {
            Passed = new List<double>();
        } 

        //realization of linear method 
        public override int Search(double[] arr, double key)
        {
            Comp = 0;
            Passed.Clear();
            for (int i = 0; i < arr.Length; i++)
            {
                Comp++;
                Passed.Add(arr[i]);
                if (arr[i] == key)
                {
                    return i;
                }
            }
            return -1;
        }
        
    }
}
