using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class HourlyWorkers
    {
        public int hourRate { get; set; }
        public int hoursWorked { get; set; }
        public double overTime { get; set; }
        public double Wage { get; set; }

        public double calcOvertime(int hoursWorked)
        {
            switch (hoursWorked)
            {
                case > 40:
                    overTime = (hoursWorked - 40) * 1.5;
                    break;

                case < 40:
                    overTime = 0;
                    break;
            }
            return overTime;
        }
        public double WeeklyWage(int hourRate, int hoursWorked)
        {
            var xx = calcOvertime(hoursWorked);
            Wage = (hourRate * 40) + xx;
            return Wage;
        }
    }
}
