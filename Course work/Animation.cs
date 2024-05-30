using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Interface_Course_work
{
    //class for graphical display of searching
    public class Animation
    {
        //method for graphical display in data grid
        //it uses list of passed elements
        public async void AnimationSearch(double[] arr, List<double> passed, int index, DataGridView dataGridView, TextBox ResultBox)
        {
            int columns = 10;
            foreach (var element in passed)
            {
                int i = Array.IndexOf(arr, element);
                int rowIndex = i / columns;
                int colIndex = i % columns;
                await Task.Delay(800);
                dataGridView.Rows[rowIndex].Cells[colIndex].Style.BackColor = Color.Yellow;
            }

            if (index != -1)
            {
                int rowIndex = index / columns;
                int colIndex = index % columns;
                dataGridView.Rows[rowIndex].Cells[colIndex].Style.BackColor = Color.LightGreen;
                ResultBox.Visible = true;
                ResultBox.AppendText($"Індекс {index}");
            }
            else
            {
                ResultBox.Visible = true;
                ResultBox.AppendText("Вказаний елемент не знайдено");
            }
        }
    }
}
