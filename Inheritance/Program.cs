using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;


        public void PrintFullName()
        {
            Console.WriteLine(FirstName + "" + LastName);
            Console.ReadLine();
        }
    }

    public class FullTimeEmployee : Employee
    {
        public float YearlySalary;
    }

    public class PartTimeEmployee : Employee
    {
        public float HourlySalary;
    }

    public class Program
    {
       public static void Main()
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Aniket";
            FTE.LastName = "Dharmadhikari";
            FTE.YearlySalary = 500000;
            
            FTE.PrintFullName();


            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "Tinki";
            PTE.LastName = "Dharmadhikari";
            PTE.HourlySalary = 200000;
            PTE.PrintFullName();
        }


    }
}
