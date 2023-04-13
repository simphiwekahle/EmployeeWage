using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class CommissionWorkers
    {
        public double weeklySales { get; set; }
        public double defaultCommission { get; set; }
        public double commissionPay { get; set; }

        public double calcCommission (double defaultCommission, double weeklySales)
        {
            commissionPay = defaultCommission + (weeklySales * 0.057);
            return commissionPay;
        }
    }
}
