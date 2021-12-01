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

namespace pr_7_glebov_01._01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Triad triadActions;
        Triangle triangle;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void caluculateSum_Click(object sender, RoutedEventArgs e)
        {
            allNumbers.IsEnabled = true;

            bool isOneNumber = Int32.TryParse(allNumbers.Text, out int number);
            bool isFirstNumber = Int32.TryParse(firstNumber.Text, out int firstNum);
            bool isSecondtNumber = Int32.TryParse(secondNumber.Text, out int secondNum);
            bool isThirdNumber = Int32.TryParse(thirdNumber.Text, out int thirdNum);
            if (isOneNumber)
            {
                triadActions = new();
                triadActions.SetParams(number);
                result.Text = triadActions.GetSumOfNumbers().ToString();
            }
            else if (isFirstNumber && isSecondtNumber && isThirdNumber)
            {
                triadActions = new();
                triadActions.SetParams(firstNum, secondNum, thirdNum);
                result.Text = triadActions.GetSumOfNumbers().ToString();
            }
            else MessageBox.Show("Ввдеите необходимые данные (либо одно число, либо три)", "Ошибка");
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Глебов Артур ИСП - 34\n" +
                "Практическая работа №7\n" +
                "Использовать класс Triad (тройка положительных чисел). Определить производный класс Triangle с полями - сторонами. Определить методы вычисления углов и " +
                "площади треугольника.", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void allNumbers_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (allNumbers.Text == string.Empty)
            {
                firstNumber.IsEnabled = true;
                secondNumber.IsEnabled = true;
                thirdNumber.IsEnabled = true;
            }
            else
            {
                firstNumber.Clear();
                secondNumber.Clear();
                thirdNumber.Clear();
                firstNumber.IsEnabled = false;
                secondNumber.IsEnabled = false;
                thirdNumber.IsEnabled = false;
            }
        }

        private void checkEquality_Click(object sender, RoutedEventArgs e)
        {
            bool isOneNumber = Int32.TryParse(allNumbers.Text, out int number);
            bool isFirstNumber = Int32.TryParse(firstNumber.Text, out int firstNum);
            bool isSecondtNumber = Int32.TryParse(secondNumber.Text, out int secondNum);
            bool isThirdNumber = Int32.TryParse(thirdNumber.Text, out int thirdNum);
            if (isOneNumber)
            {
                triadActions = new();
                triadActions.SetParams(number);
                if (triadActions)
                    MessageBox.Show("Числа равны");
            }
            else if (isFirstNumber && isSecondtNumber && isThirdNumber)
            {
                triadActions = new();
                triadActions.SetParams(firstNum, secondNum, thirdNum);
                if (triadActions)
                    MessageBox.Show("Числа равны");
                else MessageBox.Show("Числа не равны");
            }
            else MessageBox.Show("Введите необходимые данные (либо одно число, либо три)", "Ошибка");
        }

        private void calculateArea_Click(object sender, RoutedEventArgs e)
        {
            if (allNumbers.Text != string.Empty)
            {
                if (triangle != null)
                    outputArea.Text = triangle.Area().ToString();
            }
            else if (firstNumber.Text != string.Empty && secondNumber.Text != string.Empty && thirdNumber.Text != string.Empty)
            {
                if (triangle != null)
                    outputArea.Text = triangle.Area().ToString();
            }
            else MessageBox.Show("Сначала создайте треугольник", "Ошибка");
        }

        private void createTriangle_Click(object sender, RoutedEventArgs e)
        {
            allNumbers.IsEnabled = true;

            bool isOneNumber = Int32.TryParse(allNumbers.Text, out int number);
            bool isFirstNumber = Int32.TryParse(firstNumber.Text, out int firstNum);
            bool isSecondtNumber = Int32.TryParse(secondNumber.Text, out int secondNum);
            bool isThirdNumber = Int32.TryParse(thirdNumber.Text, out int thirdNum);
            if (isOneNumber)
            {
                triangle = new Triangle(number, number, number);

            }
            else if (isFirstNumber && isSecondtNumber && isThirdNumber)
            {
                if (firstNum + secondNum > thirdNum && firstNum + thirdNum > secondNum && secondNum + thirdNum > firstNum)
                    triangle = new Triangle(firstNum, secondNum, thirdNum);
                else MessageBox.Show("Треугольник с такими сторонами не может существовать", "Ошибка");

            }
            else MessageBox.Show("Введите необходимые данные (либо одно число, либо три)", "Ошибка");
        }

        private void calculateAngles_Click(object sender, RoutedEventArgs e)
        {
            if (triangle != null)
            {
                (double angle1, double angle2, double angle3) = triangle.Angles();
                outputAngles.Text = $"{angle1} | {angle2} | {angle3}";
            }
            else MessageBox.Show("Сначала создайте треугольник", "Ошибка");
        }
    }
}
