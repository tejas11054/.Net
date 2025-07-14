using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollege
{
    public class Professor : Person
    {
        public double BasicSalary { get; set; }
        public double HRA {  get; set; }
        public double DA { get; set; }

        public Professor(int id, string address, DateTime dob, double basic, double hra, double da) : base(id, address, dob)
        {
            BasicSalary = basic;
            HRA = hra;
            DA = da;
        }

        public double CalculateSalary()
        {
            return BasicSalary + HRA + DA;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"\nBasic Salary: {BasicSalary} \nHRA: {HRA} \nDA: {DA} \nTotal Salary: {CalculateSalary():F2}");
        }
    }
}
