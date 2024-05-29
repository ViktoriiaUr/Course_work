using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Interface_Course_work
{
    public partial class AnimationForm : Form
    {
        private double[] array;
        private int index;
        private List<double> passaedElements;
        private double key;

        public AnimationForm(double[] arr, int ind, List<double> passed, double element)
        {
            InitializeComponent();
            array = arr;
            index = ind;
            passaedElements = passed;
            key = element;

            NoElementLabel.Visible = false;
            DisplayArray();
            AnimationSearch();
        }

        private void DisplayArray()
        {
            SearchedElementBox.AppendText($"Елемент {key}");
            ArrayDataGrid.Rows.Clear();
            ArrayDataGrid.Columns.Clear();

            int columns = 10;
            //int rows = (int)array.Length / columns;
            int rows = array.Length % columns == 0 ? array.Length / columns - 1 : array.Length / columns;


            for (int i = 0; i < columns; i++)
            {
                ArrayDataGrid.Columns.Add(i.ToString(), i.ToString());
                ArrayDataGrid.Columns[i].Width = 68;
            }
            for (int i = 0; i < rows; i++)
            {
                ArrayDataGrid.Rows.Add();
            }
            for (int i = 0; i < array.Length; i++)
            {
                int rowIndex = i / columns;
                int columnIndex = i % columns;
                ArrayDataGrid.Rows[rowIndex].Cells[columnIndex].Value = array[i];
            }
        }

        private async void AnimationSearch()
        {
            int columns = 10;
            foreach (var element in passaedElements)
            {
                int i = Array.IndexOf(array, element);
                int rowIndex = i / columns;
                int colIndex = i % columns;
                await Task.Delay(800);
                ArrayDataGrid.Rows[rowIndex].Cells[colIndex].Style.BackColor = Color.Yellow;
            }

            if (index != -1)
            {
                int rowIndex = index / columns;
                int colIndex = index % columns;
                ArrayDataGrid.Rows[rowIndex].Cells[colIndex].Style.BackColor = Color.LightGreen;
            }
            else
                NoElementLabel.Visible = true;
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
