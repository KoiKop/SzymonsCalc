using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace CalcAgain
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string input;
        private string displayInfo;
        private double leftValueDouble = 0;
        private double rightValueDouble = 0;
        Action action = Action.Initial;



        public MainWindow()
        {
            InitializeComponent();
            MainDisplay.Content = leftValueDouble.ToString();

        }

        private void ButtonValue0_Click(object sender, RoutedEventArgs e)
        {
            MainDisplay.Content = UpdateInput("0");
        }

        private void ButtonValue1_Click(object sender, RoutedEventArgs e)
        {
            MainDisplay.Content = UpdateInput("1");
        }

        private void ButtonValue2_Click(object sender, RoutedEventArgs e)
        {
            MainDisplay.Content = UpdateInput("2");
        }

        private void ButtonValue3_Click(object sender, RoutedEventArgs e)
        {
            MainDisplay.Content = UpdateInput("3");
        }

        private void ButtonValue4_Click(object sender, RoutedEventArgs e)
        {
            MainDisplay.Content = UpdateInput("4");
        }

        private void ButtonValue5_Click(object sender, RoutedEventArgs e)
        {
            MainDisplay.Content = UpdateInput("5");
        }

        private void ButtonValue6_Click(object sender, RoutedEventArgs e)
        {
            MainDisplay.Content = UpdateInput("6");
        }

        private void ButtonValue7_Click(object sender, RoutedEventArgs e)
        {
            MainDisplay.Content = UpdateInput("7");
        }

        private void ButtonValue8_Click(object sender, RoutedEventArgs e)
        {
            MainDisplay.Content = UpdateInput("8");
        }

        private void ButtonValue9_Click(object sender, RoutedEventArgs e)
        {
            MainDisplay.Content = UpdateInput("9");
        }

        private void ButtonComma_Click(object sender, RoutedEventArgs e)
        {
            string separator = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            if (!input.Contains(separator))
            {
                MainDisplay.Content = UpdateInput(separator);
            }
        }

        private void ButtonPlusMinus_Click(object sender, RoutedEventArgs e)
        {
            if (input.Contains("-"))
            {
                input = input.Remove(0, 1);
                MainDisplay.Content = input;
            }
            else
            {
                input = input.Insert(0, "-");
                MainDisplay.Content = input;
            }
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {

            Calculate(action);
            action = Action.Add;
            MainDisplay.Content = leftValueDouble.ToString();

        }

        private void ButtonExtract_Click(object sender, RoutedEventArgs e)
        {

            Calculate(action);
            action = Action.Extract;
            MainDisplay.Content = leftValueDouble.ToString();
        }

        private void ButtonMultiple_Click(object sender, RoutedEventArgs e)
        {
            Calculate(action);
            action = Action.Multiple;
            MainDisplay.Content = leftValueDouble.ToString();
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            Calculate(action);
            action = Action.Divide;
            MainDisplay.Content = leftValueDouble.ToString();
        }

        private void ButtonResult_Click(object sender, RoutedEventArgs e)
        {
            Calculate(action);
            if (string.IsNullOrEmpty(displayInfo))
            {

                MainDisplay.Content = leftValueDouble.ToString();
            }
            else
            {
                MainDisplay.Content = displayInfo;
                displayInfo = string.Empty;
                Cancel();
            }
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            Cancel();
            MainDisplay.Content = leftValueDouble.ToString();
        }

        private void ButtonBackspace_Click(object sender, RoutedEventArgs e)
        {
            if ((input.Length) >= 1)
            {
                input = input.Remove(input.Length - 1);

                if (input.Length == 0)
                {
                    rightValueDouble = 0;
                    MainDisplay.Content = rightValueDouble;
                }
                else
                    MainDisplay.Content = input;
            }

        }

        private string UpdateInput(string input)
        {
            this.input += input;
            return this.input;
        }

        private void Calculate(Action action)
        {
            if (input != "")
                rightValueDouble = Convert.ToDouble(input);

            switch (action)
            {
                case Action.Initial:
                    leftValueDouble = rightValueDouble;
                    break;
                case Action.Add:
                    leftValueDouble += rightValueDouble;
                    break;
                case Action.Extract:
                    leftValueDouble = leftValueDouble - rightValueDouble;
                    break;
                case Action.Multiple:
                    leftValueDouble = leftValueDouble * rightValueDouble;
                    break;
                case Action.Divide:
                    if (rightValueDouble == 0)
                        displayInfo = "Cannot divide by 0";
                    else
                        leftValueDouble = leftValueDouble / rightValueDouble;
                    break;
            }

            rightValueDouble = 0;
            input = "";
        }

        private void Cancel()
        {
            action = Action.Initial;
            leftValueDouble = 0;
            rightValueDouble = 0;
            input = string.Empty;
            //nie wiem 
        }

    }

    public enum Action
    {
        Initial,
        Add,
        Extract,
        Multiple,
        Divide
    }
}
