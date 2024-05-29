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

namespace Interface_Course_work
{
    public partial class ResultsForm : Form
    {
        private double[] array;
        private int index;
        private List<double> passedElements;
        private int comparisons;
        private double key;
        public ResultsForm(double[] arr, int ind, List<double> passed, int comp, double element)
        {
            InitializeComponent();
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

        private void DisplayResult()
        {
            SearchedIndexBox.Clear();
            ComplexityBox.Clear();
            ComplexityBox.AppendText($"Практична складність алгоритму: {comparisons} порівнянь.");
            if (index == -1)
            {
                SearchedIndexBox.AppendText("Вказаний елемент не знайдено.");
            }
            else
            {
                SearchedIndexBox.AppendText($"Вказаний елемент {key} має індекс {index}.");
            }
        }

        private void txtButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    writer.WriteLine($"Масив: \n{string.Join("; ", array)}");
                    writer.WriteLine($"\nІндекс елемента {key}: {index}");
                }
                MessageBox.Show("Файл створено успішно.");
            }
        }

        private void AnimationButton_Click(object sender, EventArgs e)
        {
            AnimationForm animationForm = new AnimationForm(array, index, passedElements, key);
            animationForm.Show();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
