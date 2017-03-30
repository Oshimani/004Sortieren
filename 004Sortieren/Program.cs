using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004Sortieren
{
    class Program
    {
        public static int[] arr = { 1, 5, 3, 36, 43, 4, 76, 44, 3, 1, 0, 8, 65, 2 };
        static void Main(string[] args)
        {
           
            sort();
            gibAus(arr);

        }
        static void sort()
        {
            int links = 0, rechts = arr.Length -1;
            quicksort(links, rechts);
        }
        static void quicksort(int links, int rechts)
        {
            if (links < rechts)
            {
                int teiler = teile(links, rechts);
                //Console.WriteLine("L:{0} R:{1} T:{2}", links, rechts, teiler);
                //gibAus(arr);
                quicksort(links, teiler - 1);
                quicksort(teiler + 1, rechts);
            }

        }
        static int teile(int links, int rechts)
        {
            int i = links;
            int j = rechts - 1;
            int pivot = arr[rechts];
            //Console.WriteLine("Pivot: {0}", pivot);
            do
            {
                while (arr[i] <= pivot && i < rechts)
                {
                    i = i + 1;
                }
                while (arr[j] >= pivot && j > links)
                {
                    j = j - 1;
                }
                if (i < j)
                {
                    tausche(i, j);
                }
                if (arr[i] > pivot)
                {
                    tausche(i, rechts);
                }
            } while (i < j);
            return i;
        }
        static void tausche(int i, int j)
        {
            //Console.WriteLine("Tausche arr[{0}]={1} mit arr[{2}]={3}", i, arr[i], j, arr[j]);
            int tmp = arr[i];
            arr[i] = arr[j];
            arr[j] = tmp;
        }

        static void gibAus(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.Write("\n");
        }
    }
}
