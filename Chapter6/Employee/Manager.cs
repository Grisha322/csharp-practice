using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    sealed class Manager : Employee
    {
        public int StockOptions { get; set; }

        public Manager(string name, int id, float pay, string empSsn, int numberOfOptions) : base(name, id, pay, empSsn, EmployeePayTypeEnum.Salaried)
        {
            StockOptions = numberOfOptions;
        }

        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount);
            Random r = new();
            StockOptions += r.Next(500);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine($"Number of stock options: {StockOptions}");
        }
    }
}
