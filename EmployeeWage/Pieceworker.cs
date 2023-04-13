using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class Pieceworker
    {
        public string? itemType { get; set; }
        public double itemValue { get; set; }
        public double itemsProduced { get; set; }
        public double pieceWorkersPay { get; set; }

        public double calcPieceworkersPay(double itemValue, double itemsProduced)
        {
            pieceWorkersPay = itemValue * itemsProduced;
            return pieceWorkersPay;
        }
    }   
}
   