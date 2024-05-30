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
    //window for graphical display of array and searching the element
    public partial class AnimationForm : Form
    {
        private MatrixDisplayingArray matrixDisplayingArray;
        private Animation animation;
        private double[] array;
        private int index;
        private List<double> passaedElements;
        private double key;

        public AnimationForm(double[] arr, int ind, List<double> passed, double element)
        {
            InitializeComponent();
            matrixDisplayingArray = new MatrixDisplayingArray();
            animation = new Animation();
            array = arr;
            index = ind;
            passaedElements = passed;
            key = element;

            ResultBox.Visible = false;

            SearchedElementBox.AppendText($"Елемент {key}");
            matrixDisplayingArray.DisplayArray(ArrayDataGrid, array);
            animation.AnimationSearch(array, passaedElements, index, ArrayDataGrid, ResultBox);
        }

        //when GoBackButton is clicked, ResultsForm window closes
        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
