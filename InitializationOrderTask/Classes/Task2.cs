using System;
using System.Collections.Generic;
using System.Text;

namespace InitializationOrderTask.Classes
{
    class Task2
    {
        private static int _counter;
        public Task2()
        {
            _counter++;
        }
        public static void CounterOfObjectsView()
        {
            Console.WriteLine("There is " + _counter + " objects of class \"Task2\"");
        }
    }
}
