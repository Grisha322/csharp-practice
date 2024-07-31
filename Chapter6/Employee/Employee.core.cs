using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    partial class Employee
    {
        private string _empName;
        private int _empId;
        private float _currPay;
        private string _empSSN;
        private EmployeePayTypeEnum _payType;

        public Employee() { }

        public Employee(string empName, int empId, float currPay, string ssn, EmployeePayTypeEnum payType)
        {
            Name = empName;
            Id = empId;
            Pay = currPay;
            SocialSecurityNumber = ssn;
            PayType = payType;
        }
    }
}
