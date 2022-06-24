using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] people =
            {
             new string[] { "Локтионов Сергей Петрович", "Сухов Алексей Сергеевич", "Локтионов Петр Максимович", "Симов Александр Николаевич","Павлухин Лев Михаилович","Морозов Николай Викторович"},//имя 0
             new string[] { "яблочная","цветная","яблочная","цветная","цветная","яблочная" },//улица 1
             new string[] { "1","2","1","2","1","2"},//дом 2 
             new string[] { "6", "18", "30", "30","21","25" },//день рождения 3
             new string[] { "6", "7", "11", "11","10","9" },//месяц рождения 4
             new string[] { "2002", "2002", "2000", "1995","1999","2000" }//год рождения 5
            };

            int k = 0;
            Console.Write("Введите улицу (яблочная) или (цветная): ");
            string a = Console.ReadLine();
            Console.Write("Введите дом (1) или (2): ");
            string b = Console.ReadLine();
            Console.Write("Введите какой сейчас год: ");
            int y = Convert.ToInt32(Console.ReadLine());//год
            Console.Write("Введите какой сечас месяц: ");
            int m = Convert.ToInt32(Console.ReadLine());//месяц
            Console.Write("Введите сегоднешнее число: ");
            int d = Convert.ToInt32(Console.ReadLine());//день

            for (int i = 0; i < people[0].Length; i++)
                if (AgeAndHouse(people, i, a, b, y, m, d))
                    k++;

            int c = 0;
            string[] isbir = new string[k];
            Console.WriteLine("BEFORE:");//до сортировки по алфавиту
            for (int i = 0; i < people[0].Length; i++)
                 if (AgeAndHouse(people, i, a, b, y, m, d))
                 {
                        isbir[c] = people[0][i];
                        Console.WriteLine($"{c + 1}. {isbir[c]}");
                        c++;
                 }

            if (c != 1)
            {
                Console.WriteLine("AFTER:");//после сортировки по алфавиту
                for (int i = 0; i < k; i++)
                {
                    for (int j = 0; j < k - 1; j++)
                        if (Order(isbir[j], isbir[j + 1]))
                        {
                            string s = isbir[j];
                            isbir[j] = isbir[j + 1];
                            isbir[j + 1] = s;
                        }
                  Console.WriteLine($"{i + 1}. {isbir[i]}");
                }
            }
            Console.ReadLine();
        }

        public static bool Order(string s1, string s2)
        {
            for (int i = 0; i < (s1.Length > s2.Length ? s2.Length : s1.Length); i++)
            {
                if (s1.ToCharArray()[i] < s2.ToCharArray()[i]) return false;
                if (s1.ToCharArray()[i] > s2.ToCharArray()[i]) return true;
            }
            return false;
        }

        public static bool AgeAndHouse(string[][] people, int i, string a, string b, int y, int m, int d)
        {
            if ((people[1][i] == a && people[2][i] == b) && ((y - Convert.ToInt32(people[5][i]) > 18) || (y - Convert.ToInt32(people[5][i]) == 18 && (Convert.ToInt32(people[4][i]) < m || (Convert.ToInt32(people[4][i]) == m && Convert.ToInt32(people[3][i]) <= d)))))
                return true;
            else
                return false;
        }
    }
}
