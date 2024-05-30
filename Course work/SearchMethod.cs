using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Course_work
{
    //abstract class for different searching methods
    public abstract class SearchMethod
    {
        //method of searching element (key) in array (arr)
        public abstract int Search(double[] arr, double key);
    }
}
