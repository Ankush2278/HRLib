using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class Trainee : Employee
    {
        public int NoOfDays { get; set; }
        public double RatePerDay { get; set; }

        public Trainee() { }

        public Trainee(string name,string address,int noOfDays, double ratePerDay):base(name, address)
        {
            NoOfDays = noOfDays;
            RatePerDay = ratePerDay;
        }
        public override double CalculateSalary()
        {
            return NoOfDays * RatePerDay;
        }
        public override string ToString()
        {
            return base.ToString()+"No of Days: "+NoOfDays+" "+"Rate per day: "+RatePerDay;

        }
    }
}
