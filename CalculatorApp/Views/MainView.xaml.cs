using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CalculatorApp.Views
{
    /// <summary>
    /// MainView.xaml の相互作用ロジック
    /// </summary>
    public partial class MainView : Window
    {

        long number1 = 0;
        long number2 = 0;
        string operation = "";
        public MainView()
        {
            InitializeComponent();
        }

        private void ZeroButton_Click(object sender, RoutedEventArgs e)
        {
            if(ResultBox.Text == "0")
            {
                return;
            }

            if (string.IsNullOrEmpty(operation))
            {
                number1 = long.Parse(string.Concat(number1, ZeroButton.Content));
                ResultBox.Text = number1.ToString();
            }
            else 
            {
                number2 = long.Parse(string.Concat(number2, ZeroButton.Content));
                ResultBox.Text = number2.ToString();
            }
        }

        private void OneButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(operation))
            {
                number1 = long.Parse(string.Concat(number1, OneButton.Content));
                ResultBox.Text = number1.ToString();
            }
            else
            {
                number2 = long.Parse(string.Concat(number2, OneButton.Content));
                ResultBox.Text = number2.ToString();
            }
        }

        private void TwoButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(operation))
            {
                number1 = long.Parse(string.Concat(number1, TwoButton.Content));
                ResultBox.Text = number1.ToString();
            }
            else
            {
                number2 = long.Parse(string.Concat(number2, TwoButton.Content));
                ResultBox.Text = number2.ToString();
            }
        }

        private void ThreeButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(operation))
            {
                number1 = long.Parse(string.Concat(number1, ThreeButton.Content));
                ResultBox.Text = number1.ToString();
            }
            else
            {
                number2 = long.Parse(string.Concat(number2, ThreeButton.Content));
                ResultBox.Text = number2.ToString();
            }
        }

        private void FourButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(operation))
            {
                number1 = long.Parse(string.Concat(number1, FourButton.Content));
                ResultBox.Text = number1.ToString();
            }
            else
            {
                number2 = long.Parse(string.Concat(number2, FourButton.Content));
                ResultBox.Text = number2.ToString();
            }
        }

        private void FiveButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(operation))
            {
                number1 = long.Parse(string.Concat(number1, FiveButton.Content));
                ResultBox.Text = number1.ToString();
            }
            else
            {
                number2 = long.Parse(string.Concat(number2, FiveButton.Content));
                ResultBox.Text = number2.ToString();
            }
        }

        private void SixButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(operation))
            {
                number1 = long.Parse(string.Concat(number1, SixButton.Content));
                ResultBox.Text = number1.ToString();
            }
            else
            {
                number2 = long.Parse(string.Concat(number2, SixButton.Content));
                ResultBox.Text = number2.ToString();
            }
        }

        private void SevenButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(operation))
            {
                number1 = long.Parse(string.Concat(number1, SevenButton.Content));
                ResultBox.Text = number1.ToString();
            }
            else
            {
                number2 = long.Parse(string.Concat(number2, SevenButton.Content));
                ResultBox.Text = number2.ToString();
            }
        }

        private void EightButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(operation))
            {
                number1 = long.Parse(string.Concat(number1, EightButton.Content));
                ResultBox.Text = number1.ToString();
            }
            else
            {
                number2 = long.Parse(string.Concat(number2, EightButton.Content));
                ResultBox.Text = number2.ToString();
            }
        }

        private void NineButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(operation))
            {
                number1 = long.Parse(string.Concat(number1, NineButton.Content));
                ResultBox.Text = number1.ToString();
            }
            else
            {
                number2 = long.Parse(string.Concat(number2, NineButton.Content));
                ResultBox.Text = number2.ToString();
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            operation = "＋";
        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            operation = "－";
        }

        private void MultipleButton_Click(object sender, RoutedEventArgs e)
        {
            operation = "×";
        }

        private void DividButton_Click(object sender, RoutedEventArgs e)
        {
            operation = "÷";
        }

        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            switch(operation)
            {
                case "＋":
                    ResultBox.Text = (number1+number2).ToString();
                    operation = "";
                    break;
                case "－":
                    ResultBox.Text = (number1-number2).ToString();
                    operation = "";
                    break;
                case "×":
                    ResultBox.Text = (number1*number2).ToString();
                    operation = "";
                    break;
                case "÷":
                    ResultBox.Text = (number1/number2).ToString();
                    operation = "";
                    break;
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            ResultBox.Text = "0";
        }
    }
}
