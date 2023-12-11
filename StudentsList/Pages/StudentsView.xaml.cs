using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для StudentsView.xaml
    /// </summary>
    public partial class StudentsView : Page
    {
        public StudentsView(MV mv)
        {
            this.mv= mv;
            InitializeComponent();
            View.ItemsSource= this.mv.students;
        }

        private MV mv = new MV();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(((Student)(((Button)sender).DataContext)).Name); // ОЧЕНЬ ВАЖНО



            var student = new StudentsList.Pages.StudentInfo( new Student());
            
            ((MainWindow)Tag).mainFrame.Navigate( new StudentsList.Pages.StudentInfo(((Student)(((Button)sender).DataContext))) {Tag = this.Tag});
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Tag).mv.students.Remove(((Student)(((Button)sender).DataContext)));
        }

        private void View_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
