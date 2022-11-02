using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_2_Algoritma_Semester_3
{
    internal class Program
    {
        //Array to be searcher
        int[] rap = new int[44];
        //Number of element in the array
        int n;
        //get number of the element to store in the array
        int i;

       public void input()
        {
            while (true)
            {
                Console.WriteLine("Enter the number of the element in the array: ");
                string s = (Console.ReadLine());
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 44))
                    break;
                else
                    Console.WriteLine("\nArray should have minimum 1 and maximum 20 elements");
            }
        }
    }
}
