using System;
using System.Windows;
using System.Windows.Controls;

namespace CalculatorApp.Views
{
    /// <summary>
    /// MainView.xaml の相互作用ロジック
    /// </summary>
    public partial class MainView : Window
    {

        double number1 = 0;
        double number2 = 0;

        string operation = "";
        public MainView()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            if (((Button)sender).Content.ToString() == "0" && ResultBox.Text == "0")
            {
                return;
            }
            if (string.IsNullOrEmpty(operation))
            {
                number1 = double.Parse(string.Concat(number1, ((Button)sender).Content));
                ResultBox.Text = number1.ToString();
            }
            else
            {
                number2 = double.Parse(string.Concat(number2, ((Button)sender).Content));
                ResultBox.Text = number2.ToString();
            }
        }

        private void MathOperationButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(operation))
            {             
                switch (operation)
                {
                    case "＋":
                        number1 += number2;
                        break;
                    case "－":
                        number1 -= number2;
                        break;
                    case "×":
                        number1 *= number2;
                        break;
                    case "÷":
                        if (number2 == 0)
                        {
                            ResultBox.Text = "エラー";
                            return;
                        }
                        number1 /= number2;
                        break;
                }
                number2 = 0;
            }

            operation = ((Button)sender).Content.ToString();
            ResultBox.Text = number1.ToString();
        }

        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            switch(operation)
            {
                case "＋":
                    number1 += number2;
                    break;
                case "－":
                    number1 -= number2;
                    break;
                case "×":
                    number1 *= number2;
                    break;
                case "÷":
                    if(number2 == 0)
                    {
                        ResultBox.Text = "エラー";
                        return;
                    }
                    number1 /= number2;
                    break;
            }
            number2 = 0;
            operation = "";
            ResultBox.Text = (number1).ToString();
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            ResultBox.Text = "0";
        }

        private void PercentButton_Click(object sender, RoutedEventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                return;
            }
            if (string.IsNullOrEmpty(operation))
            {
                number1 /= 100;
                ResultBox.Text = number1.ToString();
            }
            else
            {
                number2 /= 100;
                ResultBox.Text = number2.ToString();
            }
        }

        private void PlusMinusButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(operation))
            {
                number1 = -number1;
                ResultBox.Text = number1.ToString();
            }
            else
            {
                number2 = -number2;
                ResultBox.Text = number2.ToString();
            }
        }
    }
}
