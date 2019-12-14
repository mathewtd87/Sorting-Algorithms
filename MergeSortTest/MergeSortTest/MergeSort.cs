using System;
namespace MergeSortTest
{
    public class MergeSort
    {
        public int[] data;
        public static Random generator = new Random();

        public MergeSort(int size)
        {
            data = new int[size];

            for (int i = 0; i < size; ++i)
                data[i] = generator.Next(10, 100);
        }//end constructor

        public void Sort()
        {
            //send arguments to sort the full length of the data array
            SortArray(0, data.Length - 1);
        }

        private void SortArray(int low, int high)
        {
            //test base case to make sure array has more than 1 value
            if ((high - low) >= 1)
            {
                int middle1 = (low + high) / 2;
                int middle2 = middle1 + 1;

                //Output split steps
                Console.WriteLine("split   " + Subarray(low, high));
                Console.WriteLine("        " + Subarray(low, middle1));
                Console.WriteLine("        " + Subarray(middle2, high));
                Console.WriteLine();

                //Call recursion with new split array
                SortArray(low, middle1);
                SortArray(middle2, high);

                //Merge split array
                Merge(low, middle1, middle2, high);
            }
        }

        private void Merge(int left, int middle1, int middle2, int right)
        {
            int leftIndex = left;  //index into left subarray
            int rightIndex = middle2; //index into right subarray
            int combinedIndex = left;  //index into temporary working array
            int[] combined = new int[data.Length];

            //output 2 subarrays before merging
            Console.WriteLine("merge:   " + Subarray(left, middle1));
            Console.WriteLine("         " + Subarray(middle2, right));

            //merge arrays until reaching end of either
            while (leftIndex <= middle1 && rightIndex <= right)
            {
                //place smaller of two elements into the combined array,
                //then move to next place of the arrays.
                if (data[leftIndex] <= data[rightIndex])
                    combined[combinedIndex++] = data[leftIndex++];
                else
                    combined[combinedIndex++] = data[rightIndex++];
            }

            //if left array is empty
            if (leftIndex == middle2)
            {
                while (rightIndex <= right)
                {
                    combined[combinedIndex++] = data[rightIndex++];
                }
            }
            else  //right array is empty
            {
                while (leftIndex <= middle1)
                {
                    combined[combinedIndex++] = data[leftIndex++];
                }
            }

            //Copy values back to original array.
            for (int i = left; i <= right; ++i)
            {
                data[i] = combined[i];
            }

            //output merged array
            Console.WriteLine("             " + Subarray(left, right));
            Console.WriteLine();

        }//end Merge()

        //Subarray function to output the array contents
        public string Subarray(int low, int high)
        {
            string temporary = string.Empty;

            //output spaces for alignment
            for (int i = 0; i < low; ++i)
                temporary += "  ";

            //output items left in array
            for (int i = low; i <= high; ++i)
                temporary += " " + data[i];

            return temporary;
        }//end Subarray()

        public override string ToString()
        {
            return Subarray(0, data.Length - 1);
        }
    }
}
