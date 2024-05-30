using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Windows.Forms;

namespace Interface_Course_work
{ 
    //class for displaying array like matrix
    public class MatrixDisplayingArray
    {
        //displays array in matrix with 10 columns data grid
        public void DisplayArray(DataGridView dataGridView, double[] arr)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            int columns = 10;
            int rows = arr.Length % columns == 0 ? arr.Length / columns - 1 : arr.Length / columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridView.Columns.Add(i.ToString(), i.ToString());
                dataGridView.Columns[i].Width = 68;
            }
            for (int i = 0; i < rows; i++)
            {
                dataGridView.Rows.Add();
            }
            for (int i = 0; i < arr.Length; i++)
            {
                int rowIndex = i / columns;
                int columnIndex = i % columns;
                dataGridView.Rows[rowIndex].Cells[columnIndex].Value = arr[i];
            }
        }
    }
}
