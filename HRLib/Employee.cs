using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    abstract public class Employee
    {
        public static int count=1000;
        public int EmpNo;
        public string Name { get; set; }
        public string Address { get; set; }
        public Employee()
        {
            EmpNo= count++;
        }
        public Employee(string name, string address)
        {
            EmpNo= count++;
            Name = name; 
            Address = address;
        }
        abstract public double CalculateSalary();

        public override string ToString()
        {
            return string.Format($"EmpNo: {EmpNo} Name: {Name} Address: {Address}");
        }
    }
}
