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

namespace StudentsList.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddStudent.xaml
    /// </summary>
    public partial class AddStudent : Page
    {
        public AddStudent()
        {
            InitializeComponent();
            brush = nameBox.Background;
        }

        Brush brush;

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (nameBox.Text == string.Empty) nameBox.Background = Brushes.Red;
            else nameBox.Background = brush;
            if (groupBox.Text == string.Empty) groupBox.Background = Brushes.Red;
            else groupBox.Background = brush;

            if (genderBox.Text == string.Empty) genderBox.Background = Brushes.Red;
            else genderBox.Background = brush;

            if (GetAgeValue() == 0) agePicker.Background = Brushes.Red;
            else agePicker.Background = brush;

            if (genderBox.Background == Brushes.Red || agePicker.Background == Brushes.Red || nameBox.Background == Brushes.Red || groupBox.Background == Brushes.Red) return;

            ((MainWindow)Tag).mv.students.Add(new Student(nameBox.Text, groupBox.Text, genderBox.Text, GetAgeValue().ToString()));
            ((MainWindow)Tag).mainFrame.Navigate(((MainWindow)Tag).studentsPage) ;

        }

        private int GetAgeValue() 
        {
            int age = 0;
            if (agePicker.SelectedDate != null) age = DateTime.Now.Year - ((DateTime)agePicker.SelectedDate).Year;
            else return 0;
            if (age > 14 && age < 99) return age;
            else    return 0;
        }



    }
}
