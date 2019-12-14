using System;

namespace SelectionSortTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            SelectionSort sortArray = new SelectionSort(10);

            Console.WriteLine("Unsorted Array");
            Console.WriteLine(sortArray);  //Run toString method

            sortArray.Sort(); //Class class funtion Sort()

            Console.WriteLine();
            Console.WriteLine(sortArray);  //display sorted array

        }//end main
    }
}
