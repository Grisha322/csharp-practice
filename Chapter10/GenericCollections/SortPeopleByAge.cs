using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    public class SortPeopleByAge : IComparer<Person>
    {
        public int Compare(Person? x, Person? y)
        {
            return x?.Age.CompareTo(y?.Age) ?? 0;
        }
    }
}
