using System.Linq.Expressions;
using System.Threading.Channels;

namespace meethodtest1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vajutage 1 kui ristküliku rakendust, 2 foreachi, 3 wherelinq, 4 püramiid ja 5 kalkulaator");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------");
            switch (a)
                {
                case 1:
                    ristkulik();
                    break;
                    case 2:
                    zesty();
                    break;
                    case 3:
                    wherelinq();
                    break;
                case 4: 
                    pym();
                    break;
                case 5:
                    calc();
                    break;

            }
        }
        static void ristkulik()
        {
            Console.WriteLine("Määra ristküliku pikkus ja laius");
            int n = Convert.ToInt16(Console.ReadLine());
            int m = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("---------------------------------");
            int e = n * m;
            int a = 2*(m+n);
            Console.WriteLine("Ristküliku pindala on "+ e+ " ja ümbermõõt on "+ a+ " .");
            Console.WriteLine(" ");
            int i, j;
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= m; j++)
                {
                    if (i == 1 || i == n ||
                        j == 1 || j == m)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static void zesty()
        {
            string[] test = { "Womp womp","No maidens", "No Spotify premium", "Exclusively Single", "Absolutely zesty" };
            foreach (string e in test)
            {
                Console.WriteLine(e);
            }
        }
        static void wherelinq()
        {
            var peopleAge = wherelingbs.Peoples
                .Where(x => x.Age > 20 && x.Age < 23);

            foreach (var people in peopleAge)
            {
                Console.WriteLine(people.Name);
            }
        }
        static void pym()
        {
            int k = 10;
            int j = 0;
            while (true)
            {
                int i = 0;
                while (true)
                {
                    if (i >= (k - j) && i <= (k + j))
                    {
                        Console.Write("*");
                        Console.Write("\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                    if (i > (j + k))
                    {
                        break;
                    }
                    i++;
                }
                Console.Write("\n");
                if (j == (k - 1))
                {
                    break;
                }

                j++;
            }
        }
        static void calc()
        {
            Console.WriteLine("Valikus on liitmine, lahutamine, korrutamine, jagamine JA ruutjuur");
            string e = Console.ReadLine();
            try { 
            switch (e)
            {
                case "liitmine":
                    Console.WriteLine("Sisesta esimene ja teine number");
                    int a = Convert.ToInt16(Console.ReadLine());
                    int b = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("tulemus: " +(a+b));
                    break;
                    case "lahutamine":
                    Console.WriteLine("Sisesta esimene ja teine number");
                    int C = Convert.ToInt16(Console.ReadLine());
                    int D = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("tulemus: " + (C - D));
                    break;
                    case "korrutamine":
                    Console.WriteLine("Sisesta esimene ja teine number");
                    int E = Convert.ToInt16(Console.ReadLine());
                    int F = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("tulemus: " + (E * F));
                    break;
                    case "jagamine":
                    Console.WriteLine("Sisesta esimene ja teine number");
                    int G = Convert.ToInt16(Console.ReadLine());
                    int H = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("tulemus: " + (G / H));
                    break;
                case "ruutjuur":
                    Console.WriteLine("Sisesta mingi väärtus");
                    int j = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("tulemus: " + Math.Sqrt(j));
                    break;
            }
            
            }
            catch (Exception a)
            {
                Console.WriteLine("See pole arv");
            }
        }
    }
}
