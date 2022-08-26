using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    internal class ArraysCase
    {
        public static void IntroArray()
        {
            //declare array with int data type
            int[] arr;
            int[] arrINT = new int[10];
            arrINT[0] = 1;
            arrINT[1] = 2; 
            arrINT[2] = 3;  
            arrINT[3] = 4;    
            arrINT[4] = 5;
            arrINT[5] = 6;  
            arrINT[6] = 7;
            arrINT[7] = 8;
            arrINT[8] = 9;
            arrINT[9] = 10;

            // init array with string data type
            string[] ListOfGirl = new string[] { "Yuli","Rini","Widi" };

            // Display Array
            foreach (var item in ListOfGirl)
            {
                Console.WriteLine(item);

            }

            for (int i = 0; i < ListOfGirl.Length; i++)
            {
                Console.WriteLine(ListOfGirl[i]);
            }
        }
        
        //Method return or function input array int, return array int
        public static int[] InitArrayInt(int[] arr)
        {
            int[] array = arr;
            return array;
        }

        //initial value with random
        public static int[] InitArrayRandom(int n)
        {
            int[] arr = new int[n];
            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 50);

            }
            return arr;
        }
        //sum all element array
        public static double SumAllElement(int[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        //find large element
        public static int FindLargestElement(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public static void DisplayArrayInt(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
