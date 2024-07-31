using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    public class Car
    {
        public string PetName { get; set; } = "George";// You can provide default values for Properties,
                                                       // especially useful when a property works with objects,
                                                       // since their actual default is null, hence dengerous
        public int Speed { get; set; }
        public string Color { get; set; }

    }
}
