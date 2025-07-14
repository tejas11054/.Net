using System;

class Employee
{
    public int id;
    public string name;
    public double salary;

    //default constructor
    public Employee() 
    {
        id = 101;
        name = "ABC";
        salary = 30000;
    }
    
    //parameterized constructor
    public Employee(int empCode, string empName, double empSalary)
    {
        id = empCode;
        name = empName;
        salary = empSalary;
    }

    public override string ToString()
    {
        return "EmpCode: " + id + " Name: " + name + " Salary: " + salary;
    }
}
    
class Program
{
    public static void Main(string [] args)
    {
        Employee e1 = new Employee();
        Employee e2 = new Employee(102, "XYZ", 20000);
        
        Console.WriteLine(e1.ToString());
        Console.WriteLine(e2.ToString());
    }
}
