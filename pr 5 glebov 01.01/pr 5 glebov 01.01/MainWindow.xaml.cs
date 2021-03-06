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

namespace pr_5_glebov_01._01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Triad triadActions = new Triad();
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
                triadActions.SetParams(number);
                result.Text = triadActions.GetSumOfNumbers().ToString();
            }
            else if (isFirstNumber && isSecondtNumber && isThirdNumber)
            {
                triadActions.SetParams(firstNum, secondNum, thirdNum);
                result.Text = triadActions.GetSumOfNumbers().ToString();
            }
            else MessageBox.Show("Ввдеите необходимые данные (либо одно число, либо три)", "Ошибка");
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Глебов Артур ИСП - 34\n" +
                "Практическая работа №5\n" +
                "Создать класс Triad (тройка положительных чисел). Создать необходимые методы и свойства.Определить метод вычисления суммы чисел.Создать перегруженные " +
                "методы SetParams, для установки параметров объекта.", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void allNumbers_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(allNumbers.Text == string.Empty)
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
    }
}
