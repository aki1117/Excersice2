using System;

namespace Excersice2
{
    class Program
    {
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
            Console.WriteLine("Hello World!");
        }
    }
}
