using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    public class EmployeeWage
    {
        public int EmpPresent = 1;
        public void CheackEmpPresentAbsent()
        {
            Random Check = new Random();
            int CheckEmp = Check.Next(0, 2);

            if (EmpPresent == CheckEmp)
                Console.WriteLine("Employeee is present");
            else
                Console.WriteLine("EmpPresent is Absent");

        }

    }
}
