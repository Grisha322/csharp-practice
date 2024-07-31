using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithMethodOverloading
{
    public static class AddOperations
    {
        public static int Add(int x, int y) => x + y;

        public static double Add(double x, double y) => x + y;

        public static long Add(long x, long y) => x + y;

        // This is alowed, since one signature uses ref and one doesn't
        static void Add(ref int x) { /* */ }
        static void Add(int x) { /* */ }

        /*
         * 
         * However this is not alowed, since both signatures use  a keyword, even though different
        static void Add(ref int x) { *//* *//* }
        static void Add(out int x) { *//* *//* }
                                             */
    }
}
