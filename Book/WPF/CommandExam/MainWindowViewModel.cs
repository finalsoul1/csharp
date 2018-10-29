using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using System.Globalization;
using System;
namespace CommandExam
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public Emp _SelectedEmp;
        public Emp SelectedEmp
        {
            get
            {
                return _SelectedEmp;
            }
            set
            {
                _SelectedEmp = value;
                OnPropertyChanged("SelectedEmp");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string Pname = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Pname));
        }
        public RelayCommand AddEmpCommand { get; set; }
        public ObservableCollection<Emp> Emps { get; set; }
        public MainWindowViewModel()
        {
            Emps = new ObservableCollection<Emp>();
            Emps.Add(new Emp { Ename = "홍길동", Job = "Salesman" });
            Emps.Add(new Emp { Ename = "김길동", Job = "Clerk" });
            Emps.Add(new Emp { Ename = "정길동", Job = "Manager" });
            Emps.Add(new Emp { Ename = "박길동", Job = "Salesaman" });
            Emps.Add(new Emp { Ename = "성길동", Job = "Clerk" });
            AddEmpCommand = new RelayCommand(AddEmp);
        }
        public void AddEmp(object param)
        {
            Emps.Add(new Emp { Ename = param.ToString() });
        }
    }

    class EmpConverter : IMultiValueConverter
    {
        public object Convert(object[] val, Type targetType, object param, CultureInfo culture)
        {
            string EmpData;
            switch ((string)param)
            {
                case "reverse": EmpData = val[1] + " : " + val[0]; break;
                default: EmpData = val[0] + " : " + val[1]; break;
            }
            return EmpData;
        }
        public object[] ConvertBack(object val, Type[] targetTypes, object param, CultureInfo culture)
        {
            var splitValues = ((string)val).Split(':');
            return splitValues;
        }
    }
}