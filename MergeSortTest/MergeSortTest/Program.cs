using System;

namespace MergeSortTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            MergeSort sortArray = new MergeSort(10);

            Console.WriteLine("Unsorted:  {0}", sortArray);

            sortArray.Sort();

            Console.WriteLine("Sorted:  {0}", sortArray);
            //Console.WriteLine("Hello World!");
        }
    }
}
