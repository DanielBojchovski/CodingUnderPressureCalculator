using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CodingUnderPressureCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double num1;
        public double num2;
        public string operation;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumBtn_Click(object sender, RoutedEventArgs e)
        {
            string name = ((Button)sender).Name;
            switch (name)
            {
                case "ZeroBtn":
                    OutputTextBlock.Text += "0";
                    break;
                case "OneBtn":
                    OutputTextBlock.Text += "1";
                    break;
                case "TwoBtn":
                    OutputTextBlock.Text += "2";
                    break;
                case "ThreeBtn":
                    OutputTextBlock.Text += "3";
                    break;
                case "FourBtn":
                    OutputTextBlock.Text += "4";
                    break;
                case "FiveBtn":
                    OutputTextBlock.Text += "5";
                    break;
                case "SixBtn":
                    OutputTextBlock.Text += "6";
                    break;
                case "SevenBtn":
                    OutputTextBlock.Text += "7";
                    break;
                case "EightBtn":
                    OutputTextBlock.Text += "8";
                    break;
                case "NineBtn":
                    OutputTextBlock.Text += "9";
                    break;
                case "DotBtn":
                    OutputTextBlock.Text += ".";
                    break;

            }
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            OutputTextBlock.Text = "";
            num1 = 0;
            num2 = 0;
            operation = "";
        }

        private void PlusBtn_Click(object sender, RoutedEventArgs e)
        {
            if(OutputTextBlock.Text != "")
            {
                num1 = double.Parse(OutputTextBlock.Text);
                operation = "+";
                OutputTextBlock.Text = "";
            }
        }

        private void MinusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (OutputTextBlock.Text != "")
            {
                num1 = double.Parse(OutputTextBlock.Text);
                operation = "-";
                OutputTextBlock.Text = "";
            }
        }

        private void MultBtn_Click(object sender, RoutedEventArgs e)
        {
            if (OutputTextBlock.Text != "")
            {
                num1 = double.Parse(OutputTextBlock.Text);
                operation = "*";
                OutputTextBlock.Text = "";
            }
        }

        private void DivBtn_Click(object sender, RoutedEventArgs e)
        {
            if (OutputTextBlock.Text != "")
            {
                num1 = double.Parse(OutputTextBlock.Text);
                operation = "/";
                OutputTextBlock.Text = "";
            }
        }

        private void EqualsBtn_Click(object sender, RoutedEventArgs e)
        {
            if(OutputTextBlock.Text != "")
            {
                num2 = double.Parse(OutputTextBlock.Text);
                switch (operation)
                {
                    case "+":
                        OutputTextBlock.Text = (num1 + num2).ToString("0.00");
                        break;
                    case "-":
                        OutputTextBlock.Text = (num1 - num2).ToString("0.00");
                        break;
                    case "*":
                        OutputTextBlock.Text = (num1 * num2).ToString("0.00");
                        break;
                    case "/":
                        OutputTextBlock.Text = (num1 / num2).ToString("0.00");
                        break;
                }
                num1 = 0;
                num2 = 0;
                operation = "";
            }
        }
    }
}
