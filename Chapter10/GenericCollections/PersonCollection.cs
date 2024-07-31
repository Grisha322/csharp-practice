using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericCollections;

namespace CustomGenericMethodsd
{
    public class PersonCollection: IEnumerable
    {
        private ArrayList people = new();

        public Person this[int index] {
            get => (Person) people[index];
            set => people[index] = value;
        }

        IEnumerator IEnumerable.GetEnumerator() => people.GetEnumerator();
    }
}
