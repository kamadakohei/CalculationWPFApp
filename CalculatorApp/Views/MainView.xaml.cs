﻿using System;
using System.Windows;
using System.Windows.Controls;

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

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            if (((Button)sender).Content.ToString() == "0" && ResultBox.Text == "0")
            {
                return;
            }
            if (string.IsNullOrEmpty(operation))
            {
                number1 = long.Parse(string.Concat(number1, ((Button)sender).Content));
                ResultBox.Text = number1.ToString();
            }
            else
            {
                number2 = long.Parse(string.Concat(number2, ((Button)sender).Content));
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
    }
}
