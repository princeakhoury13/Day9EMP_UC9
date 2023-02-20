using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9EMPWageUC9
{
    public class EmpWageBuilder
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private string company;
        private int empRate;
        private int workingDays;
        private int maxHours;
        private int totalWage;

        public EmpWageBuilder(string company, int empRate, int workingDays, int maxHours)
        {
            this.company = company;
            this.empRate = empRate;
            this.workingDays = workingDays;
            this.maxHours = maxHours;

        }

        public void computeEmpWage()
        {
            int empHours = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs <= this.maxHours && totalWorkingDays < this.workingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHours = 4;
                        break;
                    case IS_FULL_TIME:
                        empHours = 8;
                        break;
                    default:
                        empHours = 0;
                        break;
                }
                totalEmpHrs += empHours;
                Console.WriteLine("Day: " + totalWorkingDays + "; Hours Worked: " + empHours);
            }
            totalWage = totalEmpHrs * this.empRate;
            //Console.WriteLine("Total emp wage for company "+company+" is : "+totalWage);
        }

        public string toString()
        {
            return "Total employee wage for company " + this.company + " is : " + this.totalWage;
        }
    }
}
