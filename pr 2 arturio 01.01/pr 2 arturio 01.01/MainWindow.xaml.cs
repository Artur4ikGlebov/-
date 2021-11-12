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

namespace pr_2_arturio_01._01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int[] _array;
        private SimpleArray ArrayAct = new SimpleArray();
        private CalculateActs calculateActs = new CalculateActs();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void generate_Click(object sender, RoutedEventArgs e)
        {
            bool isInputEmpty = int.TryParse(inputLength.Text, out int length);
            if (isInputEmpty && length > 0)
            {
                _array = ArrayAct.GenerateRandom(length);
                dataGridForArray.ItemsSource = VisualArray.ToDataTable(_array).DefaultView;
            }
            else MessageBox.Show("Введите длину(положительное целое число)", "Ошибка");
        }

        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            if (_array != null)
                result.Text = Convert.ToString(calculateActs.Calc(_array));
            else MessageBox.Show("Сгенерируйте таблицу", "Ошибка");
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            if(_array != null)
            {
                inputLength.Clear();
                result.Clear();
                _array = ArrayAct.Initialize(0, 0);
                dataGridForArray.ItemsSource = VisualArray.ToDataTable(_array).DefaultView;
            }
        }

        private void open_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _array = ArrayAct.Open();
                dataGridForArray.ItemsSource = VisualArray.ToDataTable(_array).DefaultView;
            }
            catch (ArgumentNullException)
            {

                MessageBox.Show("");
            }
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            ArrayAct.Save();
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №2\n" +
                "Глебов Артур ИСП - 34\n" +
                "Ввести n целых чисел. Найти сумму чисел < 15. Результат вывести на экран.");
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
