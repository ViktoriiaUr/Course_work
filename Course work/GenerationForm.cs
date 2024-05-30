using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Interface_Course_work
{
    //main window of program, where user can enter dimension, limits, searching element and method
    public partial class GenerationForm : Form
    {
        private ArrayGeneration arrayGeneration;
        private DisplayingArray displayingArray;
        private LinearMethod linearMethod;
        private FibonacciMethod fibonacciMethod;
        private InterpolationMethod interpolationMethod;
        private HashMethod hashMethod;
        private const int DimensionMin = 10;
        private const int DimensionMax = 10000;
        private const int LimitMax = 10000;

        public GenerationForm()
        {
            InitializeComponent();
            arrayGeneration = new ArrayGeneration();
            displayingArray = new DisplayingArray(displayArrayBox);
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

        //when GenerationButton is clicked, array is generating and displaying in displayArrayBox
        //validation of entered data
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
                    MessageBox.Show($"Розмірність масиву має бути в межах від {DimensionMin} до {DimensionMax}.");
                }
                if (lowerLimit < -LimitMax)
                {
                    lowerLimitBox.BackColor = Color.Red;
                    MessageBox.Show($"Межі масиву мають бути в межах від -{LimitMax} до {LimitMax}.");
                }
                if (upperLimit > LimitMax)
                {
                    upperLimitBox.BackColor = Color.Red;
                    MessageBox.Show($"Межі масиву мають бути в межах від -{LimitMax} до {LimitMax}.");
                }
                
                if (lowerLimit >= upperLimit)
                {
                    lowerLimitBox.BackColor = Color.Red;
                    upperLimitBox.BackColor = Color.Red;
                    MessageBox.Show("Нижня межа повинна бути менше верхньої!");
                }
                else if (lowerLimit < upperLimit && lowerLimit >= -LimitMax && upperLimit <= LimitMax && dimension <= DimensionMax && dimension >= DimensionMin)
                {
                    arrayGeneration.EmptyArray(dimension);
                    double[] array = arrayGeneration.GenerateOrderedArray(dimension, lowerLimit, upperLimit);
                    displayArrayBox.Clear();
                    ElementBox.Clear();
                    ChooseMethodBox.SelectedIndex = -1;
                    displayingArray.Display(array);
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

        //checks whether all boxes are filled correctly
        private bool IsValidInput()
        {
            bool error = false;
            //checking for dimensionBox
            if (!double.TryParse(dimensionBox.Text, out double dimensionDouble) || dimensionDouble != (int)dimensionDouble)
            {
                if (string.IsNullOrWhiteSpace(dimensionBox.Text))
                {
                    dimensionBox.BackColor = Color.Red;
                    MessageBox.Show("Розмірність не вказана.");
                }
                else
                {
                    dimensionBox.BackColor = Color.Red;
                    MessageBox.Show("Розмірність введена некоректно. Вкажіть ціле число (наприклад, 1000).");
                }
                error = true;
            }

            //checking for lowerLimitBox
            if (!double.TryParse(lowerLimitBox.Text, out _) || !IsValidDouble(lowerLimitBox.Text))
            {
                lowerLimitBox.BackColor = Color.Red;
                if (string.IsNullOrWhiteSpace(lowerLimitBox.Text))
                {
                    MessageBox.Show("Нижня межа не вказана.");
                }
                else if (!IsValidDouble(upperLimitBox.Text))
                {
                    MessageBox.Show("Нижня межа введена некоректно. Максимальна кількість знаків після коми - 16.");
                }
                else
                {
                    MessageBox.Show("Нижня межа введена некоректно. Використанo недопустимі символи.");
                }
                error = true;
            }

            //checking for upperLimitBox
            if (!double.TryParse(upperLimitBox.Text, out _) || !IsValidDouble(upperLimitBox.Text))
            {
                upperLimitBox.BackColor = Color.Red;
                if (string.IsNullOrWhiteSpace(upperLimitBox.Text))
                {
                    MessageBox.Show("Верхня межа не вказана.");
                }
                else if (!IsValidDouble(upperLimitBox.Text))
                {
                    MessageBox.Show("Верхня межа введена некоректно. Максимальна кількість знаків після коми - 16.");
                }
                else
                {
                    MessageBox.Show("Верхня межа введена некоректно. Використанo недопустимі символи.");
                }
                error = true;
            }
            return !error;
        }

        //checks that maximum number of characters after the comma (not more than 16)
        private bool IsValidDouble(string input)
        {
            if (input.Length > 20)
            {
                return false;
            }
            string[] parts = input.Split(',');
            if (parts.Length == 2 && parts[1].Length > 16) 
            {
                return false;
            }
            return true;
        }

        //when FindButton is clicked, the program searches element depending on the chosen method
        //methods returns index of element, number of comparisons and the list of elements which were compared
        private void FindButton_Click(object sender, EventArgs e)
        {
            ElementBox.BackColor = Color.White;
            //checking for ElementBox
            if (!double.TryParse(ElementBox.Text, out double searchKey) || !IsValidDouble(ElementBox.Text))
            {
                ElementBox.BackColor = Color.Red;
                if (!IsValidDouble(upperLimitBox.Text))
                {
                    MessageBox.Show("Елемент введено некоректно. Максимальна кількість знаків після коми - 16.");
                }
                else
                {
                    MessageBox.Show("Елемент введено некоректно. Використанo недопустимі символи.");
                }
                return;
            }
            if (ChooseMethodBox.SelectedItem == null)
            {
                MessageBox.Show("Метод пошуку не обрано!");
            }
            else
            {
                int index = -1;
                double[] array = arrayGeneration.GetArray();
                List<double> passedElem = [];
                int comparisons = 0;
                string selectedMethod = ChooseMethodBox.SelectedItem.ToString();
                switch (selectedMethod)
                {
                    case "послідовний метод":
                        index = linearMethod.Search(array, searchKey);
                        passedElem = linearMethod.Passed;
                        comparisons = linearMethod.Comp;
                        break;
                    case "метод Фібоначчі":
                        index = fibonacciMethod.Search(array, searchKey);
                        passedElem = fibonacciMethod.Passed;
                        comparisons = fibonacciMethod.Comp;
                        break;
                    case "інтерполяційний метод":
                        index = interpolationMethod.Search(array, searchKey);
                        passedElem = interpolationMethod.Passed;
                        comparisons = interpolationMethod.Comp;
                        break;
                    case "метод хеш-функції":
                        hashMethod.BuildHashTable(array);
                        index = hashMethod.Search(array, searchKey);
                        passedElem = hashMethod.Passed;
                        comparisons = hashMethod.Comp;
                        break;
                    default:
                        MessageBox.Show("Оберіть метод пошуку зі списку.");
                        break;                   
                }
                ResultsForm resultsForm = new(array, index, passedElem, comparisons, searchKey);
                resultsForm.Show();
            }
        }

        private void InstructionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Розмірність має бути цілим значенням у межах [10; 10 000].\nМежі генерування - дійсні числа, що належать проміжку [-10 000; 10 000].\nДробові числа записувати через кому до 16 знаків в дробовій частині (наприклад, 425,32)");
        }
    }
}
