using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    enum EmployeePayTypeEnum { 
        Commission,
        Hourly,
        Salaried,
    }
    partial class Employee
    {
        public void GiveBonus(float amount) {
            // just an example of using switch with objects, however here PayType switch{...} would be sufficient
            Pay = this switch
            {
                { PayType: EmployeePayTypeEnum.Commission } => Pay += .1F * amount,
                { PayType: EmployeePayTypeEnum.Hourly } => Pay += 40F * amount/2080F,
                { PayType: EmployeePayTypeEnum.Salaried } => Pay += amount,
                _ => Pay += 0,
            };
        }

        public void DisplayStats() {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"ID: {Name}");
            Console.WriteLine($"Pay: {Pay}");
        }

        public String Name {
            get => _empName;
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine($"Error! Name length exceeds 15 characters");
                    return;
                }
                _empName = value;
            }
        }

        public EmployeePayTypeEnum PayType
        {
            get => _payType;
            set => _payType = value;
        }

        public int Id
        {
            get => _empId;
            set => _empId = value;
        }

        public float Pay {
            get => _currPay;
            set => _currPay = value;
        }

        public String SocialSecurityNumber {
            get => _empSSN;
            private set => _empSSN = value;
        }
    }
}
