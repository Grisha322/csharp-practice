using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumeratorWithYield

{
    internal class Garage : IEnumerable
    {
        private Car[] carArray = new Car[4];

        public Garage()
        {
            carArray[0] = new Car("alex", 20);
            carArray[1] = new Car("flex", 60);
            carArray[2] = new Car("lex", 30);
            carArray[3] = new Car("ex", 50);
        }

        // explicit interface name before method hides this method for Garage instances, however it still can be casted to IEnumerable
        // and used from there
        IEnumerator IEnumerable.GetEnumerator() {
            foreach (Car car in carArray) { 
                yield return car;
            }
            // or
            /*
            * yield return carArray[0]
            * yield return carArray[1]
            * yield return carArray[2]
            * yield return carArray[3]
            */
            // both are valid
        }
    }
}
