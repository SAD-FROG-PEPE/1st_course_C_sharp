using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] mat = new double[100];
            decimal s=0;

            for (int i = 0; i < 100; i++)
            {
                mat[i] = 1 / Math.Pow(2,i);
                Console.WriteLine(mat[i]);
                s += (decimal)mat[i];
            }

            int a = 0;
            for (int i = 0; i < s.ToString().Length; i++)
            {
                if (i> (s.ToString()).IndexOf(','))
                    a++;
                Console.Write(s.ToString()[i]);
                if (a == 10)
                    break;
            }
            Console.ReadLine();
        }
    }
}
