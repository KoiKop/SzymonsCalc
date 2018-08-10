using System;
using System.Threading;
using System.Windows;

namespace CalcAgain
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        InputReader inputReader = new InputReader();
        Calculations calculations = new Calculations();

        private double lValue;
        private double rValue;
        Action action = Action.Initial;


        public MainWindow()
        {
            InitializeComponent();
            MainDisplay.Content = inputReader.Input;
        }

        private void ButtonValue0_Click(object sender, RoutedEventArgs e)
        {
            MainDisplay.Content = inputReader.UpdateInput("0");
        }

        private void ButtonValue1_Click(object sender, RoutedEventArgs e)
        {
            MainDisplay.Content = inputReader.UpdateInput("1");
        }

        private void ButtonValue2_Click(object sender, RoutedEventArgs e)
        {
            MainDisplay.Content = inputReader.UpdateInput("2");
        }

        private void ButtonValue3_Click(object sender, RoutedEventArgs e)
        {
            MainDisplay.Content = inputReader.UpdateInput("3");
        }

        private void ButtonValue4_Click(object sender, RoutedEventArgs e)
        {
            MainDisplay.Content = inputReader.UpdateInput("4");
        }

        private void ButtonValue5_Click(object sender, RoutedEventArgs e)
        {
            MainDisplay.Content = inputReader.UpdateInput("5");
        }

        private void ButtonValue6_Click(object sender, RoutedEventArgs e)
        {
            MainDisplay.Content = inputReader.UpdateInput("6");
        }

        private void ButtonValue7_Click(object sender, RoutedEventArgs e)
        {
            MainDisplay.Content = inputReader.UpdateInput("7");
        }

        private void ButtonValue8_Click(object sender, RoutedEventArgs e)
        {
            MainDisplay.Content = inputReader.UpdateInput("8");
        }

        private void ButtonValue9_Click(object sender, RoutedEventArgs e)
        {
            MainDisplay.Content = inputReader.UpdateInput("9");
        }

        private void ButtonComma_Click(object sender, RoutedEventArgs e)
        {
            MainDisplay.Content = inputReader.AddCommaToInput();
        }

        private void ButtonPlusMinus_Click(object sender, RoutedEventArgs e)
        {
            MainDisplay.Content = inputReader.ChangePlusMinusSign();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            ValueUpdater();
            action = Action.Add;
        }

        private void ButtonExtract_Click(object sender, RoutedEventArgs e)
        {
            ValueUpdater();
            action = Action.Extract;
        }

        private void ButtonMultiple_Click(object sender, RoutedEventArgs e)
        {
            ValueUpdater();
            action = Action.Multiple;
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            ValueUpdater();
            action = Action.Divide;
        }

        private void ButtonResult_Click(object sender, RoutedEventArgs e)
        {
            ValueUpdater();
            var result = calculations.Calculate(action, lValue, rValue);
            MainDisplay.Content = result.ToString();
            inputReader.ClearInput();
            lValue = result;
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            action = Action.Initial;
            inputReader.ClearInput();
            MainDisplay.Content = inputReader.Input;
        }

        private void ButtonBackspace_Click(object sender, RoutedEventArgs e)
        {
            MainDisplay.Content = inputReader.DeleteLastCharacter();
        }

        //private void Cancel()
        //{
        //    action = Action.Initial;
        //    leftValueDouble = 0;
        //    rightValueDouble = 0;
        //    input = string.Empty;
        //    nie wiem
        //}

        private void ValueUpdater()
        {
            if (action == Action.Initial)
            {
                lValue = Convert.ToDouble(inputReader.Input);
                inputReader.ClearInput();
            }
            else
            {
                rValue = Convert.ToDouble(inputReader.Input);
            }  
        }





    }
}
