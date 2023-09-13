using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deepDiveWithHeapAndStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int actualValue = 5;
            string stringValue = "Hey you!";
            bool boolValue = false;
            byte byteValue = 0;

            HeapAndStack HeapStack = new HeapAndStack();
            HeapStack.JustGiven(2);
        }
    }
}
