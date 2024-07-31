using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleException
{
    class Car
    {
        private class Radio {
            public void TurnOn(bool on) {
                Console.WriteLine(on ? "Jamming..." : "Quiet time...");
            }
        }

        public const int MaxSpeed = 100;
        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";

        private bool _carIsDead;
        private readonly Radio _theMusicBox = new Radio();

        public Car()
        {

        }
        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }

        public void CrankTunes(bool state) => _theMusicBox.TurnOn(state);

        public void Accelerate(int delta) {
            if (_carIsDead) {
                Console.WriteLine($"{PetName} is out of order...");
                return;
            }
            CurrentSpeed += delta;
            if (CurrentSpeed > MaxSpeed) {
                CurrentSpeed = 0;
                _carIsDead = true;
                throw new Exception($"{PetName} has overheated!");
            }
            Console.WriteLine($"=> CurrentSpeed = {CurrentSpeed}");
        }
    }
}
