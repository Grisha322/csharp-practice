using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    enum EmployeePayTypeEnum { 
        Commission,
        Hourly,
        Salaried,
    }
    partial class Employee
    {
        public virtual void GiveBonus(float amount) {
            Pay += amount;
        }

        public virtual void DisplayStats() {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"ID: {Name}");
            Console.WriteLine($"Pay: {Pay}");
            Console.WriteLine($"Pay: {SocialSecurityNumber}");
            Console.WriteLine($"Pay: {PayType}");
        }


        /*
         * The next two methods are overrides of System.Object methods.
         * the versions demonstrated are easy to implement, yet do work reliably 
        */
        public override bool Equals(object? obj) => obj?.ToString() == ToString();

        public override int GetHashCode()
        {
            return ToString()!.GetHashCode();
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
