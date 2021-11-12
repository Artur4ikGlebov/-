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
using Lib_6;

namespace pr_1_arturio_01._01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Calculate calculate = new();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void startCalc_Click(object sender, RoutedEventArgs e)
        {
            calculate.GenerateRandomX(out string res);
            resOutput.Text = res;
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            resOutput.Clear();
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №1\n" +
                "Глебов Артур ИСП - 34\n" +
                "Генерировать случайные числа Х, распределенные в диапазоне от -5 до 4 и " +
                "вычислять для чисел > 0 X, а для чисел < 0 функцию x2. Вычисления " +
                "прекратить, когда подряд появится два одинаковых случайных числа.", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
