using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case_Yapısı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            //Expression
            switch (month) 
            {
                case 6:
                    Console.WriteLine("Haziran ayındasınız!");
                    break;
             case 7:
                 Console.WriteLine("Temmuz ayındasınız!");
                    break;
             case 8:
                    Console.WriteLine("Ağustos ayındasınız!");
                    break;

                case 9:
                    Console.WriteLine("Eylül ayındasınız!");
                    break;

                default:
                    Console.WriteLine("Yanlış Veri girişi");
                    break;
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış ayındasınız!");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar ayındasınız!");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz ayındasınız!");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Son bahar ayındasınız!");
                    break;

                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
