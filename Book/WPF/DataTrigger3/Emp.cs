using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace DataTrigger2
{
    public class Emp
    {
        private int _Empno;
        private string _Ename;
        private int _Deptno;

        public int Empno
        {
            get { return _Empno; }
            set { _Empno = value; }
        }

        public string Ename
        {
            get { return _Ename; }
            set { _Ename = value; }
        }

        public int Deptno
        {
            get { return _Deptno; }
            set { _Deptno = value; }
        }

        public Emp(int Empno, string Ename, int Deptno)
        {
            this.Empno = Empno;
            this.Ename = Ename;
            this.Deptno = Deptno;
        }
    }

    public class Emps : ObservableCollection<Emp>
    {
        public Emps()
        {
            Add(new Emp(1001, "SMITH", 10));
            Add(new Emp(1001, "KING", 10));
            Add(new Emp(1001, "ALLEN", 10));
            Add(new Emp(1001, "TIGER", 10));
            Add(new Emp(1001, "SCOTT", 10));
            Add(new Emp(1001, "JHON", 10));
        }
    }
}