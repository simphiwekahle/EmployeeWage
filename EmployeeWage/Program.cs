using EmployeeWage;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Type of Employee");
        string? employeeType = Console.ReadLine();

        if (employeeType == "Manager")
        {
            //Manager
            var man = new Manager();
            man.weeklyWage = 15000;

            Console.WriteLine("Employee weekly wage is R" + man.weeklyWage);
        }
        else if (employeeType == "Hourly Worker")
        {
            //Hourly Workers
            var hWorkers = new HourlyWorkers();
            Console.WriteLine("Rate per Hour is: ");
            hWorkers.hourRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours Worked is: ");
            hWorkers.hoursWorked = Convert.ToInt32(Console.ReadLine());

            hWorkers.Wage = hWorkers.WeeklyWage(hWorkers.hourRate, hWorkers.hoursWorked);

            Console.WriteLine("Hourly Workers weekly pay is R" + hWorkers.Wage);
        }
        else if (employeeType == "Commission Worker")
        {
            //Commission Workers
            var commission = new CommissionWorkers();
            Console.WriteLine("Default Commission pay is: ");
            commission.defaultCommission = 250;
            Console.WriteLine("Sales this week are: ");
            commission.weeklySales = Convert.ToDouble(Console.ReadLine());

            commission.commissionPay = commission.calcCommission(commission.defaultCommission, commission.weeklySales);

            Console.WriteLine("Commission Workers weekly pay is R" + commission.commissionPay);
        }
        else
        {
            //Pieceworkers
            var pw = new Pieceworker();
            Console.WriteLine("Type of Item: ");
            pw.itemType = Console.ReadLine();
            Console.WriteLine("Value of Item: ");
            pw.itemValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Items Produced: ");
            pw.itemsProduced = Convert.ToDouble(Console.ReadLine());

            pw.pieceWorkersPay = pw.calcPieceworkersPay(pw.itemValue, pw.itemsProduced);

            Console.WriteLine("Pieceworkers weekly pay is R" + pw.pieceWorkersPay);
        }
        

        

        

        
    }
}