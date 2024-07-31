using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithSimpleClasses
{
    public class Car
    {
        public int speed;
        public string petName;

        public Car()
        {

        }

        public Car(int speed, string petName)
        {
            this.speed = speed;
            this.petName = petName;
        }

        public Car(int speed) => this.speed = speed;

        public Car(string petName) => this.petName = petName;

        public Car(int speed, string petName, out bool inDanger)
        {
            this.speed = speed;
            this.petName = petName;

            inDanger = speed > 100;
        }

        public void SpeedUp(int delta) => speed += delta;

        public void PrintState() => Console.WriteLine($"{petName} is driving {speed} MPH!");
    }
}
