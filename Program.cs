using System;
using System.Collections.Generic;

namespace ListIterationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create list and fill it with number 1-100
            List<int> myList = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                myList.Add(i);
            }

            // Define some upper boundary
            int upperBoundary = 20;

            foreach (var i in myList)
            {
                if (i > upperBoundary)
                {
                    myList.Remove(i);
                }
            }

            Console.WriteLine();
        }
    }
}
