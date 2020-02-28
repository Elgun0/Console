using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit kivi = new Fruit();
            kivi.ad = "kivi";
            kivi.qiymet = 4;
            Fruit banan = new Fruit();
            banan.ad = "banan";
            banan.qiymet = 2;
            Fruit alma = new Fruit();
            alma.ad = "alma";
            alma.qiymet = 0.80;
            Console.WriteLine(kivi.ad + "-" + kivi.qiymet+" Azn"+ ","+ "\n" + banan.ad + "-" + banan.qiymet + " Azn");



            /*  double num, result, interest;
              Console.WriteLine("Reqem daxil edin...");
              num = Convert.ToDouble(Console.ReadLine());
              Console.WriteLine("Faiz daxil edin...");
              interest = Convert.ToDouble(Console.ReadLine());
              result = num * interest / 100;
              Console.WriteLine($"{num} reqeminin {interest}% i {result}");
            */


          /*  string meyve;
            do
            {
                Console.WriteLine("Meyve adi daxil edin");
                meyve = Console.ReadLine();
                switch (meyve)
                {
                    case "banan":
                        Console.WriteLine("kq/2 Azn");
                        break;
                    case "kivi":
                        Console.WriteLine("kq/5 Azn");
                        break;
                    case "alma":
                        Console.WriteLine("kq/0.80 Azn");
                        break;
                    case "exit":
                        Console.WriteLine("Tesekkurler");
                        break;
                    default:
                        break;
                }
            } while (meyve != "exit"); */
        }
    }
}
