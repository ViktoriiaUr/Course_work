using ClassLibraryCourseWork;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Interface_Course_work
{
    public partial class GenerationForm : Form
    {
        private GenerateArray generateArray;
        private LinearMethod linearMethod;
        private FibonacciMethod fibonacciMethod;
        private InterpolationMethod interpolationMethod;
        private HashMethod hashMethod;
        public const int DimensionMin = 10;
        public const int DimensionMax = 10000;
        public const int LimitMax = 10000;

        public GenerationForm()
        {
            InitializeComponent();
            generateArray = new GenerateArray();
            linearMethod = new LinearMethod();
            fibonacciMethod = new FibonacciMethod();
            interpolationMethod = new InterpolationMethod();
            hashMethod = new HashMethod();


            displayArrayBox.Visible = false;
            generatedArrayLabel.Visible = false;
            ElementToFindLabel.Visible = false;
            ElementBox.Visible = false;
            FindButton.Visible = false;
            methodLabel.Visible = false;
            ChooseMethodBox.Visible = false;
        }

        private void GenerationButton_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                dimensionBox.BackColor = Color.White;
                lowerLimitBox.BackColor = Color.White;
                upperLimitBox.BackColor = Color.White;
                double dimensionDouble = double.Parse(dimensionBox.Text);
                int dimension = (int)dimensionDouble;
                double lowerLimit = double.Parse(lowerLimitBox.Text);
                double upperLimit = double.Parse(upperLimitBox.Text);
                if (dimension > DimensionMax || dimension < DimensionMin)
                {
                    dimensionBox.BackColor = Color.Red;
                    MessageBox.Show($"��������� ������ �� ���� � ����� �� {DimensionMin} �� {DimensionMax}.");
                }
                if (lowerLimit < -LimitMax)
                {
                    lowerLimitBox.BackColor = Color.Red;
                    MessageBox.Show($"��� ������ ����� ���� � ����� �� -{LimitMax} �� {LimitMax}.");
                }
                if (upperLimit > LimitMax)
                {
                    upperLimitBox.BackColor = Color.Red;
                    MessageBox.Show($"��� ������ ����� ���� � ����� �� -{LimitMax} �� {LimitMax}.");
                }
                
                if (lowerLimit >= upperLimit)
                {
                    lowerLimitBox.BackColor = Color.Red;
                    upperLimitBox.BackColor = Color.Red;
                    MessageBox.Show("����� ���� ������� ���� ����� �������!");
                }
                else if (lowerLimit < upperLimit && lowerLimit >= -LimitMax && upperLimit <= LimitMax && dimension <= DimensionMax && dimension >= DimensionMin)
                {
                    generateArray.EmptyArray(dimension);
                    generateArray.GenerateOrderedArray(dimension, lowerLimit, upperLimit);
                    displayArrayBox.Clear();
                    ElementBox.Clear();
                    ChooseMethodBox.SelectedIndex = -1;
                    DisplayArray();
                    displayArrayBox.Visible = true;
                    generatedArrayLabel.Visible = true;
                    ElementToFindLabel.Visible = true;
                    ElementBox.Visible = true;
                    FindButton.Visible = true;
                    methodLabel.Visible = true;
                    ChooseMethodBox.Visible = true;
                    
                }
            }
        }

        private bool IsValidInput()
        {
            bool error = false;
            if (!(double.TryParse(dimensionBox.Text, out double dimensionDouble) ||
                dimensionDouble != (int)dimensionDouble))
            {
                if (string.IsNullOrWhiteSpace(dimensionBox.Text))
                {
                    dimensionBox.BackColor = Color.Red;
                    MessageBox.Show("��������� �� �������.");
                }
                else
                {
                    dimensionBox.BackColor = Color.Red;
                    MessageBox.Show("��������� ������� ����������. ������ ���� ����� (���������, 1000)");
                }
                error = true;
            }

            if (!double.TryParse(lowerLimitBox.Text, out _) || !IsValidDouble(lowerLimitBox.Text))
            {
                lowerLimitBox.BackColor = Color.Red;
                if (string.IsNullOrWhiteSpace(lowerLimitBox.Text))
                {
                    MessageBox.Show("����� ���� �� �������.");
                }
                else if (!IsValidDouble(upperLimitBox.Text))
                {
                    MessageBox.Show("����� ���� ������� ����������. ����������� ������� ����� ���� ���� - 16.");
                }
                else
                {
                    MessageBox.Show("����� ���� ������� ����������. ����������o ���������� �������.");
                }
                error = true;
            }

            if (!double.TryParse(upperLimitBox.Text, out _) || !IsValidDouble(upperLimitBox.Text))
            {
                upperLimitBox.BackColor = Color.Red;
                if (string.IsNullOrWhiteSpace(upperLimitBox.Text))
                {
                    MessageBox.Show("������ ���� �� �������.");
                }
                else if (!IsValidDouble(upperLimitBox.Text))
                {
                    MessageBox.Show("������ ���� ������� ����������. ����������� ������� ����� ���� ���� - 16.");
                }
                else
                {
                    MessageBox.Show("������ ���� ������� ����������. ����������o ���������� �������.");
                }
                error = true;
            }
            return !error;
        }

        private bool IsValidDouble(string input)
        {
            if (input.Length > 20) // ����������� ������� �����
            {
                return false;
            }
            string[] parts = input.Split(',');
            if (parts.Length == 2 && parts[1].Length > 16) // ����������� ������� ���������� �����
            {
                return false;
            }
            return true;
        }

        private void DisplayArray()
        {
            double[] array = generateArray.GetArray();
           // displayArrayBox.Clear();
            

            for (int i = 0; i < array.Length; i++)
            {
                displayArrayBox.AppendText(array[i].ToString());

                if (i < array.Length - 1)
                {
                    displayArrayBox.AppendText(";  ");
                }
            }
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            ElementBox.BackColor = Color.White;
            if (!double.TryParse(ElementBox.Text, out double searchKey) || !IsValidDouble(ElementBox.Text))
            {
                ElementBox.BackColor = Color.Red;
                if (!IsValidDouble(upperLimitBox.Text))
                {
                    MessageBox.Show("������� ������� ����������. ����������� ������� ����� ���� ���� - 16.");
                }
                else
                {
                    MessageBox.Show("������� ������� ����������. ����������o ���������� �������.");
                }
                return;
            }
            if (ChooseMethodBox.SelectedItem == null)
            {
                MessageBox.Show("����� ������ �� ������!");
            }
            else
            {
                int index = -1;
                double[] array = generateArray.GetArray();
                List<double> passedElem = [];
                int comparisons = 0;
                string selectedMethod = ChooseMethodBox.SelectedItem.ToString();
                switch (selectedMethod)
                {
                    case "���������� �����":
                        index = linearMethod.LinearSearch(array, searchKey);
                        passedElem = linearMethod.Passed;
                        comparisons = linearMethod.Comp;
                        break;
                    case "����� Գ�������":
                        index = fibonacciMethod.FibonacciSearch(array, searchKey);
                        passedElem = fibonacciMethod.Passed;
                        comparisons = fibonacciMethod.Comp;
                        break;
                    case "��������������� �����":
                        index = interpolationMethod.InterpolationSearch(array, searchKey);
                        passedElem = interpolationMethod.Passed;
                        comparisons = interpolationMethod.Comp;
                        break;
                    case "����� ���-�������":
                        hashMethod.BuildHashTable(array);
                        index = hashMethod.HashSearch(array, searchKey);
                        passedElem = hashMethod.Passed;
                        comparisons = hashMethod.Comp;
                        break;
                    default:
                        MessageBox.Show("������ ����� ������ � ������.");
                        break;                   
                }
                ResultsForm resultsForm = new(array, index, passedElem, comparisons, searchKey);
                resultsForm.Show();
            }
        }

        private void InstructionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("��������� �� ���� ����� ��������� � ����� [10; 10 000].\n��� ����������� - ���� �����, �� �������� ������� [-10 000; 10 000].\n������ ����� ���������� ����� ���� �� 16 ����� � ������� ������ (���������, 425,32)");
        }
    }
}
