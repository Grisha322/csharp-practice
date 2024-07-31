using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethods
{
    static class MyExtentions
    {
        public static void DisplayDefiningAssembly(this object o) {
            Console.WriteLine($"{o.GetType().Name} lives here => {Assembly.GetAssembly(o.GetType())?.GetName().Name}");
        }

        public static int ReverseDigits(this int i) {
            char[] digits = i.ToString().ToCharArray();

            Array.Reverse(digits);

            string newDigits = new string(digits);

            return int.Parse(newDigits);
        }
    }
}
