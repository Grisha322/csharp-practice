using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEvents
{
    class Car
    {
        public const int MaxSpeed = 100;
        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";

        private bool _carIsDead;
        public Car()
        {

        }
        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }
        
        //public delegate void CarEngineHandler(string msgForCaller);
        // Recomended way of delegates is this tho. pass this as o and normally you should extend class EventArgs
        // and pass all the necessary informaton in there.
        // public delegate void CarEngineHandler(object o, CarEventArgs e);
        // EventHandler<T> creates the delegate above
        public event EventHandler<CarEventArgs> AboutToExplode;
        public event EventHandler<CarEventArgs> Exploded;

        public void Acelerate(int delta) {
            if (_carIsDead) {
                Exploded?.Invoke(this, new CarEventArgs("Sorry this car is dead..."));
                return;
            }
            CurrentSpeed += delta;
            if ((MaxSpeed - CurrentSpeed) is <= 10 and > 0) {
                AboutToExplode?.Invoke(this, new CarEventArgs("Careful buddy! gonna blow!"));
            }
            if (CurrentSpeed >= MaxSpeed) { 
                _carIsDead = true;
                return;
            }
            Console.WriteLine($"Current speed = {CurrentSpeed}");
        }
    }
}
