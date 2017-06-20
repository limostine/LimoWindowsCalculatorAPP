using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        //Vairables

        string displayNumber, mathType;
        Int32 numberOne, numberTwo;
        Int64 answer;

        public MainPage()
        {
            this.InitializeComponent();
            displayNumber = "";
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void twoButton_Click(object sender, RoutedEventArgs e)
        {
            displayNumber = displayNumber + "2";
            outPutText.Text = displayNumber;
        }

        private void oneButton_Click(object sender, RoutedEventArgs e)
        {
            displayNumber = displayNumber + "1";
            outPutText.Text = displayNumber;
        }

        private void threeButton_Click(object sender, RoutedEventArgs e)
        {
            displayNumber = displayNumber + "3";
            outPutText.Text = displayNumber;
        }

        private void fourButton_Click(object sender, RoutedEventArgs e)
        {
            displayNumber = displayNumber + "4";
            outPutText.Text = displayNumber;
        }

        private void fiveButton_Click(object sender, RoutedEventArgs e)
        {
            displayNumber = displayNumber + "5";
            outPutText.Text = displayNumber;

        }

        private void sixButton_Click(object sender, RoutedEventArgs e)
        {
            displayNumber = displayNumber + "6";
            outPutText.Text = displayNumber;
        }

        private void sevenButton_Click(object sender, RoutedEventArgs e)
        {
            displayNumber = displayNumber + "7";
            outPutText.Text = displayNumber;
        }

        private void eightButton_Click(object sender, RoutedEventArgs e)
        {
            displayNumber = displayNumber + "8";
            outPutText.Text = displayNumber;
        }

        private void nineButton_Click(object sender, RoutedEventArgs e)
        {
            displayNumber = displayNumber + "9";
            outPutText.Text = displayNumber;
        }

        private void tenButton_Click(object sender, RoutedEventArgs e)
        {
            displayNumber = displayNumber + "0";
            outPutText.Text = displayNumber;
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            displayNumber = "";
            numberOne = 0;
            numberTwo = 0;
            outPutText.Text = displayNumber;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            numberOne = Convert.ToInt32(displayNumber);
            displayNumber = "";
            outPutText.Text = displayNumber;
            mathType = "addition";
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void equalsButton_Click(object sender, RoutedEventArgs e)
        {
            if (mathType == "addition")
            {
                numberTwo = Convert.ToInt32(displayNumber);
                answer = numberOne + numberTwo;
                displayNumber = Convert.ToString(answer);
                outPutText.Text = displayNumber;
            }

            if (mathType == "subtraction")
            {
                numberTwo = Convert.ToInt32(displayNumber);
                answer = numberOne - numberTwo;
                displayNumber = Convert.ToString(answer);
                outPutText.Text = displayNumber;
            }




        }

        private void subtractButton_Click(object sender, RoutedEventArgs e)
        {

            numberOne = Convert.ToInt32(displayNumber);
            displayNumber = "";
            outPutText.Text = displayNumber;
            mathType = "subtraction";

        }
    }
}
