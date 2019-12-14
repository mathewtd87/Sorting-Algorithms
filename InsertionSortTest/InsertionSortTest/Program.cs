using System;

namespace InsertionSortTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            InsertionSort sortArray = new InsertionSort(10);
            Console.WriteLine("Unsorted array: ");
            Console.WriteLine(sortArray); //Calls the overriden ToString()

            sortArray.Sort();  //Sorts the array

            Console.WriteLine("Sorted array: ");
            Console.WriteLine(sortArray); //Calls the overriden ToString()

        }
    }
}
