using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.CodeAnalysis;

namespace Interface_Course_work
{
    //window of the program where results appears
    //there is buttons to save txt file and open graphical display of searching
    public partial class ResultsForm : Form
    {
        private WorkWithFile workWithFile;
        private double[] array;
        private int index;
        private List<double> passedElements;
        private int comparisons;
        private double key;
        public ResultsForm(double[] arr, int ind, List<double> passed, int comp, double element)
        {
            InitializeComponent();
            workWithFile = new WorkWithFile();
            array = arr;
            index = ind;
            passedElements = passed;
            comparisons = comp;
            key = element;

            if (array.Length <= 100)
            {
                AnimationButton.Visible = true;
            }
            else
                AnimationButton.Visible = false;

            DisplayResult();
        }

        //this method displays the results of searching in text boxes
        private void DisplayResult()
        {
            SearchedIndexBox.Clear();
            ComplexityBox.Clear();
            ComplexityBox.AppendText($"Практична складність алгоритму: {comparisons} порівнянь.");
            if (index == -1)
            {
                SearchedIndexBox.AppendText($"Вказаний елемент {key} не знайдено.");
            }
            else
            {
                SearchedIndexBox.AppendText($"Вказаний елемент {key} має індекс {index}.");
            }
        }

        //when txtButton is clicked, array with index of searched element (key) is written to created file
        private void txtButton_Click(object sender, EventArgs e)
        {
            workWithFile.SaveToFile(array, key, index);
        }

        //when AnimationButton is clicked, AnimationForm window for graphical display opens
        private void AnimationButton_Click(object sender, EventArgs e)
        {
            AnimationForm animationForm = new(array, index, passedElements, key);
            animationForm.Show();
        }

        //when GoBackButton is clicked, ResultsForm window closes
        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
