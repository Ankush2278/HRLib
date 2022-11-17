using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using HRLib;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            int no;
            do
            {
                Console.WriteLine("Enter your choice");
                Console.WriteLine("1. Display All Employees");
                Console.WriteLine("2. Insert Confirm Employee");
                Console.WriteLine("3. Insert Trainee");
                Console.WriteLine("4. Delete Employee");
                Console.WriteLine("5. Display Employee by No");
                Console.WriteLine("6. Exit");
                no = Convert.ToInt32(Console.ReadLine());
                switch(no)
                {
                    case 1:
                    Console.WriteLine("All Employee details");
                    foreach (Employee item in empList)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                    case 2:
                    Console.WriteLine("2. Insert Confirm Employee");
                    Console.WriteLine("Enter Name");
                    string name= Console.ReadLine();
                    Console.WriteLine("Enter Address");
                    string address= Console.ReadLine();
                    Console.WriteLine("Enter Basic");
                    int basic=Convert.ToInt32(Console.ReadLine());
                        if (basic < 5000)
                        {
                            try
                            {
                                throw new BasicException("Basic should be minimum 5000");
                            }
                            catch
                            {
                                Console.WriteLine("Cannot add with basic 5000");
                                break;
                            }
                        }
                    Console.WriteLine("Enter a designation");
                    string desig= Console.ReadLine();
                    ConfirmEmployee confirmEmployee= new ConfirmEmployee(name,address,basic,desig);
                    empList.Add(confirmEmployee);
                        Console.WriteLine("Employee details has been added successfully");
                    break;

                    case 3:
                        Console.WriteLine("3. Insert trainee");
                        Console.WriteLine("Enter Name");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter Address");
                        address = Console.ReadLine();
                        Console.WriteLine("Enter no. of days");
                        int nod= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter rate per day");
                        int rate=Convert.ToInt32(Console.ReadLine());
                        Trainee trainee= new Trainee(name,address,nod,rate);
                        empList.Add(trainee);
                        Console.WriteLine("Employee details has been added successfully");
                        break;

                    case 4:
                        Console.WriteLine("4. Delete Employee");
                        Console.WriteLine("Enter Employee Number");
                        int Eno=Convert.ToInt32(Console.ReadLine());
                        foreach (var item in empList)
                        {
                            if (Eno == item.EmpNo)
                            {
                                empList.Remove(item);
                                Console.WriteLine("Record deleted");
                                break;                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("5. Display Employee by No");
                        Console.WriteLine("Enter Employee Number");
                        Eno = Convert.ToInt32(Console.ReadLine());
                        foreach (var item in empList)
                        {
                            if (Eno==item.EmpNo)
                            {
                                Console.WriteLine(item);
                            }

                        }
                        break;
                }



            }
            while (no!=6);

        }
    }
}
