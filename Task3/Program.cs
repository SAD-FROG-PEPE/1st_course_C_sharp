using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 14, 15, 15}; //сторона а для 3х треугольников
            int[] b = { 10, 9, 8 }; // сторона в для 3х треугольников
            int[] c = { 8, 7, 10}; //сторона с для 3х треугольников
            int sum,maxsum=0;
            double s,maxs=0;
            int imax=0;
            int jmax = 0;

            for (int i = 0; i < 3; i++)
            {
                sum = a[i] + b[i] + c[i];
                if (maxsum < sum)
                {
                    maxsum = sum;
                    imax = i;
                }
                
                float p = sum / 2f;
                s =Math.Sqrt(p*(p-a[i])*(p-b[i])*(p-c[i]));
                if (maxs < s)
                {
                    maxs = s;
                    jmax = i;
                }
                Console.WriteLine($"у {i+1}го трегольника периметр {sum}, а площадь {s}");
            }

            imax++;
            jmax++;
            if (imax != jmax)
                Console.WriteLine($"Так как в данном примере периметр больше у {imax}-го, треугольника, а площадь у {jmax}-го, то не всегда будет один и тот же треугольник");
            else
                Console.WriteLine($"В данном примере наибольшая площадь и наибольший периметр у одного теругольника {imax} (попробуйте ввести другие стороны треугольника, чтобы убедиться, что не всегда будет один и тот же треугольник)");
            Console.ReadLine();
        }
    }
}
