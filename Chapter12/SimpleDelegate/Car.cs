using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
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
        
        public delegate void CarEngineHandler(string msgForCaller);
        private CarEngineHandler? _listOfHandlers;
        public void RegisterWithCarEngine(CarEngineHandler methodToCall) { _listOfHandlers += methodToCall; }

        public void Acelerate(int delta) {
            if (_carIsDead) {
                _listOfHandlers?.Invoke("Sorry this car is dead...");
                return;
            }
            CurrentSpeed += delta;
            if ((MaxSpeed - CurrentSpeed) is <= 10 and > 0) {
                _listOfHandlers?.Invoke("Careful buddy! gonna blow!");
            }
            if (CurrentSpeed >= MaxSpeed) { 
                _carIsDead = true;
                return;
            }
            Console.WriteLine($"Current speed = {CurrentSpeed}");
        }
    }
}
