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
            //Accept array elements
            Console.WriteLine("");
            Console.WriteLine("--------------------");
            Console.WriteLine("Enter Array Elements");
            Console.WriteLine("--------------------");
            for (i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = (Console.ReadLine());
                rap[i] = Int32.Parse(s1);

            }
        }

        public void firstalgorithm()
        {
          for(int i = 1; i < n; i++)
            {
                for (int RA = 0; RA < n; RA++)
                {
                  if(rap[RA] > rap[RA + 1])
                    {
                        int temp;
                        temp = rap[RA];
                        rap[RA] = rap[RA + 1];
                        rap[RA + 1] = temp;
                    }
                }
            }
        }
        public void mergedsort()
        {

        }

        static void Main(string[] args)
        {
            Program myList = new Program();
            int pilihanmenu;
            char ch;
            do
            {
                {
                    Console.WriteLine("Menu Option");
                    Console.WriteLine("-----------");
                    Console.WriteLine("1.First Algorithm Sort");
                    Console.WriteLine("2.High Low Algorithm");
                    Console.WriteLine("3.Exit");
                    Console.WriteLine("Enter your choice (1,2,3) : ");
                    pilihanmenu = Convert.ToInt32(Console.ReadLine());
                    switch (pilihanmenu)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine(".............");
                            Console.WriteLine("first algorithm sort");
                            Console.WriteLine(".............");
                            myList.input();
                            myList.firstalgorithm();
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine(".............");
                            Console.WriteLine("Merged Sort");
                            Console.WriteLine(".............");
                            myList.input();
                            myList.mergedsort();
                            break;
                        case 3:
                            Console.WriteLine("exit.");
                            break;
                        default:
                            Console.WriteLine("Error");
                            break;
                    }
                    Console.WriteLine("\nPilih Menu Lagi? (y/n) : ");
                    ch = char.Parse(Console.ReadLine().ToLower());
                    Console.Clear();
                } while (ch == 'y') ;

                // to exit from the console
                Console.WriteLine("\n\nPress Return to exit. ");
                Console.ReadLine();
            } while (pilihanmenu != 3);
        }
    }
}
