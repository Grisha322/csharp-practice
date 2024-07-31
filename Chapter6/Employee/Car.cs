using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    class Car
    {
        public readonly int MaxSpeed;
        private int _curSpeed;

        public Car(int maxSpeed) { 
            MaxSpeed = maxSpeed;
        }

        public Car()
        {
            MaxSpeed = 55;
        }

        public int Speed { 
            get => _curSpeed; 
            set => _curSpeed = value > MaxSpeed ? MaxSpeed : value;    
        }
    }
}
