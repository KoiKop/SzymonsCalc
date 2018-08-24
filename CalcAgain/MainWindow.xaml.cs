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
        Calculations calculations = new Calculations();
        InputStorage inputStorage = new InputStorage();

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
            inputStorage.StoreValue(inputReader);
            MainDisplay.Content = calculations.Calculate(inputStorage);
            inputReader.ClearInput();
            inputStorage.SetAction(Action.Add);
        }

        private void ButtonExtract_Click(object sender, RoutedEventArgs e)
        {
            inputStorage.StoreValue(inputReader);
            MainDisplay.Content = calculations.Calculate(inputStorage);
            inputReader.ClearInput();
            inputStorage.SetAction(Action.Extract);
        }

        private void ButtonMultiple_Click(object sender, RoutedEventArgs e)
        {
            inputStorage.StoreValue(inputReader);
            MainDisplay.Content = calculations.Calculate(inputStorage);
            inputReader.ClearInput();
            inputStorage.SetAction(Action.Multiple);
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            inputStorage.StoreValue(inputReader);
            MainDisplay.Content = calculations.Calculate(inputStorage);
            inputReader.ClearInput();
            inputStorage.SetAction(Action.Divide);
        }

        private void ButtonResult_Click(object sender, RoutedEventArgs e)
        {
            inputStorage.StoreValue(inputReader);
            MainDisplay.Content = calculations.Calculate(inputStorage);
            inputReader.ClearInput();
        }

        






        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            inputStorage.SetAction(Action.Initial);
            inputReader.ClearInput();
            MainDisplay.Content = inputReader.Input;
        }

        private void ButtonBackspace_Click(object sender, RoutedEventArgs e)
        {
            MainDisplay.Content = inputReader.DeleteLastCharacter();
        }
    }

    public class DoubleClickValidation
    {

    }
}
