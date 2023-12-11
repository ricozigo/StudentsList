using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentsList
{
    public class MV : INotifyPropertyChanged
    {
        private Student openedStudent;

        private Student OpenedStudent { get { return openedStudent; }  set { openedStudent = value;  OnPropertyChanged("OpenedStudent"); } }

        public ObservableCollection<Student> students;

        public MV() 
        {
            students = Student.GetStudentsExample();
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }





    public class Student : INotifyPropertyChanged
    {
        private string name;
        private string group;
        private string gender;
        private string age;
        private string imgPath;

        public string Name { get { return name; } 
            set { name = value;
                OnPropertyChanged("Name");
            } }

        public string Group { get { return group; } set { group = value; OnPropertyChanged("Group"); } }
        public string Gender { get { return gender; } set
            {
                gender = value;
                OnPropertyChanged("Gender");
            } }
        public string Age { get { return age; }
            set
            {
                age = value;
                OnPropertyChanged("Age");
            } }
        public string ImgPath { get { return imgPath; }
            set
            {
                imgPath = value;
                OnPropertyChanged("ImgPath");
            } }
        public Student() 
        {
            name = "";
            group = "";
            gender = "";
            age = "";
            imgPath = "/Resources/sg.jpg";
        }
        public Student(string name, string group, string gender, string age)
        {
            this.name = name;
            this.group = group;
            this.gender = gender;
            this.age = age;
            this.imgPath = "/Resources/sg.jpg";
        }



        public static ObservableCollection<Student> GetStudentsExample() 
        {
            return new ObservableCollection<Student>() 
            {
                new Student(){Name = "Vasiliy Vasilievich Vasya", Group = "NSK", Age = "61", Gender = "Transformer" },
                new Student(){Name = "Just Student", Group = "Students", Age = "18", Gender = "HELICOPTER" },
                new Student(){Name = "Иванов Артём Владимирович", Group = "321", Age = "21", Gender = "female" },
                new Student(){Name = "Человек Паук", Age = "-21", Group = "Паукообразные", Gender = "Water" }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
