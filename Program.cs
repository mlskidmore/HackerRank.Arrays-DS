using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Arrays_DS
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrCount = Convert.ToInt32(args[0]);

            //int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int[] arr = new int[args.Length - 1];

            for (int i = 1; i < args.Length; i++)
            {
                arr[i - 1] = Convert.ToInt32(args[i]);
            }

            //int[] arr = Array.ConvertAll(args[1].Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            int[] res = new int[arrCount];

            if (arrCount > 0 && arrCount <= 1000)
            {
                res = reverseArray(arr);
                //textWriter.WriteLine(string.Join(" ", res));
                Console.WriteLine(string.Join(" ", res));
            }

            //textWriter.Flush();
            //textWriter.Close();

            Console.ReadLine();
        }

        static int[] reverseArray(int[] a)
        {

            int[] temp = new int[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                temp[i] = a[a.Length - 1 - i];
            }
            return temp;
        }
    }
}
