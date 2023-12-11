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

namespace StudentsList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            studentsPage = new StudentsList.Pages.StudentsView(mv);
            studentsPage.Tag = this;
            mainFrame.Navigate(studentsPage);
        }
        public MV mv = new MV();
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
       public  StudentsList.Pages.StudentsView studentsPage;
        private void btnMainMenu_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(studentsPage);
        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new StudentsList.Pages.AddStudent() {Tag = this });
        }
    }
}
