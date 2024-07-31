using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithSimpleClasses
{
    public class MotorCycle
    {
        private int _intensity;
        private string _driverName;

        public MotorCycle(int intensity, string driverName) {
            _intensity = intensity <= 10 ? intensity : 10;
            _driverName = driverName;
        }

        public MotorCycle(int intensity) : this(intensity, "Jack") { }

        public MotorCycle(string driverName) : this(5, driverName) { }

        public MotorCycle() : this(5, "Jack") { }
    }
}
