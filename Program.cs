using System;

namespace ValueAndReference
{
    class Program
    {
        static void Main(string[] args)
        {
            // value type
            var a = 10;
            var b = a;
            b++;

            /* Even if "b" is incremented, "a" remains the same value that it was initialised as.
            "a" is stored in a stack. We are making a copy of this value in the stack, so if
            there are any changes, "a" and "b" work independent from one another.
            Both "a" and "b"" are integers and they are value types. So they will be two
            independent values in memory. Modifying "b" does not affect "a"".
             */
            System.Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            // reference type
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            
            /* The value of index 0 of either array will be the same. This is a reference type.
            array1 and array2 is a reference of the array that is stored in the heap.
            Arrays are reference types. So here, both array1 and array2 are referencing the
            same object in memory. Any changes applied via array2, will
            be visible via array1 reference. */
            System.Console.WriteLine(string.Format("array1: {0}, array2: {1}", array1[0], array2[0]));
        }
    }
}
