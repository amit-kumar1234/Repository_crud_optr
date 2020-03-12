using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository_crud_optr.Models
{
    public class Dept
    {
        public int DeptId { set; get; }
        public string Dname { set; get; }
        public ICollection<Emp> Emps { set; get; }
    }
    public class Emp
    {
        public int EmpId { set; get; }
        public string Ename { set; get; }
        public int sal { set; get; }
        public int DeptId{set;get;}
        public Dept Dept { set; get; }
    }
    public class stu
    {
        public int stuId { set; get; }
        public string sname { set; get; }
        public string city { set; get; }
    }
}
