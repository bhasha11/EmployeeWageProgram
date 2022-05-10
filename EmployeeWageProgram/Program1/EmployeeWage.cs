using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageProblems

{
    public class EmployeeWageProgram
    {
        const int Emp_Full_Time = 1;
        const int Emp_Part_Time = 2;
        public int Wage_Per_Hours = 20;
        public int empHrs = 0;
        public int Working_Days_Per_Month = 20;
        public int Total_Salary_Month = 0;


        public void Attendence()
        {
            for (int day = 1; day <= Working_Days_Per_Month; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case Emp_Full_Time:
                        empHrs = 8;
                        break;

                    case Emp_Part_Time:
                        empHrs = 4;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }
                int EmployeeWage = empHrs * Wage_Per_Hours;
                Total_Salary_Month += EmployeeWage;
                Console.WriteLine(EmployeeWage);
            }
        }
    }
}
    