using System;
using System.Windows.Forms;

namespace Laba4
{
    public partial class Form1 : Form
    {
        private Perceptron percept;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            var perceptron = new Perceptron((int) numericUpDownClassCount.Value,
                (int) numericUpDownObjectsInClassCount.Value, (int) numericUpDownAttributesCount.Value);
            perceptron.Calculate();
            perceptron.FillListBox(listBox, listBoxFunctions);
            percept = perceptron;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var testObj = new Perceptron.PerceptronObject();
            string[] numbersStr = textBox1.Text.Split(';');
            var numbers = new int[numbersStr.Length];
            try
            {
                for (int i = 0; i < numbersStr.Length; i++)
                {
                    numbers[i] = Convert.ToInt32(numbersStr[i]);
                }
                if (numbers.Length == numericUpDownAttributesCount.Value)
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        testObj.attributes.Add(numbers[i]);
                    }
                }
                else
                {
                    MessageBox.Show("Некорректный ввод тестовой сборки");
                }
                MessageBox.Show(String.Format("Объект относится к {0} классу", percept.FindClass(testObj)));
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректный ввод тестовой сборки");
            }
        }
    }
}