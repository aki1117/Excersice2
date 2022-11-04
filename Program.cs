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
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
