using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest2022
{
    internal class Answers
    {
        public static void nomer1()
        {
            int X = 10;
            int Y = 85;
            int K = 30;

            int berapaKali = 0;

            while (Y > 0)
            {
                Y = Y - (K + X);
                berapaKali++;
            }

            Console.WriteLine($"Katak harus Melompat = {berapaKali}");
        }

        public static int nomer2(int n)
        {
            int x = 1;
            for (int i = n; i > 0; i--)
            {
                x = x * i;
            }

            return x;
        }

        public static int nomer3(int n)
        {
            int x = 0;

            for (int i = 1; i <= n; i++)
            {
                x = x + i;
            }

            return x;
        }

        public static int nomer4(int n)
        {
            int x = n;
            int n1 = 1;
            int n2 = 2;
            int n3 = 0;

            if (x == 1)
            {
                x = 1;
            }
            else if (x == 2)
            {
                x = 2;
            }

            else if (x > 2)
            {
                for (int i = 2; i < n; i++)
                {
                    n3 = n2 + n1;
                    n1 = n2;
                    n2 = n3;
                }

                x = n3;
            }

            return x;
        }

        public static void nomer5()
        {
            Console.Write("Masukan angka Fibbonaci : ");
            int x = Convert.ToInt32(Console.ReadLine());
            int n1 = 0;
            int n2 = 1;
            int n3 = 0;

            Console.Write($"ShowFibo({x}) : 1 ");

            for (int i = 1; i < x; i++)
            {
                n3 = n2 + n1;
                Console.Write($"{n3} ");
                n1 = n2;
                n2 = n3;
            }

        }

        public static bool nomer6(string s)
        {
            bool x;
            int buka = 0;
            int tutup = 0;


            string kurawa = s;

            for (int i = 0; i < kurawa.Length; i++)
            {
                if (kurawa[i] == '{')
                {
                    buka = buka + 1;
                }
                else if (kurawa[i] == '}')
                {
                    tutup = tutup + 1;
                }
                else
                {
                    x = false;
                }
            }
            if (buka == tutup)
            {
                x = true;
            }
            else
            {
                x = false;
            }

            return x;
        }
        public static bool nomer7(string kats1, string kats2)
        {
            bool kata;

            string kata1 = kats1;
            kata1 = kata1.ToLower();

            string kata2 = kats2;
            kata2 = kata2.ToLower();

            if (kata1.Length != kata2.Length)
            {
                kata = false;
            }
            else if (kata1.Length == kata2.Length)
            {
                kata = true;
            }
            var huruf = new Dictionary<char, int>();

            //mengisi kata inputan ke -1 ke dictionary dengan huruf dan menghitungnya.
            foreach (char element in kata1.ToCharArray())
            {
                if (huruf.ContainsKey(element))
                    huruf[element]++;
                else
                    huruf.Add(element, 1);
            }

            // mengisi kata inputan ke-2
            foreach (char element in kata2.ToCharArray())
            {
                //jika huruf gada yang sama; we're out
                if (!huruf.ContainsKey(element))
                    kata = false;

                // jika perhitungan huruf kurang setelah pengurangan huruf double; we're out
                else if (--huruf[element] == 0)
                    huruf.Remove(element);
            }
            return huruf.Count == 0;
        }

        public static void DisplayMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++) // looping baris
            {
                for (int j = 0; j < matrix.GetLength(1); j++)//loop kolom
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public static void nomer8()
        {
            int baris1 = 5;
            int kolom1 = 5;

            int[,] matrix1 = new int[baris1, kolom1];

            for (int i = 0; i < baris1; i++)
            {
                for (int j = 0; j < kolom1; j++)
                {
                    if( (i+j) <= (baris1-1) )
                    {
                        matrix1[i, j] = (baris1 + kolom1) - j ;
                    }
                }

            }
            DisplayMatrix(matrix1);
            Console.WriteLine();
            Console.WriteLine();

            int baris2 = 5;
            int kolom2 = 5;
            int count2 = 1;

            int[,] matrix2 = new int[baris2, kolom2];

            for (int i = 0; i < baris2; i++)
            {
                for (int j = 0; j < kolom2; j++)
                {
                    if (j <= i)
                    {
                        matrix2[i, j] = count2;
                        count2++;
                    }
                }

            }
            DisplayMatrix(matrix2);
            Console.WriteLine();
            Console.WriteLine();

            int baris3 = 7;
            int kolom3 = 4;

            int[,] matrix3 = new int[baris3, kolom3];

            for (int i = 0; i < baris3; i++)
            {
                for (int j = 0; j < kolom3; j++)
                {
                    
                    if (i <= (baris3/2))
                    {
                        if (i >= j)
                        {
                            matrix3[i, j] = j+1;
                        }
                        else
                        {
                            matrix3[i, j] = 0;
                        }
                    }
                    else if (i > (baris3 / 2))
                    {
                        if ((i + j) >= baris3)
                        {
                            matrix3[i, j] = 0;
                        }
                        else
                        {
                            matrix3[i, j] = j + 1;
                        }

                    }
                    
                }

            }
            DisplayMatrix(matrix3);
            Console.WriteLine();
            Console.WriteLine();

            int baris4 = 5;
            int kolom4 = 9;

            int[,] matrix4 = new int[baris4, kolom4];

            for (int i = 0; i < baris4; i++)
            {
                for (int j = 0; j < kolom4; j++)
                {
                    matrix4[i, j] = i + j;
                    if (j <= (baris4 / 2))
                    {
                        if ((i + j) < (kolom4/2))
                        {
                            matrix4[i, j] = 0;
                        }
                        else
                        {
                            matrix4[i, j] = j + 1;
                        }
                    }
                    else if (j > (baris4 / 2))
                    {
                        matrix4[i, j] = 0;
                    }

                }

            }
            DisplayMatrix(matrix4);
            Console.WriteLine();
            Console.WriteLine();
        }

        
    }
}
