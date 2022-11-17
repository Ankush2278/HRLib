using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class ConfirmEmployee : Employee
    {
        public int Basic { get; set; }
        public string Designation { get; set; }
        public ConfirmEmployee()
        {

        }
        public ConfirmEmployee(string name, string address,int basic,string designation ) : base(name, address)
        {
            Basic = basic;
            Designation = designation;
        }

        public sealed override double CalculateSalary()
        {
            if (Basic >= 30000)
            {
                return 0.3 * Basic + 0.3 * Basic - 0.1 * Basic;
            }
            if (Basic >= 20000)
            {
                return 0.2 * Basic + 0.2 * Basic - 0.1 * Basic;
            }
            else
            {
                return 0.1 * Basic * 2 - 0.1 * Basic;
            }

        }
        public override string ToString()
        {
            return base.ToString()+"Basic: "+Basic+" "+ "Designation: "+Designation;
        }
    }
}
