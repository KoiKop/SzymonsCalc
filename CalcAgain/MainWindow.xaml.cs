using System;
using System.Globalization;
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
        InputStorage inputStorage = new InputStorage();
        Calculations calculations = new Calculations();

        public MainWindow()
        {
            InitializeComponent();
            MainDisplay.Content = inputReader.Input;
        }

        #region 0-9 buttons input update

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

        #endregion

        private void ButtonComma_Click(object sender, RoutedEventArgs e)
        {
            MainDisplay.Content = inputReader.AddCommaToInput();
        }

        private void ButtonPlusMinus_Click(object sender, RoutedEventArgs e)
        {
            MainDisplay.Content = inputReader.ChangePlusMinusSign();
        }


        #region Math operations buttons

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            MathOperationsButtonsActions(Action.Add);
        }

        private void ButtonExtract_Click(object sender, RoutedEventArgs e)
        {
            MathOperationsButtonsActions(Action.Extract);
        }

        private void ButtonMultiple_Click(object sender, RoutedEventArgs e)
        {
            MathOperationsButtonsActions(Action.Multiple);
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            MathOperationsButtonsActions(Action.Divide);
        }

        #endregion

        private void MathOperationsButtonsActions(Action action)
        {
            inputStorage.StoreValue(inputReader);

            if (!Double.IsNaN(inputStorage.RValue))
            {
                MainDisplay.Content = calculations.Calculate(inputStorage);
                inputStorage.SetRValueToNaN();
                inputReader.SetInputToNull();
            }
            
            inputStorage.SetAction(action);
        }

        private void ButtonResult_Click(object sender, RoutedEventArgs e)
        {
            inputStorage.StoreValue(inputReader);

            if (!Double.IsNaN(inputStorage.RValue))
            {
                MainDisplay.Content = calculations.Calculate(inputStorage);
                inputStorage.SetRValueToNaN();
                inputReader.SetInputToNull();
            }
        }

        




        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            inputStorage.SetAction(Action.Initial);
            inputReader.SetInputToZero();
            MainDisplay.Content = inputReader.Input;
        }

        private void ButtonBackspace_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(inputReader.Input))
            {
                MainDisplay.Content = inputReader.DeleteLastCharacter();
            }
            
        }
    }
}
