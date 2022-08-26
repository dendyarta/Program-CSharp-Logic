using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    internal class QuizLogicDay02
    {
        public static void DisplayArrayInt(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
        }

        //1.
        public static void Nomer1()
        {
            int[] arrINT = new int[6];
            arrINT[0] = 15;
            arrINT[1] = 2;
            arrINT[2] = 30;
            arrINT[3] = 12;
            arrINT[4] = 10;
            arrINT[5] = 5;

            QuizLogicDay02.DisplayArrayInt(arrINT);
            Console.WriteLine();
            int panjang = arrINT.Length;


            for (int index = 0; index < panjang; index++)
            {
                int NilaiSementara = arrINT[index];
                int RandomIndex = new Random().Next(0, panjang);
                arrINT[index] = arrINT[RandomIndex];
                arrINT[RandomIndex] = NilaiSementara;
            }

            QuizLogicDay02.DisplayArrayInt(arrINT);
        }

        //2. 
        public static void nomer2()
        {
            int[] angka = new int[6];
            angka[0] = 15;
            angka[1] = 2;
            angka[2] = 30;
            angka[3] = 12;
            angka[4] = 10;
            angka[5] = 5;
            QuizLogicDay02.DisplayArrayInt(angka);
            Console.WriteLine();
            int[] tampung = new int[angka.Length];
            int temp = 0;

            for (int i = 0; i <= angka.Length; i++)
            {
                temp = angka[0];
                for (int j = 0; j < angka.Length-1; j++)
                {
                    angka[j] = angka[j+1];
                }
                angka[angka.Length-1] = temp;
            }
            
            QuizLogicDay02.DisplayArrayInt(angka);

        }
        public static void nomer3()
        {
            int[] angka = new int[6];
            angka[0] = 15;
            angka[1] = 2;
            angka[2] = 30;
            angka[3] = 12;
            angka[4] = 10;
            angka[5] = 5;
            QuizLogicDay02.DisplayArrayInt(angka);
            Console.WriteLine();
            Console.Write("Masukan jumlah rotasi  : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int temp = 0;

            for (int i = 0; i < n; i++)
            {
                temp = angka[0];
                for (int j = 0; j < angka.Length - 1; j++)
                {
                    angka[j] = angka[j + 1];
                }
                angka[angka.Length - 1] = temp;

                Console.WriteLine($"Rotate Ke - {i + 1}");
                QuizLogicDay02.DisplayArrayInt(angka);
                Console.WriteLine();
                Console.WriteLine();
            }

            

        }
        //4.
        public static void nomer4()
        {
            int[] angka = new int[6];
            angka[0] = 15;
            angka[1] = 2;
            angka[2] = 30;
            angka[3] = 12;
            angka[4] = 10;
            angka[5] = 5;
            QuizLogicDay02.DisplayArrayInt(angka);
            Console.WriteLine();
            Console.Write("Masukan jumlah rotasi  : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int tampung = 0;
            int banyak = angka.Length - 1;
            int temp = 0;

            for (int i = 0; i < n; i++)
            {
                temp = angka[5];
                for (int j = 0; j < banyak; j++)
                {
                    tampung = j + 1;
                    angka[banyak - j] = angka[banyak - tampung];

                }
                angka[0] = temp;

                Console.WriteLine($"Rotate Ke - {i + 1}");
                QuizLogicDay02.DisplayArrayInt(angka);
                Console.WriteLine();
                Console.WriteLine();
            }

        }
    }
}
