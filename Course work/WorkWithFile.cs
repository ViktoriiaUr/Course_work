using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Windows.Forms;

namespace Interface_Course_work
{
    //class to 
    public class WorkWithFile
    {
        //method saves array (arr) and index of searched element (key)
        //uses the path that user chosed in saveFileDialog
        public void SaveToFile(double[] arr, double key, int index)
        {
            SaveFileDialog saveFileDialog = new()
            {
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new(saveFileDialog.FileName))
                {
                    writer.WriteLine($"Масив: \n{string.Join("; ", arr)}");
                    writer.WriteLine($"\nІндекс елемента {key}: {index}");
                }
                MessageBox.Show("Файл створено успішно.");
            }
        }
    }
}
