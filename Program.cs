using System.Collections.Generic;

Console.WriteLine("Enter your name Please");
Employee Mohammad = new Employee("John", 30, 2500);
Mohammad.Name =  (Console.ReadLine());;
Console.WriteLine("Enter Your Age Please");
Mohammad.Age = int.Parse(Console.ReadLine());
Mohammad.commision = 0.3;
Mohammad.Ponus = 1000;
Console.WriteLine("Enter Your salary Please");
Mohammad.Salary = double.Parse(Console.ReadLine());
double netSalary = Mohammad.CalculateNetSalary();
Console.WriteLine(netSalary);
// Employee[] employees = new Employee[3];
// employees[0] =Mohammad;
// for(int i = 0; i < emps.Length; i++)
// {
//     Console.WriteLine(emps[i]);
// }
        
// double allowness = Mohammad.Salary * Mohammad.commision; // 2000*0.3 =600
// double NetSalary = Mohammad.Salary + Mohammad.allowness; // 2000+600 =2600
                                                         //   Mohammad.AdditionalSal = Mohammad.Salary +=500;
// double AdditionalSal = Mohammad.Salary + Mohammad.ponus;
// if (Age >= 50)
// {
//     Console.WriteLine(AdditionalSal);
// }
// else
// {
//     Console.WriteLine(NetSalary);
// }


public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }
    public double NetSalary { get; set; }
    public double commision { get; set; }
    public double allowness { get; set; }
    public double Ponus { get; set; }
    public int legth {get;set;}
    public double CalculateNetSalary()
    {
        double allowness = Salary * commision;
        double netSalary = 0;
        if (Age >= 50)
        {

            netSalary = Salary + Ponus + allowness;
        }
        else
        {
            netSalary = Salary + allowness;
        }

        return netSalary;
    }
             public Employee(string name, int age, double salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }
}                            
    class Program1
{
    static void Main(string[] args)
    {
        // create an array of Employee objects
        Employee[] employees = new Employee[3];
        employees[0] = new Employee("John", 30, 2500);
        employees[1] = new Employee("Mary", 55, 3500);
        employees[2] = new Employee("Bob", 40, 2000);

        // loop through the array and print out salaries
        foreach (Employee emp in employees)
        {
            double netSalary = emp.CalculateNetSalary();
            Console.WriteLine(emp.Name + "'s salary is " + netSalary);
            if (emp.Age >= 50)
            {
                Console.WriteLine(emp.Name + " is " + emp.Age + " years old.");
            }
        }
    }
}



