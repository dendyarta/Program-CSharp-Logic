using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    internal class MyCollections
    {
        public static void InitList()
        {
            var alfabet = new List<string>() { "A", "B", "C", "D", "E" };
            alfabet.Add("F");
            alfabet.AddRange(new[] { "G", "H", "I" });
            alfabet.Insert(0, "J");
            alfabet.InsertRange(3, new[] { "X", "Y" });

            foreach (var item in alfabet)
            {
                Console.Write($"{item} ");
            }

            // remove element from List<T>
            alfabet.Remove("X");
            alfabet.RemoveRange(4, 6);
            alfabet.RemoveAll(v => v == "A");

            //clear
            alfabet.Clear();

            // declare List<int>
            var numbers = new List<int>() { 2, 5, 7, 11, 13, 17, 19 };
            numbers.Remove(13);
            numbers.RemoveAll(v => v >= 7);

            // find element
            var a = numbers.Find(e => e < 10);
            var b = numbers.Find(e => e > 11);
            var c = numbers.Find(e => e <= 10);

            // find index element
            var d = numbers.FindIndex(e => e <= 11);
            var e = numbers.FindLastIndex(e => e <= 10);
            var f = numbers.IndexOf(13);
            var g = numbers.BinarySearch(11);

            Console.WriteLine();
        }

        public static void InitStack()
        {
            var numbers = new Stack<int>(new int[] { 1, 2, 3 });
            numbers.Push(5);
            numbers.Push(7);

            //remove
            numbers.Pop();
            var n = numbers.Peek();
            numbers.Clear();
        }

        public static void InitDictionary()
        {
            var pl = new Dictionary<int, string>();
            pl.Add(1, "C#");
            pl.Add(2, "Java");

            var pl2 = new Dictionary<int, string>()
            {
                {1, "C#" },
                {2, "Java" },
                {3, "Phyton" }
            };

            //add new element
            pl2.Add(4, "Golang");

            //pl2.Add(4 , "SQL")
            pl2.TryAdd(4, "SQL");
            pl2[4] = "SQL";

            foreach (var item in pl2)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }

        public static void InitHashSet()
        {
            var number = new HashSet<int>() { 1, 2, 3, 5, 8};
            number.Add(5);
            number.Add(10);
            number.Add(8);

            var hs1 = new HashSet<int>() { 1, 2, 5, 6, 9 };
            var hs2 = new HashSet<int>() { 1, 2, 3, 4 };
            var result1 = new HashSet<int>();
            result1.IntersectWith(hs2); // inner join (1,2)

            var result2 = new HashSet<int>(hs1);
            result2.UnionWith(hs2); // union atau gabungan 2 variable (1,2,3,4,5,6,9)

            var result3 = new HashSet<int>(hs1);
            result3.ExceptWith(hs2); // Result 5,6,9

            var result4 = new HashSet<int>(hs1);
            result4.SymmetricExceptWith(hs2); // result 3,4,5,6,9

            //convert hashset to List
            var myNumber = result4.ToList();

            Console.WriteLine();
        }

        //FiFo
        public static void InitQueue()
        {
            var queue = new Queue<string>();
            queue.Enqueue("asep");
            queue.Enqueue("budi");
            queue.Enqueue("charlie");

            Console.WriteLine($"Queue from front to back");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            string served = queue.Dequeue();
            Console.WriteLine();
            Console.WriteLine($"Served :  {served}");
        }

        //return LIST<T>

        public static List<T> GetStudent<T>(ref List<T> list)
        {
            var myList = new List<T>();
            foreach (var item in list)
            {
                myList.Add(item);
            }
            return myList;
        }

    }
}
