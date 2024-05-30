using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Course_work
{
    //class for displaying generated array on the screen
    public class DisplayingArray
    {
        private TextBox displayArrayBox;

        public DisplayingArray(TextBox textbox) 
        {
            displayArrayBox = textbox;
        }

        //writes all elements of arr into the text box
        public void Display(double[] arr)
        {
            displayArrayBox.Clear();

            for (int i = 0; i < arr.Length; i++)
            {
                displayArrayBox.AppendText(arr[i].ToString());

                if (i < arr.Length - 1)
                {
                    displayArrayBox.AppendText(";  ");
                }
            }
        }
    }
}
