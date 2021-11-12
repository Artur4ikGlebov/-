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
using LibMas;
using Lib_6;

namespace pr_3_arturio_01._01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MatrixModules matrixModules = new();
        CalculateModules calculateSum = new();
        private int[,] _matrix;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №3\n" +
                "Глебов Артур ИСП - 34\n" +
                "Дана матрица размера M × N. Для каждого столбца матрицы с четным номером (2, 4, …) найти сумму его элементов. Условный оператор не использовать.", "О программе", MessageBoxButton.OK);
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void generate_Click(object sender, RoutedEventArgs e)
        {
            bool isNEmpty = Int32.TryParse(inputN.Text, out int n);
            bool isMEmpty = Int32.TryParse(inputM.Text, out int m);
            if (isNEmpty && isMEmpty && n > 0 && m > 0)
            {
                _matrix = matrixModules.Generate(n, m);
                dataGridForMatrix.ItemsSource = VisualMatrix.ToDataTable(_matrix).DefaultView;
            }
            else MessageBox.Show("Введите правильные числа(положительное целое число)", "Ошибка");
        }

        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            if ( _matrix != null)
                result.Text = string.Join(" | ", calculateSum.SumEven(_matrix));
            else MessageBox.Show("Сгенерируйте таблицу", "Ошибка");
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            result.Clear();
            inputM.Clear();
            inputN.Clear();
            matrixModules.ClearMatrix();
            dataGridForMatrix.ItemsSource = VisualMatrix.ToDataTable(_matrix).DefaultView;
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridForMatrix.ItemsSource != null)
                matrixModules.Save();
            else MessageBox.Show("Нечего сохранять", "Ошибка");
        }

        private void open_Click(object sender, RoutedEventArgs e)
        {
            _matrix = matrixModules.Open();
            inputN.Text = Convert.ToString(_matrix.GetLength(0));
            inputM.Text = Convert.ToString(_matrix.GetLength(1));
            dataGridForMatrix.ItemsSource = VisualMatrix.ToDataTable(_matrix).DefaultView;
        }
    }
}
