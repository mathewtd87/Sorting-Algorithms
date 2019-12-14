using System;
namespace SelectionSortTest
{
    public class SelectionSort
    {
        //Variables
        private int[] data;
        private static Random generator = new Random();

        public SelectionSort(int size)
        {
            //generate int[] size of size
            data = new int[size];

            //populate int array with ints from random generator.Next
            for (int i = 0; i < size; ++i)
            {
                data[i] = generator.Next(10, 100);
            }
        } //end constructor

        //Sort function
        public void Sort()
        {
            int smallest;  //index of smallest element

            //loop over data.Length - 1 elements
            for (int i = 0; i < data.Length - 1; ++i)
            {
                smallest = i; //first index of remaining array

                //loop through data, if a number is smaller than i, set it to the smallest variable
                for (int index = i + 1; index < data.Length; ++index)
                {
                    if (data[index] < data[smallest])
                    {
                        smallest = index;
                    }
                }

                Swap(i, smallest);
                PrintPass(i + 1, smallest);
            }
        }//End Sort()

        //Swap algorithm, uses data values from class array data.
        public void Swap(int first, int second)
        {
            int temporary = data[first];
            data[first] = data[second];
            data[second] = temporary;
        }//end swap()

        //display a pass of the algorithm
        public void PrintPass(int pass, int index)
        { 
            //the pass int comes from the i in the sort function for each sort iteration
            Console.Write("after pass {0}: ", pass);

            //output elements through the selected item
            for (int i = 0; i < index; ++i)
            {
                Console.Write(data[i] + " ");
            }

            Console.Write(data[index] + "* ");  //indicate swap

            //finish outputting array
            for (int i = index + 1; i < data.Length; ++i)
            {
                Console.Write(data[i] + " ");
            }

            //alignment
            Console.Write("\n              ");

            //indicate amount of array that is sorted using pass number
            for (int j = 0; j < pass; ++j)
            {
                Console.Write("-- ");
            }

            Console.WriteLine("\n"); //skip a line in output

        }//end PrintPass()

        public override string ToString()
        {
            string temporary = string.Empty;

            foreach (int element in data)
                temporary += element + " ";

            temporary += "\n";
            return temporary;
        }//end ToString()
    }
}
