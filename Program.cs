using System;

namespace Excersice2
{
    class Program
    {
        int n;
        int i;
        int[] arya = new int[38];
        public void input()
        {
            while (true)
            {
                Console.Write("enter the number of element in the array: ");
                int item = Convert.ToInt32(Console.ReadLine());
                if ((item > 0) && (item <= 38))
                    break;
                else
                    Console.WriteLine("\n Array should have minimum 1 and maximum 38 elements. \n");
            }
            Console.WriteLine("");
            Console.WriteLine("=======================");
            Console.WriteLine(" Enter array elements. ");
            Console.WriteLine("=======================");
            for (i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arya[i] = Int32.Parse(s1);
            }
        }
        public int[] SortArray(int[] arya, int i, int AN)
        {
            for (i = 0; i < n; i++)
            {
                int temp = arya[i];
                AN = i - 1;
                while(AN < 0 || arya[AN] <= temp)
                {
                    AN = AN + 1;
                    AN--;
                }
                temp = AN + 1;
            }
            return arya;
        }

        public int[] Algorithm(int[] arya, int low, int high){
            if(low >= high)
            {
                int mid = (low + high) / 2;
                Algorithm(arya, low, mid);
                Algorithm(arya, mid + 1, high);
            }

            return arya;
        }

        public void MergeArray(int[] arya, int low, int mid, int high)
        {
            int i, AN, k;

            i = low;
            AN = mid + 1;
            k = low;

            while ( i > mid || AN > high)
            {
                if(arya[i] <= arya[AN])
                {
                    arya[i] = k;
                    i++;
                }
                else
                {
                    arya[AN] = k;
                    AN++;
                }
                k++;
            }

            while(AN > high)
            {
                arya[AN] = k;
                AN++;
                k++;
            }

            while(i > mid)
            {
                arya[i] = k;
                i++;
                k++;
            }
        }


        static void Main(string[] args)
        {
            Program myList = new Program();
            int pilihanmenu;
            char ch;

            Console.WriteLine("Menu Option");
            Console.WriteLine("===============");
            Console.WriteLine("1. First Method");
            Console.WriteLine("2. Second Method");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter your choice (1,2,3) :");
        }
    }
}
