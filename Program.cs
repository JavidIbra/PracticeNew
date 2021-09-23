using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Homework3";

            #region task1

            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("telebenin balini daxil edin");
            //        int num = int.Parse(Console.ReadLine());

            //        if (num < 0 && num > 100)
            //        {
            //            Console.WriteLine("duzgun eded daxil edin!!");
            //        }

            //        else if (num <= 100 && num > 90)
            //        {
            //            Console.WriteLine("telebenin bali: A");
            //        }
            //        else if (num <= 90 && num > 80)
            //        {
            //            Console.WriteLine("telebenin bali: B");

            //        }
            //        else if (num <= 80 && num > 70)
            //        {
            //            Console.WriteLine("telebenin bali: C");

            //        }
            //        else if (num <= 70 && num > 60)
            //        {
            //            Console.WriteLine("telebenin bali: D");

            //        }
            //        else if (num <= 60 && num > 50)
            //        {
            //            Console.WriteLine("telebenin bali: E");

            //        }
            //        else if (num <= 50 && num >= 0)
            //        {
            //            Console.WriteLine("kesildiniz ");

            //        }

            //    }

            //    catch (Exception)
            //    {
            //        Console.WriteLine("error");

            //    }
            //}
            //Console.ReadKey();
            #endregion

            #region task2

            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("eded daxil edin: ");
            //        int num1 = int.Parse(Console.ReadLine());
            //        if (num1 > 0)
            //        {
            //            for (int i = 1; i <= num1; i++)
            //            {
            //                if (num1 % i == 0)
            //                {
            //                    Console.WriteLine($"ededin tam bolenleri : {i}");
            //                }
            //            }
            //        }
            //        else if (num1 == 0)
            //        {
            //            Console.WriteLine("0 in bolenlerini tapmaq olmaz!!!");
            //        }
            //        else
            //        {
            //            Console.WriteLine("musbet eded daxil edin!!!");
            //        }
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("yalniz eded daxil edilelidir!!!");

            //    }
            //}

            //Console.ReadKey();

            #endregion

            #region task3

            //int i;
            //int divider = 0;
            //while (true)
            //{
            //    Console.WriteLine("eded daxil edin: ");

            //    try
            //    {
            //        int numb = int.Parse(Console.ReadLine());
            //        if (numb >= 0)
            //        {
            //            for (i = 0; i <= numb; i++)
            //            {

            //                divider = numb % 10;
            //                numb = (numb - divider) / 10;

            //            }
            //            if (numb == 1 || numb == 2)
            //            {
            //                i += 1;
            //            }

            //            Console.WriteLine($"eded {i} reqemlidir");
            //        }
            //        else if (numb == 0)

            //        {
            //            Console.WriteLine("0 dan yuxari eded daxil edin!!!");
            //        }
            //        else
            //        {
            //            Console.WriteLine("musbet eded daxil edin");
            //        }

            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("error");
            //    }
            //}

            //Console.ReadKey();

            #endregion

            #region task4

            //int i;
            //int sum = 0;
            //while (true)
            //{
            //    Console.WriteLine("eded daxil edin: ");

            //    try
            //    {
            //        int numb = int.Parse(Console.ReadLine());

            //        if (numb > 9)
            //        {
            //            for (i = 0; i <= numb; i++)
            //            {

            //                sum += numb % 10;
            //                numb = numb / 10;
            //            }

            //            Console.WriteLine($"ededin reqemlerinin cemi {sum} dir");
            //            break;
            //        }
            //        else if (numb == 0)

            //        {
            //            Console.WriteLine("0 dan yuxari eded daxil edin!!!");
            //        }
            //        else if (numb > 0 && numb < 10)
            //        {
            //            Console.WriteLine("eded 1 reqemlidir!!!");

            //        }
            //        else
            //        {
            //            Console.WriteLine("musbet eded daxil edin");
            //        }

            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("error");
            //    }
            //}

            //Console.ReadKey();

            #endregion

            //-----Diqqet : method olan tapsiriqlari main methoddan colde yazib main methodda cagirmisam.asagiya baxin zehmet olmasa----//

            #region task7
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("arrayin eded sayini daxil edin:");
            //        int r = int.Parse(Console.ReadLine());
            //        int[] num = new int[r];
            //        int sum = 0;
            //        int max = 0, min = 0;


            //        for (int i = 0; i < r; i++)
            //        {
            //            Console.WriteLine("arrayin ededlerini daxil edin:");

            //            num[i] = int.Parse(Console.ReadLine());
            //        }


            //        max += num.Max();
            //        min += num.Min();
            //        sum = max + min;

            //        Console.WriteLine($"arrayin max ededi {max} , min ededi ise {min} dur.");
            //        Console.WriteLine($"arrayin max ve min ededlerinin cemi ise {sum} ");
            //    }
            //    catch (Exception)
            //    {

            //        Console.WriteLine("error");
            //    }
            //}

            //Console.ReadKey();


            #endregion

            #region task8

            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("1-4 arasi eded daxil edin:");
            //        int num = int.Parse(Console.ReadLine());

            //        if (num >= 1 && num <= 4)
            //        {
            //            switch (num)
            //            {
            //                case 1:
            //                    Console.WriteLine("fesil yazdir");
            //                    break;
            //                case 2:
            //                    Console.WriteLine("fesil yaydir");
            //                    break;
            //                case 3:
            //                    Console.WriteLine("fesil payizdir");
            //                    break;
            //                case 4:
            //                    Console.WriteLine("fesil qisdir");
            //                    break;
            //            }

            //        }
            //        else
            //        {
            //            Console.WriteLine("1-4 arasi dedim axi!!!");
            //        }

            //    }
            //    catch (Exception)
            //    {

            //        Console.WriteLine("error");
            //    }
            //    continue;

            //}
            //Console.ReadKey();

            #endregion

            #region task10

            //try
            //{
            //    Console.WriteLine("1-10 da daxil olmaqla her hansi bir eded daxil edin!!!");
            //    int num = int.Parse(Console.ReadLine());
            //    int multp = 0;
            //    if (num >= 1 && num <= 10)
            //    {
            //        for (int i = 1; i <= 10; i++)
            //        {
            //            multp = num * i;
            //            Console.WriteLine($" daxil edilmis ededin vurma cedveli {multp}");
            //            multp = num / i;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("1-10 araligi eded daxil edin(!");
            //    }
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("error");
            //}


            //Console.ReadKey();


            #endregion


           // -------task5------//
            //Console.WriteLine(Boole());
            //Console.ReadKey();


            //-----task6-----//
            //Factor();
            //Console.ReadKey();


            //----task9-----//
            //LongestString();
            //Console.ReadKey();

        }

        #region task5-BooleMethod

        //static bool Boole()
        //{
            
        //    Console.WriteLine("musbet eded daxil edin,eger eded sadedirse true , deyilse false alacaqsiz");
        //    int num1 = int.Parse(Console.ReadLine());


        //    if (num1 == 2 || num1 == 3)
        //    {
        //        return true;
        //    }
        //    else if (num1 % 2 == 0 || num1 % 3 == 0)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }

        //}

        #endregion

        #region task6-FactorMethod

        //static void Factor()
        //{
        //    Console.WriteLine("eded daxil edin: ");

        //    int mult = 1;
        //    try
        //    {
        //        int num1 = int.Parse(Console.ReadLine());

        //        if (num1 > 1)
        //        {
        //            for (int i = 1; i <= num1; i++)
        //            {
        //                mult *= i;
        //            }

        //        }
        //    Console.WriteLine($"daxil edilmis ededin faktoriali :{mult} " );

        //    }
        //    catch (Exception)
        //    {
        //    Console.WriteLine("error" );

        //    }


        #endregion

        #region task9-LongestSting

        //static void LongestString()
        //{
        //    string s = "";
        //    int ctr = 0;
        //    while (true)
        //    {
        //        try
        //        {
        //            Console.WriteLine("string arrayinde olan sozlerin sayini daxil edin");
        //            int worrd = int.Parse(Console.ReadLine());
        //            string[] words = new string[worrd];
        //            for (int i = 0; i < words.Length; i++)
        //            {
        //                Console.WriteLine("indi ise sozleri daxil edin");
        //                words[i] = Console.ReadLine();
        //            }

        //            foreach (var item in words)
        //            {
        //                if (item.Length>ctr)
        //                {
        //                    s = item;
        //                    ctr = s.Length;
        //                }
        //            }

        //            Console.WriteLine($"Arrayda en uzun soz {s} dir");
        //        }

        //        catch (Exception)
        //        {

        //            Console.WriteLine("error");
        //        }
        //    }

        //    Console.ReadKey();
        //}

        #endregion



    }
}



