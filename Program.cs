using System;

namespace homework_practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num1 = Console.ReadLine();
            var Letter1 = Convert.ToInt32(num1);
            var num2 = Console.ReadLine();
            var Letter2 = Convert.ToInt32(num2);
            var count = 0;
            var sum = 0;
            while (Letter1 < Letter2)
            {
                if (Letter1 % 21 == 0)
                {
                    count++;
                    sum += Letter1;
                    Letter1++;
                    continue;

                }
                else
                {


                    Letter1++;
                    continue;
                }


            }
            if (count > 0)
            {
                var avr = sum / count;
                Console.WriteLine(avr);


            }
            else
            {

                Console.WriteLine("eded tapilmadi");

            }
            Console.WriteLine("=========================");
            var nums = Console.ReadLine();
            var letter3 = Convert.ToInt32(nums);
            var sumAll = 0;
            do
            {
                sumAll += letter3 % 10;
                letter3 /= 10;

            }
            while (letter3 > 0);


            Console.WriteLine(sumAll);
            Console.WriteLine("==============");
            Console.WriteLine("eded daxil et");
            var num = Console.ReadLine();
            string dum = "0123456789";
            bool hasNum = false;


            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < dum.Length; j++)
                {
                    while (num[i] == dum[j])
                    {

                        hasNum = true;
                        Console.WriteLine("regem ver tezden yaz");
                        num = Console.ReadLine();

                    }


                }

            }
            if (hasNum)
            {

                Console.WriteLine("eded daxil edildi");

            }


            Console.WriteLine("============");
            var cos = Console.ReadLine();
            var len = Convert.ToInt32(cos);
            var cos1 = Console.ReadLine();
            var len1 = Convert.ToInt32(cos1);
            string nummer = "+-/*";
            for(int z=0; z< nummer.Length; z++)
            {

                while(nummer)


            }
            





        }



           

            












        }




 }  

