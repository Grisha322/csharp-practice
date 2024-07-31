using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class SalesPerson : Employee
    {
        public int SalesNumber { get; set; }

        public SalesPerson() { }
        public SalesPerson(string name, int id, float pay, string empSsn, int numberOfSales) : base(name, id, pay, empSsn, EmployeePayTypeEnum.Commission)
        {
            SalesNumber = numberOfSales;
        }

        public sealed override void GiveBonus(float amount)
        {
            int salesBonus = (SalesNumber) switch
            {
                >= 0 and <= 100 => 10,
                >= 101 and <= 200 => 15,
                _ => 20,
            };
            base.GiveBonus(amount * salesBonus);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine($"Number of Sales: {SalesNumber}");
        }
    }
}
