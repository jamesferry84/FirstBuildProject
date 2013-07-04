using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using MVVMBuildProject.Annotations;

namespace MVVMBuildProject.ViewModel
{
    class StudentData : INotifyPropertyChanged
    {
        string _firstName = null;
        public string StudentFirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;

                OnPropertyChanged("StudentFirstName");
            }
        }

 
        

        double _gradePointAverage;
        public double StudentGradePointAverage
        {
            get
            {
                return _gradePointAverage;
            }

            set
            {
                _gradePointAverage = value;
                OnPropertyChanged("StudentGradePointAverage");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
