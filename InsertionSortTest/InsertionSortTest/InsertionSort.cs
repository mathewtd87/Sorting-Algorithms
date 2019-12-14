using System;
namespace InsertionSortTest
{
    public class InsertionSort
    {
        private int[] data;
        private static Random generator = new Random();

        public InsertionSort(int size)
        {
            data = new int[size];

            for (int i = 0; i < data.Length; ++i)
                data[i] = generator.Next(10, 100);
        }

        public void Sort()
        {
            int insert; // temporary variable to hold value to insert

            for (int next = 1; next < data.Length; ++next)
            {
                //current value, store in temporary insert variable
                insert = data[next];
                
                //get location
                int moveItem = next; //storing an index
                
                //while data[moveItem - 1] ie previous val is greater than the insert variable value
                while (moveItem > 0 && data[moveItem - 1] > insert)
                {
                    //shift data value of left element to the right
                    data[moveItem] = data[moveItem - 1];
                    moveItem--; //Ensures the loop will end.
                }

                data[moveItem] = insert;  //place inserted element
                PrintPass(next, moveItem); //Output result of algorithm
            }
        }//end Sort()

        public void PrintPass(int pass, int index)
        {
            //print the pass number to console
            Console.Write("after pass {0}: ", pass);

            //output elements up to swapped item
            for(int i = 0; i < index; ++i)
            {
                Console.Write(data[i] + " ");
            }
            //output swapped item indicated with an asterisk
            Console.Write(data[index] + "* ");

            //output rest of the array
            for (int i = index + 1; i < data.Length; ++i)
                Console.Write(data[i] + " ");

            Console.Write("\n            ");

            //Indicate how much of the array has been passed
            for (int i = 0; i < pass; ++i)
                Console.Write("-- ");

            Console.WriteLine();
        }//end PrintPass()

        public override string ToString()
        {
            string temporary= string.Empty;
            //add each element od the data array into the temporary string
            foreach (int element in data)
                temporary += element + " ";

            temporary += "\n";  //add a new line character and then return the temporary string
            return temporary;
        }
    }
}
