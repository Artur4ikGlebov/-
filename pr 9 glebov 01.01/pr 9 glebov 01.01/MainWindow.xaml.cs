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

namespace pr_9_glebov_01._01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            lecturerListBox.Items.Add($"{lecturer1.Surname} {lecturer1.Name} {lecturer1.Patronymic}: Кабинет №{lecturer1.AudienceNumber}: Кол-во часов в семестре - {lecturer1.HoursPerSemester}");
            lecturerListBox.Items.Add($"{lecturer2.Surname} {lecturer2.Name} {lecturer2.Patronymic}: Кабинет №{lecturer2.AudienceNumber}: Кол-во часов в семестре - {lecturer2.HoursPerSemester}");
            lecturerListBox.Items.Add($"{lecturer3.Surname} {lecturer3.Name} {lecturer3.Patronymic}: Кабинет №{lecturer3.AudienceNumber}: Кол-во часов в семестре - {lecturer3.HoursPerSemester}");
            lecturerListBox.Items.Add($"{lecturer4.Surname} {lecturer4.Name} {lecturer4.Patronymic}: Кабинет №{lecturer4.AudienceNumber}: Кол-во часов в семестре - {lecturer4.HoursPerSemester}");
            lecturerListBox.Items.Add($"{lecturer5.Surname} {lecturer5.Name} {lecturer5.Patronymic}: Кабинет №{lecturer5.AudienceNumber}: Кол-во часов в семестре - {lecturer5.HoursPerSemester}");
        }

        Lecturer lecturer1 = new Lecturer("Морозов", "Иван", "Даниэльевич", 211, 180);
        Lecturer lecturer2 = new Lecturer("Полякова", "Мария", "Глебовна", 195, 200);
        Lecturer lecturer3 = new Lecturer("Васильева", "Ясмина", "Владимировна", 10, 150);
        Lecturer lecturer4 = new Lecturer("Тарасов", "Георгий", "Даниилович ", 95, 150);
        Lecturer lecturer5 = new Lecturer("Куприянов", "Кирилл", "Артёмович", 100, 166);

        Lecturer[] lecturers;


        private void find_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lecturers = new Lecturer[] { lecturer1, lecturer2, lecturer3, lecturer4, lecturer5 };
                int audience = Convert.ToInt32(audienceInput.Text);
                for (int i = 0; i < lecturers.Length; i++)
                {
                    if (audience == lecturers[i].AudienceNumber)
                        MessageBox.Show($"В данной аудитории работает {lecturers[i].Surname} {lecturers[i].Name} {lecturers[i].Patronymic}");
                }
            }
            catch
            {
                MessageBox.Show("Ввдеите корректное значение", "Ошибка");
            }
            
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №9\n" +
                "Глебов Артур ИСП-34\n" +
                "Заполнить таблицу на 5 предметов с полями: предмет, ФИО лектора, номер аудитории, кол - во часов в семестре .Вывести результат на экран.Вывести список " +
                "лекторов работающих в заданной аудитории.", "О программе", MessageBoxButton.OK);
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }

    struct Lecturer
    {
        public string Name;
        public string Surname;
        public string Patronymic;
        public int AudienceNumber;
        public int HoursPerSemester;

        public Lecturer(string surname, string name, string patronymic, int audience, int hours)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            AudienceNumber = audience;
            HoursPerSemester = hours;
        }
    }

}
