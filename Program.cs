using System;

namespace ггг
{
    
             class Program
        {

            static bool Binary(ref int[] arr, int key)
            {

                int L = 0, R = arr.Length - 1, mid;

                while (L <= R)
                {
                    mid = (R + L) / 2;
                    if (arr[mid] == key) { return true; }
                    else if (arr[mid] < key) { L = mid + 1; }
                    else if (arr[mid] > key) { R = mid - 1; }
                }
                return false;
            }

            static void Main(string[] args)
            {

                int size;
                size = int.Parse(Console.ReadLine());



                int[] arr = new int[size];
                for (int i = 0; i < size; ++i)
                {
                    arr[i] = i + 1;
                }
                Console.WriteLine(Binary(ref arr, 140));
                Console.ReadKey();

            }

        }
    }
    

